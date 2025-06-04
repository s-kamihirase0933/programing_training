using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

public class DatabaseHelper
{
    private readonly string _connectionString;

    public DatabaseHelper(string connectionString)
    {
        _connectionString = connectionString;
    }

    // データ変更（INSERT, UPDATE, DELETE）用
    public void ExecuteIUDQuery(string query)
    {
        using (MySqlConnection conn = new MySqlConnection(_connectionString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }

    // データ取得（SELECT）用
    public DataTable ExecuteSelectQuery(string query)
    {
        using (MySqlConnection conn = new MySqlConnection(_connectionString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }

}
