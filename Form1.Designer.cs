namespace VideoRental
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabCustomers = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbxCustInstructions = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCust = new System.Windows.Forms.Button();
            this.btnDeleteCust = new System.Windows.Forms.Button();
            this.tbxCustID = new System.Windows.Forms.TextBox();
            this.lblFN = new System.Windows.Forms.Label();
            this.tbxFN = new System.Windows.Forms.TextBox();
            this.lblLN = new System.Windows.Forms.Label();
            this.tbxLN = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tabRentedMovies = new System.Windows.Forms.TabPage();
            this.btnOverdue = new System.Windows.Forms.Button();
            this.lbxRMID = new System.Windows.Forms.Label();
            this.tbxRMID = new System.Windows.Forms.TextBox();
            this.btnAllMoviesIssued = new System.Windows.Forms.Button();
            this.btnMoviesOut = new System.Windows.Forms.Button();
            this.dgvRentedMovies = new System.Windows.Forms.DataGridView();
            this.tabMovies = new System.Windows.Forms.TabPage();
            this.tbxMovieInstructions = new System.Windows.Forms.TextBox();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.Copies = new System.Windows.Forms.Label();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.Copies_txt = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnDelMovie = new System.Windows.Forms.Button();
            this.tbxRating = new System.Windows.Forms.TextBox();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlot = new System.Windows.Forms.Label();
            this.tbxPlot = new System.Windows.Forms.TextBox();
            this.tbxMovieID = new System.Windows.Forms.TextBox();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.tbxGenre = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tabQueries = new System.Windows.Forms.TabPage();
            this.btnMostPopular = new System.Windows.Forms.Button();
            this.btnMostVideos = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tbxScreen = new System.Windows.Forms.TextBox();
            this.lbxScreen = new System.Windows.Forms.ListBox();
            this.lblIssueInst = new System.Windows.Forms.Label();
            this.lblReturnInst = new System.Windows.Forms.Label();
            this.tabCustomers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.tabRentedMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedMovies)).BeginInit();
            this.tabMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.tabQueries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.tabPage1);
            this.tabCustomers.Controls.Add(this.tabRentedMovies);
            this.tabCustomers.Controls.Add(this.tabMovies);
            this.tabCustomers.Controls.Add(this.tabQueries);
            this.tabCustomers.Location = new System.Drawing.Point(12, 21);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.SelectedIndex = 0;
            this.tabCustomers.Size = new System.Drawing.Size(740, 530);
            this.tabCustomers.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.tbxCustInstructions);
            this.tabPage1.Controls.Add(this.lblCustID);
            this.tabPage1.Controls.Add(this.dgvCustomer);
            this.tabPage1.Controls.Add(this.btnAddCustomer);
            this.tabPage1.Controls.Add(this.btnUpdateCust);
            this.tabPage1.Controls.Add(this.btnDeleteCust);
            this.tabPage1.Controls.Add(this.tbxCustID);
            this.tabPage1.Controls.Add(this.lblFN);
            this.tabPage1.Controls.Add(this.tbxFN);
            this.tabPage1.Controls.Add(this.lblLN);
            this.tabPage1.Controls.Add(this.tbxLN);
            this.tabPage1.Controls.Add(this.lblAddress);
            this.tabPage1.Controls.Add(this.tbxAddress);
            this.tabPage1.Controls.Add(this.lblPhone);
            this.tabPage1.Controls.Add(this.tbxPhone);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(732, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            // 
            // tbxCustInstructions
            // 
            this.tbxCustInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCustInstructions.Location = new System.Drawing.Point(6, 297);
            this.tbxCustInstructions.Multiline = true;
            this.tbxCustInstructions.Name = "tbxCustInstructions";
            this.tbxCustInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxCustInstructions.Size = new System.Drawing.Size(723, 56);
            this.tbxCustInstructions.TabIndex = 39;
            this.tbxCustInstructions.Text = resources.GetString("tbxCustInstructions.Text");
            this.tbxCustInstructions.TextChanged += new System.EventHandler(this.tbxCustInstructions_TextChanged);
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(684, 462);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(42, 13);
            this.lblCustID.TabIndex = 38;
            this.lblCustID.Text = "Cust ID";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(6, 6);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.Size = new System.Drawing.Size(723, 288);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick_1);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Lime;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(40, 450);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(169, 26);
            this.btnAddCustomer.TabIndex = 9;
            this.btnAddCustomer.Text = " Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnUpdateCust
            // 
            this.btnUpdateCust.BackColor = System.Drawing.Color.Orange;
            this.btnUpdateCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCust.Location = new System.Drawing.Point(224, 449);
            this.btnUpdateCust.Name = "btnUpdateCust";
            this.btnUpdateCust.Size = new System.Drawing.Size(161, 29);
            this.btnUpdateCust.TabIndex = 11;
            this.btnUpdateCust.Text = "Update Customer";
            this.btnUpdateCust.UseVisualStyleBackColor = false;
            this.btnUpdateCust.Click += new System.EventHandler(this.btnUpdateCust_Click);
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCust.Location = new System.Drawing.Point(391, 449);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(141, 26);
            this.btnDeleteCust.TabIndex = 12;
            this.btnDeleteCust.Text = "Delete Customer";
            this.btnDeleteCust.UseVisualStyleBackColor = false;
            this.btnDeleteCust.Click += new System.EventHandler(this.btnDeleteCust_Click);
            // 
            // tbxCustID
            // 
            this.tbxCustID.Location = new System.Drawing.Point(687, 478);
            this.tbxCustID.Name = "tbxCustID";
            this.tbxCustID.Size = new System.Drawing.Size(39, 20);
            this.tbxCustID.TabIndex = 10;
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(15, 367);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(57, 13);
            this.lblFN.TabIndex = 5;
            this.lblFN.Text = "First Name";
            // 
            // tbxFN
            // 
            this.tbxFN.Location = new System.Drawing.Point(6, 383);
            this.tbxFN.Name = "tbxFN";
            this.tbxFN.Size = new System.Drawing.Size(134, 20);
            this.tbxFN.TabIndex = 1;
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Location = new System.Drawing.Point(170, 367);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(49, 13);
            this.lblLN.TabIndex = 6;
            this.lblLN.Text = "Surname";
            // 
            // tbxLN
            // 
            this.tbxLN.Location = new System.Drawing.Point(163, 383);
            this.tbxLN.Name = "tbxLN";
            this.tbxLN.Size = new System.Drawing.Size(131, 20);
            this.tbxLN.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(460, 367);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(463, 383);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(209, 20);
            this.tbxAddress.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(331, 367);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(334, 383);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(99, 20);
            this.tbxPhone.TabIndex = 4;
            // 
            // tabRentedMovies
            // 
            this.tabRentedMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabRentedMovies.Controls.Add(this.btnOverdue);
            this.tabRentedMovies.Controls.Add(this.lbxRMID);
            this.tabRentedMovies.Controls.Add(this.tbxRMID);
            this.tabRentedMovies.Controls.Add(this.btnAllMoviesIssued);
            this.tabRentedMovies.Controls.Add(this.btnMoviesOut);
            this.tabRentedMovies.Controls.Add(this.dgvRentedMovies);
            this.tabRentedMovies.Location = new System.Drawing.Point(4, 22);
            this.tabRentedMovies.Name = "tabRentedMovies";
            this.tabRentedMovies.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabRentedMovies.Size = new System.Drawing.Size(732, 504);
            this.tabRentedMovies.TabIndex = 1;
            this.tabRentedMovies.Text = "Rented Movies";
            // 
            // btnOverdue
            // 
            this.btnOverdue.BackColor = System.Drawing.Color.Red;
            this.btnOverdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverdue.Location = new System.Drawing.Point(6, 424);
            this.btnOverdue.Name = "btnOverdue";
            this.btnOverdue.Size = new System.Drawing.Size(195, 49);
            this.btnOverdue.TabIndex = 5;
            this.btnOverdue.Text = "Show Overdue Movies";
            this.btnOverdue.UseVisualStyleBackColor = false;
            this.btnOverdue.Click += new System.EventHandler(this.btnOverdue_Click);
            // 
            // lbxRMID
            // 
            this.lbxRMID.AutoSize = true;
            this.lbxRMID.Location = new System.Drawing.Point(689, 460);
            this.lbxRMID.Name = "lbxRMID";
            this.lbxRMID.Size = new System.Drawing.Size(35, 13);
            this.lbxRMID.TabIndex = 4;
            this.lbxRMID.Text = "RMID";
            // 
            // tbxRMID
            // 
            this.tbxRMID.Location = new System.Drawing.Point(692, 481);
            this.tbxRMID.Name = "tbxRMID";
            this.tbxRMID.Size = new System.Drawing.Size(34, 20);
            this.tbxRMID.TabIndex = 3;
            // 
            // btnAllMoviesIssued
            // 
            this.btnAllMoviesIssued.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAllMoviesIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMoviesIssued.Location = new System.Drawing.Point(441, 425);
            this.btnAllMoviesIssued.Name = "btnAllMoviesIssued";
            this.btnAllMoviesIssued.Size = new System.Drawing.Size(199, 48);
            this.btnAllMoviesIssued.TabIndex = 2;
            this.btnAllMoviesIssued.Text = "Return to All Movies Issued";
            this.btnAllMoviesIssued.UseVisualStyleBackColor = false;
            this.btnAllMoviesIssued.Click += new System.EventHandler(this.btnAllMoviesIssued_Click);
            // 
            // btnMoviesOut
            // 
            this.btnMoviesOut.BackColor = System.Drawing.Color.Orange;
            this.btnMoviesOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoviesOut.Location = new System.Drawing.Point(207, 425);
            this.btnMoviesOut.Name = "btnMoviesOut";
            this.btnMoviesOut.Size = new System.Drawing.Size(216, 48);
            this.btnMoviesOut.TabIndex = 1;
            this.btnMoviesOut.Text = "Show Movies Still Out";
            this.btnMoviesOut.UseVisualStyleBackColor = false;
            this.btnMoviesOut.Click += new System.EventHandler(this.btnMoviesOut_Click);
            // 
            // dgvRentedMovies
            // 
            this.dgvRentedMovies.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRentedMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentedMovies.Location = new System.Drawing.Point(0, 14);
            this.dgvRentedMovies.Name = "dgvRentedMovies";
            this.dgvRentedMovies.RowHeadersWidth = 51;
            this.dgvRentedMovies.Size = new System.Drawing.Size(720, 349);
            this.dgvRentedMovies.TabIndex = 0;
            this.dgvRentedMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentedMovies_CellContentClick);
            // 
            // tabMovies
            // 
            this.tabMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabMovies.Controls.Add(this.tbxMovieInstructions);
            this.tabMovies.Controls.Add(this.lblMovieID);
            this.tabMovies.Controls.Add(this.Copies);
            this.tabMovies.Controls.Add(this.dgvMovies);
            this.tabMovies.Controls.Add(this.Copies_txt);
            this.tabMovies.Controls.Add(this.btnAddMovie);
            this.tabMovies.Controls.Add(this.btnUpdateMovie);
            this.tabMovies.Controls.Add(this.btnDelMovie);
            this.tabMovies.Controls.Add(this.tbxRating);
            this.tabMovies.Controls.Add(this.tbxCost);
            this.tabMovies.Controls.Add(this.lblCost);
            this.tabMovies.Controls.Add(this.Rating);
            this.tabMovies.Controls.Add(this.lblTitle);
            this.tabMovies.Controls.Add(this.lblPlot);
            this.tabMovies.Controls.Add(this.tbxPlot);
            this.tabMovies.Controls.Add(this.tbxMovieID);
            this.tabMovies.Controls.Add(this.tbxTitle);
            this.tabMovies.Controls.Add(this.tbxGenre);
            this.tabMovies.Controls.Add(this.lblYear);
            this.tabMovies.Controls.Add(this.lblGenre);
            this.tabMovies.Controls.Add(this.tbxYear);
            this.tabMovies.Location = new System.Drawing.Point(4, 22);
            this.tabMovies.Name = "tabMovies";
            this.tabMovies.Size = new System.Drawing.Size(732, 504);
            this.tabMovies.TabIndex = 2;
            this.tabMovies.Text = "Movies";
            // 
            // tbxMovieInstructions
            // 
            this.tbxMovieInstructions.Location = new System.Drawing.Point(10, 289);
            this.tbxMovieInstructions.Multiline = true;
            this.tbxMovieInstructions.Name = "tbxMovieInstructions";
            this.tbxMovieInstructions.Size = new System.Drawing.Size(719, 60);
            this.tbxMovieInstructions.TabIndex = 35;
            this.tbxMovieInstructions.Text = resources.GetString("tbxMovieInstructions.Text");
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Location = new System.Drawing.Point(679, 462);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(50, 13);
            this.lblMovieID.TabIndex = 34;
            this.lblMovieID.Text = "Movie ID";
            // 
            // Copies
            // 
            this.Copies.AutoSize = true;
            this.Copies.Location = new System.Drawing.Point(555, 377);
            this.Copies.Name = "Copies";
            this.Copies.Size = new System.Drawing.Size(39, 13);
            this.Copies.TabIndex = 39;
            this.Copies.Text = "Copies";
            // 
            // dgvMovies
            // 
            this.dgvMovies.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(3, 3);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.RowHeadersWidth = 51;
            this.dgvMovies.Size = new System.Drawing.Size(726, 265);
            this.dgvMovies.TabIndex = 0;
            this.dgvMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellContentClick_1);
            // 
            // Copies_txt
            // 
            this.Copies_txt.Location = new System.Drawing.Point(558, 393);
            this.Copies_txt.Name = "Copies_txt";
            this.Copies_txt.Size = new System.Drawing.Size(62, 20);
            this.Copies_txt.TabIndex = 38;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.Lime;
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(94, 464);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(131, 22);
            this.btnAddMovie.TabIndex = 13;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.BackColor = System.Drawing.Color.Orange;
            this.btnUpdateMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMovie.Location = new System.Drawing.Point(231, 464);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(120, 24);
            this.btnUpdateMovie.TabIndex = 15;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = false;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnDelMovie
            // 
            this.btnDelMovie.BackColor = System.Drawing.Color.Red;
            this.btnDelMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelMovie.Location = new System.Drawing.Point(357, 462);
            this.btnDelMovie.Name = "btnDelMovie";
            this.btnDelMovie.Size = new System.Drawing.Size(112, 28);
            this.btnDelMovie.TabIndex = 14;
            this.btnDelMovie.Text = "Delete Movie";
            this.btnDelMovie.UseVisualStyleBackColor = false;
            this.btnDelMovie.Click += new System.EventHandler(this.btnDelMovie_Click);
            // 
            // tbxRating
            // 
            this.tbxRating.Location = new System.Drawing.Point(499, 393);
            this.tbxRating.Name = "tbxRating";
            this.tbxRating.Size = new System.Drawing.Size(42, 20);
            this.tbxRating.TabIndex = 30;
            // 
            // tbxCost
            // 
            this.tbxCost.Enabled = false;
            this.tbxCost.Location = new System.Drawing.Point(637, 393);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(55, 20);
            this.tbxCost.TabIndex = 23;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(634, 377);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(62, 13);
            this.lblCost.TabIndex = 24;
            this.lblCost.Text = "Rental Cost";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(496, 377);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(38, 13);
            this.Rating.TabIndex = 33;
            this.Rating.Text = "Rating";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(7, 377);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Title";
            // 
            // lblPlot
            // 
            this.lblPlot.AutoSize = true;
            this.lblPlot.Location = new System.Drawing.Point(354, 417);
            this.lblPlot.Name = "lblPlot";
            this.lblPlot.Size = new System.Drawing.Size(25, 13);
            this.lblPlot.TabIndex = 32;
            this.lblPlot.Text = "Plot";
            // 
            // tbxPlot
            // 
            this.tbxPlot.Location = new System.Drawing.Point(353, 433);
            this.tbxPlot.Multiline = true;
            this.tbxPlot.Name = "tbxPlot";
            this.tbxPlot.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxPlot.Size = new System.Drawing.Size(250, 23);
            this.tbxPlot.TabIndex = 29;
            // 
            // tbxMovieID
            // 
            this.tbxMovieID.Location = new System.Drawing.Point(690, 478);
            this.tbxMovieID.Name = "tbxMovieID";
            this.tbxMovieID.Size = new System.Drawing.Size(39, 20);
            this.tbxMovieID.TabIndex = 16;
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(10, 393);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(313, 20);
            this.tbxTitle.TabIndex = 17;
            // 
            // tbxGenre
            // 
            this.tbxGenre.Location = new System.Drawing.Point(419, 394);
            this.tbxGenre.Name = "tbxGenre";
            this.tbxGenre.Size = new System.Drawing.Size(64, 20);
            this.tbxGenre.TabIndex = 22;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(350, 377);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 19;
            this.lblYear.Text = "Year";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(416, 377);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 20;
            this.lblGenre.Text = "Genre";
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(353, 393);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(52, 20);
            this.tbxYear.TabIndex = 21;
            // 
            // tabQueries
            // 
            this.tabQueries.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabQueries.Controls.Add(this.btnMostPopular);
            this.tabQueries.Controls.Add(this.btnMostVideos);
            this.tabQueries.Location = new System.Drawing.Point(4, 22);
            this.tabQueries.Name = "tabQueries";
            this.tabQueries.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabQueries.Size = new System.Drawing.Size(732, 504);
            this.tabQueries.TabIndex = 3;
            this.tabQueries.Text = "Queries";
            // 
            // btnMostPopular
            // 
            this.btnMostPopular.BackColor = System.Drawing.Color.Maroon;
            this.btnMostPopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostPopular.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMostPopular.Location = new System.Drawing.Point(105, 250);
            this.btnMostPopular.Name = "btnMostPopular";
            this.btnMostPopular.Size = new System.Drawing.Size(521, 47);
            this.btnMostPopular.TabIndex = 1;
            this.btnMostPopular.Text = "Which is most popular movie?";
            this.btnMostPopular.UseVisualStyleBackColor = false;
            this.btnMostPopular.Click += new System.EventHandler(this.btnMostPopular_Click);
            // 
            // btnMostVideos
            // 
            this.btnMostVideos.BackColor = System.Drawing.Color.Maroon;
            this.btnMostVideos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostVideos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMostVideos.Location = new System.Drawing.Point(103, 170);
            this.btnMostVideos.Name = "btnMostVideos";
            this.btnMostVideos.Size = new System.Drawing.Size(523, 51);
            this.btnMostVideos.TabIndex = 0;
            this.btnMostVideos.Text = "Who has rented most movies?";
            this.btnMostVideos.UseVisualStyleBackColor = false;
            this.btnMostVideos.Click += new System.EventHandler(this.btnMostVideos_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1031, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 35);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear text boxes";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1228, 541);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.ForestGreen;
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(1053, 359);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(138, 46);
            this.btnIssue.TabIndex = 34;
            this.btnIssue.Text = "Issue Movie";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Red;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(1053, 278);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(138, 43);
            this.btnReturn.TabIndex = 35;
            this.btnReturn.Text = "Return Movie";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tbxScreen
            // 
            this.tbxScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxScreen.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxScreen.Location = new System.Drawing.Point(800, 34);
            this.tbxScreen.Multiline = true;
            this.tbxScreen.Name = "tbxScreen";
            this.tbxScreen.Size = new System.Drawing.Size(310, 121);
            this.tbxScreen.TabIndex = 36;
            this.tbxScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbxScreen
            // 
            this.lbxScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbxScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxScreen.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxScreen.FormattingEnabled = true;
            this.lbxScreen.ItemHeight = 14;
            this.lbxScreen.Location = new System.Drawing.Point(848, 70);
            this.lbxScreen.Name = "lbxScreen";
            this.lbxScreen.Size = new System.Drawing.Size(229, 70);
            this.lbxScreen.TabIndex = 37;
            this.lbxScreen.TabStop = false;
            this.lbxScreen.Visible = false;
            // 
            // lblIssueInst
            // 
            this.lblIssueInst.Location = new System.Drawing.Point(761, 359);
            this.lblIssueInst.Name = "lblIssueInst";
            this.lblIssueInst.Size = new System.Drawing.Size(286, 33);
            this.lblIssueInst.TabIndex = 40;
            this.lblIssueInst.Text = "To issue a movie:  Please select a customer from Customer tab, and a movie from M" +
    "ovie tab then click the Issue Movie button";
            // 
            // lblReturnInst
            // 
            this.lblReturnInst.Location = new System.Drawing.Point(758, 278);
            this.lblReturnInst.Name = "lblReturnInst";
            this.lblReturnInst.Size = new System.Drawing.Size(293, 33);
            this.lblReturnInst.TabIndex = 41;
            this.lblReturnInst.Text = "To return a movie:  Please select movie to be returned from Rented Movies tab the" +
    "n click on Return Movie button.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1228, 541);
            this.Controls.Add(this.lblReturnInst);
            this.Controls.Add(this.lblIssueInst);
            this.Controls.Add(this.lbxScreen);
            this.Controls.Add(this.tabCustomers);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbxScreen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabCustomers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.tabRentedMovies.ResumeLayout(false);
            this.tabRentedMovies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedMovies)).EndInit();
            this.tabMovies.ResumeLayout(false);
            this.tabMovies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.tabQueries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCustomers;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridView dgvRentedMovies;
        private System.Windows.Forms.TabPage tabMovies;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.TabPage tabRentedMovies;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbxFN;
        private System.Windows.Forms.TextBox tbxLN;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox tbxCustID;
        private System.Windows.Forms.Button btnUpdateCust;
        private System.Windows.Forms.Button btnDeleteCust;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnDelMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.TextBox tbxMovieID;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxGenre;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxPlot;
        private System.Windows.Forms.TextBox tbxRating;
        private System.Windows.Forms.Label lblPlot;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox tbxScreen;
        private System.Windows.Forms.TabPage tabQueries;
        private System.Windows.Forms.Button btnMostPopular;
        private System.Windows.Forms.Button btnMostVideos;
        private System.Windows.Forms.ListBox lbxScreen;
        private System.Windows.Forms.Button btnMoviesOut;
        private System.Windows.Forms.Button btnAllMoviesIssued;
        private System.Windows.Forms.TextBox tbxRMID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lbxRMID;
        private System.Windows.Forms.TextBox tbxMovieInstructions;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.TextBox tbxCustInstructions;
        private System.Windows.Forms.Button btnOverdue;
        private System.Windows.Forms.TextBox Copies_txt;
        private System.Windows.Forms.Label Copies;
        private System.Windows.Forms.Label lblIssueInst;
        private System.Windows.Forms.Label lblReturnInst;
    }
}
