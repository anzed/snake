﻿using System.Collections.Generic;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public void LineDraw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
