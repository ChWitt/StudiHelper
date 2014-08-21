namespace StudiHelper.UI
{
  partial class CursView
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.deleteLessons = new System.Windows.Forms.Button();
      this.deleteCurs = new System.Windows.Forms.Button();
      this.loadOfCurs = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.CursCombobox = new System.Windows.Forms.ComboBox();
      this.ModuleCombobox = new System.Windows.Forms.ComboBox();
      this.lessonOfCurs = new StudiHelper.UI.Components.StudiHelperDataGrid(this.components);
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dateGridColumn2 = new StudiHelper.UI.Components.DateGridColumn();
      this.timeGridColumn3 = new StudiHelper.UI.Components.TimeGridColumn();
      this.timeGridColumn4 = new StudiHelper.UI.Components.TimeGridColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dateGridColumn1 = new StudiHelper.UI.Components.DateGridColumn();
      this.timeGridColumn1 = new StudiHelper.UI.Components.TimeGridColumn();
      this.timeGridColumn2 = new StudiHelper.UI.Components.TimeGridColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cursInfo = new System.Windows.Forms.Button();
      this.moduleInfo = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.lessonOfCurs)).BeginInit();
      this.SuspendLayout();
      // 
      // deleteLessons
      // 
      this.deleteLessons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.deleteLessons.Location = new System.Drawing.Point(670, 32);
      this.deleteLessons.Name = "deleteLessons";
      this.deleteLessons.Size = new System.Drawing.Size(181, 23);
      this.deleteLessons.TabIndex = 15;
      this.deleteLessons.Text = "markierte Vorlesungen löschen";
      this.deleteLessons.UseVisualStyleBackColor = true;
      this.deleteLessons.Click += new System.EventHandler(this.deleteLessons_Click);
      // 
      // deleteCurs
      // 
      this.deleteCurs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.deleteCurs.Location = new System.Drawing.Point(670, 7);
      this.deleteCurs.Name = "deleteCurs";
      this.deleteCurs.Size = new System.Drawing.Size(181, 23);
      this.deleteCurs.TabIndex = 14;
      this.deleteCurs.Text = "Kurs löschen";
      this.deleteCurs.UseVisualStyleBackColor = true;
      this.deleteCurs.Click += new System.EventHandler(this.deleteCurs_Click);
      // 
      // loadOfCurs
      // 
      this.loadOfCurs.Location = new System.Drawing.Point(200, 5);
      this.loadOfCurs.Name = "loadOfCurs";
      this.loadOfCurs.Size = new System.Drawing.Size(64, 50);
      this.loadOfCurs.TabIndex = 13;
      this.loadOfCurs.Text = "Laden";
      this.loadOfCurs.UseVisualStyleBackColor = true;
      this.loadOfCurs.Click += new System.EventHandler(this.loadOfCurs_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 37);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(31, 13);
      this.label2.TabIndex = 11;
      this.label2.Text = "Kurs:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Modul:";
      // 
      // CursCombobox
      // 
      this.CursCombobox.FormattingEnabled = true;
      this.CursCombobox.Location = new System.Drawing.Point(73, 34);
      this.CursCombobox.Name = "CursCombobox";
      this.CursCombobox.Size = new System.Drawing.Size(121, 21);
      this.CursCombobox.TabIndex = 9;
      // 
      // ModuleCombobox
      // 
      this.ModuleCombobox.FormattingEnabled = true;
      this.ModuleCombobox.Location = new System.Drawing.Point(73, 7);
      this.ModuleCombobox.Name = "ModuleCombobox";
      this.ModuleCombobox.Size = new System.Drawing.Size(121, 21);
      this.ModuleCombobox.TabIndex = 8;
      this.ModuleCombobox.SelectedIndexChanged += new System.EventHandler(this.ModuleCombobox_SelectedIndexChanged);
      // 
      // lessonOfCurs
      // 
      this.lessonOfCurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lessonOfCurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.lessonOfCurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dateGridColumn2,
            this.timeGridColumn3,
            this.timeGridColumn4,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dateGridColumn1,
            this.timeGridColumn1,
            this.timeGridColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
      this.lessonOfCurs.Location = new System.Drawing.Point(12, 61);
      this.lessonOfCurs.Name = "lessonOfCurs";
      this.lessonOfCurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.lessonOfCurs.Size = new System.Drawing.Size(839, 302);
      this.lessonOfCurs.TabIndex = 12;
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "cursName";
      this.dataGridViewTextBoxColumn6.HeaderText = "Nummer";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.ReadOnly = true;
      this.dataGridViewTextBoxColumn6.Width = 50;
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.DataPropertyName = "cursDescription";
      this.dataGridViewTextBoxColumn7.HeaderText = "Beschreibung";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      this.dataGridViewTextBoxColumn7.ReadOnly = true;
      this.dataGridViewTextBoxColumn7.Width = 170;
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.DataPropertyName = "modul";
      this.dataGridViewTextBoxColumn8.HeaderText = "Modul";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.ReadOnly = true;
      this.dataGridViewTextBoxColumn8.Width = 150;
      // 
      // dateGridColumn2
      // 
      this.dateGridColumn2.DataPropertyName = "start";
      this.dateGridColumn2.HeaderText = "Datum";
      this.dateGridColumn2.Name = "dateGridColumn2";
      this.dateGridColumn2.ReadOnly = true;
      this.dateGridColumn2.Width = 70;
      // 
      // timeGridColumn3
      // 
      this.timeGridColumn3.DataPropertyName = "start";
      this.timeGridColumn3.HeaderText = "Start";
      this.timeGridColumn3.Name = "timeGridColumn3";
      this.timeGridColumn3.ReadOnly = true;
      this.timeGridColumn3.Width = 50;
      // 
      // timeGridColumn4
      // 
      this.timeGridColumn4.DataPropertyName = "end";
      this.timeGridColumn4.HeaderText = "Ende";
      this.timeGridColumn4.Name = "timeGridColumn4";
      this.timeGridColumn4.ReadOnly = true;
      this.timeGridColumn4.Width = 50;
      // 
      // dataGridViewTextBoxColumn9
      // 
      this.dataGridViewTextBoxColumn9.DataPropertyName = "building";
      this.dataGridViewTextBoxColumn9.HeaderText = "Ort";
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      this.dataGridViewTextBoxColumn9.ReadOnly = true;
      this.dataGridViewTextBoxColumn9.Width = 70;
      // 
      // dataGridViewTextBoxColumn10
      // 
      this.dataGridViewTextBoxColumn10.DataPropertyName = "tutor";
      this.dataGridViewTextBoxColumn10.HeaderText = "Dozent";
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
      this.dataGridViewTextBoxColumn10.ReadOnly = true;
      this.dataGridViewTextBoxColumn10.Width = 150;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "cursName";
      this.dataGridViewTextBoxColumn1.HeaderText = "Nummer";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 50;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "cursDescription";
      this.dataGridViewTextBoxColumn2.HeaderText = "Beschreibung";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "modul";
      this.dataGridViewTextBoxColumn3.HeaderText = "Modul";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Width = 150;
      // 
      // dateGridColumn1
      // 
      this.dateGridColumn1.DataPropertyName = "start";
      this.dateGridColumn1.HeaderText = "Datum";
      this.dateGridColumn1.Name = "dateGridColumn1";
      this.dateGridColumn1.ReadOnly = true;
      this.dateGridColumn1.Width = 70;
      // 
      // timeGridColumn1
      // 
      this.timeGridColumn1.DataPropertyName = "start";
      this.timeGridColumn1.HeaderText = "Start";
      this.timeGridColumn1.Name = "timeGridColumn1";
      this.timeGridColumn1.ReadOnly = true;
      this.timeGridColumn1.Width = 50;
      // 
      // timeGridColumn2
      // 
      this.timeGridColumn2.DataPropertyName = "end";
      this.timeGridColumn2.HeaderText = "Ende";
      this.timeGridColumn2.Name = "timeGridColumn2";
      this.timeGridColumn2.ReadOnly = true;
      this.timeGridColumn2.Width = 50;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "BuildingName";
      this.dataGridViewTextBoxColumn4.HeaderText = "Ort";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Width = 70;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "tutor";
      this.dataGridViewTextBoxColumn5.HeaderText = "Dozent";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      // 
      // cursInfo
      // 
      this.cursInfo.Location = new System.Drawing.Point(269, 33);
      this.cursInfo.Name = "cursInfo";
      this.cursInfo.Size = new System.Drawing.Size(75, 23);
      this.cursInfo.TabIndex = 17;
      this.cursInfo.Text = "Kurs Info";
      this.cursInfo.UseVisualStyleBackColor = true;
      this.cursInfo.Click += new System.EventHandler(this.cursInfo_Click);
      // 
      // moduleInfo
      // 
      this.moduleInfo.Location = new System.Drawing.Point(270, 5);
      this.moduleInfo.Name = "moduleInfo";
      this.moduleInfo.Size = new System.Drawing.Size(75, 23);
      this.moduleInfo.TabIndex = 16;
      this.moduleInfo.Text = "Modul Info";
      this.moduleInfo.UseVisualStyleBackColor = true;
      this.moduleInfo.Click += new System.EventHandler(this.moduleInfo_Click);
      // 
      // CursView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.cursInfo);
      this.Controls.Add(this.moduleInfo);
      this.Controls.Add(this.deleteLessons);
      this.Controls.Add(this.deleteCurs);
      this.Controls.Add(this.loadOfCurs);
      this.Controls.Add(this.lessonOfCurs);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.CursCombobox);
      this.Controls.Add(this.ModuleCombobox);
      this.Name = "CursView";
      this.Size = new System.Drawing.Size(861, 377);
      this.Load += new System.EventHandler(this.CursView_Load);
      ((System.ComponentModel.ISupportInitialize)(this.lessonOfCurs)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button deleteLessons;
    private System.Windows.Forms.Button deleteCurs;
    private System.Windows.Forms.Button loadOfCurs;
    private StudiHelper.UI.Components.StudiHelperDataGrid lessonOfCurs;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox CursCombobox;
    private System.Windows.Forms.ComboBox ModuleCombobox;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private Components.DateGridColumn dateGridColumn1;
    private Components.TimeGridColumn timeGridColumn1;
    private Components.TimeGridColumn timeGridColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private Components.DateGridColumn dateGridColumn2;
    private Components.TimeGridColumn timeGridColumn3;
    private Components.TimeGridColumn timeGridColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private System.Windows.Forms.Button cursInfo;
    private System.Windows.Forms.Button moduleInfo;
  }
}
