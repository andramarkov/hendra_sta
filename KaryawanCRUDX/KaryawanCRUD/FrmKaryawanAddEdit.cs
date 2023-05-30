/*
 * Created by SharpDevelop.
 * User: andramarkov
 * Date: 5/29/2023
 * Time: 2:20 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace KaryawanCRUD {
  /// <summary>
  /// Description of FrmKaryawanAddEdit.
  /// </summary>
  public partial class FrmKaryawanAddEdit: Form {

    private MainForm mainForm;
  	private const string connectionString = "Data Source=SVR2012R2VM;Initial Catalog=dbKaryawan;User ID=sa;Password=Aa123456#;";
    DatabaseHelper dbHelper = new DatabaseHelper(connectionString);
    UtilHelper utilHelper = new UtilHelper();

    public FrmKaryawanAddEdit(MainForm mainForm) {
      //
      // The InitializeComponent() call is required for Windows Forms designer support.
      //
      InitializeComponent();
      this.mainForm = mainForm;

      //
      // TODO: Add constructor code after the InitializeComponent() call.
      //
    }

    void FrmKaryawanAddEditLoad(object sender, EventArgs e) {

      if (MainForm.isEditMode == true) {
        txtID.Enabled = false;
        txtID.Text = MainForm.IDKaryawan.ToString();
        txtNamaKaryawan.Text = MainForm.NmKaryawan.ToString();
        dtTglMasukKerja.Text = MainForm.TglMasukKerja.ToString();
        txtUsia.Text = MainForm.Usia.ToString();
      }
    	
        Font newFont = new Font("Calibri", 9f);
        utilHelper.ChangeFont(this, newFont);

    }


    void BtnSaveClick(object sender, EventArgs e) {
      if (MainForm.isEditMode == true) {
        //MessageBox.Show("edit mode");

        if (!string.IsNullOrWhiteSpace(txtID.Text) && !string.IsNullOrWhiteSpace(txtUsia.Text) && !string.IsNullOrWhiteSpace(txtNamaKaryawan.Text)) {
          string IDKaryawan = txtID.Text;
          string NmKaryawan = txtNamaKaryawan.Text;
          DateTime TglMasukKerja = dtTglMasukKerja.Value;
          //int Usia = Convert.ToInt32(txtUsia.Text);
          int Usia = int.Parse(txtUsia.Text);
          dbHelper.UpdateRecord(IDKaryawan, NmKaryawan, TglMasukKerja, Usia);
        }
        else {
          MessageBox.Show("Data tidak lengkap.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

         
        this.Close();

      }
      else {
        if (!dbHelper.EmployeeExists(txtID.Text)) {
          //MessageBox.Show("add mode");
          if (!string.IsNullOrWhiteSpace(txtID.Text) && !string.IsNullOrWhiteSpace(txtUsia.Text) && !string.IsNullOrWhiteSpace(txtNamaKaryawan.Text)) {
            string IDKaryawan = txtID.Text;
            string NmKaryawan = txtNamaKaryawan.Text;
            DateTime TglMasukKerja = dtTglMasukKerja.Value;
            //int Usia = Convert.ToInt32(txtUsia.Text);
            int Usia = int.Parse(txtUsia.Text);

            dbHelper.CreateRecord(IDKaryawan, NmKaryawan, TglMasukKerja, Usia);
          }
          else {
            MessageBox.Show("Data tidak lengkap.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
          this.Close();

        }
        else {
          MessageBox.Show("Nomor ID Sudah Ada, Masukkan Nomor Lain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

      }

    }

		
		void FrmKaryawanAddEditFormClosed(object sender, FormClosedEventArgs e)
		{
			mainForm.LoadGrid();
		}
  }
}