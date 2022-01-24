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
    public partial class Update_Tenant : Form
    {
        public Update_Tenant(IDictionary<string, string> record)
        {
            InitializeComponent();
            if (record["Position"] == "Tenant") txtTID.Text = record["ID"];
            else txtTID.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTID.Text != "" && txtNew.Text != "")  //OR if !(string.IsNullOrEmpty(tb.Text))
            {
                using (var context = new project_manangementEntities())
                {
                    int intTenantID = int.Parse(txtTID.Text);

                    var stda = from list in context.tenants
                                   where list.TenantID == intTenantID
                                   select list;


                    Boolean done = false;

                    if (stda.FirstOrDefault() != null && rb != null)
                    {
                        if (rdoAddress.Checked)
                        {
                            if (txtNew.Text != "")
                            {
                                MessageBox.Show("Change Address");
                                stda.ToList()[0].Address = txtNew.Text;
                                done = true;
                            }
                        }
                        else if (rdoName.Checked)
                        {
                            if (txtNew.Text != "")
                            {
                                MessageBox.Show("Change Name");
                                stda.ToList()[0].Name = txtNew.Text;
                                done = true;
                            }
                        }
                        else if (rdoPhone.Checked)
                        {
                            if (txtNew.Text != "")
                            {
                                MessageBox.Show("Change Phone");
                                stda.ToList()[0].Phone = int.Parse(txtNew.Text);
                                done = true;
                            }
                        }
                        else if (rdoEmail.Checked)
                        {
                            if (txtNew.Text != "")
                            {
                                MessageBox.Show("Change Email");
                                stda.ToList()[0].Email = txtNew.Text;
                                done = true;
                            }
                        }
                        else if (rdoPassword.Checked)
                        {
                            if (txtNew.Text != "")
                            {
                                MessageBox.Show("Change Address Password");
                                stda.ToList()[0].Tenant_Password = txtNew.Text;
                                done = true;
                            }
                        }
                        else if (rdoUserName.Checked)
                            if (txtNew.Text != "")
                            {
                                MessageBox.Show("Change User Name");
                                stda.ToList()[0].Tenant_Username = txtNew.Text;
                                done = true;
                            }



                    }
                    
                    if(!done) MessageBox.Show("Wrong Staff ID OR no input found!!\nPlease try again!\n", "Error");

                    context.SaveChanges();
                    MessageBox.Show("Chenged to:" + txtNew.Text, "successful");
                
                }
            }
            else
            {
                MessageBox.Show("Wrong Staff ID OR no input found!!\nPlease try again!\n", "Error");
            }
        }
        RadioButton rb;
        private void rdoName_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                rb  = (RadioButton)sender;
            }
        }

        private void rdoPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                rb = (RadioButton)sender;
            }
        }

        private void rdoAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                rb = (RadioButton)sender;
            }
        }

        private void rdoEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                rb = (RadioButton)sender;
            }
        }

        private void rdoPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                rb = (RadioButton)sender;
            }
        }

        private void rdoUserName_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                rb = (RadioButton)sender;
            }
        }
    }
}
