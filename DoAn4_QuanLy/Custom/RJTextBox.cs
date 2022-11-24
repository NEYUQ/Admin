using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn4_QuanLy.Custom
{
    public partial class RJTextBox : UserControl
    {
        private Color bordercolor = Color.MediumSlateBlue;
        private int bordersize = 2;
        private bool underlinestyle = false;

        public Color Bordercolor { get => bordercolor; set { bordercolor = value; this.Invalidate(); } }
        public int Bordersize { get => bordersize; set { bordersize = value; this.Invalidate(); } }
        public bool Underlinestyle { get => underlinestyle; set { underlinestyle = value; this.Invalidate(); } }

        public RJTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            using (Pen penBorder = new Pen(Bordercolor, Bordersize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (Underlinestyle)
                {
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                }
                else
                {
                    graph.DrawLine(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        public string Texts
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
    }
}
