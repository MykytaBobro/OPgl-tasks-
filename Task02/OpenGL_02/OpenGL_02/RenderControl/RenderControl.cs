using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using static OpenGL_02.OpenGL;

namespace OpenGL_02
{
    public partial class RenderControl : OpenGL
    {
        Draw draw;
        public int VerticalsCount { get; set; } = 1;
        public int HorizontalsCount { get; set; } = 1;
        public DrawType DrawType { get; set; } = 0;
        public RenderControl()
        {
            InitializeComponent();
        }

        private void RenderControl_Render(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();
            double size = 400.0;
            double sideSize = 125.0;
            if (Width > Height)
                glViewport((Width - Height) / 2, 0, Height, Height);
            else
                glViewport(0, (Height - Width) / 2, Width, Width);
            double maxSize = Math.Max(HorizontalsCount, VerticalsCount);
            gluOrtho2D(-size * maxSize, size * maxSize, -size * maxSize, size * maxSize);

            draw.DrawFigure(VerticalsCount, HorizontalsCount, sideSize, DrawType);

            glLoadIdentity();
            glViewport(0, 0, Width, Height);
            gluOrtho2D(-Width / 2, Width / 2, -Height / 2, Height / 2);
            draw.DrawButtons(DrawType, -Width / 2, Width / 2, -Height / 2, Height / 2);
        }

        private void RenderControl_ContextCreated(object sender, EventArgs e)
        {
            draw = new Draw();
            draw.Print = DrawText;
        }
    }
}

