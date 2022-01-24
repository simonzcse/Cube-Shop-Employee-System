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
    public partial class Reserve_Showcase : Form
    {
        private IDictionary<string, string> record = new Dictionary<string, string>();
        DateTime currentDate = System.DateTime.Now.Date;
        String strPosition = "";
        int selfid;
        String strstoreid = "";
        String strswid = "";//showcase id
        DateTime Startdate = System.DateTime.Now.Date;
        public Reserve_Showcase(IDictionary<string, string> record)
        {
            
            InitializeComponent();
            this.record = record;
            strPosition = record["Position"];
            selfid = int.Parse(record["ID"]);

        }

        private void Reserve_Showcase_Load(object sender, EventArgs e)
        {
            if (strPosition == "Tenant")
            {
                textBox6.ReadOnly = true;
                textBox6.Text = selfid.ToString();
            }
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtcredit.ReadOnly = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtcredit.ReadOnly = true;
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Startdate = dateTimePicker1.Value.Date; 
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int intTenantID = int.Parse(textBox6.Text.ToString());
                Boolean isexist = false;
                int intswid = int.Parse(strswid);//showcaseid
                using (var classicContext = new project_manangementEntities())
                {
                    var showcases_id = (from list in classicContext.showcase_rentrecord
                                        where list.ShowcaseID == intswid
                                        select list);
                    var showcases_id_booking = (from list in classicContext.bookedshowcases
                                                where list.ShowcaseID == intswid
                                                select list);
                    int maxrecordid = (from list in classicContext.bookedshowcases
                                       select list.BookingID).Max();//find max
                    int countTenant = (from list in classicContext.showcase_rentrecord
                                       where list.TenantID == intTenantID
                                       select list).Count();
                    foreach (var emp2 in showcases_id.ToList())//get result from query
                    {
                        if (emp2.LeaseTermTo >= Startdate)
                        {
                            MessageBox.Show("This Showcase still Rented");
                            isexist = true;
                            break;
                        }
                    }
                    foreach (var emp3 in showcases_id_booking.ToList())//get result from query
                    {
                        if (emp3.BookingTermTo >= Startdate)
                        {
                            MessageBox.Show("This Showcase has been Booked");
                            isexist = true;
                            break;
                        }
                    }
                    if (!isexist)
                    {
                        bookedshowcase bookedshowcase = new bookedshowcase();
                        {
                            bookedshowcase.ShowcaseID = intswid;
                            bookedshowcase.TenantID = int.Parse(textBox6.Text.ToString());
                            maxrecordid++;
                            bookedshowcase.BookingID = maxrecordid;
                            bookedshowcase.BookingStartDate = Startdate;
                            int dur = int.Parse(textBox1.Text.ToString());//have record
                            bookedshowcase.BookingTermTo = Startdate.AddMonths(dur);
                            if (radioButton2.Checked)
                            {
                                int credit= int.Parse(txtcredit.Text.ToString());
                                bookedshowcase.Prepaid_credit = credit;
                                bookedshowcase.PrepaidDate = currentDate;
                            }
                            else if (radioButton1.Checked)
                            {
                                bookedshowcase.Prepaid_credit = 0;
                                bookedshowcase.PrepaidDate = null;
                            }
                        };
                        classicContext.bookedshowcases.Add(bookedshowcase);
                        classicContext.SaveChanges();
                        MessageBox.Show("Your Book Duration is from " + Startdate.ToShortDateString() + " to " + bookedshowcase.BookingTermTo.ToShortDateString());
                        isexist = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Expection" + "\n\r" + ex);
            }

            }
        }
    }

