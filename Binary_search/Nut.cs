using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_search
{
    public partial class Nut : UserControl
    {
        int so;
        public Nut()
        {
            InitializeComponent();
            this.Width = 40;
            this.Height = 40;
            BackColor = Color.Transparent;
        }

        public int So { get => so; set => so = value; }

        private void Nut_Paint(object sender, PaintEventArgs e)
        {
            this.ForeColor = Color.DarkRed;
           
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            g.FillEllipse(new SolidBrush(Color.GreenYellow), new Rectangle(0, 0, Width - 1, Height - 1));
            g.DrawString(so.ToString(), this.Font, new SolidBrush(this.ForeColor), new Rectangle(0, 0, Width, Height), sf);
        }
    }
}
