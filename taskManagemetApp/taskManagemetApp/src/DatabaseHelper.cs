using System;
using System.Collections.Generic;
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

    // データ変更（INSERT, UPDATE, DELETE）用（パラメータ無し）
    public void ExecuteIUDQuery(string query)
    {
        try
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
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    //データ変更（INSERT,DELETE,UPDATE）用（パラメータ有）
    public void ExecuteIUDQuery(string query, Dictionary<string, object> parameters)
    {
        try
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    foreach (var pair in parameters)
                    {
                        cmd.Parameters.AddWithValue($"@{pair.Key}", pair.Value ?? DBNull.Value);
                    }

                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // データ取得（SELECT）用
    public DataTable ExecuteSelectQuery(string query, Dictionary<string, object> parameters)
    {
        try
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            { 
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
                return dataTable;
            }
        }
        catch(Exception ex)
        {
            return null;
            Console.WriteLine(ex.Message);
        }
        
        
    }

}
