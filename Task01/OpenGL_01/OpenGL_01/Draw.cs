using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGL_01
{
    public partial class RenderControl
    {
        public class Draw
        {
            public void DrawGrid(double xmin, double xmax, double ymin, double ymax)
            {
                glLineWidth(1);
                glEnable(GL_LINE_STIPPLE);
                glLineStipple(6, 0xAAAA);
                glColor3ub(189, 189, 189);
                glBegin(GL_LINES);
                for (double i = xmin; i <= xmax; i++)
                {
                    glVertex2d(i, ymin);
                    glVertex2d(i, ymax);
                }
                for (double j = ymin; j <= ymax; j++)
                {
                    glVertex2d(xmin, j);
                    glVertex2d(xmax, j);
                }
                glEnd();
                glDisable(GL_LINE_STIPPLE);
            }
            public void DrawFigure(double[,] vertices, double plusX = 0)
            {               
                glVertex2d(vertices[0, 0] + plusX, vertices[1, 0]);
                glVertex2d(vertices[0, 1] + plusX, vertices[1, 1]);
                glVertex2d(vertices[0, 2] + plusX, vertices[1, 2]);
                glVertex2d(vertices[0, 3] + plusX, vertices[1, 3]);
                glVertex2d(vertices[0, 4] + plusX, vertices[1, 4]);
                glVertex2d(vertices[0, 5] + plusX, vertices[1, 5]);
            }
        }
    }
}
