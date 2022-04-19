using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProyectoPrestamos.Interfaces;

namespace ProyectoPrestamos.DB
{
    public class Mysql
    {
        private static readonly Mysql _instance;

        private MySqlConnection conn = new MySqlConnection();
        private readonly string server = "bf1wytpoupha59bdb1r1-mysql.services.clever-cloud.com";
        private readonly string database = "bf1wytpoupha59bdb1r1";
        private readonly string uid = "uukq7o6wyodwasm6"; 
        private readonly string pwd = "MBil8MGYbkJJqiTVmU0w";

        public static Mysql Init()
        {
            return _instance == null ? new Mysql() : _instance;
        }

        private Mysql()
        {
            try
            {
                this.conn.ConnectionString = $"Server={ this.server };Database={ this.database };Uid={ this.uid };Pwd={ this.pwd };";
                this.conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool Insert(IEntidad objeto)
        {
            try
            {
                string query = $"INSERT INTO { objeto.toString()[0] } VALUES(NULL, { objeto.toString()[1] })";

                MySqlCommand cmd = new MySqlCommand(query, this.conn);
                cmd.ExecuteNonQuery();
                this.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // UPDATE - DELETE
        public bool Query(string sql)
        {
            // "UPDATE TABLE SET name='Joe', age='22' WHERE name='John Smith'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, this.conn);
                cmd.ExecuteNonQuery();
                this.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public MySqlDataReader Select(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, this.conn);
            MySqlDataReader data = cmd.ExecuteReader();
            return data;
        }

        public void Close()
        {
            try
            {
                this.conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
