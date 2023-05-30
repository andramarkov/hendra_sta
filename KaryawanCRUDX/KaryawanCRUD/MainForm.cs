/*
 * Created by SharpDevelop.
 * User: andramarkov
 * Date: 5/29/2023
 * Time: 1:43 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace KaryawanCRUD {
  /// <summary>
  /// Description of MainForm.
  /// </summary>
  public partial class MainForm: Form {

    public static string IDKaryawan;
    public static string NmKaryawan;
    public static DateTime TglMasukKerja;
    public static int Usia;
    public static bool isEditMode;
    
    
    private const string connectionString = "Data Source=SVR2012R2VM;Initial Catalog=dbKaryawan;User ID=sa;Password=Aa123456#;";
    DatabaseHelper dbHelper = new DatabaseHelper(connectionString);
    UtilHelper utilHelper = new UtilHelper();

    public MainForm() {
      //
      // The InitializeComponent() call is required for Windows Forms designer support.
      //
      InitializeComponent();

      //
      // TODO: Add constructor code after the InitializeComponent() call.
      //
    }

    void BtnCloseClick(object sender, EventArgs e) {
      Application.Exit();
    }

    void MainFormLoad(object sender, EventArgs e) {

      dtTglMasukKerja1.Value = Convert.ToDateTime("2000-01-01");
      Font newFont = new Font("Calibri", 9f);
      utilHelper.ChangeFont(this, newFont);
      
      LoadGrid();

    }

    public void LoadGrid() {
      DataTable records = dbHelper.ReadRecords();
      if (records != null) {
        dgvKaryawan.DataSource = records;
        utilHelper.ConfigureDataGridView(dgvKaryawan);
      }

    }

    void BtnAddNewClick(object sender, EventArgs e) {

      isEditMode = false;
      FrmKaryawanAddEdit f = new FrmKaryawanAddEdit(this);
      f.ShowDialog();
    }

    void BtnEditClick(object sender, EventArgs e) {

      if (dgvKaryawan.SelectedRows.Count > 0) {

        IDKaryawan = dgvKaryawan.SelectedRows[0].Cells[0].Value.ToString();
        NmKaryawan = dgvKaryawan.SelectedRows[0].Cells[1].Value.ToString();
        TglMasukKerja = Convert.ToDateTime(dgvKaryawan.SelectedRows[0].Cells[2].Value);
        Usia = Convert.ToInt32(dgvKaryawan.SelectedRows[0].Cells[3].Value);
        isEditMode = true;

        FrmKaryawanAddEdit f = new FrmKaryawanAddEdit(this);
        f.ShowDialog();

      }
      else {
        MessageBox.Show("Harap pilih karyawan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

    }

    void BtnDeleteClick(object sender, EventArgs e) {

      if (dgvKaryawan.SelectedRows.Count > 0) {
        if (MessageBox.Show("Anda Yakin Ingin Menghapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
          IDKaryawan = dgvKaryawan.SelectedRows[0].Cells[0].Value.ToString();
          //MessageBox.Show(IDKaryawan);
          dbHelper.DeleteRecord(IDKaryawan);
          LoadGrid();

        }

      }
      else {
        MessageBox.Show("Harap pilih karyawan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

    }

    void DgvKaryawanCellContentClick(object sender, DataGridViewCellEventArgs e) {

}

    void MainFormActivated(object sender, EventArgs e) {
      //LoadGrid();
    }

    void BtnSearchClick(object sender, EventArgs e) {
      if (!string.IsNullOrWhiteSpace(txtNamaKaryawan1.Text) && !string.IsNullOrWhiteSpace(txtNamaKaryawan2.Text) && !string.IsNullOrWhiteSpace(txtUsia1.Text) && !string.IsNullOrWhiteSpace(txtUsia2.Text)) {

        string Nama1 = txtNamaKaryawan1.Text.Trim();
        string Nama2 = txtNamaKaryawan2.Text.Trim();
        DateTime Dt1 = dtTglMasukKerja1.Value.Date;
        DateTime Dt2 = dtTglMasukKerja2.Value.Date;
        int Usia1 = int.Parse(txtUsia1.Text.Trim());
        int Usia2 = int.Parse(txtUsia2.Text.Trim());

        DataTable search = dbHelper.Search(Nama1, Nama2, Usia1, Usia2, Dt1, Dt2);
        if (search != null) {
          dgvKaryawan.DataSource = search;
          utilHelper.ConfigureDataGridView(dgvKaryawan);
        }
      }
      else {
        MessageBox.Show("Data tidak lengkap.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

    }

    void BtnSearchLeave(object sender, EventArgs e) {
      LoadGrid();
      utilHelper.ClearControls(txtNamaKaryawan1, txtNamaKaryawan2, txtUsia1, txtUsia2, dtTglMasukKerja1, dtTglMasukKerja2);
    }
  }

}