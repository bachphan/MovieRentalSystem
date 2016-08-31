namespace MovieRentalSystem
{
    partial class EmployeeForm
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
            this.txtNameMovie = new System.Windows.Forms.TextBox();
            this.txtNameActor = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblNameMovie = new System.Windows.Forms.Label();
            this.lblActorName = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddnRemove = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerDisplay = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSearchMovie = new System.Windows.Forms.Button();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.btnCalculatePrice = new System.Windows.Forms.Button();
            this.lblNameCus = new System.Windows.Forms.Label();
            this.txtSearchMovie = new System.Windows.Forms.TextBox();
            this.lblSearchKeyWord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxRentalDays = new System.Windows.Forms.TextBox();
            this.txtboxCalculateTotal = new System.Windows.Forms.TextBox();
            this.btnSearchForCustomer = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.btnShowMovieList = new System.Windows.Forms.Button();
            this.lstboxMovie = new System.Windows.Forms.ListBox();
            this.lstboxCustomers = new System.Windows.Forms.ListBox();
            this.btnShowCustomerList = new System.Windows.Forms.Button();
            this.btnSelectMovie = new System.Windows.Forms.Button();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.btnRemoveMovie = new System.Windows.Forms.Button();
            this.txtboxMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNameMovie
            // 
            this.txtNameMovie.Location = new System.Drawing.Point(9, 93);
            this.txtNameMovie.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameMovie.Name = "txtNameMovie";
            this.txtNameMovie.Size = new System.Drawing.Size(133, 20);
            this.txtNameMovie.TabIndex = 0;
            // 
            // txtNameActor
            // 
            this.txtNameActor.Location = new System.Drawing.Point(9, 162);
            this.txtNameActor.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameActor.Name = "txtNameActor";
            this.txtNameActor.Size = new System.Drawing.Size(133, 20);
            this.txtNameActor.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(9, 223);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(133, 20);
            this.txtYear.TabIndex = 2;
            // 
            // lblNameMovie
            // 
            this.lblNameMovie.AutoSize = true;
            this.lblNameMovie.Location = new System.Drawing.Point(190, 93);
            this.lblNameMovie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameMovie.Name = "lblNameMovie";
            this.lblNameMovie.Size = new System.Drawing.Size(67, 13);
            this.lblNameMovie.TabIndex = 4;
            this.lblNameMovie.Text = "Movie Name";
            // 
            // lblActorName
            // 
            this.lblActorName.AutoSize = true;
            this.lblActorName.Location = new System.Drawing.Point(193, 162);
            this.lblActorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActorName.Name = "lblActorName";
            this.lblActorName.Size = new System.Drawing.Size(63, 13);
            this.lblActorName.TabIndex = 5;
            this.lblActorName.Text = "Actor Name";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(195, 223);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(61, 13);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Movie Year";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(188, 281);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(68, 13);
            this.lblGenre.TabIndex = 7;
            this.lblGenre.Text = "Movie Genre";
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange(new object[] {
            "Action",
            "Horror",
            "Comedy",
            "Drama"});
            this.cmbGenre.Location = new System.Drawing.Point(9, 279);
            this.cmbGenre.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(133, 21);
            this.cmbGenre.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 327);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 49);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Movie To Storage";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddnRemove
            // 
            this.lblAddnRemove.AutoSize = true;
            this.lblAddnRemove.Location = new System.Drawing.Point(78, 39);
            this.lblAddnRemove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddnRemove.Name = "lblAddnRemove";
            this.lblAddnRemove.Size = new System.Drawing.Size(103, 13);
            this.lblAddnRemove.TabIndex = 11;
            this.lblAddnRemove.Text = "Add/Remove Movie";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(268, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(4, 635);
            this.label1.TabIndex = 12;
            // 
            // lblCustomerDisplay
            // 
            this.lblCustomerDisplay.AutoSize = true;
            this.lblCustomerDisplay.Location = new System.Drawing.Point(356, 39);
            this.lblCustomerDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerDisplay.Name = "lblCustomerDisplay";
            this.lblCustomerDisplay.Size = new System.Drawing.Size(118, 13);
            this.lblCustomerDisplay.TabIndex = 13;
            this.lblCustomerDisplay.Text = "Add/Remove Customer";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(280, 93);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(151, 20);
            this.txtCusName.TabIndex = 14;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(280, 144);
            this.txtSSN.Margin = new System.Windows.Forms.Padding(2);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(151, 20);
            this.txtSSN.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(280, 197);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(151, 20);
            this.txtPhone.TabIndex = 16;
            // 
            // btnSearchMovie
            // 
            this.btnSearchMovie.Location = new System.Drawing.Point(9, 500);
            this.btnSearchMovie.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchMovie.Name = "btnSearchMovie";
            this.btnSearchMovie.Size = new System.Drawing.Size(116, 56);
            this.btnSearchMovie.TabIndex = 17;
            this.btnSearchMovie.Text = "Search the Storage";
            this.btnSearchMovie.UseVisualStyleBackColor = true;
            this.btnSearchMovie.Click += new System.EventHandler(this.btnSearchMovie_Click);
            // 
            // dateTime1
            // 
            this.dateTime1.CustomFormat = "yyyy/ MM/ dd    - dddd";
            this.dateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime1.Location = new System.Drawing.Point(280, 257);
            this.dateTime1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTime1.MaxDate = new System.DateTime(2016, 3, 29, 0, 0, 0, 0);
            this.dateTime1.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.ShowUpDown = true;
            this.dateTime1.Size = new System.Drawing.Size(151, 20);
            this.dateTime1.TabIndex = 18;
            this.dateTime1.Value = new System.DateTime(2016, 3, 29, 0, 0, 0, 0);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(280, 310);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(151, 20);
            this.txtAddress.TabIndex = 19;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(435, 310);
            this.txtState.Margin = new System.Windows.Forms.Padding(2);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(45, 20);
            this.txtState.TabIndex = 20;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(280, 368);
            this.txtZip.Margin = new System.Windows.Forms.Padding(2);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(76, 20);
            this.txtZip.TabIndex = 21;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(280, 116);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 22;
            this.lblFullName.Text = "Full Name";
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(283, 167);
            this.lblSSN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(117, 13);
            this.lblSSN.TabIndex = 23;
            this.lblSSN.Text = "Social Security Number";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(280, 223);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 24;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(278, 343);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 25;
            this.lblAddress.Text = "Address";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(433, 343);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 26;
            this.lblState.Text = "State";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(278, 397);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 27;
            this.lblZipCode.Text = "Zip Code";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(470, 116);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(60, 46);
            this.btnAddCustomer.TabIndex = 28;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Location = new System.Drawing.Point(470, 195);
            this.btnRemoveCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(60, 46);
            this.btnRemoveCustomer.TabIndex = 29;
            this.btnRemoveCustomer.Text = "Remove";
            this.btnRemoveCustomer.UseVisualStyleBackColor = true;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(546, -2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(4, 635);
            this.label2.TabIndex = 31;
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Location = new System.Drawing.Point(660, 39);
            this.lblTransaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(119, 13);
            this.lblTransaction.TabIndex = 32;
            this.lblTransaction.Text = "Make Movie Selection: ";
            // 
            // btnCalculatePrice
            // 
            this.btnCalculatePrice.Location = new System.Drawing.Point(752, 383);
            this.btnCalculatePrice.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculatePrice.Name = "btnCalculatePrice";
            this.btnCalculatePrice.Size = new System.Drawing.Size(82, 34);
            this.btnCalculatePrice.TabIndex = 34;
            this.btnCalculatePrice.Text = "Calculate";
            this.btnCalculatePrice.UseVisualStyleBackColor = true;
            this.btnCalculatePrice.Click += new System.EventHandler(this.btnCalculatePrice_Click);
            // 
            // lblNameCus
            // 
            this.lblNameCus.AutoSize = true;
            this.lblNameCus.Location = new System.Drawing.Point(290, 476);
            this.lblNameCus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameCus.Name = "lblNameCus";
            this.lblNameCus.Size = new System.Drawing.Size(119, 13);
            this.lblNameCus.TabIndex = 38;
            this.lblNameCus.Text = "Search Customer Name";
            // 
            // txtSearchMovie
            // 
            this.txtSearchMovie.Location = new System.Drawing.Point(9, 460);
            this.txtSearchMovie.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchMovie.Name = "txtSearchMovie";
            this.txtSearchMovie.Size = new System.Drawing.Size(116, 20);
            this.txtSearchMovie.TabIndex = 39;
            // 
            // lblSearchKeyWord
            // 
            this.lblSearchKeyWord.AutoSize = true;
            this.lblSearchKeyWord.Location = new System.Drawing.Point(148, 460);
            this.lblSearchKeyWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchKeyWord.Name = "lblSearchKeyWord";
            this.lblSearchKeyWord.Size = new System.Drawing.Size(107, 13);
            this.lblSearchKeyWord.TabIndex = 40;
            this.lblSearchKeyWord.Text = "Search for key words";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(765, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "# of Days";
            // 
            // txtboxRentalDays
            // 
            this.txtboxRentalDays.Location = new System.Drawing.Point(620, 424);
            this.txtboxRentalDays.Name = "txtboxRentalDays";
            this.txtboxRentalDays.Size = new System.Drawing.Size(100, 20);
            this.txtboxRentalDays.TabIndex = 45;
            this.txtboxRentalDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxRentalDays_KeyPress);
            // 
            // txtboxCalculateTotal
            // 
            this.txtboxCalculateTotal.Location = new System.Drawing.Point(620, 391);
            this.txtboxCalculateTotal.Name = "txtboxCalculateTotal";
            this.txtboxCalculateTotal.Size = new System.Drawing.Size(100, 20);
            this.txtboxCalculateTotal.TabIndex = 44;
            this.txtboxCalculateTotal.Text = "$0.00";
            this.txtboxCalculateTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCalculateTotal_KeyPress);
            // 
            // btnSearchForCustomer
            // 
            this.btnSearchForCustomer.Location = new System.Drawing.Point(435, 445);
            this.btnSearchForCustomer.Name = "btnSearchForCustomer";
            this.btnSearchForCustomer.Size = new System.Drawing.Size(75, 34);
            this.btnSearchForCustomer.TabIndex = 49;
            this.btnSearchForCustomer.Text = "Search for Customer";
            this.btnSearchForCustomer.UseVisualStyleBackColor = true;
            this.btnSearchForCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(293, 453);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(117, 20);
            this.txtSearchCustomer.TabIndex = 50;
            // 
            // btnShowMovieList
            // 
            this.btnShowMovieList.Location = new System.Drawing.Point(593, 141);
            this.btnShowMovieList.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowMovieList.Name = "btnShowMovieList";
            this.btnShowMovieList.Size = new System.Drawing.Size(116, 34);
            this.btnShowMovieList.TabIndex = 51;
            this.btnShowMovieList.Text = "Show Movie List";
            this.btnShowMovieList.UseVisualStyleBackColor = true;
            this.btnShowMovieList.Click += new System.EventHandler(this.btnShowMovieList_Click);
            // 
            // lstboxMovie
            // 
            this.lstboxMovie.FormattingEnabled = true;
            this.lstboxMovie.Location = new System.Drawing.Point(566, 60);
            this.lstboxMovie.Name = "lstboxMovie";
            this.lstboxMovie.Size = new System.Drawing.Size(302, 69);
            this.lstboxMovie.TabIndex = 53;
            // 
            // lstboxCustomers
            // 
            this.lstboxCustomers.FormattingEnabled = true;
            this.lstboxCustomers.Location = new System.Drawing.Point(566, 208);
            this.lstboxCustomers.Name = "lstboxCustomers";
            this.lstboxCustomers.Size = new System.Drawing.Size(302, 69);
            this.lstboxCustomers.TabIndex = 54;
            // 
            // btnShowCustomerList
            // 
            this.btnShowCustomerList.Location = new System.Drawing.Point(593, 296);
            this.btnShowCustomerList.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowCustomerList.Name = "btnShowCustomerList";
            this.btnShowCustomerList.Size = new System.Drawing.Size(116, 34);
            this.btnShowCustomerList.TabIndex = 55;
            this.btnShowCustomerList.Text = "Show Customer List";
            this.btnShowCustomerList.UseVisualStyleBackColor = true;
            // 
            // btnSelectMovie
            // 
            this.btnSelectMovie.Location = new System.Drawing.Point(752, 144);
            this.btnSelectMovie.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectMovie.Name = "btnSelectMovie";
            this.btnSelectMovie.Size = new System.Drawing.Size(116, 34);
            this.btnSelectMovie.TabIndex = 56;
            this.btnSelectMovie.Text = "Select Movie";
            this.btnSelectMovie.UseVisualStyleBackColor = true;
            this.btnSelectMovie.Click += new System.EventHandler(this.btnSelectMovie_Click);
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Location = new System.Drawing.Point(752, 296);
            this.btnSelectCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(116, 34);
            this.btnSelectCustomer.TabIndex = 57;
            this.btnSelectCustomer.Text = "Select Customer";
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // btnRemoveMovie
            // 
            this.btnRemoveMovie.Location = new System.Drawing.Point(162, 327);
            this.btnRemoveMovie.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveMovie.Name = "btnRemoveMovie";
            this.btnRemoveMovie.Size = new System.Drawing.Size(93, 49);
            this.btnRemoveMovie.TabIndex = 58;
            this.btnRemoveMovie.Text = "Remove Movie from Storage";
            this.btnRemoveMovie.UseVisualStyleBackColor = true;
            this.btnRemoveMovie.Click += new System.EventHandler(this.btnRemoveMovie_Click);
            // 
            // txtboxMovieName
            // 
            this.txtboxMovieName.Location = new System.Drawing.Point(620, 460);
            this.txtboxMovieName.Name = "txtboxMovieName";
            this.txtboxMovieName.Size = new System.Drawing.Size(100, 20);
            this.txtboxMovieName.TabIndex = 59;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(765, 467);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(95, 13);
            this.lblMovieName.TabIndex = 60;
            this.lblMovieName.Text = "Enter Movie Name";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 602);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.txtboxMovieName);
            this.Controls.Add(this.btnRemoveMovie);
            this.Controls.Add(this.btnSelectCustomer);
            this.Controls.Add(this.btnSelectMovie);
            this.Controls.Add(this.btnShowCustomerList);
            this.Controls.Add(this.lstboxCustomers);
            this.Controls.Add(this.lstboxMovie);
            this.Controls.Add(this.btnShowMovieList);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.btnSearchForCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxRentalDays);
            this.Controls.Add(this.txtboxCalculateTotal);
            this.Controls.Add(this.lblSearchKeyWord);
            this.Controls.Add(this.txtSearchMovie);
            this.Controls.Add(this.lblNameCus);
            this.Controls.Add(this.btnCalculatePrice);
            this.Controls.Add(this.lblTransaction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoveCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.dateTime1);
            this.Controls.Add(this.btnSearchMovie);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.lblCustomerDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblActorName);
            this.Controls.Add(this.lblNameMovie);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtNameActor);
            this.Controls.Add(this.txtNameMovie);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeForm";
            this.Text = "Employee Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameMovie;
        private System.Windows.Forms.TextBox txtNameActor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblNameMovie;
        private System.Windows.Forms.Label lblActorName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerDisplay;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSearchMovie;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Button btnCalculatePrice;
        private System.Windows.Forms.Label lblNameCus;
        private System.Windows.Forms.TextBox txtSearchMovie;
        private System.Windows.Forms.Label lblSearchKeyWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxRentalDays;
        private System.Windows.Forms.TextBox txtboxCalculateTotal;
        private System.Windows.Forms.Button btnSearchForCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Button btnShowMovieList;
        private System.Windows.Forms.ListBox lstboxMovie;
        private System.Windows.Forms.ListBox lstboxCustomers;
        private System.Windows.Forms.Button btnShowCustomerList;
        private System.Windows.Forms.Button btnSelectMovie;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.Button btnRemoveMovie;
        private System.Windows.Forms.TextBox txtboxMovieName;
        private System.Windows.Forms.Label lblMovieName;
    }
}

