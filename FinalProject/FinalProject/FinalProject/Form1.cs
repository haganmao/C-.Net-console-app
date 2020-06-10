using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        static string xmlPath  = "bookinginfo.xml";
        static string bookingID = "";

        public Form1()
        {
            InitializeComponent();
        }

        //bind xml to gridview
        private void loadXmlFile()
        {
            DataSet mybooking = new DataSet();
            mybooking.ReadXml(xmlPath);
            try
            {
                dataGridView1.DataSource = mybooking.Tables[0];
                
            }
            catch (System.Exception)
            {

            }
        }

        //add item to 
        private void Form1_Load_1(object sender, EventArgs e)
        {
            comboboxTableNumber.Items.Add("A01 table for 2");
            comboboxTableNumber.Items.Add("A02 table for 2");
            comboboxTableNumber.Items.Add("A03 table for 2");
            comboboxTableNumber.Items.Add("A04 table for 2");
            comboboxTableNumber.Items.Add("A05 table for 2");
            comboboxTableNumber.Items.Add("B01 table for 4");
            comboboxTableNumber.Items.Add("B02 table for 4");
            comboboxTableNumber.Items.Add("B03 table for 4");
            comboboxTableNumber.Items.Add("B04 table for 4");
            comboboxTableNumber.Items.Add("B05 table for 4");
            comboboxTableNumber.Items.Add("C01 table for 6");
            comboboxTableNumber.Items.Add("C02 table for 6");
            comboboxTableNumber.Items.Add("C03 table for 6");
            comboboxTableNumber.Items.Add("C04 table for 6");
            comboboxTableNumber.Items.Add("C05 table for 6");
            comboboxTableNumber.Items.Add("D01 table for 8");
            comboboxTableNumber.Items.Add("D02 table for 8");
            comboboxTableNumber.Items.Add("D03 table for 8");
            comboboxTableNumber.Items.Add("D04 table for 8");
            comboboxTableNumber.Items.Add("D05 table for 8");
            comboTime.Items.Add("11:30");
            comboTime.Items.Add("12:00");
            comboTime.Items.Add("12:30");
            comboTime.Items.Add("13:00");
            comboTime.Items.Add("17:30");
            comboTime.Items.Add("18:00");
            comboTime.Items.Add("18:30");
            comboTime.Items.Add("19:00");

            if (System.IO.File.Exists(xmlPath))
            {
                loadXmlFile();
            }
            else
            {
                XDocument doc = new XDocument(new XElement("Booking"));
                doc.Save(xmlPath);
            }
            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Blue;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
        }

        //show bookings with details in table 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            bookingID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            dataGridView1.Columns[7].Visible = false;

            XElement data = XElement.Load(xmlPath);
            IEnumerable<XElement> elements = from bookingInfo in data.Elements("Booking")
                                             where bookingInfo.Attribute("ID").Value == bookingID
                                             select bookingInfo;
            foreach (XElement element in elements)
            {
                txtBookingID.Text = bookingID;
                txtname.Text = element.Element("Name").Value;
                txtPhone.Text = element.Element("Phone").Value;
                numPeople.Text = element.Element("Num_People").Value;
                dateTimePicker1.Text = element.Element("Date").Value;
                comboTime.Text = element.Element("Time").Value;
                comboboxTableNumber.Text = element.Element("Table_Num").Value;
            }
        }





        //add 
        private void button2_Click(object sender, EventArgs e)
        {
            XElement data = XElement.Load(xmlPath);
            IEnumerable<XElement> elementsAdd = from element in data.Elements("Booking")
                                             select element;

            string str = (Convert.ToInt32(elementsAdd.Max(element => element.Attribute("ID").Value)) + 1).ToString("0");
            string strOne = str;
            XElement booking = new XElement(
                "Booking",new XAttribute("ID",str),
                           new XElement("BookingID", strOne),
                           new XElement("Name",txtname.Text),
                           new XElement("Phone",txtPhone.Text),                       
                           new XElement("Num_People",numPeople.Text),
                           new XElement("Date",dateTimePicker1.Text),
                           new XElement("Time", comboTime.Text),
                           new XElement("Table_Num",comboboxTableNumber.Text)               
                );
            data.Add(booking);
            data.Save(xmlPath);
            loadXmlFile();
        }


        //update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (bookingID != "")
            { 
                XElement data = XElement.Load(xmlPath);
                IEnumerable<XElement> elements = from element in data.Elements("Booking")
                                                 where element.Attribute("ID").Value == bookingID
                                                 select element;          
                if (elements.Count() > 0)
                {
                    XElement UpdateData = elements.First();
                    UpdateData.SetAttributeValue("ID", bookingID);
                    UpdateData.ReplaceNodes(
                        new XElement("BookingID", bookingID),
                        new XElement("Name", txtname.Text),
                        new XElement("Phone", txtPhone.Text),
                        new XElement("Num_People", numPeople.Text),
                        new XElement("Date", dateTimePicker1.Text),
                        new XElement("Time", comboTime.Text),
                        new XElement("Table_Num", comboboxTableNumber.Text)
                        );
                }
                data.Save(xmlPath);
            }
            MessageBox.Show("Selected Booking Information has Updated");
            loadXmlFile();
        }


        //delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bookingID != "")
            {
                XElement data = XElement.Load(xmlPath);
                IEnumerable<XElement> elements = from element in data.Elements("Booking")
                                                  where element.Attribute("ID").Value == bookingID
                                                  select element;
                if (elements.Count() > 0)
                    elements.First().Remove();
                data.Save(xmlPath);
            }
            MessageBox.Show("Selected Booking has Deleted");
            loadXmlFile();
        }
        

        //search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSeacrchName.Text != "")
            {
                Name = txtSeacrchName.Text;
                XElement data = XElement.Load(xmlPath);
                IEnumerable<XElement> elements = from bookingInfo in data.Elements("Booking")
                                                 where bookingInfo.Element("Name").Value == Name
                                                 select bookingInfo;
                foreach (XElement element in elements)
                {
                    txtBookingID.Text = bookingID;
                    txtBookingID.Text = element.Attribute("ID").Value;
                    txtname.Text = element.Element("Name").Value;
                    txtPhone.Text = element.Element("Phone").Value;
                    numPeople.Text = element.Element("Num_People").Value;
                    dateTimePicker1.Text = element.Element("Date").Value;
                    comboTime.Text = element.Element("Time").Value;
                    comboboxTableNumber.Text = element.Element("Table_Num").Value;
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string s = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    
                    if (s == Name)
                    {
                        
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            else
                MessageBox.Show("Please Enter a Customer name for Search");
        }


        //reset for new bookings
        private void btnnew_Click(object sender, EventArgs e)
        {
            this.txtBookingID.Text = "";
            this.txtname.Text = "";
            this.txtPhone.Text = "";
            this.numPeople.Text = "";
            this.dateTimePicker1.Text = "";
            this.comboTime.Text = "";
            this.comboboxTableNumber.Text = "";
        }
        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void numPeople_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void tableNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSeacrchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
