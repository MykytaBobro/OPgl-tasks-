using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.InteropServices;

namespace OpenGL_01
{
    public partial class RenderControl : OpenGL
    {
        Draw draw;
        double Xmin { get; set; } = -8;
        double Xmax { get; set; } = 3;
        double Ymin { get; set; } = -2;
        double Ymax { get; set; } = 4;
        double[,] vertices = {
            {-7.0, -7.0, -6.0, -5.0, -4.0, -4.0}, 
            {-1.0,  1.0,  3.0,  3.0,  1.0, -1.0}  
        };
        double multipl = 0.5;
        public RenderControl()
        {
            InitializeComponent();
        }

        private void RenderControl_Render(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();
            glViewport(0, 0, Width, Height);
            gluOrtho2D(Xmin - multipl, Xmax + multipl, Ymin - multipl, Ymax + multipl);

            draw.DrawGrid(Xmin, Xmax, Ymin, Ymax);

            glLineWidth(3);
            glPointSize(8);
            glColor3ub(0, 0, 0);
            glBegin(GL_LINE_LOOP);
            draw.DrawFigure(vertices);
            glEnd();
            glBegin(GL_POINTS);
            draw.DrawFigure(vertices, 5);
            glEnd();
        }

        private void RenderControl_ContextCreated(object sender, EventArgs e)
        {
            draw = new Draw();
        }
    }
}

