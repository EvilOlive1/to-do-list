
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace To_Do_List_App
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        private string titleBoxText = "";
        private string descriptionBoxText = "";
        private DateTime dateBoxText;
        private string categoryText = "";

        // Source of "Date"
        DataTable todoList = new DataTable();

        string connstring = "Data Source=DESKTOP-75B7PCR\\SQLEXPRESS01;Initial Catalog=ToDoList;Integrated Security=True;Encrypt=False";
        private void ClearTaskEntry()
        {
            titleBox.Text = "";
            descriptionBox.Text = "";
            categoryBox.Text = "";
        }

        private void LoadTaskList()
        {
            string query = "Select * from TaskList";

            ConnectToDatabase(con =>
            {
                todoList.Clear();

                using (SqlCommand srcCmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = srcCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataRow row = todoList.NewRow();
                            row["ID"] = reader.GetValue(0);
                            row["Title"] = reader.GetValue(1);
                            row["Description"] = reader.GetValue(2);
                            row["DueDate"] = reader.GetValue(3);
                            row["Category"] = reader.GetValue(4);
                            todoList.Rows.Add(row);
                        }
                    }
                }
            });
        }
        
        private void ConnectToDatabase(Action<SqlConnection> action)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                con.Open();
                action(con);
            }
        }

        private void LoadCategoryList()
        {
            string query = "Select * from Categories";

            ConnectToDatabase(con =>
            {
                using (SqlCommand srcCmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = srcCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categoryBox.Items.Add(reader.GetValue(0));
                            sortBox.Items.Add(reader.GetValue(0));
                        }
                    }
                }
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ExtConsole.Show(true, "Title of console");
            //ExtConsole.WriteLine("Form is currently loading");

            // INITIALIZE the DataTable and add columns
            todoList = new DataTable();
            todoList.Columns.Add("ID");
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Category");
            todoList.Columns.Add("DueDate");
            todoList.Columns.Add("Description");

            // CREATE more columns as needed
            toDoListView.DataSource = todoList;

            // RETRIEVE all categories from Categories(SQL)
            try
            {
                LoadCategoryList();

                // ENSURES user cannot type their own custom category
                categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                sortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            // RETRIEVE all data from ToDoList(SQL)
            try
            {
                LoadTaskList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Reset button to restart the form
        private void newButton_Click(object sender, EventArgs e)
        {
            ClearTaskEntry();

            ExtConsole.WriteLine("Form Cleared.");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (toDoListView.CurrentCell != null)
            {
                ConnectToDatabase(con =>
                {
                    string query = "DELETE FROM TaskList " +
                                    "WHERE ProjectID LIKE @Id";

                    int idValue = Convert.ToInt32(toDoListView.CurrentCell.Value);

                    using (SqlCommand sc = new SqlCommand(query, con))
                    {
                        sc.Parameters.AddWithValue("@Id", idValue);
                        sc.ExecuteNonQuery();
                    }
                });

                LoadTaskList();
                ClearTaskEntry();
                ExtConsole.WriteLine("Entry Deleted!");
            }
        }

        // Save button to add new data entry
        private void saveButton_Click(object sender, EventArgs e)
        {
            ConnectToDatabase(con =>
            {
                string query = "INSERT INTO TaskList (Title, Description, DueDate, Category) " +
                                "VALUES (@Title, @Description, @DueDate, @Category)";

                using (SqlCommand sc = new SqlCommand(query, con))
                {
                    sc.Parameters.AddWithValue("@Title", titleBoxText);
                    sc.Parameters.AddWithValue("@Description", descriptionBoxText);
                    sc.Parameters.AddWithValue("@DueDate", dueDatePicker.Value.Date);
                    sc.Parameters.AddWithValue("@Category", categoryText);
                    sc.ExecuteNonQuery();
                }
            });

            LoadTaskList();
            ClearTaskEntry();
            ExtConsole.WriteLine("Entry Saved!");
        }
        
        private void titleBox_TextChanged(object sender, EventArgs e)
        {
            titleBoxText = titleBox.Text;
        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {
            descriptionBoxText = descriptionBox.Text;
        }        
        
        private void dueDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dateBoxText = dueDatePicker.Value.Date;
        }      
        
        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryText = categoryBox.Text;
        }
        
        private void sortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = (string)sortBox.SelectedItem;

            todoList.Clear();

            // RETRIEVE all data from ToDoList(SQL)
            try
            {
                ConnectToDatabase(con =>
                {
                    // SQL Command for getting necessary data
                    string query = "SELECT * FROM ToDoList " +
                                    "WHERE Category LIKE @selectedCategory";

                    using (SqlCommand srcCmd = new SqlCommand(query, con))
                    {
                        srcCmd.Parameters.AddWithValue("@selectedCategory", selectedCategory);

                        using (SqlDataReader reader = srcCmd.ExecuteReader())
                        {
                            // Reading each row of data
                            while (reader.Read())
                            {
                                // Create a new row for each record
                                DataRow row = todoList.NewRow();
                                row["Title"] = reader.GetValue(1);
                                row["Description"] = reader.GetValue(2);
                                row["DueDate"] = reader.GetValue(3);
                                row["Category"] = reader.GetValue(4);
                                todoList.Rows.Add(row);
                            }
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // ------------------------------------------------------------------------------------

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void toDoListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        class ExtConsole
        {
            static bool console_on = false;

            public static void Show(bool on, string title)
            {
                console_on = on;
                if (console_on)
                {
                    AllocConsole();
                    Console.Title = title;
                    Console.BackgroundColor = System.ConsoleColor.White;
                    Console.ForegroundColor = System.ConsoleColor.Black;
                }
                else
                {
                    FreeConsole();
                }
            }

            public static void Write(string output)
            {
                if (console_on)
                {
                    Console.Write(output);
                }
            }

            public static void WriteLine(string output)
            {
                if (console_on)
                {
                    Console.WriteLine(output);
                }
            }

            [DllImport("kernel32.dll")]
            public static extern Boolean AllocConsole();

            [DllImport("kernel32.dll")]
            public static extern Boolean FreeConsole();

            internal static void Write(int rowIndex)
            {
                if (console_on)
                {
                    Console.Write(rowIndex);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
