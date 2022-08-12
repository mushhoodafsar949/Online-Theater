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
    public partial class Form3 : Form
    {
        string sign = "(0)";
        string[,] THEATERPLAN = new string[16, 16];
        SqlConnection ConnectionSql;
        public Form3()
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

        private void buy_Click(object sender, EventArgs e)
        {
            int rtobuy = int.Parse(rowtextbox.Text);
            int seattobuy = int.Parse(seatnumbertextox.Text);
            try
            {
                string search = rowtextbox.Text;
                if (search != "")
                {
                    string querry = "Select price from pricing where rowid =" + search;
                    using (SqlCommand command = new SqlCommand(querry, ConnectionSql))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int price = reader.GetInt32(0);

                            MessageBox.Show("Seat Price of Row " + rowtextbox + " is " + price,"Row Price",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        }
                        reader.Close();
                    }
                }


                datagridview[rtobuy, seattobuy].Value = "(@)";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    THEATERPLAN[i, j] = sign + " ";
                }
            }
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                    THEATERPLAN[i, 0] = "Row " + i;
            }
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    THEATERPLAN[0, j] = "Column " + j + " ";
                }
            }

            int h = THEATERPLAN.GetLength(0);
            int w = THEATERPLAN.GetLength(1);

            this.datagridview.ColumnCount = w;

            for (int r = 0; r < h; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.datagridview);

                for (int c = 0; c < w; c++)
                {
                    row.Cells[c].Value = THEATERPLAN[r, c];
                }

                this.datagridview.Rows.Add(row);
            }
        }

        private void rowtextbox_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}