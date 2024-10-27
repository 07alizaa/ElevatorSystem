using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ElevatorSystem
{
    internal class DBContext
    {
        string connectString = @"Server=ALIZA;Database=testing; Trusted_Connection=True;";

        public void InsertLogsIntoDB(DataTable dt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    string query = @"Insert into Logs_2(LogTime, Eventdescription) values(@Time,@Log)";
                    using (SqlDataAdapter adpater = new SqlDataAdapter())
                    {
                        adpater.InsertCommand = new SqlCommand(query, conn);
                        adpater.InsertCommand.Parameters.Add("@Time", SqlDbType.DateTime, 0, "LogTime");
                        adpater.InsertCommand.Parameters.Add("@Log", SqlDbType.NVarChar, 255, "EventDescription");
                        conn.Open();
                        adpater.Update(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving logs to DB:" + ex.Message);



            }
        }
        public void loadLogsFormDB(DataTable dt, DataGridView dataGridView1)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    string query = @"Select LogTime, Eventdescription from Logs_2 order by LogTime";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        dt.Rows.Clear();
                        adapter.Fill(dt);
                        dataGridView1.Rows.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            string currentTime = Convert.ToDateTime(row["LogTime"]).ToString("hh:mm:ss");
                            string events = row["Eventdescription"].ToString();

                            dataGridView1.Rows.Add(currentTime, events);


                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving logs to DB:" + ex.Message);

            }
        }

        public void DeleteLogFromDB(DataTable dt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {

                    string query = @"DELETE FROM Logs_2";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        conn.Open();
                        cmd.ExecuteNonQuery();


                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error deleting log from DB: " + ex.Message);
            }
        }

    }
}
