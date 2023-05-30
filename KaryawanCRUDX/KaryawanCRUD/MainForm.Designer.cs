/*
 * Created by SharpDevelop.
 * User: andramarkov
 * Date: 5/29/2023
 * Time: 1:43 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace KaryawanCRUD
{
	partial class MainForm
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
			this.txtNamaKaryawan1 = new System.Windows.Forms.TextBox();
			this.lblNmKaryawan1 = new System.Windows.Forms.Label();
			this.lblsdNamaKaryawan = new System.Windows.Forms.Label();
			this.txtNamaKaryawan2 = new System.Windows.Forms.TextBox();
			this.lblUsia = new System.Windows.Forms.Label();
			this.txtUsia1 = new System.Windows.Forms.TextBox();
			this.lblsdUsia = new System.Windows.Forms.Label();
			this.txtUsia2 = new System.Windows.Forms.TextBox();
			this.lblTglMasukKerja = new System.Windows.Forms.Label();
			this.dtTglMasukKerja1 = new System.Windows.Forms.DateTimePicker();
			this.dtTglMasukKerja2 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.dgvKaryawan = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvKaryawan)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNamaKaryawan1
			// 
			this.txtNamaKaryawan1.Location = new System.Drawing.Point(109, 26);
			this.txtNamaKaryawan1.Name = "txtNamaKaryawan1";
			this.txtNamaKaryawan1.Size = new System.Drawing.Size(145, 20);
			this.txtNamaKaryawan1.TabIndex = 0;
			// 
			// lblNmKaryawan1
			// 
			this.lblNmKaryawan1.Location = new System.Drawing.Point(13, 26);
			this.lblNmKaryawan1.Name = "lblNmKaryawan1";
			this.lblNmKaryawan1.Size = new System.Drawing.Size(90, 23);
			this.lblNmKaryawan1.TabIndex = 1;
			this.lblNmKaryawan1.Text = "Nama Karyawan";
			// 
			// lblsdNamaKaryawan
			// 
			this.lblsdNamaKaryawan.Location = new System.Drawing.Point(260, 26);
			this.lblsdNamaKaryawan.Name = "lblsdNamaKaryawan";
			this.lblsdNamaKaryawan.Size = new System.Drawing.Size(32, 23);
			this.lblsdNamaKaryawan.TabIndex = 2;
			this.lblsdNamaKaryawan.Text = "s/d";
			// 
			// txtNamaKaryawan2
			// 
			this.txtNamaKaryawan2.Location = new System.Drawing.Point(298, 26);
			this.txtNamaKaryawan2.Name = "txtNamaKaryawan2";
			this.txtNamaKaryawan2.Size = new System.Drawing.Size(145, 20);
			this.txtNamaKaryawan2.TabIndex = 3;
			// 
			// lblUsia
			// 
			this.lblUsia.Location = new System.Drawing.Point(13, 60);
			this.lblUsia.Name = "lblUsia";
			this.lblUsia.Size = new System.Drawing.Size(90, 23);
			this.lblUsia.TabIndex = 4;
			this.lblUsia.Text = "Usia";
			// 
			// txtUsia1
			// 
			this.txtUsia1.Location = new System.Drawing.Point(109, 57);
			this.txtUsia1.Name = "txtUsia1";
			this.txtUsia1.Size = new System.Drawing.Size(145, 20);
			this.txtUsia1.TabIndex = 5;
			// 
			// lblsdUsia
			// 
			this.lblsdUsia.Location = new System.Drawing.Point(260, 60);
			this.lblsdUsia.Name = "lblsdUsia";
			this.lblsdUsia.Size = new System.Drawing.Size(32, 23);
			this.lblsdUsia.TabIndex = 6;
			this.lblsdUsia.Text = "s/d";
			// 
			// txtUsia2
			// 
			this.txtUsia2.Location = new System.Drawing.Point(298, 57);
			this.txtUsia2.Name = "txtUsia2";
			this.txtUsia2.Size = new System.Drawing.Size(145, 20);
			this.txtUsia2.TabIndex = 7;
			// 
			// lblTglMasukKerja
			// 
			this.lblTglMasukKerja.Location = new System.Drawing.Point(13, 93);
			this.lblTglMasukKerja.Name = "lblTglMasukKerja";
			this.lblTglMasukKerja.Size = new System.Drawing.Size(90, 23);
			this.lblTglMasukKerja.TabIndex = 8;
			this.lblTglMasukKerja.Text = "Tgl Masuk Kerja";
			// 
			// dtTglMasukKerja1
			// 
			this.dtTglMasukKerja1.Location = new System.Drawing.Point(110, 90);
			this.dtTglMasukKerja1.Name = "dtTglMasukKerja1";
			this.dtTglMasukKerja1.Size = new System.Drawing.Size(144, 20);
			this.dtTglMasukKerja1.TabIndex = 9;
			// 
			// dtTglMasukKerja2
			// 
			this.dtTglMasukKerja2.Location = new System.Drawing.Point(299, 90);
			this.dtTglMasukKerja2.Name = "dtTglMasukKerja2";
			this.dtTglMasukKerja2.Size = new System.Drawing.Size(144, 20);
			this.dtTglMasukKerja2.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(261, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 23);
			this.label1.TabIndex = 11;
			this.label1.Text = "s/d";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(461, 26);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 12;
			this.btnSearch.Text = "SEARCH";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.BtnSearchClick);
			this.btnSearch.Leave += new System.EventHandler(this.BtnSearchLeave);
			// 
			// btnAddNew
			// 
			this.btnAddNew.Location = new System.Drawing.Point(13, 333);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(75, 23);
			this.btnAddNew.TabIndex = 14;
			this.btnAddNew.Text = "NEW";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.BtnAddNewClick);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(94, 333);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 15;
			this.btnEdit.Text = "EDIT";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(175, 333);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 16;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(261, 333);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 17;
			this.btnClose.Text = "CLOSE";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// dgvKaryawan
			// 
			this.dgvKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKaryawan.Location = new System.Drawing.Point(13, 119);
			this.dgvKaryawan.Name = "dgvKaryawan";
			this.dgvKaryawan.Size = new System.Drawing.Size(430, 208);
			this.dgvKaryawan.TabIndex = 18;
			this.dgvKaryawan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvKaryawanCellContentClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 373);
			this.Controls.Add(this.dgvKaryawan);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtTglMasukKerja2);
			this.Controls.Add(this.dtTglMasukKerja1);
			this.Controls.Add(this.lblTglMasukKerja);
			this.Controls.Add(this.txtUsia2);
			this.Controls.Add(this.lblsdUsia);
			this.Controls.Add(this.txtUsia1);
			this.Controls.Add(this.lblUsia);
			this.Controls.Add(this.txtNamaKaryawan2);
			this.Controls.Add(this.lblsdNamaKaryawan);
			this.Controls.Add(this.lblNmKaryawan1);
			this.Controls.Add(this.txtNamaKaryawan1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "KaryawanCRUD";
			this.Activated += new System.EventHandler(this.MainFormActivated);
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvKaryawan)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dgvKaryawan;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtTglMasukKerja2;
		private System.Windows.Forms.DateTimePicker dtTglMasukKerja1;
		private System.Windows.Forms.Label lblTglMasukKerja;
		private System.Windows.Forms.TextBox txtUsia2;
		private System.Windows.Forms.Label lblsdUsia;
		private System.Windows.Forms.TextBox txtUsia1;
		private System.Windows.Forms.Label lblUsia;
		private System.Windows.Forms.TextBox txtNamaKaryawan2;
		private System.Windows.Forms.Label lblsdNamaKaryawan;
		private System.Windows.Forms.Label lblNmKaryawan1;
		private System.Windows.Forms.TextBox txtNamaKaryawan1;
	}
}
