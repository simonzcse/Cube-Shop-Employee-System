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
    public partial class Invoice : Form
    {
        public Invoice(int order)
        {
            InitializeComponent();
            using (var classicContext = new project_manangementEntities())
            {
                var showcases_id = (from list in classicContext.showcase_rentrecord
                                    where list.rentrecordID == order
                                    select list);
                foreach (var emp2 in showcases_id.ToList())//get result from query
                {
                    lblAmount.Text = emp2.RentFee.ToString();
                    lblTID.Text = emp2.TenantID.ToString();
                    lblShowCaseID.Text = emp2.ShowcaseID.ToString();
                    lblrentrecordID.Text = emp2.rentrecordID.ToString();
                    lblDuration.Text = emp2.LeaseStartDate.ToShortDateString();
                    lblDuration.Text += " - "+emp2.LeaseTermTo.ToShortDateString();
                    lblRentingStore.Text = "("+(from list in classicContext.showcases  select list.StoreID).Max().ToString()+")";
                    lblRentingStore.Text += "Tuen Mun";
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
