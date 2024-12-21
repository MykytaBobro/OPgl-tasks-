using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static OpenGL_02.OpenGL;


namespace OpenGL_02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nUDhorizont_ValueChanged(object sender, System.EventArgs e)
        {
            int horizontalescount = (int)nUDhorizont.Value;
            int verticalescount = (int)nUDvert.Value;
            renderControl1.HorizontalsCount = horizontalescount;
            renderControl1.VerticalsCount = verticalescount;
            renderControl1.Invalidate();
        }

        private void nUDvert_ValueChanged(object sender, System.EventArgs e)
        {
            int horizontalescount = (int)nUDhorizont.Value;
            int verticalescount = (int)nUDvert.Value;
            renderControl1.HorizontalsCount = horizontalescount;
            renderControl1.VerticalsCount = verticalescount;
            renderControl1.Invalidate();
        }

        private void rBtnFill_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rBtnFill.Checked)
            {
                renderControl1.DrawType = DrawType.Fill;
                renderControl1.Invalidate();
            }
        }

        private void rBtnLines_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rBtnLines.Checked)
            {
                renderControl1.DrawType = DrawType.Lines;
                renderControl1.Invalidate();
            }
        }

        private void rBtnPoints_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rBtnPoints.Checked)
            {
                renderControl1.DrawType = DrawType.Points;
                renderControl1.Invalidate();
            }
        }

        private void Click(object sender, MouseEventArgs e)
        {
            double sizeX = renderControl1.ClientRectangle.Width;
            double sizeY = renderControl1.ClientRectangle.Height;

            double trueY = sizeY - e.Y;

            double buttonWidth = 50.0;
            double buttonHeight = 25.0;
            double spacing = 10.0;

            double xStart = sizeX - (buttonWidth + spacing);
            double yStart = sizeY - (buttonHeight + spacing);

            for (int i = 0; i < 3; i++)
            {
                int k = 2;
                double x = xStart - i * (buttonWidth + spacing);
                double y = yStart;

                if (e.X >= x && e.X <= x + buttonWidth && trueY >= y && trueY <= y + buttonHeight)
                {
                    renderControl1.DrawType = (DrawType)k - i;
                    switch (k - i)
                    {
                        case 0:
                            rBtnFill.Checked = true; break;
                        case 1:
                            rBtnLines.Checked = true; break;
                        case 2:
                            rBtnPoints.Checked = true; break;
                    }
                    renderControl1.Invalidate();
                    break;
                }
            }
        }
    }
}
