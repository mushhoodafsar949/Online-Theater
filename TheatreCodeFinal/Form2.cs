using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheatreCodeFinal
{
    public partial class Form2 : Form
    {
        int R1, R2, R3, R4,R5, R6, R7, R8, R9, R10, R11, R12, R13, R14, R15;

       
        SqlConnection ConnectionSql;
        public Form2()
        {
            InitializeComponent();
            string connectionStr = Properties.Settings.Default.connectionstring;
            ConnectionSql = new SqlConnection(connectionStr);
            try
            {

                ConnectionSql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                R1 = int.Parse(row1.Text);
                R2 = int.Parse(row2.Text);
                R3 = int.Parse(row3.Text);
                R4 = int.Parse(row4.Text);
                R5 = int.Parse(row5.Text);
                R6 = int.Parse(row6.Text);
                R7 = int.Parse(row7.Text);
                R8 = int.Parse(row8.Text);
                R9 = int.Parse(row9.Text);
                R10 = int.Parse(row10.Text);
                R11 = int.Parse(row11.Text);
                R12 = int.Parse(row12.Text);
                R13 = int.Parse(row13.Text);
                R14 = int.Parse(row14.Text);
                R15 = int.Parse(row15.Text);
                if (R1.ToString() != "" && R2.ToString() != "" && R3.ToString() != "" && R4.ToString() != "" && R5.ToString() != "" && R6.ToString() != "" && R7.ToString() != "" && R8.ToString() != "" && R9.ToString() != "" && R10.ToString() != "" && R11.ToString() != "" && R12.ToString() != "" && R13.ToString() != "" && R14.ToString() != "" && R15.ToString() != "")

                {
                    string query = String.Format("Insert into pricing (rowid,price)"
                                                          + "VALUES ('{0}','{1}')",
                                                                      1, R1);
                    string query1 = String.Format("Insert into pricing(rowid,price)"
                                                            + "VALUES ('{0}','{1}')",
                                                                        2, R2);
                    string query2 = String.Format("Insert into pricing (rowid,price)"
                                                            + "VALUES ('{0}','{1}')",
                                                                        3, R3);
                    string query3 = String.Format("Insert into pricing (rowid,price)"
                                                            + "VALUES ('{0}','{1}')",
                                                                        4, R4);
                    string query4 = String.Format("Insert into pricing (rowid,price)"
                                                             + "VALUES ('{0}','{1}')",
                                                                         5, R5);
                    string query5 = String.Format("Insert into pricing (rowid,price)"
                                                            + "VALUES ('{0}','{1}')",
                                                                        6, R6);
                    string query6 = String.Format("Insert into pricing(rowid,price)"
                                                            + "VALUES ('{0}','{1}')",
                                                                        7, R7);
                    string query7 = String.Format("Insert into pricing(rowid,price)"
                                                            + "VALUES ('{0}','{1}')",
                                                                        8, R8);
                    string query8 = String.Format("Insert into pricing (rowid,price)"
                                                            + "VALUES ('{0}','{1}')",
                                                                        9, R9);
                    string query9 = String.Format("Insert into pricing (rowid,price)"
                                                            + "VALUES ('{0}','{1}')",
                                                                        10, R10);
                    string query10 = String.Format("Insert into pricing (rowid,price)"
                                                             + "VALUES ('{0}','{1}')",
                                                                         11, R11);
                    string query11 = String.Format("Insert into pricing (rowid,price)"
                                                            + "VALUES ('{0}','{1}')",
                                                                        12, R12);
                    string query12 = String.Format("Insert into pricing (rowid,price)"
                                                            + "VALUES ('{0}','{1}')",
                                                                        13, R13);
                    string query13 = String.Format("Insert into pricing (rowid,price)"
                                                            + "VALUES ('{0}','{1}')",
                                                                        14, R14);
                    string query14 = String.Format("Insert into pricing (rowid,price)"
                                                            + "VALUES ('{0}','{1}')",
                                                                        15, R15);

                    try
                    {
                        using (SqlCommand command = new SqlCommand(query, ConnectionSql))
                        {
                            int numberOfAffectedRows = command.ExecuteNonQuery();
                            MessageBox.Show("Successfuly Entered!" + "\nNumber of Affected " + numberOfAffectedRows, "Message", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Form3 f1 = new Form3();
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Fields are Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
            this.Hide();

        }

    }
}
