﻿using System.Threading;

namespace SnapchatBot {
    public class SwipeHorizontal {
        private int _speed;
        private int _posX;
        private int _posY;
        private int _sleepTime;
        private int _distance;
        
        public SwipeHorizontal(int posX, int posY, int distance, int speed, int sleepTime) {
            this._posX = posX;
            this._posY = posY;
            this._distance = distance;
            this._speed = speed;
            this._sleepTime = sleepTime;
            
            Grab();
            Release();
        }

        private void Grab() {
            Utilities.MakeClickDownAtPixel(this._posX, this._posY);

            MoveMouse();
        }
        private void Release() {
            Utilities.MakeClickUpAtPixel(this._posX, this._posY);
        }

        private void MoveMouse()
        {
            do
            {
                Utilities.MoveCursor(this._posX + _speed, _posY);
                _posX += _speed;
                Thread.Sleep(_sleepTime);
            } 
            while (_posX < _distance);
        } 
    }
}