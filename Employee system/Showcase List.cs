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
    public partial class Showcase_List : Form
    {
        public Showcase_List()
        {
            InitializeComponent();

            using (var classicContext = new project_manangementEntities())
            {
                var showcases_id = (from list in classicContext.showcases
                                    select list.StoreID ).Distinct();
                foreach (var emp2 in showcases_id.ToList())//get result from query
                {
                    cmbShowcase.Items.Add(emp2);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTID.Text = txtStatus.Text = txtReserveFrom.Text = txtReserveEnd.Text = txtHaveAdv.Text =
                txtFrom.Text = txtFee.Text = txtEnd.Text = txtBookedTID.Text = txtAdv.Text = txtSID.Text = txtBookedTID.Text = "";
            

            using (var classicContext = new project_manangementEntities())
            {//Conn. Database 
                int TargetStore = int.Parse(cmbShowcase.Text);

                var emp = (from list in classicContext.showcases
                           where list.StoreID == TargetStore
                           select list);

                var bv = (from list in classicContext.showcase_rentrecord
                          select list);

                

                foreach (var emp2 in emp.ToList())//get result from query
                {
                    txtShop.Text = emp2.StoreID.ToString();

                    txtSID.AppendText(emp2.ShowcaseID.ToString());
                    txtSID.AppendText(Environment.NewLine);

                    CheckBookedRecord(emp2.ShowcaseID);
                    txtBookedTID.AppendText(Environment.NewLine);
                    txtReserveEnd.AppendText(Environment.NewLine);
                    txtReserveFrom.AppendText(Environment.NewLine);

                    bv = (from list in classicContext.showcase_rentrecord
                          where list.ShowcaseID == emp2.ShowcaseID
                          select list);

                    if (bv.FirstOrDefault() != null)
                    {
                        if (bv.ToList()[0].LeaseTermTo != null) txtEnd.AppendText(((DateTime)bv.ToList()[0].LeaseTermTo).ToString("dd/MM/yyyy"));
                        

                        txtFee.AppendText("$" + bv.ToList()[0].RentFee.ToString());
                        

                        if (bv.ToList()[0].LeaseTermTo != null) txtFrom.AppendText(((DateTime)bv.ToList()[0].LeaseTermTo).ToString("dd/MM/yyyy"));
                        

                        txtTID.AppendText(bv.ToList()[0].TenantID.ToString());
                        
                    }
                    txtTID.AppendText(Environment.NewLine);
                    txtFrom.AppendText(Environment.NewLine);
                    txtFee.AppendText(Environment.NewLine);
                    txtEnd.AppendText(Environment.NewLine);

                    if (emp2.adv_description != null)
                    {
                        if ((emp2.adv_description.ToString() != ""))
                        {
                            txtHaveAdv.AppendText("Yes");
                            txtAdv.AppendText(emp2.adv_description.ToString());
                        }
                        else txtHaveAdv.AppendText("No");
                    }
                    else txtHaveAdv.AppendText("No");

                    txtAdv.AppendText(Environment.NewLine);
                    txtHaveAdv.AppendText(Environment.NewLine);

                    txtStatus.AppendText(emp2.ShowcaseType.ToString());
                    txtStatus.AppendText(Environment.NewLine);

                }
                SetTextsize();
            }
        }

        public void SetTextsize()
        {
            Size size = TextRenderer.MeasureText(txtSID.Text, txtSID.Font);
            txtSID.Height = size.Height;
            txtReserveFrom.Height = size.Height;
            txtReserveEnd.Height = size.Height;
            txtHaveAdv.Height = size.Height;
            txtFrom.Height = size.Height;
            txtFee.Height = size.Height;
            txtEnd.Height = size.Height;
            txtBookedTID.Height = size.Height;
            txtAdv.Height = size.Height;
            txtTID.Height = size.Height;
            txtStatus.Height = size.Height;
        }

        public void CheckBookedRecord(int ShowcaseID)
        {
            using (var classicContext = new project_manangementEntities())
            {

                var book = (from list in classicContext.bookedshowcases
                            where ShowcaseID == list.ShowcaseID
                            select list);

                foreach (var emp2 in book.ToList())//get result from query
                {
                    txtBookedTID.AppendText(emp2.TenantID.ToString());
                    
                    txtReserveEnd.AppendText(((DateTime)emp2.BookingTermTo).ToString("dd/MM/yyyy"));
                    
                    txtReserveFrom.AppendText(((DateTime)emp2.BookingStartDate).ToString("dd/MM/yyyy"));
                    
                }
            }
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBookedTID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReserveFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReserveEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHaveAdv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
