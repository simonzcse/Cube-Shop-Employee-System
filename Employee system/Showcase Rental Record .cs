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
    public partial class Showcase_Rental_Record : Form
    {
        public Showcase_Rental_Record()
        {
            InitializeComponent();
        }

        private void cmbStoreID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strstoreid = cmbStoreID.SelectedItem.ToString();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbShowcase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Showcase_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            using (var classicContext = new project_manangementEntities())
            {//Conn. Database 
                txtrentID.Text = "";
                txtEndDate.Text = "";
                txtFee.Text = "";
                txtStartDate.Text = "";
                txtShowCaseID.Text = "";
                txtTenantID.Text = "";

                int showcaseID = int.Parse(cmbShowcase.Text);

                var emp = (from list in classicContext.showcase_rentrecord
                           where list.ShowcaseID == showcaseID
                           select list);

                foreach (var emp2 in emp.ToList())//get result from query
                {


                    txtrentID.AppendText(emp2.rentrecordID.ToString());
                    txtrentID.AppendText(Environment.NewLine);

                    txtShowCaseID.AppendText(emp2.ShowcaseID.ToString());
                    txtShowCaseID.AppendText(Environment.NewLine);

                    txtStartDate.AppendText(((DateTime)emp2.LeaseStartDate).ToString("dd/MM/yyyy"));
                    txtStartDate.AppendText(Environment.NewLine);

                    txtTenantID.AppendText(emp2.TenantID.ToString());
                    txtTenantID.AppendText(Environment.NewLine);


                    txtEndDate.AppendText(((DateTime)emp2.LeaseStartDate).ToString("dd/MM/yyyy"));
                    txtEndDate.AppendText(Environment.NewLine);


                    txtFee.AppendText(emp2.RentFee.ToString());
                    txtFee.AppendText(Environment.NewLine);
                }
            }
        }

    }
}
