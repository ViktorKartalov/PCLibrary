namespace LibrarySoftware
{
    partial class FormLibrarySoftware
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
            this.comboBoxSelection = new System.Windows.Forms.ComboBox();
            this.groupBoxBook = new System.Windows.Forms.GroupBox();
            this.buttonEditBook = new System.Windows.Forms.Button();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.labelIsTaken = new System.Windows.Forms.Label();
            this.checkBoxTaken = new System.Windows.Forms.CheckBox();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.labelDateTaken = new System.Windows.Forms.Label();
            this.dateTimePickerReturn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTaken = new System.Windows.Forms.DateTimePicker();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxCard = new System.Windows.Forms.GroupBox();
            this.buttonEditCard = new System.Windows.Forms.Button();
            this.buttonDeleteCard = new System.Windows.Forms.Button();
            this.buttonAddNewCard = new System.Windows.Forms.Button();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.labeldateCreated = new System.Windows.Forms.Label();
            this.dateTimePickerExpirationDAt = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateCreated = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEgn = new System.Windows.Forms.TextBox();
            this.labelEGN = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxBook.SuspendLayout();
            this.groupBoxCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSelection
            // 
            this.comboBoxSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelection.Items.AddRange(new object[] {
            "Books",
            "Cards"});
            this.comboBoxSelection.Location = new System.Drawing.Point(361, 10);
            this.comboBoxSelection.Name = "comboBoxSelection";
            this.comboBoxSelection.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelection.TabIndex = 1;
            this.comboBoxSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelection_SelectedIndexChanged);
            // 
            // groupBoxBook
            // 
            this.groupBoxBook.Controls.Add(this.buttonEditBook);
            this.groupBoxBook.Controls.Add(this.buttonDeleteBook);
            this.groupBoxBook.Controls.Add(this.buttonAddBook);
            this.groupBoxBook.Controls.Add(this.labelIsTaken);
            this.groupBoxBook.Controls.Add(this.checkBoxTaken);
            this.groupBoxBook.Controls.Add(this.labelReturnDate);
            this.groupBoxBook.Controls.Add(this.labelDateTaken);
            this.groupBoxBook.Controls.Add(this.dateTimePickerReturn);
            this.groupBoxBook.Controls.Add(this.dateTimePickerTaken);
            this.groupBoxBook.Controls.Add(this.textBoxCategory);
            this.groupBoxBook.Controls.Add(this.labelCategory);
            this.groupBoxBook.Controls.Add(this.textBoxAuthor);
            this.groupBoxBook.Controls.Add(this.labelAuthor);
            this.groupBoxBook.Controls.Add(this.textBoxTitle);
            this.groupBoxBook.Controls.Add(this.labelTitle);
            this.groupBoxBook.Location = new System.Drawing.Point(1, 0);
            this.groupBoxBook.Name = "groupBoxBook";
            this.groupBoxBook.Size = new System.Drawing.Size(354, 374);
            this.groupBoxBook.TabIndex = 2;
            this.groupBoxBook.TabStop = false;
            this.groupBoxBook.Text = "Add book";
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditBook.Location = new System.Drawing.Point(21, 280);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(303, 31);
            this.buttonEditBook.TabIndex = 17;
            this.buttonEditBook.Text = "Edit selected book";
            this.buttonEditBook.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteBook.Location = new System.Drawing.Point(21, 317);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(303, 31);
            this.buttonDeleteBook.TabIndex = 16;
            this.buttonDeleteBook.Text = "Delete selected book";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddBook.Location = new System.Drawing.Point(21, 243);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(303, 31);
            this.buttonAddBook.TabIndex = 15;
            this.buttonAddBook.Text = "Add new book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            // 
            // labelIsTaken
            // 
            this.labelIsTaken.AutoSize = true;
            this.labelIsTaken.Location = new System.Drawing.Point(32, 158);
            this.labelIsTaken.Name = "labelIsTaken";
            this.labelIsTaken.Size = new System.Drawing.Size(52, 13);
            this.labelIsTaken.TabIndex = 14;
            this.labelIsTaken.Text = "Is Taken:";
            // 
            // checkBoxTaken
            // 
            this.checkBoxTaken.AutoSize = true;
            this.checkBoxTaken.Location = new System.Drawing.Point(90, 157);
            this.checkBoxTaken.Name = "checkBoxTaken";
            this.checkBoxTaken.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTaken.TabIndex = 13;
            this.checkBoxTaken.UseVisualStyleBackColor = true;
            this.checkBoxTaken.CheckedChanged += new System.EventHandler(this.checkBoxTaken_CheckedChanged);
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.Location = new System.Drawing.Point(18, 198);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(66, 13);
            this.labelReturnDate.TabIndex = 12;
            this.labelReturnDate.Text = "Return date:";
            this.labelReturnDate.Visible = false;
            // 
            // labelDateTaken
            // 
            this.labelDateTaken.AutoSize = true;
            this.labelDateTaken.Location = new System.Drawing.Point(113, 158);
            this.labelDateTaken.Name = "labelDateTaken";
            this.labelDateTaken.Size = new System.Drawing.Size(67, 13);
            this.labelDateTaken.TabIndex = 11;
            this.labelDateTaken.Text = "Date Taken:";
            this.labelDateTaken.Visible = false;
            // 
            // dateTimePickerReturn
            // 
            this.dateTimePickerReturn.Enabled = false;
            this.dateTimePickerReturn.Location = new System.Drawing.Point(90, 194);
            this.dateTimePickerReturn.Name = "dateTimePickerReturn";
            this.dateTimePickerReturn.Size = new System.Drawing.Size(234, 20);
            this.dateTimePickerReturn.TabIndex = 4;
            this.dateTimePickerReturn.Visible = false;
            // 
            // dateTimePickerTaken
            // 
            this.dateTimePickerTaken.Location = new System.Drawing.Point(183, 154);
            this.dateTimePickerTaken.Name = "dateTimePickerTaken";
            this.dateTimePickerTaken.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerTaken.TabIndex = 10;
            this.dateTimePickerTaken.Visible = false;
            this.dateTimePickerTaken.ValueChanged += new System.EventHandler(this.dateTimePickerTaken_ValueChanged);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(90, 114);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(234, 20);
            this.textBoxCategory.TabIndex = 9;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(35, 118);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(52, 13);
            this.labelCategory.TabIndex = 8;
            this.labelCategory.Text = "Category:";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(90, 74);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(234, 20);
            this.textBoxAuthor.TabIndex = 7;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(46, 78);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(41, 13);
            this.labelAuthor.TabIndex = 6;
            this.labelAuthor.Text = "Author:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(90, 34);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(234, 20);
            this.textBoxTitle.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(54, 38);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Title:";
            // 
            // groupBoxCard
            // 
            this.groupBoxCard.Controls.Add(this.buttonEditCard);
            this.groupBoxCard.Controls.Add(this.buttonDeleteCard);
            this.groupBoxCard.Controls.Add(this.buttonAddNewCard);
            this.groupBoxCard.Controls.Add(this.labelExpirationDate);
            this.groupBoxCard.Controls.Add(this.labeldateCreated);
            this.groupBoxCard.Controls.Add(this.dateTimePickerExpirationDAt);
            this.groupBoxCard.Controls.Add(this.dateTimePickerDateCreated);
            this.groupBoxCard.Controls.Add(this.textBoxEmail);
            this.groupBoxCard.Controls.Add(this.labelEmail);
            this.groupBoxCard.Controls.Add(this.textBoxEgn);
            this.groupBoxCard.Controls.Add(this.labelEGN);
            this.groupBoxCard.Controls.Add(this.textBoxFullName);
            this.groupBoxCard.Controls.Add(this.labelFullName);
            this.groupBoxCard.Location = new System.Drawing.Point(825, 23);
            this.groupBoxCard.Name = "groupBoxCard";
            this.groupBoxCard.Size = new System.Drawing.Size(339, 374);
            this.groupBoxCard.TabIndex = 3;
            this.groupBoxCard.TabStop = false;
            this.groupBoxCard.Text = "Add card";
            // 
            // buttonEditCard
            // 
            this.buttonEditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditCard.Location = new System.Drawing.Point(19, 276);
            this.buttonEditCard.Name = "buttonEditCard";
            this.buttonEditCard.Size = new System.Drawing.Size(303, 31);
            this.buttonEditCard.TabIndex = 32;
            this.buttonEditCard.Text = "Edit selected card";
            this.buttonEditCard.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCard
            // 
            this.buttonDeleteCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteCard.Location = new System.Drawing.Point(19, 313);
            this.buttonDeleteCard.Name = "buttonDeleteCard";
            this.buttonDeleteCard.Size = new System.Drawing.Size(303, 31);
            this.buttonDeleteCard.TabIndex = 31;
            this.buttonDeleteCard.Text = "Delete selected card";
            this.buttonDeleteCard.UseVisualStyleBackColor = true;
            // 
            // buttonAddNewCard
            // 
            this.buttonAddNewCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNewCard.Location = new System.Drawing.Point(19, 239);
            this.buttonAddNewCard.Name = "buttonAddNewCard";
            this.buttonAddNewCard.Size = new System.Drawing.Size(303, 31);
            this.buttonAddNewCard.TabIndex = 30;
            this.buttonAddNewCard.Text = "Add new card";
            this.buttonAddNewCard.UseVisualStyleBackColor = true;
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Location = new System.Drawing.Point(5, 194);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(80, 13);
            this.labelExpirationDate.TabIndex = 27;
            this.labelExpirationDate.Text = "Expiration date:";
            // 
            // labeldateCreated
            // 
            this.labeldateCreated.AutoSize = true;
            this.labeldateCreated.Location = new System.Drawing.Point(13, 154);
            this.labeldateCreated.Name = "labeldateCreated";
            this.labeldateCreated.Size = new System.Drawing.Size(72, 13);
            this.labeldateCreated.TabIndex = 26;
            this.labeldateCreated.Text = "Date created:";
            // 
            // dateTimePickerExpirationDAt
            // 
            this.dateTimePickerExpirationDAt.Enabled = false;
            this.dateTimePickerExpirationDAt.Location = new System.Drawing.Point(88, 190);
            this.dateTimePickerExpirationDAt.Name = "dateTimePickerExpirationDAt";
            this.dateTimePickerExpirationDAt.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerExpirationDAt.TabIndex = 18;
            // 
            // dateTimePickerDateCreated
            // 
            this.dateTimePickerDateCreated.Location = new System.Drawing.Point(88, 150);
            this.dateTimePickerDateCreated.Name = "dateTimePickerDateCreated";
            this.dateTimePickerDateCreated.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerDateCreated.TabIndex = 25;
            this.dateTimePickerDateCreated.ValueChanged += new System.EventHandler(this.dateTimePickerDateCreated_ValueChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(88, 110);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(234, 20);
            this.textBoxEmail.TabIndex = 24;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(50, 113);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 23;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEgn
            // 
            this.textBoxEgn.Location = new System.Drawing.Point(88, 70);
            this.textBoxEgn.Name = "textBoxEgn";
            this.textBoxEgn.Size = new System.Drawing.Size(234, 20);
            this.textBoxEgn.TabIndex = 22;
            // 
            // labelEGN
            // 
            this.labelEGN.AutoSize = true;
            this.labelEGN.Location = new System.Drawing.Point(52, 73);
            this.labelEGN.Name = "labelEGN";
            this.labelEGN.Size = new System.Drawing.Size(33, 13);
            this.labelEGN.TabIndex = 21;
            this.labelEGN.Text = "EGN:";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(88, 30);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(234, 20);
            this.textBoxFullName.TabIndex = 20;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(30, 30);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(55, 13);
            this.labelFullName.TabIndex = 19;
            this.labelFullName.Text = "Full name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(373, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 320);
            this.dataGridView1.TabIndex = 4;
            // 
            // FormLibrarySoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 377);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxCard);
            this.Controls.Add(this.comboBoxSelection);
            this.Controls.Add(this.groupBoxBook);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(812, 416);
            this.MinimumSize = new System.Drawing.Size(812, 416);
            this.Name = "FormLibrarySoftware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Software";
            this.groupBoxBook.ResumeLayout(false);
            this.groupBoxBook.PerformLayout();
            this.groupBoxCard.ResumeLayout(false);
            this.groupBoxCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxSelection;
        private System.Windows.Forms.GroupBox groupBoxBook;
        private System.Windows.Forms.GroupBox groupBoxCard;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturn;
        private System.Windows.Forms.DateTimePicker dateTimePickerTaken;
        private System.Windows.Forms.Label labelReturnDate;
        private System.Windows.Forms.Label labelDateTaken;
        private System.Windows.Forms.CheckBox checkBoxTaken;
        private System.Windows.Forms.Button buttonEditBook;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Label labelIsTaken;
        private System.Windows.Forms.Button buttonEditCard;
        private System.Windows.Forms.Button buttonDeleteCard;
        private System.Windows.Forms.Button buttonAddNewCard;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.Label labeldateCreated;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpirationDAt;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateCreated;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEgn;
        private System.Windows.Forms.Label labelEGN;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

