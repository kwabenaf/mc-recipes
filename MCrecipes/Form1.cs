using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.IO;

namespace MCrecipes
{

    public partial class Form1 : Form
    {
        //Draggable form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        //Draggable form
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Rounding the corners of the form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //Rounding form
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int HeightEllipse
        );

        //Connecting to the database
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
            
            //Rounding form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(45, 106, 79);

            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //HOME BUTTON
        private void btnHome_Click(object sender, EventArgs e)
        {
            //to move the nav bar, change the button color on click
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(45, 106, 79);
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(27, 67, 50);
        }


        //ALL ITEMS BUTTON
        private void btnAll_Click(object sender, EventArgs e)
        {
            //to change the default color of the home button
            btnHome.BackColor = Color.FromArgb(27, 67, 50);

            //to move the nav bar, change the button color on click
            pnlNav.Height = btnAll.Height;
            pnlNav.Top = btnAll.Top;
            pnlNav.Left = btnAll.Left;
            btnAll.BackColor = Color.FromArgb(45, 106, 79);

        }

        private void btnAll_Leave(object sender, EventArgs e)
        {
            //change the button back to normal after another button is clicked
            btnAll.BackColor = Color.FromArgb(27, 67, 50);
        }


        //RECENTS BUTTON
        private void btnRecent_Click(object sender, EventArgs e)
        {
            //to change the default color of the home button
            btnHome.BackColor = Color.FromArgb(27, 67, 50);

            //to move the nav bar, change the button color on click
            pnlNav.Height = btnRecent.Height;
            pnlNav.Top = btnRecent.Top;
            pnlNav.Left = btnRecent.Left;
            btnRecent.BackColor = Color.FromArgb(45, 106, 79);
        }

        private void btnRecent_Leave(object sender, EventArgs e)
        {
            //change the button back to normal after another button is clicked
            btnRecent.BackColor = Color.FromArgb(27, 67, 50);
        }


        //FAVOURITES BUTTON
        private void btnFav_Click(object sender, EventArgs e)
        {
            //to change the default color of the home button
            btnHome.BackColor = Color.FromArgb(27, 67, 50);

            //to move the nav bar, change the button color on click
            pnlNav.Height = btnFav.Height;
            pnlNav.Top = btnFav.Top;
            pnlNav.Left = btnFav.Left;
            btnFav.BackColor = Color.FromArgb(45, 106, 79);
        }

        private void btnFav_Leave(object sender, EventArgs e)
        {
            //change the button back to normal after another button is clicked
            btnFav.BackColor = Color.FromArgb(27, 67, 50);
        }


        //SETTINGS BUTTON
        private void btnSettings_Click(object sender, EventArgs e)
        {
            //to change the default color of the home button
            btnHome.BackColor = Color.FromArgb(27, 67, 50);

            //to move the nav bar, change the button color on click
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(45, 106, 79);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            //change the button back to normal after another button is clicked
            btnSettings.BackColor = Color.FromArgb(27, 67, 50);
        }

        //close form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //minimise form
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //making the form draggable
        private void pnlDrag_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //SEARCHBAR CLEARING
        private void txtSearch_Click(object sender, EventArgs e)
        {

            //this just gets rid of what is put there by me and nothing else the user inputs
            if (txtSearch.Text.Trim() == "Search...")

            {

                txtSearch.Text = "";

            }
        }

        
        void showLbl()
        {
            lblItemname.Show();
            lblItemIng.Show();
            lblName.Show();
            lblIng.Show();
        }

        void hideLbl() 
        {

            lblError.Show();
            lblItemname.Hide();
            lblItemIng.Hide();
            lblName.Hide();
            lblIng.Hide();

        }

        //method for the search commands
        void searchClick() 
        {

            //To remove the error message so it's not there the whole time
            lblError.Text = "";

            //try catch in case the item searched is not in the database
            try
            {
                string selectQuery = "SELECT * FROM mc_recipes_project.items WHERE Name = '" + txtSearch.Text + "'";

                command = new MySqlCommand(selectQuery, connection);

                da = new MySqlDataAdapter(command);

                DataTable table = new DataTable();

                da.Fill(table);

                showLbl();

                lblName.Text = table.Rows[0][1].ToString();
                lblIng.Text = table.Rows[0][3].ToString();

                byte[] img = (byte[])table.Rows[0][4];

                MemoryStream ms = new MemoryStream(img);
                picItem.Image = Image.FromStream(ms);

                da.Dispose();
            }

            catch (IndexOutOfRangeException)
            {

                lblError.Text = "Sorry that Item cannot be found";

                hideLbl();
                picItem.Image = MCrecipes.Properties.Resources.Empty_crafting_table;


            }

        }

        //actually searching by click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchClick();
        }

        //searching by enter
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                searchClick();
            }
        }
    }
}