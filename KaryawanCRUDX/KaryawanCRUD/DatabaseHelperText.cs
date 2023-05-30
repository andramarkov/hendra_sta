///*
// * Created by SharpDevelop.
// * User: andramarkov
// * Date: 5/30/2023
// * Time: 1:09 AM
// * 
// * To change this template use Tools | Options | Coding | Edit Standard Headers.
// */
//using System;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Windows.Forms;
//
//namespace KaryawanCRUD {
//  /// <summary>
//  /// Description of DatabaseHelper.
//  /// </summary>
//  public class DatabaseHelperText {
//
//    private readonly string connectionString;
//    public DatabaseHelper(string connectionString) {
//      this.connectionString = connectionString;
//    }
//
//    public void CreateRecord(string name, int age) {
//      try {
//        using(SqlConnection connection = new SqlConnection(connectionString)) {
//          string query = "INSERT INTO tblKaryawan (Name, Age) VALUES (@Name, @Age)";
//
//          SqlCommand command = new SqlCommand(query, connection);
//          command.Parameters.AddWithValue("@Name", name);
//          command.Parameters.AddWithValue("@Age", age);
//
//          connection.Open();
//          command.ExecuteNonQuery();
//        }
//      }
//      catch(Exception ex) {
//        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//      }
//    }
//
//    public DataTable ReadRecords() {
//      try {
//        using(SqlConnection connection = new SqlConnection(connectionString)) {
//          string query = "SELECT * FROM tblKaryawan";
//
//          SqlCommand command = new SqlCommand(query, connection);
//          SqlDataAdapter adapter = new SqlDataAdapter(command);
//
//          DataTable dataTable = new DataTable();
//          adapter.Fill(dataTable);
//
//          return dataTable;
//        }
//      }
//      catch(Exception ex) {
//        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//      }
//
//      return null;
//    }
//
//    public void UpdateRecord(int id, string name, int age) {
//      try {
//        using(SqlConnection connection = new SqlConnection(connectionString)) {
//          string query = "UPDATE tblKaryawan SET Name = @Name, Age = @Age WHERE Id = @Id";
//
//          SqlCommand command = new SqlCommand(query, connection);
//          command.Parameters.AddWithValue("@Name", name);
//          command.Parameters.AddWithValue("@Age", age);
//          command.Parameters.AddWithValue("@Id", id);
//
//          connection.Open();
//          command.ExecuteNonQuery();
//        }
//      }
//      catch(Exception ex) {
//        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//      }
//    }
//
//    public void DeleteRecord(int id) {
//      try {
//        using(SqlConnection connection = new SqlConnection(connectionString)) {
//          string query = "DELETE FROM tblKaryawan WHERE Id = @Id";
//
//          SqlCommand command = new SqlCommand(query, connection);
//          command.Parameters.AddWithValue("@Id", id);
//
//          connection.Open();
//          command.ExecuteNonQuery();
//        }
//      }
//      catch(Exception ex) {
//        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//      }
//    }
//  }
//
//}