using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_system
{
    public partial class Update_Staff : Form
    {
        public Update_Staff(IDictionary<string, string> record)
        {
            InitializeComponent();
            txtStaffID.Text = record["ID"];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtStaffID.Text != "" && txtName.Text != "")  //OR if !(string.IsNullOrEmpty(tb.Text))
            {
                using (var context = new project_manangementEntities())
                {
                    int intStaffID = int.Parse(txtStaffID.Text);

                    var stda = from list in context.staffs
                               where list.StaffID == intStaffID
                               select list;

                    if (stda.FirstOrDefault() != null)
                    {
                        if(txtPassword.Text != "") stda.ToList()[0].Staff_password = txtPassword.Text;
                        if(txtName.Text != "") stda.ToList()[0].Staff_Username = txtName.Text;
                    }
                    else
                        MessageBox.Show("Wrong Staff ID OR no input found!!\nPlease try again!\n", "Error");
                    
                    context.SaveChanges();
                    MessageBox.Show("Your Name Changed\nUsername:" + txtName.Text + "\nPassword:" + txtPassword.Text, "successful");
                }
            }
            else 
            {
                MessageBox.Show("Wrong Staff ID OR no input found!!\nPlease try again!\n" , "Error");
            }

    
        }
    }
}
