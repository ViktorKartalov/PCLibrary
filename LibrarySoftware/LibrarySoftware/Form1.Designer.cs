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
            this.labelIsTaken = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.groupBoxBook.SuspendLayout();
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
            this.groupBoxBook.Controls.Add(this.buttonEdit);
            this.groupBoxBook.Controls.Add(this.button1);
            this.groupBoxBook.Controls.Add(this.buttonAdd);
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
            this.groupBoxCard.Location = new System.Drawing.Point(863, 0);
            this.groupBoxCard.Name = "groupBoxCard";
            this.groupBoxCard.Size = new System.Drawing.Size(339, 374);
            this.groupBoxCard.TabIndex = 3;
            this.groupBoxCard.TabStop = false;
            this.groupBoxCard.Text = "Add card";
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
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(21, 243);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(303, 31);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add new book";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(21, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Delete selected book";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(21, 280);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(303, 31);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Edit selected book";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // FormLibrarySoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 377);
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
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelIsTaken;
    }
}

