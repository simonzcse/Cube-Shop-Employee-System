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
    public partial class Renting_Showcase : Form
    {
        private IDictionary<string, string> record = new Dictionary<string, string>();
        DateTime currentDate = System.DateTime.Now.Date;
        String strPosition = "";
        int selfid;
        String strstoreid = "";
        String strswid = "";//showcase id

        public Renting_Showcase(IDictionary<string, string> record)
        {
            InitializeComponent();
            this.record = record;
            strPosition = record["Position"];
            selfid = int.Parse(record["ID"]);
        }

        private void Renting_Showcase_Load(object sender, EventArgs e)
        {
           if(strPosition == "Tenant")
            {
                textBox6.ReadOnly = true;
                textBox6.Text = selfid.ToString();
            }
        }

        private void cmbStoreID_SelectedIndexChanged(object sender, EventArgs e)
        {
            strstoreid = cmbStoreID.SelectedItem.ToString();
            int intstoreid = int.Parse(strstoreid);
            cmbShowcase.Items.Clear();
            using (var classicContext = new project_manangementEntities())
            {
                var showcases_id = (from list in classicContext.showcases
                                    where list.StoreID == intstoreid
                                    select list);
                foreach (var emp2 in showcases_id.ToList())//get result from query
                {
                    cmbShowcase.Items.Add(emp2.ShowcaseID.ToString());
                }
            }
        }

        private void cmbShowcase_SelectedIndexChanged(object sender, EventArgs e)
        {
            strswid = cmbShowcase.SelectedItem.ToString();
        }
        int maxrecordid;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {   int intTenantID = int.Parse(textBox6.Text.ToString());
                Boolean isexist = false;
                int fee = 0;
                int intswid = int.Parse(strswid);
                using (var classicContext = new project_manangementEntities())
                {
                    var showcases_id = (from list in classicContext.showcase_rentrecord
                                        where list.ShowcaseID == intswid
                                        select list);
                    maxrecordid = (from list in classicContext.showcase_rentrecord
                                       select list.rentrecordID).Max();
                    int countTenant = (from list in classicContext.showcase_rentrecord
                                       where list.TenantID == intTenantID
                                       select list).Count();
                    var showcases1 = (from list in classicContext.showcases
                                      where list.ShowcaseID == intswid
                                      select list);
                    foreach (var emp in showcases1.ToList())
                    {
                        fee = emp.Standard_RentFee;
                        break;
                    }
                    foreach (var emp2 in showcases_id.ToList())//get result from query
                    {
                        if (emp2.LeaseTermTo >= currentDate)
                        {


                            MessageBox.Show("This Showcase has been rented");
                            isexist = true;
                            break;
                        }
                    }

                    //do something
                    if (!isexist)
                    {
                        DialogResult dialogResult = MessageBox.Show("Mouthly fee:" + fee + "\nTotal fee:" + fee * int.Parse(txtDuration.Text), "Fee", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            showcase_rentrecord showcase_Rentrecord = new showcase_rentrecord();
                            {
                                maxrecordid++;
                                showcase_Rentrecord.rentrecordID = maxrecordid;
                                showcase_Rentrecord.ShowcaseID = intswid;
                                showcase_Rentrecord.TenantID = int.Parse(textBox6.Text.ToString());
                                int dur = int.Parse(txtDuration.Text.ToString());//have record
                                showcase_Rentrecord.LeaseStartDate = currentDate;
                                showcase_Rentrecord.LeaseTermTo = currentDate.AddMonths(dur);
                                if (countTenant >= 3 && countTenant < 6)
                                {
                                    double fee2 = fee * dur * 0.97;
                                    showcase_Rentrecord.RentFee = (int)fee2;
                                    MessageBox.Show("You have rented " + countTenant.ToString() + " times " + "\nSo you can gain 3% discount");
                                }
                                else if (countTenant >= 6)
                                {
                                    double fee2 = fee * dur * 0.94;
                                    showcase_Rentrecord.RentFee = (int)fee2;
                                    MessageBox.Show("You have rented " + countTenant.ToString() + " times " + "\nSo you can gain 6% discount");
                                }
                                else
                                {
                                    showcase_Rentrecord.RentFee = fee * dur;
                                }
                            };
                            classicContext.showcase_rentrecord.Add(showcase_Rentrecord);
                            classicContext.SaveChanges();
                            MessageBox.Show("Your Reat Duration is from " + currentDate.ToShortDateString() + " to " + showcase_Rentrecord.LeaseTermTo.ToShortDateString() + "\n times:" + countTenant.ToString());
                            isexist = true;

                            Invoice();
                        }
                    }
                    

                    

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Expection + \n\r" + ex);
            }
        }

        public void Invoice()
        {

            Invoice a = new Invoice(maxrecordid);
            a.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
