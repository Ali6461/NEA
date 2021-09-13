using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Hotel_Booking_System
{
    public partial class FmMenu : Form
    {
        public FmMenu()
        {
            InitializeComponent();
        }

        private void FmMenu_Load(object sender, EventArgs e)
        {
            if (File.Exists("FPHotelCS.accdb") ==false)
            {
                ADOX.Catalog cat = new ADOX.Catalog();
                cat.Create(Program.connString); 
                OleDbConnection Conn = new OleDbConnection(Program.connString);
                Conn.Open(); 
                OleDbCommand Cmd = new OleDbCommand(); 
                Cmd.Connection = Conn;

                Cmd.CommandText = "CREATE TABLE Booking(Date_In DATE(8), " + " Date_Out DATE(8), " + " Price INTEGER(4), " + " Name VarChar(20), "
                    + " BookingID INTEGER(4), FOREIGN KEY (Name) REFERENCES Customer(Name), PRIMARY KEY (BookingID)";
                Cmd.ExecuteNonQuery();


                Cmd.CommandText = "CREATE TABLE Customer(Name VARCHAR(20), " + " Tele INTEGER(11), " + " PRIMARY KEY (Name)";
                Cmd.ExecuteNonQuery();


                Cmd.CommandText = "CREATE TABLE Room(Room_Size INTEGER(2), " + " Room_Numner INTEGER(2), " + " Price INTEGER(4), "
                    + " Occupied BIT, " + " BookingID INTEGER(4), " + " PRIMARY KEY (Room_Number)";
                Cmd.ExecuteNonQuery();
                Conn.Close();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btBooking_Click(object sender, EventArgs e)
        {
            Booking Book = new Booking();
            Book.ShowDialog();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {

        }

        private void FmMenu_Load_1(object sender, EventArgs e)
        {

        }
    }
}

