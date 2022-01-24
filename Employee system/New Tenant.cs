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
    public partial class New_Tenant : Form
    {
        private IDictionary<string, string> record = new Dictionary<string, string>();

        public New_Tenant(IDictionary<string, string> record)
        {
            InitializeComponent();
            this.record = record;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int newestTenantId = int.Parse(record["newestTenantId"]) + 1;// newestProductId + 1
            record["newestTenantId"] = newestTenantId.ToString();

            using (var context = new project_manangementEntities())
            {

                if (txtPassword.Text == txtComfirmPassword.Text)
                {
                    var std = new tenant()
                    {
                        TenantID = newestTenantId,
                        Name = txtRealName.Text,
                        Tenant_HKIDNumber = txtHKID.Text,
                        Tenant_Username = txtUserName.Text,
                        Tenant_Password = txtPassword.Text,
                        Phone = int.Parse(txtPhone.Text),
                        DateOfBirth = (DateTime)dateTimePicker1.Value,
                        Email = txtEmail.Text,
                        DateTimeofCreation = (DateTime)DateTime.Now,
                        Address = txtAddress.Text,
                        CommisionRate = int.Parse(txtCommission.Text)
                    };

                    context.tenants.Add(std);
                    context.SaveChanges();
                    MessageBox.Show("Success!\nYour Staff ID is " + newestTenantId);
                }
                else
                {
                    MessageBox.Show("Comfirm password is wrong!!");
                }
            }
        }
    }
}
