namespace PTKS
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMaas = new System.Windows.Forms.TabPage();
            this.tabMesai = new System.Windows.Forms.TabPage();
            this.mesaiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTakipSistemiDataSet = new PTKS.PersonelTakipSistemiDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maasTableAdapter = new PTKS.PersonelTakipSistemiDataSetTableAdapters.MaasTableAdapter();
            this.tableAdapterManager = new PTKS.PersonelTakipSistemiDataSetTableAdapters.TableAdapterManager();
            this.hareketlerTableAdapter = new PTKS.PersonelTakipSistemiDataSetTableAdapters.HareketlerTableAdapter();
            this.mesaiTableAdapter = new PTKS.PersonelTakipSistemiDataSetTableAdapters.MesaiTableAdapter();
            this.hareketlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTakipSistemiDataSet2 = new PTKS.PersonelTakipSistemiDataSet2();
            this.maasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.maasTableAdapter1 = new PTKS.PersonelTakipSistemiDataSet2TableAdapters.MaasTableAdapter();
            this.tableAdapterManager1 = new PTKS.PersonelTakipSistemiDataSet2TableAdapters.TableAdapterManager();
            this.maasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabMaas.SuspendLayout();
            this.tabMesai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesaiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTakipSistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTakipSistemiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMaas);
            this.tabControl1.Controls.Add(this.tabMesai);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMaas
            // 
            this.tabMaas.AutoScroll = true;
            this.tabMaas.Controls.Add(this.maasDataGridView);
            this.tabMaas.Location = new System.Drawing.Point(4, 22);
            this.tabMaas.Name = "tabMaas";
            this.tabMaas.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaas.Size = new System.Drawing.Size(882, 431);
            this.tabMaas.TabIndex = 0;
            this.tabMaas.Text = "Maas";
            this.tabMaas.UseVisualStyleBackColor = true;
            this.tabMaas.Click += new System.EventHandler(this.tabMaas_Click);
            // 
            // tabMesai
            // 
            this.tabMesai.AutoScroll = true;
            this.tabMesai.Controls.Add(this.mesaiDataGridView);
            this.tabMesai.Location = new System.Drawing.Point(4, 22);
            this.tabMesai.Name = "tabMesai";
            this.tabMesai.Padding = new System.Windows.Forms.Padding(3);
            this.tabMesai.Size = new System.Drawing.Size(882, 431);
            this.tabMesai.TabIndex = 1;
            this.tabMesai.Text = "Mesai";
            this.tabMesai.UseVisualStyleBackColor = true;
            // 
            // mesaiDataGridView
            // 
            this.mesaiDataGridView.AutoGenerateColumns = false;
            this.mesaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mesaiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.mesaiDataGridView.DataSource = this.mesaiBindingSource;
            this.mesaiDataGridView.Location = new System.Drawing.Point(20, 196);
            this.mesaiDataGridView.Name = "mesaiDataGridView";
            this.mesaiDataGridView.Size = new System.Drawing.Size(840, 220);
            this.mesaiDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MesaiID";
            this.dataGridViewTextBoxColumn7.HeaderText = "MesaiID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Tarih";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tarih";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PerID";
            this.dataGridViewTextBoxColumn9.HeaderText = "PerID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Ad";
            this.dataGridViewTextBoxColumn10.HeaderText = "Ad";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Soyad";
            this.dataGridViewTextBoxColumn11.HeaderText = "Soyad";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Başlama";
            this.dataGridViewTextBoxColumn12.HeaderText = "Başlama";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Bitis";
            this.dataGridViewTextBoxColumn13.HeaderText = "Bitis";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ToplamSaat";
            this.dataGridViewTextBoxColumn14.HeaderText = "ToplamSaat";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // mesaiBindingSource
            // 
            this.mesaiBindingSource.DataMember = "Mesai";
            this.mesaiBindingSource.DataSource = this.personelTakipSistemiDataSet;
            // 
            // personelTakipSistemiDataSet
            // 
            this.personelTakipSistemiDataSet.DataSetName = "PersonelTakipSistemiDataSet";
            this.personelTakipSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Aylar";
            this.dataGridViewTextBoxColumn1.HeaderText = "Aylar";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Prim";
            this.dataGridViewTextBoxColumn2.HeaderText = "Prim";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sigorta";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sigorta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Maas";
            this.dataGridViewTextBoxColumn4.HeaderText = "Maas";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Kesinti";
            this.dataGridViewTextBoxColumn5.HeaderText = "Kesinti";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MaasID";
            this.dataGridViewTextBoxColumn6.HeaderText = "MaasID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // maasBindingSource
            // 
            this.maasBindingSource.DataMember = "Maas";
            this.maasBindingSource.DataSource = this.personelTakipSistemiDataSet;
            // 
            // maasTableAdapter
            // 
            this.maasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgiTableAdapter = null;
            this.tableAdapterManager.AylarTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BirimlerTableAdapter = null;
            this.tableAdapterManager.DepartmanlarTableAdapter = null;
            this.tableAdapterManager.HareketlerTableAdapter = this.hareketlerTableAdapter;
            this.tableAdapterManager.KartlarTableAdapter = null;
            this.tableAdapterManager.KartYetkiTableAdapter = null;
            this.tableAdapterManager.KullanıcılarTableAdapter = null;
            this.tableAdapterManager.KullanıcıListesiTableAdapter = null;
            this.tableAdapterManager.MaasTableAdapter = this.maasTableAdapter;
            this.tableAdapterManager.MesaiTableAdapter = this.mesaiTableAdapter;
            this.tableAdapterManager.PersonelTableAdapter = null;
            this.tableAdapterManager.TarihTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PTKS.PersonelTakipSistemiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hareketlerTableAdapter
            // 
            this.hareketlerTableAdapter.ClearBeforeFill = true;
            // 
            // mesaiTableAdapter
            // 
            this.mesaiTableAdapter.ClearBeforeFill = true;
            // 
            // hareketlerBindingSource
            // 
            this.hareketlerBindingSource.DataMember = "Hareketler";
            this.hareketlerBindingSource.DataSource = this.personelTakipSistemiDataSet;
            // 
            // personelTakipSistemiDataSet2
            // 
            this.personelTakipSistemiDataSet2.DataSetName = "PersonelTakipSistemiDataSet2";
            this.personelTakipSistemiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maasBindingSource1
            // 
            this.maasBindingSource1.DataMember = "Maas";
            this.maasBindingSource1.DataSource = this.personelTakipSistemiDataSet2;
            // 
            // maasTableAdapter1
            // 
            this.maasTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AgiTableAdapter = null;
            this.tableAdapterManager1.AylarTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BirimlerTableAdapter = null;
            this.tableAdapterManager1.DepartmanlarTableAdapter = null;
            this.tableAdapterManager1.HareketlerTableAdapter = null;
            this.tableAdapterManager1.KartlarTableAdapter = null;
            this.tableAdapterManager1.KartYetkiTableAdapter = null;
            this.tableAdapterManager1.KullanıcılarTableAdapter = null;
            this.tableAdapterManager1.KullanıcıListesiTableAdapter = null;
            this.tableAdapterManager1.Maas2TableAdapter = null;
            this.tableAdapterManager1.MaasTableAdapter = this.maasTableAdapter1;
            this.tableAdapterManager1.MesaiTableAdapter = null;
            this.tableAdapterManager1.PersonelTableAdapter = null;
            this.tableAdapterManager1.TarihTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = PTKS.PersonelTakipSistemiDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maasDataGridView
            // 
            this.maasDataGridView.AutoGenerateColumns = false;
            this.maasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.maasDataGridView.DataSource = this.maasBindingSource1;
            this.maasDataGridView.Location = new System.Drawing.Point(46, 285);
            this.maasDataGridView.Name = "maasDataGridView";
            this.maasDataGridView.Size = new System.Drawing.Size(744, 113);
            this.maasDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "MaasID";
            this.dataGridViewTextBoxColumn15.HeaderText = "MaasID";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "PerID";
            this.dataGridViewTextBoxColumn16.HeaderText = "PerID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Aylar";
            this.dataGridViewTextBoxColumn17.HeaderText = "Aylar";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Prim";
            this.dataGridViewTextBoxColumn18.HeaderText = "Prim";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Mesai";
            this.dataGridViewTextBoxColumn19.HeaderText = "Mesai";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Kesinti";
            this.dataGridViewTextBoxColumn20.HeaderText = "Kesinti";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Maas";
            this.dataGridViewTextBoxColumn21.HeaderText = "Maas";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 521);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMaas.ResumeLayout(false);
            this.tabMesai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mesaiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTakipSistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTakipSistemiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMaas;
        private System.Windows.Forms.TabPage tabMesai;
        private PersonelTakipSistemiDataSet personelTakipSistemiDataSet;
        private System.Windows.Forms.BindingSource maasBindingSource;
        private PersonelTakipSistemiDataSetTableAdapters.MaasTableAdapter maasTableAdapter;
        private PersonelTakipSistemiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private PersonelTakipSistemiDataSetTableAdapters.HareketlerTableAdapter hareketlerTableAdapter;
        private System.Windows.Forms.BindingSource hareketlerBindingSource;
        private PersonelTakipSistemiDataSetTableAdapters.MesaiTableAdapter mesaiTableAdapter;
        private System.Windows.Forms.BindingSource mesaiBindingSource;
        private System.Windows.Forms.DataGridView mesaiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private PersonelTakipSistemiDataSet2 personelTakipSistemiDataSet2;
        private System.Windows.Forms.BindingSource maasBindingSource1;
        private PersonelTakipSistemiDataSet2TableAdapters.MaasTableAdapter maasTableAdapter1;
        private PersonelTakipSistemiDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView maasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    }
}