using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Binary_search
{
    public partial class Form1 : Form
    {
        public static Graphics g;
        BinaryTree tree;
        Dictionary<Node, Nut> Map = new Dictionary<Node, Nut>();
        int k = 0;
        List<Nut> Lnut = new List<Nut>();
        List<Nut> LDuyet = new List<Nut>();
        Nut NThem = null;
        Nut Nxoa = null;
        public Form1()
        {
            InitializeComponent();
            Height = 750;
            Width = 1400;
            StartPosition = FormStartPosition.CenterScreen;
            g = this.CreateGraphics();
        }
        public void Setup()
        {
            List<Button> Lbtn = new List<Button>();
           
            Lbtn.Add(btnCB);
            Lbtn.Add(btnXoa);
            Lbtn.Add(btnInsert);
            Lbtn.Add(btnTim);
            Lbtn.Add(btnNhan);
            Lbtn.Add(btnRef);
            
            Lbtn.Add(btnLNR);
            Lbtn.Add(btnLRN);
            Lbtn.Add(btnNLR);
            int tmp = 0;
            int dai = 90, cao = 30;
            int Padding = 50;
            int tong = dai * Lbtn.Count + Padding * (Lbtn.Count - 1);
            int Pad = (Width - tong) / 2;
            foreach (Button btn in Lbtn)
            {
                btn.Size = new Size(dai, cao);
            }

            foreach (Button btn in Lbtn)
            {
                btn.Location = new Point(Pad + tmp * (dai + Padding), Height - 100);
                ++tmp;
            }
            txtNhap.Location = new Point(Width / 2 - txtNhap.Width / 2, Height - 150);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tree = new BinaryTree();
            Setup();

        }
        public void SetDuyet()
        {
            int pad = 10;
            int tong = (40 + pad) * LDuyet.Count - pad;
            int Padding = (Width - tong) / 2, dem = 0;
            foreach(Nut nut in LDuyet)
            {
                nut.Location =  new Point(Padding + dem *(40 + pad),Height - 220);
                ++dem;
            }
            LDuyet.Clear();
        }
        public void LNR(Node node)
        {

            if (node == null)
                return;
            Map[node].BackColor = Color.Blue;
            Map[node].Refresh();
            
            Thread.Sleep(800);
            LNR(node.Left);
            ++k;
            Map[node].BackColor = Color.Purple;
            Map[node].Refresh();
            g.DrawString(k.ToString(), new Font("Tahoma", 14, FontStyle.Regular), new SolidBrush(Color.Red), new Rectangle(Map[node].Location.X + 10, Map[node].Location.Y + 40, 30,20));
            Nut tmp = new Nut();
            tmp.So = Map[node].So;
            this.Controls.Add(tmp);
            Lnut.Add(tmp);
            tmp.Refresh();
            LDuyet.Add(tmp);

            Thread.Sleep(800);
            LNR(node.Right);
        }
        public void LRN(Node node)
        {

            if (node == null)
                return;
            Map[node].BackColor = Color.Blue;
            Map[node].Refresh();

            Thread.Sleep(800);
            LRN(node.Left);
          
            LRN(node.Right);
            ++k;
            Nut tmp = new Nut();
            tmp.So = Map[node].So;
            this.Controls.Add(tmp);
            Lnut.Add(tmp);
            tmp.Refresh();
            LDuyet.Add(tmp);


            Map[node].BackColor = Color.Purple;
            Map[node].Refresh();
            g.DrawString(k.ToString(), new Font("Tahoma", 14, FontStyle.Regular), new SolidBrush(Color.Red), new Rectangle(Map[node].Location.X + 10, Map[node].Location.Y + 40, 30, 20));
            Thread.Sleep(800);
        }
        public void NLR(Node node)
        {

            if (node == null)
                return;
            Map[node].BackColor = Color.Blue;
            Map[node].Refresh();
            ++k;
            Nut tmp = new Nut();
            tmp.So = Map[node].So;
            this.Controls.Add(tmp);
            Lnut.Add(tmp);
            tmp.Refresh();
            LDuyet.Add(tmp);

            
            Map[node].BackColor = Color.Purple;
            Map[node].Refresh();
            g.DrawString(k.ToString(), new Font("Tahoma", 14, FontStyle.Regular), new SolidBrush(Color.Red), new Rectangle(Map[node].Location.X + 10, Map[node].Location.Y + 40, 30, 20));
            Thread.Sleep(800);
            
            NLR(node.Left);
            //Thread.Sleep(800);
            NLR(node.Right);
            
        }
        
        public void Ve(Node node, int x, int y, int z, int t)
        {
            if (node == null)
                return;
            Nut tmp = new Nut();
            this.Controls.Add(tmp);
            Lnut.Add(tmp);
            Map[node] = tmp;
            tmp.So = node.Data;
            tmp.Location = new Point(x, y);
            tmp.BackColor = Color.Transparent;
            tmp.Refresh();

            if(node.Left != null)
            {
                Ve(node.Left, x - z, y + t, z/2,t);
                g.DrawLine(new Pen(Color.Blue, 2), new Point(x + 20, y + 20), new Point(x - z + 20, y + t + 20));
            }
            if(node.Right != null)
            {
                Ve(node.Right, x + z, y + t, z/2,t);
                g.DrawLine(new Pen(Color.Blue, 2), new Point(x + 20, y + 20), new Point(x + z + 20, y + t + 20));
            }
        }
        public Node Them(Node node,int x, Node Father, int h, int hs, bool flag)
        {
            if (node == null)
            {
                node = new Node(x);
                Nut nut = new Nut();
                nut.So = x;
                nut.Refresh();
                int X = Map[Father].Location.X + hs * h;
                int Y = Map[Father].Location.Y + 100;
                nut.Location = new Point(X,Y);
                g.DrawLine(new Pen(Color.Blue, 2), new Point(Map[Father].Location.X + 20, Map[Father].Location.Y + 20), new Point(X + 20, Y + 20));
                //Thread.Sleep(1000);
                nut.BackColor = Color.Purple;
                Controls.Add(nut);
                if (NThem != null)
                {
                    NThem.BackColor = Color.Transparent;
                    NThem.Refresh();
                }
                NThem = nut;
                Lnut.Add(nut);
                Map[node] = nut;
                return node;
            }
            if (flag)
            {
               /* if (Father != null)
                {
                    int X = Map[Father].Location.X + hs * h;
                    int Y = Map[Father].Location.Y + 100;
                    g.DrawLine(new Pen(Color.Red, 2), new Point(Map[Father].Location.X + 20, Map[Father].Location.Y + 20), new Point(X + 20, Y + 20));
                }*/
                Map[node].BackColor = Color.Blue;
                Map[node].Refresh();
                Thread.Sleep(1000);
            }
            if (node.Data > x)
            {
                node.Left = Them(node.Left, x, node, h/2, -1, flag);
            }
            else if (node.Data < x)
            {
                node.Right = Them(node.Right, x, node, h/2, 1,flag);
            }
            return node;
        }
        private int CucTrai(Node node)
        {
            int Min = node.Data;
            Map[node].BackColor = Color.Aqua;
            Map[node].Refresh();
            Thread.Sleep(1000);
            Node Pre = node;
            while (node.Left != null)
            {
                Pre = node.Left;
                Map[node.Left].BackColor = Color.Aqua;
                Map[node.Left].Refresh();
                Thread.Sleep(1000);
                Min = node.Left.Data;
                node = node.Left;
            }
            Map[Pre].BackColor = Color.Pink;
            Map[Pre].Refresh();
            Thread.Sleep(1000);
            Nxoa = Map[Pre];
            return Min;
        }
        public Node Xoa(Node node, int x, bool flag)
        {
            if (node == null)
                return node;

            if (x < node.Data)
            {
                if (flag)
                {
                    Map[node].BackColor = Color.Blue;
                    Map[node].Refresh();
                    Thread.Sleep(1000);
                }
                node.Left = Xoa(node.Left, x,flag);
            }
            else if (x > node.Data)
            {
                if (flag)
                {
                    Map[node].BackColor = Color.Blue;
                    Map[node].Refresh();
                    Thread.Sleep(1000);
                }
                node.Right = Xoa(node.Right, x, flag);
            }
            else
            {
                if (flag)
                {
                    Map[node].BackColor = Color.Purple;
                    Map[node].Refresh();
                    Thread.Sleep(2000);
                }
                if (node.Left == null)
                {
                    if (node.Right != null)
                    {
                        if (flag)
                        {
                            Map[node.Right].BackColor = Color.Pink;
                            Map[node.Right].Refresh();
                            Nxoa = Map[node.Right];
                        }
                        Thread.Sleep(2000);
                    }
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    if (node.Left != null)
                    {
                        if (flag)
                        {
                            Map[node.Left].BackColor = Color.Pink;
                            Map[node.Left].Refresh();
                            Nxoa = Map[node.Left];
                            Thread.Sleep(2000);
                        }
                    }
                    return node.Left;
                }
                int tmp = node.Data;
                node.Data = CucTrai(node.Right);
                Map[node].So = node.Data;
                Map[node].Refresh();
                Nxoa.So = tmp;
                Nxoa.Refresh();
                Thread.Sleep(1000);
                node.Right = Xoa(node.Right, node.Data,false);
            }

            return node;
        }
        public void VVe(bool flag)
        {
            int x = 0;
            if (txtNhap.Text.Length > 0)
            {
                string str = txtNhap.Text;
                string[] ListStr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string Str in ListStr)
                {
                    x = int.Parse(Str);
                    if (tree.Root == null)
                    {
                        tree.Root = new Node(x);
                        Nut nut = new Nut();
                        nut.So = x;
                        nut.Refresh();
                        Map[tree.Root] = nut;
                        nut.Location = new Point(Width / 2, 0);
                        Controls.Add(nut);
                        Lnut.Add(nut);
                    }
                    else
                        Them(tree.Root, x, null, 600, 0, flag);
                }
            }
        }
        private void btnNhan_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn khởi tạo cây ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                ReFresh();
                tree.Root = null;
                VVe(false);
                ReFresh();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            LNR(tree.Root);
            SetDuyet();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            LRN(tree.Root);
            SetDuyet();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            NLR(tree.Root);
            SetDuyet();
        }
        public void ReFresh()
        {
            this.Refresh();
            foreach (Nut nut in Lnut)
            {
                Controls.Remove(nut);
            }
            Lnut.Clear();
            k = 0;
            Ve(tree.Root, Width / 2,0, 300, 100);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            ReFresh();
        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 32)
                e.Handled = false;
            else
                e.Handled = true;
        }
        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            VVe(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (txtNhap.Text.Length > 0)
            {
                string str = txtNhap.Text;
                string[] ListStr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string Str in ListStr)
                {
                    x = int.Parse(Str);
                    tree.Root = Xoa(tree.Root, x,true);
                }
                ReFresh();

            }

        }

        private void btnCB_Click(object sender, EventArgs e)
        {
            tree.BalanceTree();
            tree.BalanceTree();
            ReFresh();
        }

        public bool Tim(Node node,int x)
        {
            if (node == null)
                return false;
            Map[node].BackColor = Color.Blue;
            Map[node].Refresh();
            Thread.Sleep(1000);
            if (node.Data > x)
                return Tim(node.Left, x);
            else if (node.Data < x)
                return Tim(node.Right, x);
            Map[node].BackColor = Color.Purple;
            Map[node].Refresh();
            return true;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            
            if(txtNhap.Text.Length > 0)
            {
                int x = int.Parse(txtNhap.Text);
                if(!Tim(tree.Root,x))
                {
                    MessageBox.Show($"Không tìm thấy {x}");
                }    
            }    
        }

        private void btnhien_Click(object sender, EventArgs e)
        {
            TimKiem tk = new TimKiem();
            tk.Show();
        }

        private void btnLRN_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                LRN lrn = new LRN();
                lrn.Width += 100;
                lrn.StartPosition = FormStartPosition.CenterScreen;
                lrn.Show();
            }
        }

        private void btnNLR_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                NLR lrn = new NLR();
                lrn.StartPosition = FormStartPosition.CenterScreen;
                lrn.Show();
            }
        }

       

        private void btnLNR_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                LNR lrn = new LNR();
                lrn.StartPosition = FormStartPosition.CenterScreen;
                lrn.Show();
            }
        }

        private void btnTim_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TimKiem tk = new TimKiem();
                tk.Width += 80;
                tk.Height += 50;
                tk.StartPosition = FormStartPosition.CenterScreen;
                tk.Show();
            }
        }

        private void btnXoa_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Xoa xoa = new Xoa();
                xoa.Height += 100;
                xoa.StartPosition = FormStartPosition.CenterScreen;
                xoa.Show();
            }
            
        }

        private void btnInsert_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Them th = new Them();
                th.Width += 50;
                th.StartPosition = FormStartPosition.CenterScreen;
                th.Show();
            }
        }

        private void btnCB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CanBang th = new CanBang();
                
                th.StartPosition = FormStartPosition.CenterScreen;
                th.Show();
            }
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
