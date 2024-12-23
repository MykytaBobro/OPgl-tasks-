
namespace OpenGL_02
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            renderControl1 = new RenderControl();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            nUDhorizont = new System.Windows.Forms.NumericUpDown();
            nUDvert = new System.Windows.Forms.NumericUpDown();
            rBtnFill = new System.Windows.Forms.RadioButton();
            rBtnLines = new System.Windows.Forms.RadioButton();
            rBtnPoints = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)nUDhorizont).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDvert).BeginInit();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.DrawType = DrawType.Fill;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.HorizontalsCount = 1;
            renderControl1.Location = new System.Drawing.Point(-1, 0);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(497, 327);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            renderControl1.VerticalsCount = 1;
            renderControl1.MouseDown += Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(508, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 30);
            label1.TabIndex = 1;
            label1.Text = "Tile count";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(502, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Horizontal";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(502, 86);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Vertical";
            // 
            // nUDhorizont
            // 
            nUDhorizont.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            nUDhorizont.Location = new System.Drawing.Point(566, 52);
            nUDhorizont.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUDhorizont.Name = "nUDhorizont";
            nUDhorizont.Size = new System.Drawing.Size(46, 23);
            nUDhorizont.TabIndex = 4;
            nUDhorizont.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nUDhorizont.ValueChanged += nUDhorizont_ValueChanged;
            // 
            // nUDvert
            // 
            nUDvert.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            nUDvert.Location = new System.Drawing.Point(566, 82);
            nUDvert.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUDvert.Name = "nUDvert";
            nUDvert.Size = new System.Drawing.Size(46, 23);
            nUDvert.TabIndex = 5;
            nUDvert.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nUDvert.ValueChanged += nUDvert_ValueChanged;
            // 
            // rBtnFill
            // 
            rBtnFill.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            rBtnFill.AutoSize = true;
            rBtnFill.Checked = true;
            rBtnFill.Location = new System.Drawing.Point(508, 179);
            rBtnFill.Name = "rBtnFill";
            rBtnFill.Size = new System.Drawing.Size(74, 19);
            rBtnFill.TabIndex = 6;
            rBtnFill.TabStop = true;
            rBtnFill.Text = "Fill mode";
            rBtnFill.UseVisualStyleBackColor = true;
            rBtnFill.CheckedChanged += rBtnFill_CheckedChanged;
            // 
            // rBtnLines
            // 
            rBtnLines.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            rBtnLines.AutoSize = true;
            rBtnLines.Location = new System.Drawing.Point(508, 204);
            rBtnLines.Name = "rBtnLines";
            rBtnLines.Size = new System.Drawing.Size(86, 19);
            rBtnLines.TabIndex = 7;
            rBtnLines.Text = "Lines mode";
            rBtnLines.UseVisualStyleBackColor = true;
            rBtnLines.CheckedChanged += rBtnLines_CheckedChanged;
            // 
            // rBtnPoints
            // 
            rBtnPoints.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            rBtnPoints.AutoSize = true;
            rBtnPoints.Location = new System.Drawing.Point(508, 229);
            rBtnPoints.Name = "rBtnPoints";
            rBtnPoints.Size = new System.Drawing.Size(92, 19);
            rBtnPoints.TabIndex = 8;
            rBtnPoints.Text = "Points mode";
            rBtnPoints.UseVisualStyleBackColor = true;
            rBtnPoints.CheckedChanged += rBtnPoints_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(624, 324);
            Controls.Add(rBtnPoints);
            Controls.Add(rBtnLines);
            Controls.Add(rBtnFill);
            Controls.Add(nUDvert);
            Controls.Add(nUDhorizont);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)nUDhorizont).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDvert).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUDhorizont;
        private System.Windows.Forms.NumericUpDown nUDvert;
        private System.Windows.Forms.RadioButton rBtnFill;
        private System.Windows.Forms.RadioButton rBtnLines;
        private System.Windows.Forms.RadioButton rBtnPoints;
    }
}

