namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lAddMember = new System.Windows.Forms.Label();
            this.tMemberPersonalID = new System.Windows.Forms.TextBox();
            this.tMemberName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pAddBookCopy = new System.Windows.Forms.Panel();
            this.bAddMember = new System.Windows.Forms.Button();
            this.bAddBookCopy = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.pAddBook = new System.Windows.Forms.Panel();
            this.lAddBook = new System.Windows.Forms.Label();
            this.tBookTitle = new System.Windows.Forms.TextBox();
            this.tBookDescription = new System.Windows.Forms.TextBox();
            this.lAddDescription = new System.Windows.Forms.Label();
            this.lAddTitle = new System.Windows.Forms.Label();
            this.lAddISBN = new System.Windows.Forms.Label();
            this.tBookAuthor = new System.Windows.Forms.TextBox();
            this.lAddAuthor = new System.Windows.Forms.Label();
            this.tBookISBN = new System.Windows.Forms.TextBox();
            this.lbBooksAgain = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bConfirmLoan = new System.Windows.Forms.Button();
            this.lAvailableCopies = new System.Windows.Forms.Label();
            this.lChosenBook = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLoans = new System.Windows.Forms.ComboBox();
            this.ReturnLoanButton = new System.Windows.Forms.Button();
            this.lbMemberLoans = new System.Windows.Forms.ListBox();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bShowBooks = new System.Windows.Forms.Button();
            this.lAvailCopies = new System.Windows.Forms.Label();
            this.label_availableinfo = new System.Windows.Forms.Label();
            this.label_descriptioninfo = new System.Windows.Forms.Label();
            this.label_totalinfo = new System.Windows.Forms.Label();
            this.label_isbninfo = new System.Windows.Forms.Label();
            this.label_authorinfo = new System.Windows.Forms.Label();
            this.label_infotitle = new System.Windows.Forms.Label();
            this.label_bookinfo = new System.Windows.Forms.Label();
            this.bCopies = new System.Windows.Forms.Label();
            this.bDescription = new System.Windows.Forms.Label();
            this.bISBN = new System.Windows.Forms.Label();
            this.bAuthor = new System.Windows.Forms.Label();
            this.bTitle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MakeLoanButton = new System.Windows.Forms.Button();
            this.lbAuthors = new System.Windows.Forms.ListBox();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pAddBookCopy.SuspendLayout();
            this.pAddBook.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.pAddBookCopy);
            this.tabPage3.Controls.Add(this.pAddBook);
            this.tabPage3.Controls.Add(this.lbBooksAgain);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(558, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Create";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lAddMember);
            this.panel1.Controls.Add(this.tMemberPersonalID);
            this.panel1.Controls.Add(this.tMemberName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(6, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 135);
            this.panel1.TabIndex = 17;
            // 
            // lAddMember
            // 
            this.lAddMember.AutoSize = true;
            this.lAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddMember.Location = new System.Drawing.Point(19, 22);
            this.lAddMember.Name = "lAddMember";
            this.lAddMember.Size = new System.Drawing.Size(156, 20);
            this.lAddMember.TabIndex = 4;
            this.lAddMember.Text = "Add New Member";
            // 
            // tMemberPersonalID
            // 
            this.tMemberPersonalID.Location = new System.Drawing.Point(60, 92);
            this.tMemberPersonalID.Name = "tMemberPersonalID";
            this.tMemberPersonalID.Size = new System.Drawing.Size(180, 20);
            this.tMemberPersonalID.TabIndex = 3;
            // 
            // tMemberName
            // 
            this.tMemberName.Location = new System.Drawing.Point(60, 47);
            this.tMemberName.Name = "tMemberName";
            this.tMemberName.Size = new System.Drawing.Size(180, 20);
            this.tMemberName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // pAddBookCopy
            // 
            this.pAddBookCopy.Controls.Add(this.bAddMember);
            this.pAddBookCopy.Controls.Add(this.bAddBookCopy);
            this.pAddBookCopy.Controls.Add(this.AddBookButton);
            this.pAddBookCopy.Location = new System.Drawing.Point(300, 216);
            this.pAddBookCopy.Name = "pAddBookCopy";
            this.pAddBookCopy.Size = new System.Drawing.Size(252, 182);
            this.pAddBookCopy.TabIndex = 16;
            // 
            // bAddMember
            // 
            this.bAddMember.Location = new System.Drawing.Point(88, 133);
            this.bAddMember.Name = "bAddMember";
            this.bAddMember.Size = new System.Drawing.Size(75, 23);
            this.bAddMember.TabIndex = 4;
            this.bAddMember.Text = "Add Member";
            this.bAddMember.UseVisualStyleBackColor = true;
            this.bAddMember.Click += new System.EventHandler(this.bAddMember_Click);
            // 
            // bAddBookCopy
            // 
            this.bAddBookCopy.Location = new System.Drawing.Point(73, 80);
            this.bAddBookCopy.Name = "bAddBookCopy";
            this.bAddBookCopy.Size = new System.Drawing.Size(111, 38);
            this.bAddBookCopy.TabIndex = 1;
            this.bAddBookCopy.Text = "Create Copy of Selected Book";
            this.bAddBookCopy.UseVisualStyleBackColor = true;
            this.bAddBookCopy.Click += new System.EventHandler(this.bAddBookCopy_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(79, 41);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(100, 24);
            this.AddBookButton.TabIndex = 3;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // pAddBook
            // 
            this.pAddBook.Controls.Add(this.lAddBook);
            this.pAddBook.Controls.Add(this.tBookTitle);
            this.pAddBook.Controls.Add(this.tBookDescription);
            this.pAddBook.Controls.Add(this.lAddDescription);
            this.pAddBook.Controls.Add(this.lAddTitle);
            this.pAddBook.Controls.Add(this.lAddISBN);
            this.pAddBook.Controls.Add(this.tBookAuthor);
            this.pAddBook.Controls.Add(this.lAddAuthor);
            this.pAddBook.Controls.Add(this.tBookISBN);
            this.pAddBook.Location = new System.Drawing.Point(6, 6);
            this.pAddBook.Name = "pAddBook";
            this.pAddBook.Size = new System.Drawing.Size(288, 251);
            this.pAddBook.TabIndex = 14;
            // 
            // lAddBook
            // 
            this.lAddBook.AutoSize = true;
            this.lAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddBook.Location = new System.Drawing.Point(9, 17);
            this.lAddBook.Name = "lAddBook";
            this.lAddBook.Size = new System.Drawing.Size(131, 20);
            this.lAddBook.TabIndex = 14;
            this.lAddBook.Text = "Add New Book";
            // 
            // tBookTitle
            // 
            this.tBookTitle.Location = new System.Drawing.Point(60, 43);
            this.tBookTitle.Name = "tBookTitle";
            this.tBookTitle.Size = new System.Drawing.Size(168, 20);
            this.tBookTitle.TabIndex = 6;
            // 
            // tBookDescription
            // 
            this.tBookDescription.Location = new System.Drawing.Point(22, 165);
            this.tBookDescription.Multiline = true;
            this.tBookDescription.Name = "tBookDescription";
            this.tBookDescription.Size = new System.Drawing.Size(214, 70);
            this.tBookDescription.TabIndex = 9;
            // 
            // lAddDescription
            // 
            this.lAddDescription.AutoSize = true;
            this.lAddDescription.Location = new System.Drawing.Point(3, 146);
            this.lAddDescription.Name = "lAddDescription";
            this.lAddDescription.Size = new System.Drawing.Size(60, 13);
            this.lAddDescription.TabIndex = 13;
            this.lAddDescription.Text = "Description";
            // 
            // lAddTitle
            // 
            this.lAddTitle.AutoSize = true;
            this.lAddTitle.Location = new System.Drawing.Point(9, 46);
            this.lAddTitle.Name = "lAddTitle";
            this.lAddTitle.Size = new System.Drawing.Size(27, 13);
            this.lAddTitle.TabIndex = 10;
            this.lAddTitle.Text = "Title";
            // 
            // lAddISBN
            // 
            this.lAddISBN.AutoSize = true;
            this.lAddISBN.Location = new System.Drawing.Point(9, 113);
            this.lAddISBN.Name = "lAddISBN";
            this.lAddISBN.Size = new System.Drawing.Size(32, 13);
            this.lAddISBN.TabIndex = 12;
            this.lAddISBN.Text = "ISBN";
            // 
            // tBookAuthor
            // 
            this.tBookAuthor.Location = new System.Drawing.Point(60, 77);
            this.tBookAuthor.Name = "tBookAuthor";
            this.tBookAuthor.Size = new System.Drawing.Size(168, 20);
            this.tBookAuthor.TabIndex = 7;
            // 
            // lAddAuthor
            // 
            this.lAddAuthor.AutoSize = true;
            this.lAddAuthor.Location = new System.Drawing.Point(9, 80);
            this.lAddAuthor.Name = "lAddAuthor";
            this.lAddAuthor.Size = new System.Drawing.Size(38, 13);
            this.lAddAuthor.TabIndex = 11;
            this.lAddAuthor.Text = "Author";
            // 
            // tBookISBN
            // 
            this.tBookISBN.Location = new System.Drawing.Point(60, 113);
            this.tBookISBN.Name = "tBookISBN";
            this.tBookISBN.Size = new System.Drawing.Size(168, 20);
            this.tBookISBN.TabIndex = 8;
            // 
            // lbBooksAgain
            // 
            this.lbBooksAgain.FormattingEnabled = true;
            this.lbBooksAgain.HorizontalScrollbar = true;
            this.lbBooksAgain.Location = new System.Drawing.Point(300, 6);
            this.lbBooksAgain.Name = "lbBooksAgain";
            this.lbBooksAgain.ScrollAlwaysVisible = true;
            this.lbBooksAgain.Size = new System.Drawing.Size(252, 199);
            this.lbBooksAgain.TabIndex = 5;
            this.lbBooksAgain.SelectedIndexChanged += new System.EventHandler(this.lbBooksAgain_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bConfirmLoan);
            this.tabPage2.Controls.Add(this.lAvailableCopies);
            this.tabPage2.Controls.Add(this.lChosenBook);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbLoans);
            this.tabPage2.Controls.Add(this.ReturnLoanButton);
            this.tabPage2.Controls.Add(this.lbMemberLoans);
            this.tabPage2.Controls.Add(this.lbMembers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(558, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Members&Loans";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bConfirmLoan
            // 
            this.bConfirmLoan.Enabled = false;
            this.bConfirmLoan.Location = new System.Drawing.Point(416, 22);
            this.bConfirmLoan.Name = "bConfirmLoan";
            this.bConfirmLoan.Size = new System.Drawing.Size(108, 23);
            this.bConfirmLoan.TabIndex = 11;
            this.bConfirmLoan.Text = "Confirm Loan";
            this.bConfirmLoan.UseVisualStyleBackColor = true;
            this.bConfirmLoan.Click += new System.EventHandler(this.bConfirmLoan_Click);
            // 
            // lAvailableCopies
            // 
            this.lAvailableCopies.AutoSize = true;
            this.lAvailableCopies.Location = new System.Drawing.Point(368, 28);
            this.lAvailableCopies.Name = "lAvailableCopies";
            this.lAvailableCopies.Size = new System.Drawing.Size(39, 13);
            this.lAvailableCopies.TabIndex = 10;
            this.lAvailableCopies.Text = "Copies";
            // 
            // lChosenBook
            // 
            this.lChosenBook.AutoSize = true;
            this.lChosenBook.Location = new System.Drawing.Point(21, 29);
            this.lChosenBook.Name = "lChosenBook";
            this.lChosenBook.Size = new System.Drawing.Size(51, 13);
            this.lChosenBook.TabIndex = 9;
            this.lChosenBook.Text = "TheBook";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select a member to borrow the book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Loans";
            // 
            // cbLoans
            // 
            this.cbLoans.FormattingEnabled = true;
            this.cbLoans.Location = new System.Drawing.Point(352, 208);
            this.cbLoans.Name = "cbLoans";
            this.cbLoans.Size = new System.Drawing.Size(172, 21);
            this.cbLoans.TabIndex = 6;
            this.cbLoans.SelectedIndexChanged += new System.EventHandler(this.cbLoans_SelectedIndexChanged);
            // 
            // ReturnLoanButton
            // 
            this.ReturnLoanButton.Enabled = false;
            this.ReturnLoanButton.Location = new System.Drawing.Point(20, 377);
            this.ReturnLoanButton.Name = "ReturnLoanButton";
            this.ReturnLoanButton.Size = new System.Drawing.Size(131, 23);
            this.ReturnLoanButton.TabIndex = 5;
            this.ReturnLoanButton.Text = "Return Selected Loan";
            this.ReturnLoanButton.UseVisualStyleBackColor = true;
            this.ReturnLoanButton.Click += new System.EventHandler(this.ReturnLoanButton_Click);
            // 
            // lbMemberLoans
            // 
            this.lbMemberLoans.FormattingEnabled = true;
            this.lbMemberLoans.HorizontalScrollbar = true;
            this.lbMemberLoans.Location = new System.Drawing.Point(20, 237);
            this.lbMemberLoans.Name = "lbMemberLoans";
            this.lbMemberLoans.Size = new System.Drawing.Size(504, 134);
            this.lbMemberLoans.TabIndex = 1;
            this.lbMemberLoans.SelectedIndexChanged += new System.EventHandler(this.lbMemberLoans_SelectedIndexChanged);
            // 
            // lbMembers
            // 
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.HorizontalScrollbar = true;
            this.lbMembers.Location = new System.Drawing.Point(20, 53);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(504, 147);
            this.lbMembers.TabIndex = 0;
            this.lbMembers.SelectedIndexChanged += new System.EventHandler(this.lbMembers_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(39, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 435);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.bShowBooks);
            this.tabPage1.Controls.Add(this.lAvailCopies);
            this.tabPage1.Controls.Add(this.label_availableinfo);
            this.tabPage1.Controls.Add(this.label_descriptioninfo);
            this.tabPage1.Controls.Add(this.label_totalinfo);
            this.tabPage1.Controls.Add(this.label_isbninfo);
            this.tabPage1.Controls.Add(this.label_authorinfo);
            this.tabPage1.Controls.Add(this.label_infotitle);
            this.tabPage1.Controls.Add(this.label_bookinfo);
            this.tabPage1.Controls.Add(this.bCopies);
            this.tabPage1.Controls.Add(this.bDescription);
            this.tabPage1.Controls.Add(this.bISBN);
            this.tabPage1.Controls.Add(this.bAuthor);
            this.tabPage1.Controls.Add(this.bTitle);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.MakeLoanButton);
            this.tabPage1.Controls.Add(this.lbAuthors);
            this.tabPage1.Controls.Add(this.lbBooks);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(558, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books&Authors";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Select book to make a loan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Select author to search for their books";
            // 
            // bShowBooks
            // 
            this.bShowBooks.Location = new System.Drawing.Point(388, 158);
            this.bShowBooks.Name = "bShowBooks";
            this.bShowBooks.Size = new System.Drawing.Size(140, 23);
            this.bShowBooks.TabIndex = 32;
            this.bShowBooks.Text = "Show All Available Books";
            this.bShowBooks.UseVisualStyleBackColor = true;
            this.bShowBooks.Click += new System.EventHandler(this.bShowBooks_Click);
            // 
            // lAvailCopies
            // 
            this.lAvailCopies.AutoSize = true;
            this.lAvailCopies.Location = new System.Drawing.Point(267, 261);
            this.lAvailCopies.Name = "lAvailCopies";
            this.lAvailCopies.Size = new System.Drawing.Size(35, 13);
            this.lAvailCopies.TabIndex = 31;
            this.lAvailCopies.Text = "label5";
            this.lAvailCopies.Visible = false;
            // 
            // label_availableinfo
            // 
            this.label_availableinfo.AutoSize = true;
            this.label_availableinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_availableinfo.Location = new System.Drawing.Point(267, 244);
            this.label_availableinfo.Name = "label_availableinfo";
            this.label_availableinfo.Size = new System.Drawing.Size(128, 17);
            this.label_availableinfo.TabIndex = 30;
            this.label_availableinfo.Text = "Copies Available";
            this.label_availableinfo.Visible = false;
            // 
            // label_descriptioninfo
            // 
            this.label_descriptioninfo.AutoSize = true;
            this.label_descriptioninfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descriptioninfo.Location = new System.Drawing.Point(35, 285);
            this.label_descriptioninfo.Name = "label_descriptioninfo";
            this.label_descriptioninfo.Size = new System.Drawing.Size(90, 17);
            this.label_descriptioninfo.TabIndex = 29;
            this.label_descriptioninfo.Text = "Description";
            this.label_descriptioninfo.Visible = false;
            // 
            // label_totalinfo
            // 
            this.label_totalinfo.AutoSize = true;
            this.label_totalinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalinfo.Location = new System.Drawing.Point(146, 244);
            this.label_totalinfo.Name = "label_totalinfo";
            this.label_totalinfo.Size = new System.Drawing.Size(99, 17);
            this.label_totalinfo.TabIndex = 28;
            this.label_totalinfo.Text = "Total Copies";
            this.label_totalinfo.Visible = false;
            // 
            // label_isbninfo
            // 
            this.label_isbninfo.AutoSize = true;
            this.label_isbninfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_isbninfo.Location = new System.Drawing.Point(32, 244);
            this.label_isbninfo.Name = "label_isbninfo";
            this.label_isbninfo.Size = new System.Drawing.Size(43, 17);
            this.label_isbninfo.TabIndex = 27;
            this.label_isbninfo.Text = "ISBN";
            this.label_isbninfo.Visible = false;
            // 
            // label_authorinfo
            // 
            this.label_authorinfo.AutoSize = true;
            this.label_authorinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_authorinfo.Location = new System.Drawing.Point(267, 199);
            this.label_authorinfo.Name = "label_authorinfo";
            this.label_authorinfo.Size = new System.Drawing.Size(56, 17);
            this.label_authorinfo.TabIndex = 26;
            this.label_authorinfo.Text = "Author";
            this.label_authorinfo.Visible = false;
            // 
            // label_infotitle
            // 
            this.label_infotitle.AutoSize = true;
            this.label_infotitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_infotitle.Location = new System.Drawing.Point(35, 199);
            this.label_infotitle.Name = "label_infotitle";
            this.label_infotitle.Size = new System.Drawing.Size(40, 17);
            this.label_infotitle.TabIndex = 25;
            this.label_infotitle.Text = "Title";
            this.label_infotitle.Visible = false;
            // 
            // label_bookinfo
            // 
            this.label_bookinfo.AutoSize = true;
            this.label_bookinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bookinfo.Location = new System.Drawing.Point(106, 168);
            this.label_bookinfo.Name = "label_bookinfo";
            this.label_bookinfo.Size = new System.Drawing.Size(88, 20);
            this.label_bookinfo.TabIndex = 24;
            this.label_bookinfo.Text = "Book Info";
            // 
            // bCopies
            // 
            this.bCopies.AutoSize = true;
            this.bCopies.Location = new System.Drawing.Point(146, 261);
            this.bCopies.Name = "bCopies";
            this.bCopies.Size = new System.Drawing.Size(35, 13);
            this.bCopies.TabIndex = 23;
            this.bCopies.Text = "label5";
            this.bCopies.Visible = false;
            // 
            // bDescription
            // 
            this.bDescription.AutoSize = true;
            this.bDescription.Location = new System.Drawing.Point(35, 302);
            this.bDescription.MaximumSize = new System.Drawing.Size(400, 0);
            this.bDescription.Name = "bDescription";
            this.bDescription.Size = new System.Drawing.Size(35, 13);
            this.bDescription.TabIndex = 22;
            this.bDescription.Text = "label4";
            this.bDescription.Visible = false;
            // 
            // bISBN
            // 
            this.bISBN.AutoSize = true;
            this.bISBN.Location = new System.Drawing.Point(35, 261);
            this.bISBN.Name = "bISBN";
            this.bISBN.Size = new System.Drawing.Size(35, 13);
            this.bISBN.TabIndex = 21;
            this.bISBN.Text = "label3";
            this.bISBN.Visible = false;
            // 
            // bAuthor
            // 
            this.bAuthor.AutoSize = true;
            this.bAuthor.Location = new System.Drawing.Point(267, 217);
            this.bAuthor.Name = "bAuthor";
            this.bAuthor.Size = new System.Drawing.Size(35, 13);
            this.bAuthor.TabIndex = 20;
            this.bAuthor.Text = "label2";
            this.bAuthor.Visible = false;
            // 
            // bTitle
            // 
            this.bTitle.AutoSize = true;
            this.bTitle.Location = new System.Drawing.Point(35, 217);
            this.bTitle.Name = "bTitle";
            this.bTitle.Size = new System.Drawing.Size(35, 13);
            this.bTitle.TabIndex = 19;
            this.bTitle.Text = "label1";
            this.bTitle.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 14;
            // 
            // MakeLoanButton
            // 
            this.MakeLoanButton.Enabled = false;
            this.MakeLoanButton.Location = new System.Drawing.Point(450, 357);
            this.MakeLoanButton.Name = "MakeLoanButton";
            this.MakeLoanButton.Size = new System.Drawing.Size(91, 33);
            this.MakeLoanButton.TabIndex = 11;
            this.MakeLoanButton.Text = "Make Loan";
            this.MakeLoanButton.UseVisualStyleBackColor = true;
            this.MakeLoanButton.Click += new System.EventHandler(this.MakeLoanButton_Click);
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.HorizontalScrollbar = true;
            this.lbAuthors.Location = new System.Drawing.Point(293, 23);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.ScrollAlwaysVisible = true;
            this.lbAuthors.Size = new System.Drawing.Size(235, 121);
            this.lbAuthors.TabIndex = 10;
            this.lbAuthors.SelectedIndexChanged += new System.EventHandler(this.lbAuthors_SelectedIndexChanged);
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.HorizontalScrollbar = true;
            this.lbBooks.Location = new System.Drawing.Point(19, 23);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.ScrollAlwaysVisible = true;
            this.lbBooks.Size = new System.Drawing.Size(231, 121);
            this.lbBooks.TabIndex = 0;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(717, 477);
            this.Controls.Add(this.tabControl1);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pAddBookCopy.ResumeLayout(false);
            this.pAddBook.ResumeLayout(false);
            this.pAddBook.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pAddBookCopy;
        private System.Windows.Forms.Button bAddBookCopy;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Panel pAddBook;
        private System.Windows.Forms.TextBox tBookTitle;
        private System.Windows.Forms.TextBox tBookDescription;
        private System.Windows.Forms.Label lAddDescription;
        private System.Windows.Forms.Label lAddTitle;
        private System.Windows.Forms.Label lAddISBN;
        private System.Windows.Forms.TextBox tBookAuthor;
        private System.Windows.Forms.Label lAddAuthor;
        private System.Windows.Forms.TextBox tBookISBN;
        private System.Windows.Forms.ListBox lbBooksAgain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbLoans;
        private System.Windows.Forms.Button ReturnLoanButton;
        private System.Windows.Forms.ListBox lbMemberLoans;
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bConfirmLoan;
        private System.Windows.Forms.Label lAvailableCopies;
        private System.Windows.Forms.Label lChosenBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tMemberPersonalID;
        private System.Windows.Forms.TextBox tMemberName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bAddMember;
        private System.Windows.Forms.Label lAddMember;
        private System.Windows.Forms.Label lAddBook;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lAvailCopies;
        private System.Windows.Forms.Label label_availableinfo;
        private System.Windows.Forms.Label label_descriptioninfo;
        private System.Windows.Forms.Label label_totalinfo;
        private System.Windows.Forms.Label label_isbninfo;
        private System.Windows.Forms.Label label_authorinfo;
        private System.Windows.Forms.Label label_infotitle;
        private System.Windows.Forms.Label label_bookinfo;
        private System.Windows.Forms.Label bCopies;
        private System.Windows.Forms.Label bDescription;
        private System.Windows.Forms.Label bISBN;
        private System.Windows.Forms.Label bAuthor;
        private System.Windows.Forms.Label bTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button MakeLoanButton;
        private System.Windows.Forms.ListBox lbAuthors;
        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button bShowBooks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

    }
}

