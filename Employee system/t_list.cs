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
    public partial class t_list : Form
    {
        public t_list()
        {
            InitializeComponent();
        }

        private void t_list_Load(object sender, EventArgs e)
        {
            using (var classicContext = new project_manangementEntities())
            {//Conn. Database 

                var emp = (from list in classicContext.tenants
                           select list);

                foreach (var emp2 in emp.ToList())
                {
                    txtt.AppendText(emp2.TenantID.ToString());
                    txtt.AppendText(Environment.NewLine);

                    txtn.AppendText(emp2.Name.ToString());
                    txtn.AppendText(Environment.NewLine);

                    txtba.AppendText(emp2.Address.ToString());
                    txtba.AppendText(Environment.NewLine);

                    txte.AppendText(emp2.Email.ToString());
                    txte.AppendText(Environment.NewLine);

                    txtjd.AppendText(emp2.DateOfBirth.ToShortDateString());
                    txtjd.AppendText(Environment.NewLine);


                }






            }

        }
    }
}
