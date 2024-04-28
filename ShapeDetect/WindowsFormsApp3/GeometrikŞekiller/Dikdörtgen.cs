﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp3.GeometrikŞekiller
{
    public class Dikdortgen
    {
        private Random random = new Random();
        public int Gen;
        public int Boy;
        public int X;
        public int Y;

        public Dikdortgen()
        {

           
            X = random.Next(1, 301);
            Y = random.Next(1, 301);
            Gen = random.Next(1, 201);
            Boy = random.Next(1, 201);
        }



        public void DikdortgenCiz(Panel panel)
        {
            Graphics r = panel.CreateGraphics();
            Pen pen = new Pen(Color.Brown);
            r.DrawRectangle(pen, X, Y, Gen, Boy);
        }
    }

}
