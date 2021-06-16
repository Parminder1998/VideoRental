using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VideoRental
{//'Forms' is a class.  The only methods etc that should be here are those that apply to the form and it's components. 
    //All others should be in a different class e.g. database class (It's the only other one I have at the moment!)
    public partial class Form1 : Form
    { //Instantiate database class - create a new 'instance' of it from the 'blueprint'
        private Database myDatabase = new Database();

        public Form1()
        {//Set everything in place - preparation
            InitializeComponent();
            LoadDB();
            lbxScreen.Visible = false;
        }
        //Display the data in the tables
        public void LoadDB()
        {//call up all the methods that have been written below
            DisplayDataGridViewCustomer();
            DisplayDataGridViewMovie();
            DisplayDataGridViewRentedMovies();

        }
        //private vs public:  If there is no need for anyone else to have access to the method then it should be private.  Anything that applies only to the class in which it is located can be a private.  Anything that is going to be accessed by other classes needs to be public.  Technically, the above method could be private

        private void DisplayDataGridViewCustomer()
        {//load the customer table 
            //start off empty
            dgvCustomer.DataSource = null;
            try
            {
                dgvCustomer.DataSource = myDatabase.FilldgvCustomerWithCustomer();
                dgvCustomer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {// wonderful way to show where to find any errors!
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayDataGridViewMovie()
        {//load the Movie table
            dgvMovies.DataSource = null;
            try
            {
                dgvMovies.DataSource = myDatabase.FilldgvMoviesWithMovies();
                dgvMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayDataGridViewRentedMovies()
        {//load  rented movies table
            dgvRentedMovies.DataSource = null;
            try
            {
                dgvRentedMovies.DataSource = myDatabase.FilldgvRentedMovieswithInfo();
                dgvRentedMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                this.dgvRentedMovies.DefaultCellStyle.ForeColor = Color.Black;

                for (int i = 0; i < dgvRentedMovies.Rows.Count - 1; i++)
                {
                    if ((dgvRentedMovies.Rows[i].Cells[7].FormattedValue.Equals(string.Empty)))
                    {
                        dgvRentedMovies.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//specify the layout of the dgv and what it will contain
         // click event set to cell click raather than cell contennt click so that anywhere in the cell will activate command 
            int CustomerID = 0;

            try
            {
                CustomerID = (int)dgvCustomer.Rows[e.RowIndex].Cells[0].Value;
                tbxFN.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxLN.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbxPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (e.RowIndex >= 0)
                {
                    tbxCustID.Text = CustomerID.ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string result = null;
            // if there's something in the specified text boxes
            if ((tbxFN.Text != string.Empty) && (tbxLN.Text != string.Empty) && (tbxAddress.Text != string.Empty) &&
                (tbxPhone.Text != string.Empty))
            {
                try
                {//call up the method from the class
                    result = myDatabase.InsertorUpdateCustomer(tbxFN.Text, tbxLN.Text, tbxAddress.Text, tbxPhone.Text,
                        tbxCustID.Text,
                        "Add");
                    MessageBox.Show(tbxFN.Text + " " + tbxLN.Text + " added " + result);
                }
                catch (Exception a)
                {

                    MessageBox.Show((a.Message));
                }
                //where the output/results are to be displayed
                DisplayDataGridViewCustomer();
                tbxFN.Text = "";
                tbxLN.Text = "";
                tbxAddress.Text = "";
                tbxPhone.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter first name, last name, address and phone.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {//Gets rid of all the information sitting in text boxes
            ClearAllTextBoxes(this);
        }

        public void ClearAllTextBoxes(Control root)
        {
            //method for above
            foreach (Control ctrl in root.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = String.Empty;

                }
                //juggling boxes
                lbxScreen.Visible = false;
            }
        }

        private void btnUpdateCust_Click(object sender, EventArgs e)
        {//again, if the boxes are not empty
            string result = null;

            if ((tbxFN.Text != string.Empty) && (tbxLN.Text != string.Empty) && (tbxAddress.Text != string.Empty) &&
                (tbxPhone.Text != string.Empty))
            {
                try
                {//use the update command
                    result = myDatabase.InsertorUpdateCustomer(tbxFN.Text, tbxLN.Text, tbxAddress.Text, tbxPhone.Text,
                        tbxCustID.Text,
                        "Update");
                    MessageBox.Show(tbxFN.Text + " " + tbxLN.Text + " updated" + result);
                }
                catch (Exception a)
                {

                    MessageBox.Show((a.Message));
                }
                DisplayDataGridViewCustomer();
                tbxFN.Text = "";
                tbxLN.Text = "";
                tbxAddress.Text = "";
                tbxPhone.Text = "";
            }
            else
            {  //message to
                MessageBox.Show("Are these the changes you wish to make?", "", MessageBoxButtons.OKCancel);
            }
        }

        private void btnDeleteCust_Click(object sender, EventArgs e)
        { //check before deleting  - for some reason two strings are needed to make this work. Brings up a dialogue box to confirm deletion - an added measure of security
            DialogResult dialogueResult = MessageBox.Show("Are you sure you want to delete this Customer's details?", "", MessageBoxButtons.OKCancel);

            if (dialogueResult == DialogResult.OK)
            {//then go ahead and delete
                string CustID = tbxCustID.Text;
                //string result = null;
                MessageBox.Show(myDatabase.DeleteCustomer(CustID));
                DisplayDataGridViewCustomer();
                ClearAllTextBoxes(this);
            }
            //otherwise, if it is 'cancel' it doesn't delete


        }

        private void dgvMovies_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {//display the movie information of the movie clicked on in the text boxes
         // click event set to cell click rather than cell contennt click so that anywhere in the cell will activate command 
            int MovieID = 0;
            int Year = 0;
            try
            {
                MovieID = (int)dgvMovies.Rows[e.RowIndex].Cells[0].Value;
                tbxRating.Text = dgvMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxTitle.Text = dgvMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxYear.Text = dgvMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbxPlot.Text = dgvMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbxGenre.Text = dgvMovies.Rows[e.RowIndex].Cells[7].Value.ToString();
                if (e.RowIndex >= 0)
                {
                    tbxMovieID.Text = MovieID.ToString();
                    tbxScreen.Text = tbxTitle.Text;
                    tbxCost.Text = Cost(dgvMovies.Rows[e.RowIndex].Cells[3].Value.ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string Cost(string MovieYear)

        {//Work out the cost of the movies based on the year they were released
            int Yearnow = (Convert.ToInt32(DateTime.Now.Year));
            int YearsOld = Yearnow - Convert.ToInt32(MovieYear);
            if (YearsOld <= 5)

            {
                return "5";

            }
            else
            {
                return "2";
            }

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {//Same as for adding customer  - use the 'add' portion of the InsertUpdate method 
            string result = null;

            if ((tbxRating.Text != String.Empty) && (tbxTitle.Text != string.Empty) && (tbxYear.Text != string.Empty) &&
                (tbxPlot.Text != string.Empty) && (tbxGenre.Text != string.Empty) && (Copies_txt.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.InsertorUpdateMovie(tbxRating.Text, tbxTitle.Text, tbxYear.Text, tbxPlot.Text,
                        tbxGenre.Text, tbxMovieID.Text, Cost(tbxYear.Text), Copies_txt.Text, "Add");
                    //show it has been successful in a message box
                    MessageBox.Show(tbxTitle.Text + " added " + result);
                }
                catch (Exception a)
                {

                    MessageBox.Show((a.Message));
                }
                //Show all the information in appropriate places
                DisplayDataGridViewMovie();
                tbxMovieID.Text = "";
                tbxRating.Text = "";
                tbxTitle.Text = "";
                tbxYear.Text = "";
                tbxPlot.Text = "";
                tbxGenre.Text = "";
                Copies_txt.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill in Rating, Title, Year, Plot and Genre boxes.");
            }
        }

        private void btnDelMovie_Click(object sender, EventArgs e)
        {//Again a safety feature added to prevent an accidental deletion
            DialogResult dialogueResult = MessageBox.Show("Are you sure you want to delete this Movie?", "",
                MessageBoxButtons.OKCancel);

            if (dialogueResult == DialogResult.OK)
            {
                string MovieID = tbxMovieID.Text;
                //string result = null;
                MessageBox.Show(myDatabase.DeleteMovie(MovieID));
                DisplayDataGridViewMovie();
                //Clear all the information from the text boxes once the function has been completed
                ClearAllTextBoxes(this);
            }
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {//same as update customers
            string result = null;

            if ((tbxRating.Text != String.Empty) && (tbxTitle.Text != string.Empty) && (tbxYear.Text != string.Empty) &&
                (tbxPlot.Text != string.Empty) && (tbxGenre.Text != string.Empty) && (Copies_txt.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.InsertorUpdateMovie(tbxRating.Text, tbxTitle.Text, tbxYear.Text, tbxPlot.Text,
                        tbxGenre.Text, tbxMovieID.Text, Cost(tbxYear.Text), Copies_txt.Text, "Update");
                    MessageBox.Show(tbxTitle.Text + " updated " + result);
                    tbxScreen.Text = tbxTitle.Text;
                }
                catch (Exception a)
                {

                    MessageBox.Show((a.Message));
                }
                DisplayDataGridViewMovie();
                tbxMovieID.Text = "";
                tbxRating.Text = "";
                tbxTitle.Text = "";
                tbxYear.Text = "";
                tbxPlot.Text = "";
                tbxGenre.Text = "";
                Copies_txt.Text = "";
            }
            else
            {
                MessageBox.Show("Are these the changes you wish to make?", "", MessageBoxButtons.OKCancel);
            }
        }

        private void btnMostPopular_Click(object sender, EventArgs e)
        {//fill screen with the information from the MostPopular movie view
            lbxScreen.DataSource = myDatabase.FillListViewwithMostPopularMovies();

            //make sure the boxes are the right way around to display as I want
            tbxScreen.Visible = false;
            lbxScreen.Visible = true;
        }

        private void btnMostVideos_Click(object sender, EventArgs e)
        { //information comes from the RentedMostMvies view
            lbxScreen.DataSource = myDatabase.RentedMostMovies();
            tbxScreen.Visible = false;
            lbxScreen.Visible = true;
        }
        private void MoviesStillOut()
        {//load the view that has been created using information from the created view and fill the data grid view with a new set of information
            dgvRentedMovies.DataSource = null;
            myDatabase.OverdueCust();
            // instantiate list because it is a class in the background 
            List<string> RMID = new List<string>();

            RMID.AddRange(myDatabase.OverdueCust());

            try
            {
                dgvRentedMovies.DataSource = myDatabase.FilldgvRentedMovieswithMoviesOut();
                dgvRentedMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                //set the colour of the main body of text

                this.dgvRentedMovies.DefaultCellStyle.ForeColor = Color.Blue;
                for (int i = 0; i < dgvRentedMovies.Rows.Count - 1; i++)
                    if
                    (RMID.Contains(dgvRentedMovies.Rows[i].Cells[0].Value.ToString()))
                    {//highlight in red only the rows that contain the column containing the CustID that matches those in the Overdue view
                        dgvRentedMovies.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dgvRentedMovies.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }

                //this works, now how to apply it in the 'all movies out' part
                //random comment
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnMoviesOut_Click(object sender, EventArgs e)
        {//calling the method from above
            MoviesStillOut();

        }

        private void btnAllMoviesIssued_Click(object sender, EventArgs e)
        {//Speaks for itself
            DisplayDataGridViewRentedMovies();



        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            string result = null;
            //If a movie and customer has been selected
            if ((tbxCustID.Text != string.Empty) && (tbxMovieID.Text != string.Empty))
            {//then apply the method and give a message to display successs
                try
                {
                    result = myDatabase.IssueMovie(tbxCustID.Text, tbxMovieID.Text);
                    MessageBox.Show("Title " + result);
                }
                catch (Exception a)
                {
                    //or not
                    MessageBox.Show((a.Message));
                }
                DisplayDataGridViewRentedMovies();
                //add the new issuing information to dgv
                tbxFN.Text = "";
                tbxLN.Text = "";
                tbxAddress.Text = "";
                tbxPhone.Text = "";
                tbxTitle.Text = "";
                //display the cost of the movie
                tbxScreen.Text = ("$" + tbxCost.Text + " to pay.");
            }
            else
            {
                MessageBox.Show("Please select customer and movie from tables.");
            }
            myDatabase.FilldgvRentedMovieswithInfo();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string RMID = tbxRMID.Text;

            MessageBox.Show(myDatabase.ReturnMovie(RMID));
            DisplayDataGridViewRentedMovies();
            //ClearAllTextBoxes(this);
        }

        private void dgvRentedMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RMID = 0;

            try
            {// show the detalis in all the cells with the ability to click on them
             // click event set to cell click raather than cell contennt click so that anywhere in the cell will activate command 
                RMID = (int)dgvRentedMovies.Rows[e.RowIndex].Cells[0].Value;

                if (e.RowIndex >= 0)
                {
                    tbxRMID.Text = RMID.ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OverdueMovies()
        {
            dgvRentedMovies.DataSource = null;

            try
            {
                dgvRentedMovies.DataSource = myDatabase.FilldgvRentedMoviesWithOverdueMovies();
                dgvRentedMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                //

                this.dgvRentedMovies.DefaultCellStyle.ForeColor = Color.Red;

                //this works, now how to apply it in the 'all movies out' part

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnOverdue_Click(object sender, EventArgs e)
        {
            OverdueMovies();
        }

        private void tbxCustInstructions_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCustomer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
