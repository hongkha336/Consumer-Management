using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmTrangChu : Form
    {
        Quan_Ly_Tieu_DungEntities3 context;
        string USER = "";
        int tien = 0;
        public frmTrangChu()
        {
            InitializeComponent();
        }
        public frmTrangChu( string us)
        {
            InitializeComponent();
            USER = us;
            this.Text += "       [ " + us + " ]";
        }


        private void TimeNow_Tick(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void saveDate()
        {
            context = new Quan_Ly_Tieu_DungEntities3();
            try
            {
                Ngay n = new Ngay {
                    ID_Time = DateTime.Now
                };
                context.Ngays.Add(n);
                context.SaveChanges();
            }
            catch
            {

            }
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            saveDate();
            TimeNow.Enabled = true;
            loadMoney();
            loadAllChiTieu();
            loadDataThongKe();

            loadNoXau();
            loadNoTot();

            btnXoa.Enabled = false;
         




            context = new Quan_Ly_Tieu_DungEntities3();
            var user = context.Users.Find(USER);
            lbTen.Text = user.userName;
           
            
        }
        string xulytien(string mon)
        {
            string kq = "";
            int j = 0;
            for(int i = mon.Length -1; i >=0; i--)
            {
                kq = mon[i] + kq;
                if (j == 2 && i!=0)
                {
                    kq = '.' + kq;
                    j = 0;
                }
                else j++;
            }
            return kq;
        }
        void loadMoney()
        {
            context = new Quan_Ly_Tieu_DungEntities3();
            var mon = context.TienTrongVis.Where(p => p.UserID == USER);
            if (mon.ToList().Count != 0)
            {
                tien = Convert.ToInt32(mon.ToList().Last().SoTien.ToString());
                lbTien.Text = xulytien(tien.ToString()) + " VNĐ";
            }
            else lbTien.Text = "0 VNĐ";
        }

        private void frmTrangChu_SizeChanged(object sender, EventArgs e)
        {
            navigationPane1.Width = this.Width;
            navigationPane1.Height = this.Height;
            navigationPane1.Top = 0;
        }

        private void loadDataThongKe()
        {
            context = new Quan_Ly_Tieu_DungEntities3();
            var biendong = context.TienTrongVis.Where(p => p.UserID == USER)
                .Select(p => new { 
                    p.Ngay,
                    p.SoTien
                
                });

            if(biendong.ToList().Count != 0)
            dataGridView1.DataSource = biendong.ToList();
        }

        private void navigationPane1_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void navigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }
        void loadAllChiTieu()
        {
            context = new Quan_Ly_Tieu_DungEntities3();
            var used = context.LanChiTieux.Where(p => p.UserID == USER)
                .Select( p=> new { p.Ngay, p.Money, p.Reasion});
            if (used.ToList().Count != 0)
                dataGridView2.DataSource = used.ToList();

            var usedList = used.ToList();
            int tong = 0;
            for (int i = 0; i < usedList.Count; i++)
                tong += Convert.ToInt32(usedList[i].Money.ToString());
            lbchitieu.Text = xulytien(tong.ToString());
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            frmNewChiTieu f = new frmNewChiTieu(USER);
            f.ShowDialog();
            loadAllChiTieu();
            loadDataThongKe();
            loadMoney();
        }
        private void loadChitieuToDay()
        {
            
            context = new Quan_Ly_Tieu_DungEntities3();
            var used = context.LanChiTieux.Where(p => p.Ngay == DateTime.Today && p.UserID == USER)
                .Select(p => new { p.Ngay, p.Money, p.Reasion }).ToList();
            dataGridView2.DataSource = used;

            var usedList = used.ToList();
            int tong = 0;
            for (int i = 0; i < usedList.Count; i++)
                tong += Convert.ToInt32(usedList[i].Money.ToString());
            lbchitieu.Text = xulytien(tong.ToString());
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            loadChitieuToDay();
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            loadAllChiTieu();
        }
        public static DateTime GetYesterday(DateTime d)
        {
            // Ngày hôm nay.
            DateTime today = d;

            // Trừ đi một ngày.
            return today.AddDays(-1);
        }
        public static DateTime GetTomorrow(DateTime d)
        {
            // Ngày hôm nay.
            DateTime today = d;

            // Trừ đi một ngày.
            return today.AddDays(+1);
        }
        public static DateTime GetFristDayofMonth(DateTime d)
        {
            // Ngày hôm nay.
            DateTime today = d;

            // Trừ đi một ngày.
            int Month = today.Month;
            int Year = today.Year;
            DateTime x = new DateTime(Year, Month, 1);
            return x;
        }
        private void simpleButton11_Click(object sender, EventArgs e)
        {
           
            DateTime d = DateTime.Today;
           while(d.DayOfWeek.ToString().ToLower() != "monday")
           {
               d = GetYesterday(d);
           }

        
          var used = context.LanChiTieux.Where(p => p.Ngay >= d && p.UserID == USER)
                  .Select(p => new { p.Ngay, p.Money, p.Reasion }).ToList();

          if (used.Count != 0)
          {

              int count = used.Count;
              while (count == 0)
              {
                  d = GetTomorrow(d);
                  used = context.LanChiTieux.Where(p => p.Ngay >= d && p.UserID == USER)
                     .Select(p => new { p.Ngay, p.Money, p.Reasion }).ToList();
                  count = used.Count;
              }
              dataGridView2.DataSource = used;

              var usedList = used.ToList();
              int tong = 0;
              for (int i = 0; i < usedList.Count; i++)
                  tong += Convert.ToInt32(usedList[i].Money.ToString());
              lbchitieu.Text = xulytien(tong.ToString());
          }
          else
          {
              dataGridView2.DataSource = used;
              dataGridView2.Refresh();
          }
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Today;
            d = GetFristDayofMonth(d);
            var used = context.LanChiTieux.Where(p => p.Ngay >= d && p.UserID == USER)
                 .Select(p => new { p.Ngay, p.Money, p.Reasion }).ToList();
            dataGridView2.DataSource = used;

            var usedList = used.ToList();
            int tong = 0;
            for (int i = 0; i < usedList.Count; i++)
                tong += Convert.ToInt32(usedList[i].Money.ToString());
            lbchitieu.Text = xulytien(tong.ToString());
        }

        private void navigationPage3_Paint(object sender, PaintEventArgs e)
        {

        }
        void loadNoXau()
        {
            btnThanhToanXau.Enabled = false;
            context = new Quan_Ly_Tieu_DungEntities3();
            var noXau = context.NoXaus.Where(P => P.UserID == USER && P.ThanhToan == false).Select(p=> new {p.Money,p.Ghichu});
            if(noXau.ToList().Count !=0)
            {
                dgvNoXau.DataSource = noXau.ToList();
                int tong = 0;
                foreach (var nt in noXau)
                {
                    tong += Convert.ToInt32(nt.Money);
                }
                lbMonx.Text = xulytien(tong.ToString()) + " VNĐ";
            }
            else
            {
                dgvNoXau.DataSource = noXau.ToList();
                lbMonx.Text = "0 VNĐ";
            }
   
        }
        void loadNoTot()
        {
            btnThanhToanNoTots.Enabled = false;
            context = new Quan_Ly_Tieu_DungEntities3();
            var noXau = context.NoTots.Where(P => P.UserID == USER && P.ThanhToan == false).Select(p => new { p.Money, p.Ghichu });
            if (noXau.ToList().Count != 0)
            {
                dgvNoTot.DataSource = noXau.ToList();
                int tong = 0;
                foreach( var nt in noXau)
                {
                    tong += Convert.ToInt32(nt.Money);
                }
                lbMont.Text = xulytien(tong.ToString()) + " VNĐ";
            }
            else
            {
                dgvNoTot.DataSource = noXau.ToList();
                lbMont.Text = "0 VNĐ";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            frmNewChiTieu f = new frmNewChiTieu(false, true, USER);
            f.ShowDialog();
            loadNoTot();
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            frmNewChiTieu f = new frmNewChiTieu(true,false, USER);
            f.ShowDialog();
            loadNoXau();
        }

        private void dataGridView4_Leave(object sender, EventArgs e)
        {
            //btnThanhToanXau.Enabled = false;
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThanhToanXau.Enabled = true;
        }

        private void frmTrangChu_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
              if (frmTrangChu.ModifierKeys == Keys.Alt || frmTrangChu.ModifierKeys == Keys.F4)
            {
                Application.Exit();    
            }   
        }

        private void btnThanhToanXau_Click(object sender, EventArgs e)
        {
            context = new Quan_Ly_Tieu_DungEntities3();
            var ttv = context.TienTrongVis.Where(p => p.UserID == USER);

            int r = dgvNoXau.CurrentCell.RowIndex;


            // lấy số tiền trong ví
            int temp = 0;
            if (ttv.ToList().Count != 0)
                temp = Convert.ToInt32(ttv.ToList().Last().SoTien.ToString());
            // lấy ghi chú
            string ghiChu = dgvNoXau.Rows[r].Cells[1].Value.ToString();

            // lấy số tiền cần thanh toán
            int st = Convert.ToInt32(dgvNoXau.Rows[r].Cells[0].Value.ToString());

            if (temp > st)
            {
                // chuyển true / false
                
                NoXau c = context.NoXaus.Where(p => p.UserID == USER && p.Ghichu == ghiChu && p.ThanhToan == false ).ToList().First();
                c.ThanhToan = true;
                context.SaveChanges();


                // 
                if (ttv.ToList().Count != 0)
                {
                    int stt = st;
                    st =  Convert.ToInt32(ttv.ToList().Last().SoTien.ToString()) -st;
                    
                    TienTrongVi ttvs = new TienTrongVi
                    {
                        UserID = USER,
                        SoTien = st,
                        Ngay = DateTime.Today,
                    };
                    context.TienTrongVis.Add(ttvs);
                    context.SaveChanges();

                 // tạo thêm chi tiêu

                    LanChiTieu lcts = new LanChiTieu
                    {
                        Money = stt,
                        Ngay = DateTime.Today,
                        UserID = USER,
                        Reasion = "Thanh toán cho " + ghiChu,
                    };

                    context.LanChiTieux.Add(lcts);
                    context.SaveChanges();


                }

              
                loadNoXau();
                frmTrangChu_Load(null, null);
                MessageBox.Show("Đã thanh toán");
            }
             
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThanhToanNoTots.Enabled = true;
        }

        private void btnThanhToanNoTots_Click(object sender, EventArgs e)
        {
            int r = dgvNoTot.CurrentCell.RowIndex;
            string ghiChu = dgvNoTot.Rows[r].Cells[1].Value.ToString();
           
            
            int st = Convert.ToInt32(dgvNoTot.Rows[r].Cells[0].Value.ToString());
            
            
            context = new Quan_Ly_Tieu_DungEntities3();
            NoTot c = context.NoTots.Where(p => p.UserID == USER && p.Ghichu == ghiChu).ToList().First();
            c.ThanhToan = true;
            context.SaveChanges();


            var ttv = context.TienTrongVis.Where(p => p.UserID == USER);
            if(ttv.ToList().Count !=0)
            {
                st += Convert.ToInt32(ttv.ToList().Last().SoTien.ToString());
                TienTrongVi ttvs = new TienTrongVi
                {
                    UserID = USER,
                    SoTien = st,
                    Ngay = DateTime.Today,
                };
                context.TienTrongVis.Add(ttvs);
                context.SaveChanges();
            }
            else
            {
                TienTrongVi ttvs = new TienTrongVi
                {
                    UserID = USER,
                    SoTien = st,
                    Ngay = DateTime.Today,
                };
                context.TienTrongVis.Add(ttvs);
                context.SaveChanges();
            }



            loadNoTot();
            frmTrangChu_Load(null, null);
            MessageBox.Show("Đã thanh toán");
            
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            frmNewChiTieu f = new frmNewChiTieu(true, USER);
            f.ShowDialog();
            frmTrangChu_Load(null, null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
        

            }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Không thể khôi phục!!! Bạn chắc chắn xóa thông tin này?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(tl == DialogResult.Yes)
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                DateTime t = Convert.ToDateTime(dataGridView1.Rows[r].Cells[0].Value.ToString());
                int SoTien = Convert.ToInt32(dataGridView1.Rows[r].Cells[1].Value.ToString());
                string lyDo = dataGridView1.Rows[r].Cells[2].Value.ToString();

                context = new Quan_Ly_Tieu_DungEntities3();
                var removeRows = context.LanChiTieux.Where(p => p.Ngay == t && p.Money == SoTien && p.Reasion == lyDo).ToList();
                if (removeRows != null)
                {
                    context.LanChiTieux.Remove(removeRows.First());
                    context.SaveChanges();
                    TienTrongVi ttv = new TienTrongVi
                    {
                        Ngay = DateTime.Today,
                        SoTien = tien + SoTien,
                        UserID = USER,

                    };

                    context.TienTrongVis.Add(ttv);
                    context.SaveChanges();
                    MessageBox.Show("Đã xóa - Số tiền đã được khôi phục trở lại ví");
                    frmTrangChu_Load(null, null);
                }
        }


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  btnXoa.Enabled = true;
        }

    }
}
