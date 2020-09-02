# QM Restaurant Booking Management 
### QM Restaurant Booking Management System is an free and open source application built with C#, it will be a very handy tool for small restaurants after the development is completed. There is no commercial version in the funture, Any query please contact us through github, Thank you!

<br>
<br>

## Features
*	User able to input name
*	User able to enter phone number
*	Options for User confirming the booking’s number of people
*	Date and Time selections
*	Table Number selections
*	Add new bookings
*	Booking ID autoincrement 
*	Update Booking content
*	Delete booking 
*	Booking detail search by customer name
*	Reset booking content
*	Check phone number 
*	Check customer name
*	Check blank field(customer name and phone number only)
*	Ascending or Descending Booking ID, Name, Phone, Num_People,Date, Table_Num



## Demo

![d1](https://github.com/haganmao/C-.Net-console-app/blob/master/QMRestaurantBooking/demo1.JPG "demo1") 
### new booking with correct fields infomation
<br>
<br>

![d2](https://github.com/haganmao/C-.Net-console-app/blob/master/QMRestaurantBooking/demo2.JPG "demo2")
### validate customer name
<br>
<br>

![d3](https://github.com/haganmao/C-.Net-console-app/blob/master/QMRestaurantBooking/demo3.JPG "demo3")

### booking history searching by customer name
<br>
<br>
![d4](https://github.com/haganmao/C-.Net-console-app/blob/master/QMRestaurantBooking/demo4.JPG "demo4")
<br>
<br>

### validated booking information with massive dataset by acsending Date


<br>
<br>
<br>
## Code

'XML file loading'

```C#
 //bind xml to gridview
        private void loadXmlFile()
        {
            DataSet mybooking = new DataSet();
            mybooking.ReadXml(xmlPath);
            try
            {
                dataGridView1.DataSource = mybooking.Tables[0];
                dataGridView1.Columns[7].Visible = false;
            }
            catch (System.Exception)
            {

            }
        }
```

<br>

'Add New Booking'

```C#
    private void button2_Click(object sender, EventArgs e)
        {
            XElement data = XElement.Load(xmlPath);
            IEnumerable<XElement> elementsAdd = from element in data.Elements("Booking")
                                             select element;
            int i = 0;
            string str = (Convert.ToInt32(elementsAdd.Max(element => element.Attribute("ID").Value)) + (i+1)).ToString("00");
            string strOne = str;
            try
            {

                XElement booking = new XElement(
                "Booking",new XAttribute("ID",str),
                            new XElement("BookingID", str),
                            new XElement("Name",txtname.Text),
                            new XElement("Phone",txtPhone.Text),                       
                            new XElement("Num_People",numPeople.Text),
                            new XElement("Date",dateTimePicker1.Text),
                            new XElement("Time", comboTime.Text),
                            new XElement("Table_Num",comboboxTableNumber.Text)               
                );

                if (txtname.Text != "" && txtPhone.Text != "") { 

                    data.Add(booking);
                    data.Save(xmlPath);
                    loadXmlFile();
                }
                else {
                    MessageBox.Show("Please enter all blank fileds, then click Add Button!Thank you");
                }

            }
            catch (System.Exception)
            {

            }
        }
```

