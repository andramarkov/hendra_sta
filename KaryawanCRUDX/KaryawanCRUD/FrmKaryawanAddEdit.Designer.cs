/*
 * Created by SharpDevelop.
 * User: andramarkov
 * Date: 5/29/2023
 * Time: 2:20 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace KaryawanCRUD
{
	partial class FrmKaryawanAddEdit
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblID = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.lblNmKaryawan = new System.Windows.Forms.Label();
			this.txtNamaKaryawan = new System.Windows.Forms.TextBox();
			this.lblTglMasukKerja = new System.Windows.Forms.Label();
			this.lblUsia = new System.Windows.Forms.Label();
			this.dtTglMasukKerja = new System.Windows.Forms.DateTimePicker();
			this.txtUsia = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblID
			// 
			this.lblID.Location = new System.Drawing.Point(12, 18);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(29, 23);
			this.lblID.TabIndex = 2;
			this.lblID.Text = "ID";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(80, 18);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(189, 20);
			this.txtID.TabIndex = 3;
			// 
			// lblNmKaryawan
			// 
			this.lblNmKaryawan.Location = new System.Drawing.Point(12, 41);
			this.lblNmKaryawan.Name = "lblNmKaryawan";
			this.lblNmKaryawan.Size = new System.Drawing.Size(90, 23);
			this.lblNmKaryawan.TabIndex = 4;
			this.lblNmKaryawan.Text = "Nama";
			// 
			// txtNamaKaryawan
			// 
			this.txtNamaKaryawan.Location = new System.Drawing.Point(80, 44);
			this.txtNamaKaryawan.Name = "txtNamaKaryawan";
			this.txtNamaKaryawan.Size = new System.Drawing.Size(189, 20);
			this.txtNamaKaryawan.TabIndex = 5;
			// 
			// lblTglMasukKerja
			// 
			this.lblTglMasukKerja.Location = new System.Drawing.Point(326, 16);
			this.lblTglMasukKerja.Name = "lblTglMasukKerja";
			this.lblTglMasukKerja.Size = new System.Drawing.Size(52, 23);
			this.lblTglMasukKerja.TabIndex = 6;
			this.lblTglMasukKerja.Text = "Nama";
			// 
			// lblUsia
			// 
			this.lblUsia.Location = new System.Drawing.Point(326, 42);
			this.lblUsia.Name = "lblUsia";
			this.lblUsia.Size = new System.Drawing.Size(52, 23);
			this.lblUsia.TabIndex = 7;
			this.lblUsia.Text = "Usia";
			// 
			// dtTglMasukKerja
			// 
			this.dtTglMasukKerja.Location = new System.Drawing.Point(370, 13);
			this.dtTglMasukKerja.Name = "dtTglMasukKerja";
			this.dtTglMasukKerja.Size = new System.Drawing.Size(177, 20);
			this.dtTglMasukKerja.TabIndex = 10;
			// 
			// txtUsia
			// 
			this.txtUsia.Location = new System.Drawing.Point(370, 43);
			this.txtUsia.Name = "txtUsia";
			this.txtUsia.Size = new System.Drawing.Size(177, 20);
			this.txtUsia.TabIndex = 11;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(370, 71);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 15;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// FrmKaryawanAddEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 123);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtUsia);
			this.Controls.Add(this.dtTglMasukKerja);
			this.Controls.Add(this.lblUsia);
			this.Controls.Add(this.lblTglMasukKerja);
			this.Controls.Add(this.txtNamaKaryawan);
			this.Controls.Add(this.lblNmKaryawan);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.lblID);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmKaryawanAddEdit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Tambah/Edit Karyawan";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmKaryawanAddEditFormClosed);
			this.Load += new System.EventHandler(this.FrmKaryawanAddEditLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtUsia;
		private System.Windows.Forms.DateTimePicker dtTglMasukKerja;
		private System.Windows.Forms.Label lblUsia;
		private System.Windows.Forms.Label lblTglMasukKerja;
		private System.Windows.Forms.TextBox txtNamaKaryawan;
		private System.Windows.Forms.Label lblNmKaryawan;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label lblID;
	}
}
