/*
 * Created by SharpDevelop.
 * User: andramarkov
 * Date: 5/30/2023
 * Time: 1:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KaryawanCRUD {
  /// <summary>
  /// Description of UtilHelper.
  /// </summary>
  public class UtilHelper {
    public UtilHelper() {}

    public void ConfigureDataGridView(DataGridView dataGridView) {
      dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dataGridView.ReadOnly = true;
      dataGridView.AllowUserToAddRows = false;
      dataGridView.AllowUserToResizeRows = false;
      dataGridView.AllowUserToDeleteRows = false;
      dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
      dataGridView.RowHeadersVisible = false;
    }
    
    public void ClearControls(TextBox txtNamaKaryawan1, TextBox txtNamaKaryawan2, TextBox txtUsia1, TextBox txtUsia2, DateTimePicker dtTglMasukKerja1, DateTimePicker dtTglMasukKerja2)
    {
        txtNamaKaryawan1.Clear();
        txtNamaKaryawan2.Clear();
        txtUsia1.Clear();
        txtUsia2.Clear();
        dtTglMasukKerja1.Value = Convert.ToDateTime("2000-01-01");
        dtTglMasukKerja2.Value = DateTime.Today;
    }   

    public void ChangeFont(Control control, Font font)
    {
        control.Font = font;

        foreach (Control childControl in control.Controls)
        {
            ChangeFont(childControl, font);
        }
    }    


  }
}