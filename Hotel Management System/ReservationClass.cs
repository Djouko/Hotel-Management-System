using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System
{
    //in this class reservation function

    class ReservationClass
    {
        DBConnect connect = new DBConnect();

        public DataTable roomByType(int type)
        {
            string selectQuery = "SELECT * FROM `rooms` WHERE `room_type`=@type AND `status` ='Free'";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
            
        }

        // to get room type by room no 
        // room type is int
        public int typeByRoomNo(string rno)
        {
            string selectQuery = "SELECT `room_type` FROM `rooms` WHERE `room_no`=@rno";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            command.Parameters.Add("@rno", MySqlDbType.VarChar).Value = rno;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return Convert.ToInt32(table.Rows[0][0].ToString());

        }
        //To get Reservation Table
        public DataTable getReserv()
        {
            string selectQuery = "SELECT * FROM `reservation`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        //Room status is change if room reserve
        public bool setReservRoom(string rno, string sts)
        {
            string updateQuery = "UPDATE `rooms` SET `status`=@sts WHERE `room_no`=@rno";
            MySqlCommand command = new MySqlCommand(updateQuery, connect.GetConnection());

            command.Parameters.Add("@rno", MySqlDbType.VarChar).Value = rno;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = sts;
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }

        // To create a reservataion add
        public bool addReserv(string guestId, string roomNo, DateTime dateIn, DateTime dateOut)
        {
            string insertQuerry = "INSERT INTO `reservation`(`client_id`, `room_no`, `date_in`, `date_out`) VALUES (@Gid,@Rno,@Din,@Dout)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@Gid,@Rno,@Din,@Dout
            
            command.Parameters.Add("@Gid", MySqlDbType.VarChar).Value = guestId;
            command.Parameters.Add("@Rno", MySqlDbType.VarChar).Value = roomNo;
            command.Parameters.Add("@Din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@Dout", MySqlDbType.Date).Value = dateOut;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }

        //to create a function for reserv delete
        public bool removeReserv(int id)
        {
            string insertQuerry = "DELETE FROM `reservation` WHERE `reserv_id`=@id";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@id
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }
        // to create a function for edit reservation
        public bool editReserv(int reserId,string guestId, string roomNo, DateTime dateIn, DateTime dateOut)
        {
            string insertQuerry = "UPDATE `reservation` SET `client_id`=@Gid,`room_no`=@Rno,`date_in`=@Din,`date_out`=@Dout WHERE `reserv_id`=@rid";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@rid@Gid,@Rno,@Din,@Dout
            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = reserId;
            command.Parameters.Add("@Gid", MySqlDbType.VarChar).Value = guestId;
            command.Parameters.Add("@Rno", MySqlDbType.VarChar).Value = roomNo;
            command.Parameters.Add("@Din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@Dout", MySqlDbType.Date).Value = dateOut;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }
    }
}