﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2020
{
    class Figure
    {
        protected List<Point> pList;
        public void figureDraw()
        {
            foreach (Point p in pList)
            {
                p.pointDraw();
            }
        }
    }
}
