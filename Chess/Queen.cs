﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Queen : Piece
    {
        public override bool Move(Coordinate oldCoordinate, Coordinate newCoordinate)
        {
            bool checkMove = false;

            if (oldCoordinate.XCoordinate == newCoordinate.XCoordinate || oldCoordinate.YCoordinate == newCoordinate.YCoordinate
                || newCoordinate.XCoordinate - oldCoordinate.XCoordinate == newCoordinate.YCoordinate - oldCoordinate.YCoordinate
                || oldCoordinate.XCoordinate - newCoordinate.XCoordinate == oldCoordinate.YCoordinate - newCoordinate.YCoordinate
                || oldCoordinate.XCoordinate - newCoordinate.XCoordinate == newCoordinate.YCoordinate - oldCoordinate.YCoordinate)
            {
                checkMove = true;
            }

            return checkMove;
        }
    }
}
