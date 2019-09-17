using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXApplication1
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        Quan_Ly_Tieu_DungEntities3 context;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            context = new Quan_Ly_Tieu_DungEntities3();

            var thisTK = context.Users.Where(p => p.userID == textBox1.Text);
            if(thisTK.ToList().Count != 0)
            {
                string thisPass = thisTK.ToList().First().userPassWord.ToString();
                if(thisPass == textBox2.Text)
                {
                    frmTrangChu f = new frmTrangChu(textBox1.Text);
                    this.Hide();
                    f.ShowDialog();
                    textBox1.ResetText();
                    textBox2.ResetText();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng","Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo");
            }
            
            
           
            
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            textBox1.Focus();

            context = new Quan_Ly_Tieu_DungEntities3();

            var thisTK = context.Users.Where(p => p.userID == textBox1.Text);

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                simpleButton1_Click(null, null);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy f = new frmDangKy();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}