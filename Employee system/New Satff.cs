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
    
    public partial class New_Satff : Form
    {

        private IDictionary<string, string> record = new Dictionary<string, string>();


        public New_Satff(IDictionary<string, string> record)
        {
            InitializeComponent();

            this.record = record;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int newestStaffId = int.Parse(record["newestStaffId"]) + 1;// newestProductId + 1
            record["newestStaffId"] = newestStaffId.ToString();

            using (var context = new project_manangementEntities())
            {

                if (txtPassword.Text == txtComfirmPassword.Text) 
                { 
                    var std = new staff()
                    {
                        StaffID = newestStaffId, 
                        Staff_Name = txtRealName.Text, 
                        Staff_HKIDNumber = txtHKID.Text, 
                        Staff_Username = txtUserName.Text, 
                        Staff_password = txtPassword.Text, 
                        StaffPosition = cmbPosition.Text, 
                        DateOfBirth = (DateTime)dateTimePicker1.Value, 
                        HourSalary = int.Parse(txtSalary.Text), 
                        HireDate = (DateTime)DateTime.Now, 
                        isFulltime = boxPartTime.Checked

                    };

                    context.staffs.Add(std);
                    context.SaveChanges();
                    MessageBox.Show("Success!\nYour Staff ID is " + newestStaffId);
                }
                else
                {
                    MessageBox.Show("Comfirm password is wrong!!");
                }
            }

            
        }
    }
}
