namespace To_Do_List_App
{
    partial class ToDoList
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.toDoListView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1022, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(774, 100);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(260, 20);
            this.titleBox.TabIndex = 1;
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(774, 127);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(260, 20);
            this.descriptionBox.TabIndex = 2;
            this.descriptionBox.TextChanged += new System.EventHandler(this.descriptionBox_TextChanged);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(702, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(702, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Title:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(774, 182);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(72, 30);
            this.newButton.TabIndex = 7;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 465);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(72, 30);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(852, 182);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(72, 30);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toDoListView
            // 
            this.toDoListView.AllowUserToOrderColumns = true;
            this.toDoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.toDoListView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.toDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toDoListView.Location = new System.Drawing.Point(12, 100);
            this.toDoListView.Name = "toDoListView";
            this.toDoListView.ReadOnly = true;
            this.toDoListView.Size = new System.Drawing.Size(684, 359);
            this.toDoListView.TabIndex = 11;
            this.toDoListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.toDoListView_CellContentClick);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(702, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "DueDate:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dueDatePicker
            // 
            this.dueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dueDatePicker.Location = new System.Drawing.Point(774, 155);
            this.dueDatePicker.Name = "dueDatePicker";
            this.dueDatePicker.Size = new System.Drawing.Size(97, 20);
            this.dueDatePicker.TabIndex = 16;
            this.dueDatePicker.ValueChanged += new System.EventHandler(this.dueDatePicker_ValueChanged);
            // 
            // sortBox
            // 
            this.sortBox.DropDownWidth = 96;
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Location = new System.Drawing.Point(59, 72);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(96, 21);
            this.sortBox.TabIndex = 20;
            this.sortBox.SelectedIndexChanged += new System.EventHandler(this.sortList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sort by:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(877, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Category:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(938, 155);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(96, 21);
            this.categoryBox.TabIndex = 20;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1048, 507);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.dueDatePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toDoListView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label1);
            this.Name = "ToDoList";
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView toDoListView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dueDatePicker;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox categoryBox;
    }
}

