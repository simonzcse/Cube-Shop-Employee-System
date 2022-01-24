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
    public partial class Main_menu : Form
    {
        private IDictionary<string, string> record = new Dictionary<string, string>();

        public Main_menu(IDictionary<string, string> record)
        {
            InitializeComponent();

            lblPosition.Text = record["Position"];
            this.record = record;
            String strPosition = record["Position"];

            if (record["Position"] == "Tenant")
            {
                btnInstoring.Enabled = false;
                btnItemInfomation.Enabled = false;
                btnSaling.Enabled = false;
                btnTList.Enabled = false;
                btnUpdateStaff.Enabled = false;
                btnTList.Enabled = false;
                btnPastTimeRecord.Enabled = false;
                btnNewItem.Enabled = false;
                btnStaffList.Enabled = false;
                btnInstoring.Enabled = false;
                btnDeleteStaff.Enabled = false;
                btnCal.Enabled = false;
                btnNewStaff.Enabled = false;
            }
            //switch (strPosition)
           // {
            //    default:

           // }

        }

        private void Main_menu_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome, " + record["Username"] + "!", "Logined successfully!");
        }

        private void btnItemInfomation_Click(object sender, EventArgs e)
        {
            Item_Infomation item1 = new Item_Infomation(record);
            item1.ShowDialog();
           // this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInstoring_Click(object sender, EventArgs e)
        {
            Restoring restoring = new Restoring();
            restoring.ShowDialog();
            //this.Hide();
        }

        private void btnSaling_Click(object sender, EventArgs e)
        {
            Saling sail = new Saling(record);
            sail.ShowDialog();
           // this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show_Case showc = new Show_Case(); //this is the change, code for redirect  

            showc.ShowDialog();
           // this.Hide();
        }

        private void btnTakingItem_Click(object sender, EventArgs e)
        {
            Taking_Item takit = new Taking_Item();
            takit.ShowDialog();
           // this.Hide();
        }

        private void grpItem_Enter(object sender, EventArgs e)
        {

        }

        private void Main_menu_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Delete_staff delete_staff = new Delete_staff();
            delete_staff.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Cal_Salary cal_Salary = new Cal_Salary();
            cal_Salary.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Staff_List staff_List = new Staff_List();
            staff_List.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PTStaff_work pTStaff_Work = new PTStaff_work();
            pTStaff_Work.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Showcase_List showcase_List = new Showcase_List();
            showcase_List.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Update_Staff update_Staff= new Update_Staff(record);
            update_Staff.ShowDialog();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            New_Item New_Item = new New_Item(record);
            New_Item.ShowDialog();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Showcase_Inventory showcase_Inventory = new Showcase_Inventory(record);
            showcase_Inventory.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Renting_Showcase renting_Case = new Renting_Showcase(record);
            renting_Case.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Reserve_Showcase reserve_Showcase = new Reserve_Showcase(record);
            reserve_Showcase.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Self_item self_Item = new Self_item(record);
            self_Item.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Showcase_Sales_Record showcase_Sales_Record = new Showcase_Sales_Record(record);
            showcase_Sales_Record.ShowDialog();
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            Renting_Showcase renting_Case = new Renting_Showcase(record);
            renting_Case.ShowDialog();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Showcase_Sales_Record showcase_Sales_Record = new Showcase_Sales_Record(record);
            showcase_Sales_Record.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Self_item self_Item = new Self_item(record);
            self_Item.ShowDialog();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            Reserve_Showcase reserve_Showcase = new Reserve_Showcase(record);
            reserve_Showcase.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Showcase_Inventory showcase_Inventory = new Showcase_Inventory(record);
            showcase_Inventory.ShowDialog();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Monthly_Statement showcase_Inventory = new Monthly_Statement(record);
            showcase_Inventory.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t_list t_list = new t_list();
            t_list.ShowDialog();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            New_Satff a = new New_Satff(record);
            a.ShowDialog();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            New_Tenant a = new New_Tenant(record);
            a.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Find_sales_record a = new Find_sales_record(record);
            a.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Showcase_Rental_Record a = new Showcase_Rental_Record();
            a.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Update_Tenant a = new Update_Tenant(record);
            a.ShowDialog();

        }
    }
}
