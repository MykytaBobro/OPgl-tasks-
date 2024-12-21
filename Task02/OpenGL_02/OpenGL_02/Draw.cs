using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGL_02
{
    public partial class RenderControl
    {
        public class Draw
        {
            public delegate void outText(string s, double x, double y, double z = 0);
            public outText Print;

            public void DrawButtons(DrawType drawType, double start_x, double end_x, double start_y, double end_y)
            {
                glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);
                double buttonWidth = 50.0;
                double buttonHeight = 25.0;
                double spacing = 10.0;

                double xStart = end_x - (buttonWidth + spacing);
                double yStart = end_y - (buttonHeight + spacing);
                string[] buttonLabels = { "Fill", "Lines", "Point" };
                for (int i = 0; i < 3; i++)
                {
                    double x = xStart - i * (buttonWidth + spacing);
                    double y = yStart;
                    if ((int)drawType == 2 - i)
                    {
                        glColor3f(0, 150, 255);
                    }
                    else
                    {
                        glColor3f(0.0f, 0.6f, 1.0f);
                    }
                    glBegin(GL_POLYGON);
                    glVertex2d(x, y);
                    glVertex2d(x, y + buttonHeight);
                    glVertex2d(x + buttonWidth, y + buttonHeight);
                    glVertex2d(x + buttonWidth, y);
                    glEnd();
                    glColor3f(0, 0, 0);
                    Print(buttonLabels[2 - i], x + 3, y + buttonHeight / 3);
                }
            }
            public void DrawFigure(int verticalsCount, int horizontalsCount, double size, DrawType drawType)
            {
                double offsetX, offsetY;
                if (verticalsCount != 0 || horizontalsCount != 0)
                {
                    for (int i = 0; i < horizontalsCount; i += 1)
                    {
                        for (int j = 0; j < verticalsCount; j += 1)
                        {
                            offsetX = i * size * 1.5;
                            offsetY = j * size * 2;
                            if (i > 0)
                            {
                                offsetY -= size * i;
                            }
                            switch (drawType)
                            {
                                case DrawType.Fill:
                                    glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);
                                    break;
                                case DrawType.Lines:
                                    glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);
                                    break;
                                case DrawType.Points:
                                    glPolygonMode(GL_FRONT_AND_BACK, GL_POINT);
                                    break;
                            }
                            glBegin(GL_QUADS);
                            Parallelograms(offsetX, offsetY, size);
                            glEnd();
                            glBegin(GL_TRIANGLES);
                            Triangles(offsetX, offsetY, size);
                            glEnd();
                        }
                    }
                }
            }
            void Parallelograms(double start_x, double start_y, double size)
            {
                glColor3f(1, 1, 1);
                glVertex2d(start_x, start_y);
                glVertex2d(start_x + size / 2, start_y + size);
                glVertex2d(start_x + size * 1.5, start_y + size);
                glVertex2d(start_x + size, start_y);
                glColor3f(0, 1, 0);
                glVertex2d(start_x, start_y);
                glVertex2d(start_x + size / 2, start_y - size);
                glVertex2d(start_x + size * 1.5, start_y - size);
                glVertex2d(start_x + size, start_y);
            }
            void Triangles(double start_x, double start_y, double size)
            {
                glColor3f(1, 0, 0);
                glVertex2d(start_x + size, start_y);
                glVertex2d(start_x + size * 1.5, start_y + size);                
                glVertex2d(start_x + size * 2, start_y);
                glColor3f(1, 1, 0);
                glVertex2d(start_x + size, start_y);
                glVertex2d(start_x + size * 1.5, start_y - size);
                glVertex2d(start_x + size * 2, start_y);
            }

        }
    }
}
