namespace StudiHelper.UI
{
  partial class WeekView
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
      this.LayoutWeek = new System.Windows.Forms.TableLayoutPanel();
      this.LegendPanel = new System.Windows.Forms.Panel();
      this.SundayPanel = new System.Windows.Forms.Panel();
      this.SundayLabel = new System.Windows.Forms.Label();
      this.SaturdayPanel = new System.Windows.Forms.Panel();
      this.SaturdayLabel = new System.Windows.Forms.Label();
      this.FridayPanel = new System.Windows.Forms.Panel();
      this.FridayLabel = new System.Windows.Forms.Label();
      this.ThursdayPanel = new System.Windows.Forms.Panel();
      this.ThursdayLabel = new System.Windows.Forms.Label();
      this.WednesdayPanel = new System.Windows.Forms.Panel();
      this.WednesdayLabel = new System.Windows.Forms.Label();
      this.TuesdayPanel = new System.Windows.Forms.Panel();
      this.TuesdayLabel = new System.Windows.Forms.Label();
      this.HeaderSetDate = new System.Windows.Forms.Panel();
      this.loadLessonsOfWeek = new System.Windows.Forms.Button();
      this.dayPickerWeek = new System.Windows.Forms.DateTimePicker();
      this.MondayPanel = new System.Windows.Forms.Panel();
      this.MondayLabel = new System.Windows.Forms.Label();
      this.LayoutWeek.SuspendLayout();
      this.SundayPanel.SuspendLayout();
      this.SaturdayPanel.SuspendLayout();
      this.FridayPanel.SuspendLayout();
      this.ThursdayPanel.SuspendLayout();
      this.WednesdayPanel.SuspendLayout();
      this.TuesdayPanel.SuspendLayout();
      this.HeaderSetDate.SuspendLayout();
      this.MondayPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // LayoutWeek
      // 
      this.LayoutWeek.ColumnCount = 7;
      this.LayoutWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.LayoutWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.LayoutWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.LayoutWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.LayoutWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.LayoutWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.LayoutWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.LayoutWeek.Controls.Add(this.LegendPanel, 0, 2);
      this.LayoutWeek.Controls.Add(this.SundayPanel, 6, 1);
      this.LayoutWeek.Controls.Add(this.SaturdayPanel, 5, 1);
      this.LayoutWeek.Controls.Add(this.FridayPanel, 4, 1);
      this.LayoutWeek.Controls.Add(this.ThursdayPanel, 3, 1);
      this.LayoutWeek.Controls.Add(this.WednesdayPanel, 2, 1);
      this.LayoutWeek.Controls.Add(this.TuesdayPanel, 1, 1);
      this.LayoutWeek.Controls.Add(this.HeaderSetDate, 0, 0);
      this.LayoutWeek.Controls.Add(this.MondayPanel, 0, 1);
      this.LayoutWeek.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LayoutWeek.Location = new System.Drawing.Point(0, 0);
      this.LayoutWeek.Name = "LayoutWeek";
      this.LayoutWeek.RowCount = 3;
      this.LayoutWeek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.LayoutWeek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
      this.LayoutWeek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.LayoutWeek.Size = new System.Drawing.Size(811, 388);
      this.LayoutWeek.TabIndex = 1;
      // 
      // LegendPanel
      // 
      this.LayoutWeek.SetColumnSpan(this.LegendPanel, 7);
      this.LegendPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LegendPanel.Location = new System.Drawing.Point(3, 351);
      this.LegendPanel.Name = "LegendPanel";
      this.LegendPanel.Size = new System.Drawing.Size(805, 34);
      this.LegendPanel.TabIndex = 12;
      // 
      // SundayPanel
      // 
      this.SundayPanel.Controls.Add(this.SundayLabel);
      this.SundayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SundayPanel.Location = new System.Drawing.Point(693, 41);
      this.SundayPanel.Name = "SundayPanel";
      this.SundayPanel.Size = new System.Drawing.Size(115, 304);
      this.SundayPanel.TabIndex = 11;
      // 
      // SundayLabel
      // 
      this.SundayLabel.BackColor = System.Drawing.Color.Silver;
      this.SundayLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.SundayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SundayLabel.Location = new System.Drawing.Point(0, 0);
      this.SundayLabel.Name = "SundayLabel";
      this.SundayLabel.Size = new System.Drawing.Size(115, 21);
      this.SundayLabel.TabIndex = 1;
      this.SundayLabel.Text = "Sonntag";
      this.SundayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // SaturdayPanel
      // 
      this.SaturdayPanel.Controls.Add(this.SaturdayLabel);
      this.SaturdayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SaturdayPanel.Location = new System.Drawing.Point(578, 41);
      this.SaturdayPanel.Name = "SaturdayPanel";
      this.SaturdayPanel.Size = new System.Drawing.Size(109, 304);
      this.SaturdayPanel.TabIndex = 10;
      // 
      // SaturdayLabel
      // 
      this.SaturdayLabel.BackColor = System.Drawing.Color.Silver;
      this.SaturdayLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.SaturdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SaturdayLabel.Location = new System.Drawing.Point(0, 0);
      this.SaturdayLabel.Name = "SaturdayLabel";
      this.SaturdayLabel.Size = new System.Drawing.Size(109, 21);
      this.SaturdayLabel.TabIndex = 1;
      this.SaturdayLabel.Text = "Samstag";
      this.SaturdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // FridayPanel
      // 
      this.FridayPanel.Controls.Add(this.FridayLabel);
      this.FridayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.FridayPanel.Location = new System.Drawing.Point(463, 41);
      this.FridayPanel.Name = "FridayPanel";
      this.FridayPanel.Size = new System.Drawing.Size(109, 304);
      this.FridayPanel.TabIndex = 9;
      // 
      // FridayLabel
      // 
      this.FridayLabel.BackColor = System.Drawing.Color.Silver;
      this.FridayLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.FridayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FridayLabel.Location = new System.Drawing.Point(0, 0);
      this.FridayLabel.Name = "FridayLabel";
      this.FridayLabel.Size = new System.Drawing.Size(109, 21);
      this.FridayLabel.TabIndex = 1;
      this.FridayLabel.Text = "Freitag";
      this.FridayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // ThursdayPanel
      // 
      this.ThursdayPanel.Controls.Add(this.ThursdayLabel);
      this.ThursdayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ThursdayPanel.Location = new System.Drawing.Point(348, 41);
      this.ThursdayPanel.Name = "ThursdayPanel";
      this.ThursdayPanel.Size = new System.Drawing.Size(109, 304);
      this.ThursdayPanel.TabIndex = 8;
      // 
      // ThursdayLabel
      // 
      this.ThursdayLabel.BackColor = System.Drawing.Color.Silver;
      this.ThursdayLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.ThursdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ThursdayLabel.Location = new System.Drawing.Point(0, 0);
      this.ThursdayLabel.Name = "ThursdayLabel";
      this.ThursdayLabel.Size = new System.Drawing.Size(109, 21);
      this.ThursdayLabel.TabIndex = 1;
      this.ThursdayLabel.Text = "Donnerstag";
      this.ThursdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // WednesdayPanel
      // 
      this.WednesdayPanel.Controls.Add(this.WednesdayLabel);
      this.WednesdayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.WednesdayPanel.Location = new System.Drawing.Point(233, 41);
      this.WednesdayPanel.Name = "WednesdayPanel";
      this.WednesdayPanel.Size = new System.Drawing.Size(109, 304);
      this.WednesdayPanel.TabIndex = 7;
      // 
      // WednesdayLabel
      // 
      this.WednesdayLabel.BackColor = System.Drawing.Color.Silver;
      this.WednesdayLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.WednesdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.WednesdayLabel.Location = new System.Drawing.Point(0, 0);
      this.WednesdayLabel.Name = "WednesdayLabel";
      this.WednesdayLabel.Size = new System.Drawing.Size(109, 21);
      this.WednesdayLabel.TabIndex = 1;
      this.WednesdayLabel.Text = "Mittwoch";
      this.WednesdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // TuesdayPanel
      // 
      this.TuesdayPanel.Controls.Add(this.TuesdayLabel);
      this.TuesdayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TuesdayPanel.Location = new System.Drawing.Point(118, 41);
      this.TuesdayPanel.Name = "TuesdayPanel";
      this.TuesdayPanel.Size = new System.Drawing.Size(109, 304);
      this.TuesdayPanel.TabIndex = 6;
      // 
      // TuesdayLabel
      // 
      this.TuesdayLabel.BackColor = System.Drawing.Color.Silver;
      this.TuesdayLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.TuesdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TuesdayLabel.Location = new System.Drawing.Point(0, 0);
      this.TuesdayLabel.Name = "TuesdayLabel";
      this.TuesdayLabel.Size = new System.Drawing.Size(109, 21);
      this.TuesdayLabel.TabIndex = 1;
      this.TuesdayLabel.Text = "Dienstag";
      this.TuesdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // HeaderSetDate
      // 
      this.LayoutWeek.SetColumnSpan(this.HeaderSetDate, 7);
      this.HeaderSetDate.Controls.Add(this.loadLessonsOfWeek);
      this.HeaderSetDate.Controls.Add(this.dayPickerWeek);
      this.HeaderSetDate.Dock = System.Windows.Forms.DockStyle.Fill;
      this.HeaderSetDate.Location = new System.Drawing.Point(3, 3);
      this.HeaderSetDate.Name = "HeaderSetDate";
      this.HeaderSetDate.Size = new System.Drawing.Size(805, 32);
      this.HeaderSetDate.TabIndex = 4;
      // 
      // loadLessonsOfWeek
      // 
      this.loadLessonsOfWeek.Location = new System.Drawing.Point(221, 4);
      this.loadLessonsOfWeek.Name = "loadLessonsOfWeek";
      this.loadLessonsOfWeek.Size = new System.Drawing.Size(138, 23);
      this.loadLessonsOfWeek.TabIndex = 3;
      this.loadLessonsOfWeek.Text = "Laden";
      this.loadLessonsOfWeek.UseVisualStyleBackColor = true;
      this.loadLessonsOfWeek.Click += new System.EventHandler(this.loadLessonsOfWeek_Click);
      // 
      // dayPickerWeek
      // 
      this.dayPickerWeek.Location = new System.Drawing.Point(4, 6);
      this.dayPickerWeek.Name = "dayPickerWeek";
      this.dayPickerWeek.Size = new System.Drawing.Size(200, 20);
      this.dayPickerWeek.TabIndex = 0;
      // 
      // MondayPanel
      // 
      this.MondayPanel.Controls.Add(this.MondayLabel);
      this.MondayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MondayPanel.Location = new System.Drawing.Point(3, 41);
      this.MondayPanel.Name = "MondayPanel";
      this.MondayPanel.Size = new System.Drawing.Size(109, 304);
      this.MondayPanel.TabIndex = 5;
      // 
      // MondayLabel
      // 
      this.MondayLabel.BackColor = System.Drawing.Color.Silver;
      this.MondayLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.MondayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MondayLabel.Location = new System.Drawing.Point(0, 0);
      this.MondayLabel.Name = "MondayLabel";
      this.MondayLabel.Size = new System.Drawing.Size(109, 21);
      this.MondayLabel.TabIndex = 0;
      this.MondayLabel.Text = "Montag";
      this.MondayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // WeekView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.LayoutWeek);
      this.Name = "WeekView";
      this.Size = new System.Drawing.Size(811, 388);
      this.LayoutWeek.ResumeLayout(false);
      this.SundayPanel.ResumeLayout(false);
      this.SaturdayPanel.ResumeLayout(false);
      this.FridayPanel.ResumeLayout(false);
      this.ThursdayPanel.ResumeLayout(false);
      this.WednesdayPanel.ResumeLayout(false);
      this.TuesdayPanel.ResumeLayout(false);
      this.HeaderSetDate.ResumeLayout(false);
      this.MondayPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel LayoutWeek;
    private System.Windows.Forms.Panel LegendPanel;
    private System.Windows.Forms.Panel SundayPanel;
    private System.Windows.Forms.Label SundayLabel;
    private System.Windows.Forms.Panel SaturdayPanel;
    private System.Windows.Forms.Label SaturdayLabel;
    private System.Windows.Forms.Panel FridayPanel;
    private System.Windows.Forms.Label FridayLabel;
    private System.Windows.Forms.Panel ThursdayPanel;
    private System.Windows.Forms.Label ThursdayLabel;
    private System.Windows.Forms.Panel WednesdayPanel;
    private System.Windows.Forms.Label WednesdayLabel;
    private System.Windows.Forms.Panel TuesdayPanel;
    private System.Windows.Forms.Label TuesdayLabel;
    private System.Windows.Forms.Panel HeaderSetDate;
    private System.Windows.Forms.Button loadLessonsOfWeek;
    private System.Windows.Forms.DateTimePicker dayPickerWeek;
    private System.Windows.Forms.Panel MondayPanel;
    private System.Windows.Forms.Label MondayLabel;
  }
}
