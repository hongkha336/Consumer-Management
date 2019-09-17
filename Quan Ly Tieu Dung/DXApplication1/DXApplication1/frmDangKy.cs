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
    public partial class frmDangKy : Form
    {

        Quan_Ly_Tieu_DungEntities3 context;
       
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            context = new Quan_Ly_Tieu_DungEntities3();
            var isnewper = context.Users.Where(p => p.userID == textBox1.Text);
            if(isnewper.ToList().Count == 0)
            {

                if(textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Mật khẩu không khớp");
                    textBox2.ResetText();
                    textBox3.ResetText();
                }
                else
                {
                    User nu = new User
                    {
                        userID = textBox1.Text,
                        userPassWord = textBox2.Text,
                        userName = textBox4.Text
                    };
                    context.Users.Add(nu);
                    context.SaveChanges();


                    TienTrongVi ttv = new TienTrongVi
                    {
                        Ngay = DateTime.Today,
                        SoTien = 0,
                        UserID = textBox1.Text,
                    };

                    context.TienTrongVis.Add(ttv);
                    context.SaveChanges();
                    MessageBox.Show("Đã tạo tài khoản");
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Tài khoản đã tổn tại");
                textBox1.ResetText();
                textBox2.ResetText();
                textBox3.ResetText();
            }
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
