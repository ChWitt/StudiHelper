namespace StudiHelper.UI
{
  partial class DayView
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
      this.LessonsOfDay = new StudiHelper.UI.Components.StudiHelperDataGrid();
      this.loadLessonsOfDay = new System.Windows.Forms.Button();
      this.DayPickerDay = new System.Windows.Forms.DateTimePicker();
      ((System.ComponentModel.ISupportInitialize)(this.LessonsOfDay)).BeginInit();
      this.SuspendLayout();
      // 
      // LessonsOfDay
      // 
      this.LessonsOfDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.LessonsOfDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.LessonsOfDay.Location = new System.Drawing.Point(13, 37);
      this.LessonsOfDay.Name = "LessonsOfDay";
      this.LessonsOfDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.LessonsOfDay.Size = new System.Drawing.Size(717, 261);
      this.LessonsOfDay.TabIndex = 6;
      // 
      // loadLessonsOfDay
      // 
      this.loadLessonsOfDay.Location = new System.Drawing.Point(219, 8);
      this.loadLessonsOfDay.Name = "loadLessonsOfDay";
      this.loadLessonsOfDay.Size = new System.Drawing.Size(138, 23);
      this.loadLessonsOfDay.TabIndex = 5;
      this.loadLessonsOfDay.Text = "Laden";
      this.loadLessonsOfDay.UseVisualStyleBackColor = true;
      this.loadLessonsOfDay.Click += new System.EventHandler(this.loadLessonsOfDay_Click);
      // 
      // DayPickerDay
      // 
      this.DayPickerDay.Location = new System.Drawing.Point(13, 8);
      this.DayPickerDay.Name = "DayPickerDay";
      this.DayPickerDay.Size = new System.Drawing.Size(200, 20);
      this.DayPickerDay.TabIndex = 4;
      // 
      // DayView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.LessonsOfDay);
      this.Controls.Add(this.loadLessonsOfDay);
      this.Controls.Add(this.DayPickerDay);
      this.Name = "DayView";
      this.Size = new System.Drawing.Size(747, 311);
      ((System.ComponentModel.ISupportInitialize)(this.LessonsOfDay)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private StudiHelper.UI.Components.StudiHelperDataGrid LessonsOfDay;
    private System.Windows.Forms.Button loadLessonsOfDay;
    private System.Windows.Forms.DateTimePicker DayPickerDay;

  }
}
