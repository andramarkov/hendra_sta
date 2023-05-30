/*
 * Created by SharpDevelop.
 * User: andramarkov
 * Date: 5/30/2023
 * Time: 1:09 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace KaryawanCRUD {
  /// <summary>
  /// Description of DatabaseHelper.
  /// </summary>
  public class DatabaseHelper {

    private readonly string connectionString;
    public DatabaseHelper(string connectionString) {
      this.connectionString = connectionString;
    }

    public void CreateRecord(string ID, string Nama, DateTime TglMasukKerja, int Usia) {
      try {
        using(SqlConnection connection = new SqlConnection(connectionString)) {
          string query = "INSERT INTO tblKaryawan (IDKaryawan, NmKaryawan, TglMasukKerja, Usia) VALUES (@IDKaryawan, @NmKaryawan, @TglMasukKerja, @Usia)";

          SqlCommand command = new SqlCommand(query, connection);
          command.Parameters.AddWithValue("@IDKaryawan", ID);
          command.Parameters.AddWithValue("@NmKaryawan", Nama);
          command.Parameters.AddWithValue("@TglMasukKerja", TglMasukKerja.Date);
          command.Parameters.AddWithValue("@Usia", Usia);

          connection.Open();
          command.ExecuteNonQuery();
        }
      }
      catch(Exception ex) {
        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public DataTable ReadRecords() {
      try {
        using(SqlConnection connection = new SqlConnection(connectionString)) {
          string query = "SELECT * FROM tblKaryawan";

          SqlCommand command = new SqlCommand(query, connection);
          SqlDataAdapter adapter = new SqlDataAdapter(command);

          DataTable dataTable = new DataTable();
          adapter.Fill(dataTable);

          return dataTable;
        }
      }
      catch(Exception ex) {
        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      return null;
    }

    public void UpdateRecord(string IDKaryawan, string Nama, DateTime TglMasukKerja, int Usia) {
      try {
        using(SqlConnection connection = new SqlConnection(connectionString)) {
          string query = "UPDATE tblKaryawan SET NmKaryawan = @NmKaryawan, TglMasukKerja = @TglMasukKerja, Usia = @Usia WHERE IDKaryawan = @IDKaryawan";

          SqlCommand command = new SqlCommand(query, connection);
          command.Parameters.AddWithValue("@NmKaryawan", Nama);
          command.Parameters.AddWithValue("@TglMasukKerja", TglMasukKerja.Date);
          command.Parameters.AddWithValue("@Usia", Usia);
          command.Parameters.AddWithValue("@IDKaryawan", IDKaryawan);

          connection.Open();
          command.ExecuteNonQuery();
        }
      }
      catch(Exception ex) {
        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public void DeleteRecord(string IDKaryawan) {
      try {
        using(SqlConnection connection = new SqlConnection(connectionString)) {
          string query = "DELETE FROM tblKaryawan WHERE IDKaryawan = @IDKaryawan";

          SqlCommand command = new SqlCommand(query, connection);
          command.Parameters.AddWithValue("@IDKaryawan", IDKaryawan);

          connection.Open();
          command.ExecuteNonQuery();
        }
      }
      catch(Exception ex) {
        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public DataTable Search(string Nama1, string Nama2, int Usia1, int Usia2, DateTime Dt1, DateTime Dt2) {
      try {

        StringBuilder queryBuilder = new StringBuilder("SELECT * FROM tblKaryawan WHERE 1 = 1");
        if (!string.IsNullOrWhiteSpace(Nama1)) queryBuilder.Append(" AND (NmKaryawan LIKE @Nama1");
        if (!string.IsNullOrWhiteSpace(Nama2)) queryBuilder.Append(" OR NmKaryawan LIKE @Nama2)");
        queryBuilder.Append(" AND Usia >= @Usia1");
        queryBuilder.Append(" AND Usia <= @Usia2");
        queryBuilder.Append(" AND (TglMasukKerja BETWEEN @Dt1 AND @Dt2) ORDER BY CASE WHEN NmKaryawan like @Nama1 then 0 else 1 end, NmKaryawan");

        string queryString = queryBuilder.ToString();

        using(SqlConnection connection = new SqlConnection(connectionString)) {
          SqlCommand command = new SqlCommand(queryString, connection);
          command.Parameters.AddWithValue("@Nama1", Nama1 + "%");
          command.Parameters.AddWithValue("@Nama2", Nama2 + "%");
          command.Parameters.AddWithValue("@Dt1", Dt1);
          command.Parameters.AddWithValue("@Dt2", Dt2);
          command.Parameters.AddWithValue("@Usia1", Usia1);
          command.Parameters.AddWithValue("@Usia2", Usia2);

          SqlDataAdapter adapter = new SqlDataAdapter(command);
          DataTable dataTable = new DataTable();
          adapter.Fill(dataTable);

          return dataTable;
        }
      }
      catch(Exception ex) {
        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      return null;
    }

    public bool EmployeeExists(string IDKaryawan) {
      try {
        using(SqlConnection connection = new SqlConnection(connectionString)) {
          string query = "SELECT COUNT(*) FROM tblKaryawan WHERE IDKaryawan = @IDKaryawan";
          SqlCommand command = new SqlCommand(query, connection);
          command.Parameters.AddWithValue("@IDKaryawan", IDKaryawan);

          connection.Open();
          int count = (int) command.ExecuteScalar();

          return count > 0;
        }
      }
      catch(Exception ex) {
        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }

    }

  }

}