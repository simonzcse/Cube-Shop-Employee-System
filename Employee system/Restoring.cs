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
    public partial class Restoring : Form
    {
        public Restoring()
        {
            InitializeComponent();
        }

        public Restoring(String productId)
        {
            InitializeComponent();

            txtPID.Text = productId;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var context = new project_manangementEntities())
            {
                int intPID = int.Parse(txtPID.Text);
                int intSID = int.Parse(txtSID.Text);

                var std = from list in context.showcase_product
                          where list.ProductID == intPID && intSID == list.ShowcaseID
                          select list;

                if (std.FirstOrDefault() != null)
                {
                    std.ToList()[0].stock += int.Parse(txtQty.Text);
                    MessageBox.Show("The stock is successfully set to " + std.ToList()[0].stock);
                    context.SaveChanges();
                }

                else MessageBox.Show("Not Found!");
            }
        }

        private void txtSID_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
