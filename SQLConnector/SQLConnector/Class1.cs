using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMRConnector
{
    public class DbConnector
    {
        private bool check = false;

        public DbConnector()
        {
        }

        public bool AddClient(string FirstName, string LastName, string Phone, string Address)
        {
            bool flag;
            string str = "INSERT INTO Client_Table VALUES (@Client_FirstName, @Client_LastName, @Client_Phone, @Client_Address)";
            SqlConnection connection = this.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Client_FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@Client_LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Client_Phone", SqlDbType.VarChar).Value = Phone;
            sqlCommand.Parameters.Add("@Client_Address", SqlDbType.VarChar).Value = Address;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!", "Client Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                if (sqlException.Number != 2627)
                {
                    MessageBox.Show(string.Concat("Error! \n", sqlException.ToString()), "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("Phone No. already exist.", "Phone No.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                flag = false;
                return flag;
            }
            connection.Close();
            flag = true;
            return flag;
        }

        public bool AddReservation(string Type, string No, string CID, string In, string Out)
        {
            bool flag;
            string str = "INSERT INTO Reservation_Table VALUES (@Type, @No, @CID, @In, @Out)";
            SqlConnection connection = this.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = Type;
            sqlCommand.Parameters.Add("@No", SqlDbType.Int).Value = No;
            sqlCommand.Parameters.Add("@CID", SqlDbType.Int).Value = CID;
            sqlCommand.Parameters.Add("@In", SqlDbType.VarChar).Value = In;
            sqlCommand.Parameters.Add("@Out", SqlDbType.VarChar).Value = Out;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!", "Reservation Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                if (sqlException.Number != 2627)
                {
                    MessageBox.Show(string.Concat("Error! \n", sqlException.ToString()), "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("Client ID already exist.", "Client ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                flag = false;
                return flag;
            }
            connection.Close();
            flag = true;
            return flag;
        }

        public bool AddRoom(string Type, string Phone, string Free)
        {
            bool flag;
            string str = "INSERT INTO Room_Table VALUES (@Type, @Phone, @Free)";
            SqlConnection connection = this.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = Type;
            sqlCommand.Parameters.Add("@Phone", SqlDbType.VarChar).Value = Phone;
            sqlCommand.Parameters.Add("@Free", SqlDbType.VarChar).Value = Free;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!", "Room Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                if (sqlException.Number != 2627)
                {
                    MessageBox.Show(string.Concat("Error! \n", sqlException.ToString()), "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("Phone No. already exist.", "Phone No.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                flag = false;
                return flag;
            }
            connection.Close();
            flag = true;
            return flag;
        }

        public bool AddUser(string Username, string Password)
        {
            bool flag;
            string str = "INSERT INTO User_Table VALUES (@User_Name, @User_Password)";
            SqlConnection connection = this.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@User_Name", SqlDbType.VarChar).Value = Username;
            sqlCommand.Parameters.Add("@User_Password", SqlDbType.VarChar).Value = Password;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                if (sqlException.Number != 2627)
                {
                    MessageBox.Show(string.Concat("Error! \n", sqlException.ToString()), "Add User", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("Username already exist.", "Username", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                flag = false;
                return flag;
            }
            connection.Close();
            flag = true;
            return flag;
        }

        public int Count(string query)
        {
            string str = query;
            SqlConnection connection = this.GetConnection();
            return (int)(new SqlCommand(str, connection)).ExecuteScalar();
        }

        public bool DeleteClient(string ID)
        {
            bool flag;
            string str = "DELETE FROM Client_Table WHERE Client_ID = @ClientID";
            SqlConnection connection = this.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@ClientID", SqlDbType.Int).Value = ID;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!", "Client Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                MessageBox.Show(string.Concat("Error! \n", sqlException.ToString()), "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                flag = false;
                return flag;
            }
            connection.Close();
            flag = true;
            return flag;
        }

        public bool DeleteReservation(string ID)
        {
            bool flag;
            string str = "DELETE FROM Reservation_Table WHERE Reservation_ID = @ReservationID";
            SqlConnection connection = this.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@ReservationID", SqlDbType.Int).Value = ID;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Canceled Successfully!", "Reservation Canceled", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                MessageBox.Show(string.Concat("Error! \n", sqlException.ToString()), "Canceled Reservation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                flag = false;
                return flag;
            }
            connection.Close();
            flag = true;
            return flag;
        }

        public bool DeleteRoom(string No)
        {
            bool flag;
            string str = "DELETE FROM Room_Table WHERE Room_Number = @RoomNumber";
            SqlConnection connection = this.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@RoomNumber", SqlDbType.Int).Value = No;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!", "Room Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                MessageBox.Show(string.Concat("Error! \n", sqlException.ToString()), "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                flag = false;
                return flag;
            }
            connection.Close();
            flag = true;
            return flag;
        }

        public bool DeleteUser(string ID)
        {
            bool flag;
            string str = "DELETE FROM User_Table WHERE User_ID = @UserID";
            SqlConnection connection = this.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = ID;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                MessageBox.Show(string.Concat("Error! \n", sqlException.ToString()), "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                flag = false;
                return flag;
            }
            connection.Close();
            flag = true;
            return flag;
        }

        public void DisplayAndSearch(string query, DataGridView dgv)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand(query, this.GetConnection()));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgv.DataSource = dataTable;
        }

        private SqlConnection GetConnection()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source = .\\SQLEXPRESS;\r\n                           Initial Catalog = db_hotel;\r\n                           Integrated Security = true");
            try
            {
                sqlConnection.Open();
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                MessageBox.Show(string.Concat("Error! \n", sqlException.ToString()), "SQL connection", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return sqlConnection;
        }

        public bool IsValidNamePass(string Username, string Password)
        {
            try
            {
                string str = string.Concat(new string[] { "SELECT User_Name, User_Password FROM User_Table WHERE User_Name = '", Username, "' AND User_Password = '", Password, "'" });
                SqlConnection connection = this.GetConnection();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand(str, connection));
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                connection.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.check = true;
                }
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                MessageBox.Show(string.Concat("Error! \n", sqlException.ToString()), "Username and Password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return this.check;
        }

        public void RoomTypeAndNo(string query, ComboBox cb)
        {
            SqlDataReader sqlDataReader = (new SqlCommand(query, this.GetConnection())).ExecuteReader();
            cb.Items.Clear();
            cb.Items.Add("Please select ...");
            cb.SelectedIndex = 0;
            while (sqlDataReader.Read())
            {
                cb.Items.Add(sqlDataReader[0]);
            }
        }

        public bool UpdateClient(string ID, string FirstName, string LastName, string Phone, string Address)
        {
            bool flag;
            string str = "UPDATE Client_Table SET Client_FirstName = @ClientFirstName, Client_LastName = @ClientLastName, Client_Phone = @ClientPhone, Client_Address = @ClientAddress WHERE Client_ID = @ClientID";
            SqlConnection connection = this.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@ClientID", SqlDbType.Int).Value = ID;
            sqlCommand.Parameters.Add("@ClientFirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@ClientLastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@ClientPhone", SqlDbType.VarChar).Value = Phone;
            sqlCommand.Parameters.Add("@ClientAddress", SqlDbType.VarChar).Value = Address;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!", "Client Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                if (sqlException.Number != 2627)
                {
                    MessageBox.Show(string.Concat("Error! \n", sqlException.ToString()), "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("Phone No. already exist.", "Phone No.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                flag = false;
                return flag;
            }
            connection.Close();
            flag = true;
            return flag;
        }

        public bool UpdateReservation(string RID, string Type, string No, string CID, string In, string Out)
        {
            bool flag;
            string str = "UPDATE Reservation_Table SET Reservation_Room_Type = @ReservationRoomType, Reservation_Room_Number = @ReservationRoomNumber, Reservation_Client_ID = @ReservationClientID, Reservation_In = @ReservationIn, Reservation_Out = @ReservationOut WHERE Reservation_ID = @ReservationID";
            SqlConnection connection = this.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@ReservationID", SqlDbType.Int).Value = RID;
            sqlCommand.Parameters.Add("@ReservationRoomType", SqlDbType.VarChar).Value = Type;
            sqlCommand.Parameters.Add("@ReservationRoomNumber", SqlDbType.Int).Value = No;
            sqlCommand.Parameters.Add("@ReservationClientID", SqlDbType.Int).Value = CID;
            sqlCommand.Parameters.Add("@ReservationIn", SqlDbType.VarChar).Value = In;
            sqlCommand.Parameters.Add("@ReservationOut", SqlDbType.VarChar).Value = Out;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!", "Reservation Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                if (sqlException.Number != 2627)
                {
                    MessageBox.Show(string.Concat("Error! \n", sqlException.ToString()), "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("Client ID already exist.", "Client ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                flag = false;
                return flag;
            }
            connection.Close();
            flag = true;
            return flag;
        }

        public void UpdateReservationRoom(string No, string Free)
        {
            string str = "UPDATE Room_Table SET Room_Free = @RoomFree WHERE Room_Number = @RoomNumber";
            SqlConnection connection = this.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@RoomNumber", SqlDbType.Int).Value = No;
            sqlCommand.Parameters.Add("@RoomFree", SqlDbType.VarChar).Value = Free;
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                MessageBox.Show(string.Concat("Error! \n", sqlException.ToString()), "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            connection.Close();
        }

        public bool UpdateRoom(string No, string Type, string Phone, string Free)
        {
            bool flag;
            string str = "UPDATE Room_Table SET Room_Type = @RoomType, Room_Phone = @RoomPhone, Room_Free = @RoomFree WHERE Room_Number = @RoomNumber";
            SqlConnection connection = this.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@RoomNumber", SqlDbType.Int).Value = No;
            sqlCommand.Parameters.Add("@RoomType", SqlDbType.VarChar).Value = Type;
            sqlCommand.Parameters.Add("@RoomPhone", SqlDbType.VarChar).Value = Phone;
            sqlCommand.Parameters.Add("@RoomFree", SqlDbType.VarChar).Value = Free;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!", "Room Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                if (sqlException.Number != 2627)
                {
                    MessageBox.Show(string.Concat("Error! \n", sqlException.ToString()), "Update Room", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("Phone No. already exist.", "Phone No.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                flag = false;
                return flag;
            }
            connection.Close();
            flag = true;
            return flag;
        }

        public bool UpdateUser(string ID, string Username, string Password)
        {
            bool flag;
            string str = "UPDATE User_Table SET User_Name = @UserName, User_Password = @UserPassword WHERE User_ID = @UserID";
            SqlConnection connection = this.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(str, connection)
            {
                CommandType = CommandType.Text
            };
            sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = ID;
            sqlCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = Username;
            sqlCommand.Parameters.Add("@UserPassword", SqlDbType.VarChar).Value = Password;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                if (sqlException.Number != 2627)
                {
                    MessageBox.Show(string.Concat("Error! \n", sqlException.ToString()), "Update User", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("Username already exist.", "Username", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                flag = false;
                return flag;
            }
            connection.Close();
            flag = true;
            return flag;
        }
    }
}