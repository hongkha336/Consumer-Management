using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace DXApplication1
{
    public partial class frmNewChiTieu : Form
    {
        Quan_Ly_Tieu_DungEntities3 context;

        bool themNoXau = false;
        bool themNoTot = false;
        bool thunhap = false;

        public frmNewChiTieu()
        {
            InitializeComponent();
        }
        public frmNewChiTieu(string us)
        {
            InitializeComponent();
            USER = us;
        }

        public frmNewChiTieu(bool tn,string us)
        {
            InitializeComponent();
            USER = us;
            thunhap = tn;
        }
        public frmNewChiTieu(bool nx, bool nt,string us)
        {
            InitializeComponent();
            USER = us;
            themNoTot = nt;
            themNoXau = nx;
        }
        string USER = "";
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!themNoTot && !themNoXau && !thunhap)
                newchitieu();
            else
            {
                if (themNoXau)
                    themNoXaus();
                if (themNoTot)
                    themNoTots();
                if (thunhap)
                    themThuNhap();
            }
               this.Close();
        }

        void newchitieu()
        {
            context = new Quan_Ly_Tieu_DungEntities3();
            LanChiTieu lct = new LanChiTieu
            {
                Money = Convert.ToInt32(textBox1.Text),
                Reasion = textBox2.Text,
                Ngay = DateTime.Now,
                UserID = USER
            };
            context.LanChiTieux.Add(lct);
            context.SaveChanges();

            var sst = context.TienTrongVis.Where(p=>p.UserID == USER);
            if (sst.ToList().Count != 0)
            {
                int sstv = Convert.ToInt32(sst.ToList().Last().SoTien.ToString());

                TienTrongVi ttv = new TienTrongVi
                {
                    Ngay = DateTime.Today,
                    SoTien = sstv - Convert.ToInt32(textBox1.Text),
                    UserID = USER
                };

                context.TienTrongVis.Add(ttv);
                context.SaveChanges();
            }
            MessageBox.Show("Đã lưu");
            this.Close();
        }

        void themNoXaus()
        {
            context = new Quan_Ly_Tieu_DungEntities3();
            NoXau nx = new NoXau
            {
                Money = Convert.ToInt32(textBox1.Text),
                ThanhToan = false,
                Ghichu = textBox2.Text,
                UserID = USER,
            };
            context.NoXaus.Add(nx);
            context.SaveChanges();
            MessageBox.Show("Đã thêm");
            this.Close();
        }
        void themNoTots()
        {
            context = new Quan_Ly_Tieu_DungEntities3();
            NoTot nx = new NoTot
            {
                Money = Convert.ToInt32(textBox1.Text),
                ThanhToan = false,
                Ghichu = textBox2.Text,
                UserID = USER,
            };
            context.NoTots.Add(nx);
            context.SaveChanges();
            MessageBox.Show("Đã thêm");
            this.Close();
        }

        private void frmNewChiTieu_Load(object sender, EventArgs e)
        {
            if (thunhap)
            {
                textBox2.Hide();
                label2.Hide();
            }
        }
       
        void themThuNhap()
        {
            context = new Quan_Ly_Tieu_DungEntities3();
            var thistn = context.TienTrongVis.Where(p => p.UserID == USER);
            int st = 0;
            if(thistn.ToList().Count !=0)
            {
                st = Convert.ToInt32(thistn.ToList().Last().SoTien);
                TienTrongVi ttv = new TienTrongVi
                {
                    Ngay = DateTime.Today,
                    SoTien = st + Convert.ToInt32(textBox1.Text),
                    UserID = USER,
                };

                context.TienTrongVis.Add(ttv);
                context.SaveChanges();
                MessageBox.Show("Đã thêm");
            }
            else
            {
                st = Convert.ToInt32(thistn.ToList().Last().SoTien);
                TienTrongVi ttv = new TienTrongVi
                {
                    Ngay = DateTime.Today,
                    SoTien =  Convert.ToInt32(textBox1.Text),
                    UserID = USER,
                };

                context.TienTrongVis.Add(ttv);
                context.SaveChanges();
                MessageBox.Show("Đã thêm");
            }
        }
    }
}
