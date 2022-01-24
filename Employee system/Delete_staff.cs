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
    public partial class Delete_staff : Form
    {
        public Delete_staff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                using (var classicContext = new project_manangementEntities()) {
                    Boolean isdel = false;
                    int sid = int.Parse(textBox1.Text);

                    var std = from list in classicContext.staffs
                              where list.StaffID == sid
                              select list;

                    foreach (var emp2 in std.ToList())
                    {
                        classicContext.staffs.Remove(emp2);

                        isdel = true;
                    }
                    try {
                        classicContext.SaveChanges();
                        MessageBox.Show(sid + " Deleted");
                    }
                    catch (Exception exp) { MessageBox.Show(sid + " Cant \n\r" +exp); }
                        
                    

    




                }
            }
            catch (Exception ex) { MessageBox.Show("Error : \n\r"+ex); }

        }
    }
}
