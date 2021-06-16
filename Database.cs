using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace VideoRental
{
    public class Database
    {//globalise instantiations
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();


        public Database()
        {//the route by which access to the database is gained
            string connectionString =
                @"Data Source= LAPTOP-52CB3J4K\SQLEXPRESS01;Initial Catalog=VideoRental;Integrated Security=True";
            Connection.ConnectionString = connectionString;
            //name used to create the connection
            Command.Connection = Connection;
        }

        public DataTable FilldgvCustomerWithCustomer()
        //returns a database
        {//Instantiate the datatable
            DataTable dt = new DataTable();
            //get all the information from datatable
            using (da = new SqlDataAdapter("select * from Customer", Connection))
            {//open the connection to database
                Connection.Open();
                //fill the datatable
                da.Fill(dt);
                //close the connection to prevent hiccups
                Connection.Close();
            }// output is a datatable
            return dt;
        }

        public DataTable FilldgvMoviesWithMovies()
        {//As above
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from Movies", Connection))
            {
                Connection.Open();
                da.Fill(dt);
                Connection.Close();
            }
            return dt;
        }
        public DataTable FilldgvRentedMovieswithInfo()
        {//and above and below
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from IssuesReturns", Connection))
            {
                Connection.Open();
                da.Fill(dt);
                Connection.Close();
            }
            return dt;
        }

        public DataTable FilldgvRentedMovieswithMoviesOut()
        {//and again - filling the data table querying a view
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from NotReturned", Connection))
            {
                Connection.Open();
                da.Fill(dt);
                Connection.Close();
            }
            return dt;
        }

        public string InsertorUpdateCustomer(string Firstname, string Lastname, string Address, string Phone,
            string CustID, string AddorUpdate)
        {//returns a string 
            try
            {
                if (AddorUpdate == "Add")
                {
                    using (SqlCommand cmd = Connection.CreateCommand())

                    {// this puts the parameters into the code so that the data in the text boxes is added to the database 
                        cmd.CommandText = "AddCustomer";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FirstName", Firstname);
                        cmd.Parameters.AddWithValue("@LastName", Lastname);
                        cmd.Parameters.AddWithValue("@Address", Address);
                        cmd.Parameters.AddWithValue("@Phone", Phone);
                        Connection.Open();
                        cmd.ExecuteNonQuery();
                        Connection.Close();
                    }
                }
                else if (AddorUpdate == "Update")
                {//using a view
                    var myCommand =
                        new SqlCommand(
                            "Update Customer set FirstName = @Firstname, LastName = @LastName, Address = @Address, Phone = @Phone where CustID = @CustID",
                            Connection);
                    //sanitisation to stop anyone else from putting code in that can be used as code
                    myCommand.Parameters.AddWithValue("Firstname", Firstname);
                    myCommand.Parameters.AddWithValue("Lastname", Lastname);
                    myCommand.Parameters.AddWithValue("Address", Address);
                    myCommand.Parameters.AddWithValue("Phone", Phone);
                    myCommand.Parameters.AddWithValue("CustID", CustID);

                    Connection.Open();
                    myCommand.ExecuteNonQuery();
                    Connection.Close();

                }
                return " successfuly.";

            }
            catch (Exception a)
            {// identifying an exception and adding it to the return statement shows withwhatever the failure is to make it easier to figure out where things are not working
                Connection.Close();
                return " has failed with " + a;
            }
            //return "";
        }

        public string DeleteCustomer(string CustID)
        {//'object' refers to an object on the form
            if (!object.ReferenceEquals(CustID, string.Empty))
            {
                var myCommand = new SqlCommand();
                myCommand = new SqlCommand("Delete from Customer where CustID = @CustID");

                myCommand.Connection = Connection;
                //specify what to delete by using the ID causes all information to be impacted
                myCommand.Parameters.AddWithValue("CustID", CustID);

                Connection.Open();
                myCommand.ExecuteNonQuery();
                Connection.Close();
                return "Customer has been deleted.";
            }
            else
            {//if code fails to work a message error is displayed
                Connection.Close();
                return "Customer has not been deleted.";
            }
        }


        public string InsertorUpdateMovie(string Rating, string Title, string Year, string Plot, string Genre,
            string MovieID, string Rental_Cost, string Copies, string AddorUpdate)
        {//same process as above 
            //if/else provides a way to combine methods, with essentially the same data, with slightly different commands  i.e. in this case it saves having to write an update method and an add method
            //could also use a switch statement to connect all buttons that work on the same concepts/buttons
            try
            {//"Add" is included when method is called to identify which action is required
                if (AddorUpdate == "Add")
                {
                    var myCommand =
                        new SqlCommand(
                            "Insert into Movies (Rating, Title, Year,  Plot, Genre, Rental_Cost, Copies)" +
                            "Values (@Rating, @Title, @Year, @Plot, @Genre, @Rental_Cost, @Copies)", Connection);

                    myCommand.Parameters.AddWithValue("Rating", Rating);
                    myCommand.Parameters.AddWithValue("Title", Title);
                    myCommand.Parameters.AddWithValue("Year", Year);
                    myCommand.Parameters.AddWithValue("Plot", Plot);
                    myCommand.Parameters.AddWithValue("Genre", Genre);
                    myCommand.Parameters.AddWithValue("Rental_Cost", Rental_Cost);
                    myCommand.Parameters.AddWithValue("Copies", Copies);

                    Connection.Open();
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }//this time "update" is the identifier and is case sensitive!
                else if (AddorUpdate == "Update")
                {
                    var myCommand =
                        new SqlCommand(
                            "Update Movies set Rating = @Rating, Title = @Title, Year = @Year, Rental_Cost=@Rental_Cost,Copies = @Copies, Plot = @Plot, Genre = @Genre where MovieID = @MovieID",
                            Connection);

                    myCommand.Parameters.AddWithValue("Rating", Rating);
                    myCommand.Parameters.AddWithValue("Title", Title);
                    myCommand.Parameters.AddWithValue("Year", Year);
                    myCommand.Parameters.AddWithValue("Plot", Plot);
                    myCommand.Parameters.AddWithValue("Genre", Genre);
                    myCommand.Parameters.AddWithValue("MovieID", MovieID);
                    myCommand.Parameters.AddWithValue("Rental_Cost", Rental_Cost);
                    myCommand.Parameters.AddWithValue("Copies", Copies);
                    Connection.Open();
                    myCommand.ExecuteNonQuery();
                    Connection.Close();

                }//a nice little message to let you know it worked
                return " successfuly.";

            }
            catch (Exception b)
            {//or unsuccessful with the reason
                Connection.Close();
                return " has failed with " + b;
            }
            return "";
        }

        public string DeleteMovie(string MovieID)
        {//as for delete customer
            if (!object.ReferenceEquals(MovieID, string.Empty))
            {
                var myCommand = new SqlCommand();
                myCommand = new SqlCommand("Delete from Movies where MovieID = @MovieID");

                myCommand.Connection = Connection;
                myCommand.Parameters.AddWithValue("MovieID", MovieID);

                Connection.Open();
                myCommand.ExecuteNonQuery();
                Connection.Close();
                return "Movie has been deleted.";
            }
            else
            {
                Connection.Close();
                return "Movie has not been deleted.";
            }
        }

        public string IssueMovie(string CustIDFK, string MovieIDFK)
        {// using a stored procedure - safer allows no interference
            using (SqlCommand cmd = Connection.CreateCommand())
            {// parameters "provide data to you SQL statement" gives an extra layer of protection.  
             //Parameters input a specific value. 
                cmd.CommandText = "MovieIssue";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustIDFK", CustIDFK);
                cmd.Parameters.AddWithValue("@MovieIDFK", MovieIDFK);
                cmd.Parameters.AddWithValue("@DateRented", DateTime.Now);
                //Database - open the book
                Connection.Open();
                cmd.ExecuteNonQuery();
                Connection.Close();
            }
            return "Issued";
        }
        //As above
        public string ReturnMovie(string RMID)
        {//stored procedure
            using (SqlCommand cmd = Connection.CreateCommand())
            {
                cmd.CommandText = "ReturnMovie";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RMID", RMID);
                cmd.Parameters.AddWithValue("@DateReturned", DateTime.Now);
                Connection.Open();
                cmd.ExecuteNonQuery();
                Connection.Close();
            }
            return "Movie Returned";
        }

        public List<string> FillListViewwithMostPopularMovies()
        //returns a list

        {
            var myCommand = new SqlCommand();
            myCommand = new SqlCommand("select * from MaxMostPopular", Connection);
            List<string> newMaxMostPopular = new List<string>();
            Connection.Open();
            // da.Fill(dt);


            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    newMaxMostPopular.Add(reader["Times"].ToString() + " views   " + (reader["Title"].ToString()));
                }
            }
            reader.Close();
            Connection.Close();
            return newMaxMostPopular;
        }

        public List<string> OverdueCust()
        {
            var myCommand = new SqlCommand();
            myCommand = new SqlCommand("select RMID from Overdue", Connection);

            List<string> newOverdue = new List<string>();
            Connection.Open();
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    newOverdue.Add(reader["RMID"].ToString());
                }
            reader.Close();
            Connection.Close();
            return newOverdue;
        }
        public List<string> RentedMostMovies()
        {
            var myCommand = new SqlCommand();
            myCommand = new SqlCommand("select Top (1) FirstName, LastName from IssueCount", Connection);
            List<string> newIssueCount = new List<string>();
            Connection.Open();
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    newIssueCount.Add(reader["FirstName"].ToString() + " " + (reader["LastName"].ToString()));
                }
            }
            reader.Close();
            Connection.Close();
            return newIssueCount;
        }

        public DataTable FilldgvRentedMoviesWithOverdueMovies()
        {//made a new view to show just the overdue items - based on movies out for more than 7 days
         // and filled a new dgv with it
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from Overdue", Connection))
            {
                Connection.Open();
                da.Fill(dt);
                Connection.Close();
            }
            return dt;
        }
        public bool ConnectionUnitTest()
        {
            DataTable dt = new DataTable();
            try
            {
                using (da = new SqlDataAdapter("select * from Movies", Connection))
                {
                    Connection.Open();
                    da.Fill(dt);
                    Connection.Close();
                }
                return true;
            }
            catch (Exception)
            {
                Connection.Close();
                return false;
            }
        }


    }
}
