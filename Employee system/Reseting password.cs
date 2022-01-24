using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_system
{
    public partial class Form2 : Form
    {

        Random random = new Random();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            bool found = false;
            String ram = random.Next().ToString();

            if (radioButton2.Checked)//Staff
            {
                using (var context = new project_manangementEntities())
                {
                    
                    var std = from list in context.staffs
                              where list.Staff_Name == txtName.Text && txtHKID.Text == list.Staff_HKIDNumber
                              select list;

                    if (std.FirstOrDefault() != null)  std.ToList()[0].Staff_password = ram;
                    found = true;
                    context.SaveChanges();
                }
            }
            else if (radioButton1.Checked)//tenant
            {
                using (var context = new project_manangementEntities())
                {
                    
                    var std = from list in context.tenants
                              where list.Name == txtName.Text && txtHKID.Text == list.Tenant_HKIDNumber
                              select list;

                    if (std.FirstOrDefault() != null)  std.ToList()[0].Tenant_Password = ram;
                    found = true;
                    context.SaveChanges();
                }
            }

            if (!found)
                {
                    MessageBox.Show("Wrong user name or password!!\nPlease try again!\n" + txtID.Text  , "Error");
                }
            else
            {
                MessageBox.Show("Your new password is : " + ram, "successful");
                found = false;
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            this.Close();
        }
    }
}