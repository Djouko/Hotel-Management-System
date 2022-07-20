using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System
{
    class RoomClass
    {
        /* in this class we will manage rooms
         * we need first to create a category table for room_type (single,double,family,suit)
         * 
         */
        DBConnect connect = new DBConnect();

        //create a function to get a list of room's type

        public DataTable getRoomType()
        {
            string selectQuery = "SELECT * FROM `category`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //create a function to add a new room
        public bool addRoom(string no, int type, string phone, string status)
        {
            string insertQuerry = "INSERT INTO `rooms`(`room_no`, `room_type`, `phone`, `status`) VALUES (@no,@type,@ph,@sts)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@no,@type,@ph,@sts
            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = status;

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

        // Create a function to get a table of room's list
        public DataTable getRoomList()
        {
            string selectQuery = "SELECT * FROM `rooms`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        // create a function to edit/update a room
        public bool editRoom(string no, int type, string phone, string status)
        {
            string editQuerry = "UPDATE `rooms` SET `room_type`=@type,`phone`=@ph,`status`=@sts WHERE `room_no`=@no";
            MySqlCommand command = new MySqlCommand(editQuerry, connect.GetConnection());
            //@no,@type,@ph,@sts
            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = status;

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

        //create a function to remove a room
        //we only need the room no
        public bool removeRoom(string id)
        {
            string insertQuerry = "DELETE FROM `rooms` WHERE `room_no`=@id";
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

    }
}
