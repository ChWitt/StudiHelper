namespace StudiHelper.UI
{
    partial class MainForm
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
      this.tabStudiHelper = new System.Windows.Forms.TabControl();
      this.LessonsOfDayTab = new System.Windows.Forms.TabPage();
      this.LessonsOfDay = new System.Windows.Forms.DataGridView();
      this.cursNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cursDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.startDataGridViewTextBoxColumn = new StudiHelper.UI.DataGridViewTimeTextBoxColumn();
      this.endDataGridViewTextBoxColumn = new StudiHelper.UI.DataGridViewTimeTextBoxColumn();
      this.buildingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.modulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mergedLessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.loadLessonsOfDay = new System.Windows.Forms.Button();
      this.DayPickerDay = new System.Windows.Forms.DateTimePicker();
      this.LessonsOfWeekTab = new System.Windows.Forms.TabPage();
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
      this.lessonsOfCurs = new System.Windows.Forms.TabPage();
      this.loadOfCurs = new System.Windows.Forms.Button();
      this.lessonOfCurs = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.startDate = new StudiHelper.UI.DataGridViewDateTextBoxColumn();
      this.dataGridViewTimeTextBoxColumn1 = new StudiHelper.UI.DataGridViewTimeTextBoxColumn();
      this.dataGridViewTimeTextBoxColumn2 = new StudiHelper.UI.DataGridViewTimeTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.CursCombobox = new System.Windows.Forms.ComboBox();
      this.ModuleCombobox = new System.Windows.Forms.ComboBox();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.allgmeinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.nachUpdateSuchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabStudiHelper.SuspendLayout();
      this.LessonsOfDayTab.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.LessonsOfDay)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mergedLessonBindingSource)).BeginInit();
      this.LessonsOfWeekTab.SuspendLayout();
      this.LayoutWeek.SuspendLayout();
      this.SundayPanel.SuspendLayout();
      this.SaturdayPanel.SuspendLayout();
      this.FridayPanel.SuspendLayout();
      this.ThursdayPanel.SuspendLayout();
      this.WednesdayPanel.SuspendLayout();
      this.TuesdayPanel.SuspendLayout();
      this.HeaderSetDate.SuspendLayout();
      this.MondayPanel.SuspendLayout();
      this.lessonsOfCurs.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lessonOfCurs)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabStudiHelper
      // 
      this.tabStudiHelper.Controls.Add(this.LessonsOfDayTab);
      this.tabStudiHelper.Controls.Add(this.LessonsOfWeekTab);
      this.tabStudiHelper.Controls.Add(this.lessonsOfCurs);
      this.tabStudiHelper.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabStudiHelper.Location = new System.Drawing.Point(0, 24);
      this.tabStudiHelper.Name = "tabStudiHelper";
      this.tabStudiHelper.SelectedIndex = 0;
      this.tabStudiHelper.Size = new System.Drawing.Size(863, 398);
      this.tabStudiHelper.TabIndex = 0;
      // 
      // LessonsOfDayTab
      // 
      this.LessonsOfDayTab.Controls.Add(this.LessonsOfDay);
      this.LessonsOfDayTab.Controls.Add(this.loadLessonsOfDay);
      this.LessonsOfDayTab.Controls.Add(this.DayPickerDay);
      this.LessonsOfDayTab.Location = new System.Drawing.Point(4, 22);
      this.LessonsOfDayTab.Name = "LessonsOfDayTab";
      this.LessonsOfDayTab.Padding = new System.Windows.Forms.Padding(3);
      this.LessonsOfDayTab.Size = new System.Drawing.Size(855, 372);
      this.LessonsOfDayTab.TabIndex = 0;
      this.LessonsOfDayTab.Text = "Am Tag";
      this.LessonsOfDayTab.UseVisualStyleBackColor = true;
      // 
      // LessonsOfDay
      // 
      this.LessonsOfDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.LessonsOfDay.AutoGenerateColumns = false;
      this.LessonsOfDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.LessonsOfDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cursNameDataGridViewTextBoxColumn,
            this.cursDescription,
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.buildingDataGridViewTextBoxColumn,
            this.tutorDataGridViewTextBoxColumn,
            this.modulDataGridViewTextBoxColumn});
      this.LessonsOfDay.DataSource = this.mergedLessonBindingSource;
      this.LessonsOfDay.Location = new System.Drawing.Point(8, 35);
      this.LessonsOfDay.Name = "LessonsOfDay";
      this.LessonsOfDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.LessonsOfDay.Size = new System.Drawing.Size(839, 329);
      this.LessonsOfDay.TabIndex = 3;
      this.LessonsOfDay.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.LessonsOfDay_CellFormatting);
      // 
      // cursNameDataGridViewTextBoxColumn
      // 
      this.cursNameDataGridViewTextBoxColumn.DataPropertyName = "cursName";
      this.cursNameDataGridViewTextBoxColumn.HeaderText = "Kursnummer";
      this.cursNameDataGridViewTextBoxColumn.Name = "cursNameDataGridViewTextBoxColumn";
      this.cursNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.cursNameDataGridViewTextBoxColumn.Width = 70;
      // 
      // cursDescription
      // 
      this.cursDescription.DataPropertyName = "cursDescription";
      this.cursDescription.HeaderText = "Name";
      this.cursDescription.Name = "cursDescription";
      this.cursDescription.ReadOnly = true;
      this.cursDescription.Width = 200;
      // 
      // startDataGridViewTextBoxColumn
      // 
      this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
      this.startDataGridViewTextBoxColumn.HeaderText = "Start";
      this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
      this.startDataGridViewTextBoxColumn.ReadOnly = true;
      this.startDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.startDataGridViewTextBoxColumn.Width = 50;
      // 
      // endDataGridViewTextBoxColumn
      // 
      this.endDataGridViewTextBoxColumn.DataPropertyName = "end";
      this.endDataGridViewTextBoxColumn.HeaderText = "Ende";
      this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
      this.endDataGridViewTextBoxColumn.ReadOnly = true;
      this.endDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.endDataGridViewTextBoxColumn.Width = 50;
      // 
      // buildingDataGridViewTextBoxColumn
      // 
      this.buildingDataGridViewTextBoxColumn.DataPropertyName = "building";
      this.buildingDataGridViewTextBoxColumn.HeaderText = "Gebäude";
      this.buildingDataGridViewTextBoxColumn.Name = "buildingDataGridViewTextBoxColumn";
      this.buildingDataGridViewTextBoxColumn.ReadOnly = true;
      this.buildingDataGridViewTextBoxColumn.Width = 70;
      // 
      // tutorDataGridViewTextBoxColumn
      // 
      this.tutorDataGridViewTextBoxColumn.DataPropertyName = "tutor";
      this.tutorDataGridViewTextBoxColumn.HeaderText = "Tutor";
      this.tutorDataGridViewTextBoxColumn.Name = "tutorDataGridViewTextBoxColumn";
      this.tutorDataGridViewTextBoxColumn.ReadOnly = true;
      this.tutorDataGridViewTextBoxColumn.Width = 200;
      // 
      // modulDataGridViewTextBoxColumn
      // 
      this.modulDataGridViewTextBoxColumn.DataPropertyName = "modul";
      this.modulDataGridViewTextBoxColumn.HeaderText = "Modul";
      this.modulDataGridViewTextBoxColumn.Name = "modulDataGridViewTextBoxColumn";
      this.modulDataGridViewTextBoxColumn.ReadOnly = true;
      this.modulDataGridViewTextBoxColumn.Width = 200;
      // 
      // mergedLessonBindingSource
      // 
      this.mergedLessonBindingSource.AllowNew = false;
      this.mergedLessonBindingSource.DataSource = typeof(StudiHelper.Core.Objects.MergedLesson);
      this.mergedLessonBindingSource.Sort = "";
      // 
      // loadLessonsOfDay
      // 
      this.loadLessonsOfDay.Location = new System.Drawing.Point(214, 6);
      this.loadLessonsOfDay.Name = "loadLessonsOfDay";
      this.loadLessonsOfDay.Size = new System.Drawing.Size(138, 23);
      this.loadLessonsOfDay.TabIndex = 2;
      this.loadLessonsOfDay.Text = "Laden";
      this.loadLessonsOfDay.UseVisualStyleBackColor = true;
      this.loadLessonsOfDay.Click += new System.EventHandler(this.loadLessonsOfDay_Click);
      // 
      // DayPickerDay
      // 
      this.DayPickerDay.Location = new System.Drawing.Point(8, 6);
      this.DayPickerDay.Name = "DayPickerDay";
      this.DayPickerDay.Size = new System.Drawing.Size(200, 20);
      this.DayPickerDay.TabIndex = 0;
      // 
      // LessonsOfWeekTab
      // 
      this.LessonsOfWeekTab.Controls.Add(this.LayoutWeek);
      this.LessonsOfWeekTab.Location = new System.Drawing.Point(4, 22);
      this.LessonsOfWeekTab.Name = "LessonsOfWeekTab";
      this.LessonsOfWeekTab.Padding = new System.Windows.Forms.Padding(3);
      this.LessonsOfWeekTab.Size = new System.Drawing.Size(855, 372);
      this.LessonsOfWeekTab.TabIndex = 1;
      this.LessonsOfWeekTab.Text = "in der Woche";
      this.LessonsOfWeekTab.UseVisualStyleBackColor = true;
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
      this.LayoutWeek.Location = new System.Drawing.Point(3, 3);
      this.LayoutWeek.Name = "LayoutWeek";
      this.LayoutWeek.RowCount = 3;
      this.LayoutWeek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.LayoutWeek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
      this.LayoutWeek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.LayoutWeek.Size = new System.Drawing.Size(849, 366);
      this.LayoutWeek.TabIndex = 0;
      // 
      // LegendPanel
      // 
      this.LayoutWeek.SetColumnSpan(this.LegendPanel, 7);
      this.LegendPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LegendPanel.Location = new System.Drawing.Point(3, 331);
      this.LegendPanel.Name = "LegendPanel";
      this.LegendPanel.Size = new System.Drawing.Size(843, 32);
      this.LegendPanel.TabIndex = 12;
      // 
      // SundayPanel
      // 
      this.SundayPanel.Controls.Add(this.SundayLabel);
      this.SundayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SundayPanel.Location = new System.Drawing.Point(729, 39);
      this.SundayPanel.Name = "SundayPanel";
      this.SundayPanel.Size = new System.Drawing.Size(117, 286);
      this.SundayPanel.TabIndex = 11;
      // 
      // SundayLabel
      // 
      this.SundayLabel.BackColor = System.Drawing.Color.Silver;
      this.SundayLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.SundayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SundayLabel.Location = new System.Drawing.Point(0, 0);
      this.SundayLabel.Name = "SundayLabel";
      this.SundayLabel.Size = new System.Drawing.Size(117, 21);
      this.SundayLabel.TabIndex = 1;
      this.SundayLabel.Text = "Sonntag";
      this.SundayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // SaturdayPanel
      // 
      this.SaturdayPanel.Controls.Add(this.SaturdayLabel);
      this.SaturdayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SaturdayPanel.Location = new System.Drawing.Point(608, 39);
      this.SaturdayPanel.Name = "SaturdayPanel";
      this.SaturdayPanel.Size = new System.Drawing.Size(115, 286);
      this.SaturdayPanel.TabIndex = 10;
      // 
      // SaturdayLabel
      // 
      this.SaturdayLabel.BackColor = System.Drawing.Color.Silver;
      this.SaturdayLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.SaturdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SaturdayLabel.Location = new System.Drawing.Point(0, 0);
      this.SaturdayLabel.Name = "SaturdayLabel";
      this.SaturdayLabel.Size = new System.Drawing.Size(115, 21);
      this.SaturdayLabel.TabIndex = 1;
      this.SaturdayLabel.Text = "Samstag";
      this.SaturdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // FridayPanel
      // 
      this.FridayPanel.Controls.Add(this.FridayLabel);
      this.FridayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.FridayPanel.Location = new System.Drawing.Point(487, 39);
      this.FridayPanel.Name = "FridayPanel";
      this.FridayPanel.Size = new System.Drawing.Size(115, 286);
      this.FridayPanel.TabIndex = 9;
      // 
      // FridayLabel
      // 
      this.FridayLabel.BackColor = System.Drawing.Color.Silver;
      this.FridayLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.FridayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FridayLabel.Location = new System.Drawing.Point(0, 0);
      this.FridayLabel.Name = "FridayLabel";
      this.FridayLabel.Size = new System.Drawing.Size(115, 21);
      this.FridayLabel.TabIndex = 1;
      this.FridayLabel.Text = "Freitag";
      this.FridayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // ThursdayPanel
      // 
      this.ThursdayPanel.Controls.Add(this.ThursdayLabel);
      this.ThursdayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ThursdayPanel.Location = new System.Drawing.Point(366, 39);
      this.ThursdayPanel.Name = "ThursdayPanel";
      this.ThursdayPanel.Size = new System.Drawing.Size(115, 286);
      this.ThursdayPanel.TabIndex = 8;
      // 
      // ThursdayLabel
      // 
      this.ThursdayLabel.BackColor = System.Drawing.Color.Silver;
      this.ThursdayLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.ThursdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ThursdayLabel.Location = new System.Drawing.Point(0, 0);
      this.ThursdayLabel.Name = "ThursdayLabel";
      this.ThursdayLabel.Size = new System.Drawing.Size(115, 21);
      this.ThursdayLabel.TabIndex = 1;
      this.ThursdayLabel.Text = "Donnerstag";
      this.ThursdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // WednesdayPanel
      // 
      this.WednesdayPanel.Controls.Add(this.WednesdayLabel);
      this.WednesdayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.WednesdayPanel.Location = new System.Drawing.Point(245, 39);
      this.WednesdayPanel.Name = "WednesdayPanel";
      this.WednesdayPanel.Size = new System.Drawing.Size(115, 286);
      this.WednesdayPanel.TabIndex = 7;
      // 
      // WednesdayLabel
      // 
      this.WednesdayLabel.BackColor = System.Drawing.Color.Silver;
      this.WednesdayLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.WednesdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.WednesdayLabel.Location = new System.Drawing.Point(0, 0);
      this.WednesdayLabel.Name = "WednesdayLabel";
      this.WednesdayLabel.Size = new System.Drawing.Size(115, 21);
      this.WednesdayLabel.TabIndex = 1;
      this.WednesdayLabel.Text = "Mittwoch";
      this.WednesdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // TuesdayPanel
      // 
      this.TuesdayPanel.Controls.Add(this.TuesdayLabel);
      this.TuesdayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TuesdayPanel.Location = new System.Drawing.Point(124, 39);
      this.TuesdayPanel.Name = "TuesdayPanel";
      this.TuesdayPanel.Size = new System.Drawing.Size(115, 286);
      this.TuesdayPanel.TabIndex = 6;
      // 
      // TuesdayLabel
      // 
      this.TuesdayLabel.BackColor = System.Drawing.Color.Silver;
      this.TuesdayLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.TuesdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TuesdayLabel.Location = new System.Drawing.Point(0, 0);
      this.TuesdayLabel.Name = "TuesdayLabel";
      this.TuesdayLabel.Size = new System.Drawing.Size(115, 21);
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
      this.HeaderSetDate.Size = new System.Drawing.Size(843, 30);
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
      this.MondayPanel.Location = new System.Drawing.Point(3, 39);
      this.MondayPanel.Name = "MondayPanel";
      this.MondayPanel.Size = new System.Drawing.Size(115, 286);
      this.MondayPanel.TabIndex = 5;
      // 
      // MondayLabel
      // 
      this.MondayLabel.BackColor = System.Drawing.Color.Silver;
      this.MondayLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.MondayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MondayLabel.Location = new System.Drawing.Point(0, 0);
      this.MondayLabel.Name = "MondayLabel";
      this.MondayLabel.Size = new System.Drawing.Size(115, 21);
      this.MondayLabel.TabIndex = 0;
      this.MondayLabel.Text = "Montag";
      this.MondayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lessonsOfCurs
      // 
      this.lessonsOfCurs.Controls.Add(this.loadOfCurs);
      this.lessonsOfCurs.Controls.Add(this.lessonOfCurs);
      this.lessonsOfCurs.Controls.Add(this.label2);
      this.lessonsOfCurs.Controls.Add(this.label1);
      this.lessonsOfCurs.Controls.Add(this.CursCombobox);
      this.lessonsOfCurs.Controls.Add(this.ModuleCombobox);
      this.lessonsOfCurs.Location = new System.Drawing.Point(4, 22);
      this.lessonsOfCurs.Name = "lessonsOfCurs";
      this.lessonsOfCurs.Padding = new System.Windows.Forms.Padding(3);
      this.lessonsOfCurs.Size = new System.Drawing.Size(855, 372);
      this.lessonsOfCurs.TabIndex = 2;
      this.lessonsOfCurs.Text = "Kurs anzeigen";
      this.lessonsOfCurs.UseVisualStyleBackColor = true;
      // 
      // loadOfCurs
      // 
      this.loadOfCurs.Location = new System.Drawing.Point(196, 4);
      this.loadOfCurs.Name = "loadOfCurs";
      this.loadOfCurs.Size = new System.Drawing.Size(64, 50);
      this.loadOfCurs.TabIndex = 5;
      this.loadOfCurs.Text = "Laden";
      this.loadOfCurs.UseVisualStyleBackColor = true;
      this.loadOfCurs.Click += new System.EventHandler(this.loadOfCurs_Click);
      // 
      // lessonOfCurs
      // 
      this.lessonOfCurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lessonOfCurs.AutoGenerateColumns = false;
      this.lessonOfCurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.lessonOfCurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.startDate,
            this.dataGridViewTimeTextBoxColumn1,
            this.dataGridViewTimeTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
      this.lessonOfCurs.DataSource = this.mergedLessonBindingSource;
      this.lessonOfCurs.Location = new System.Drawing.Point(8, 60);
      this.lessonOfCurs.Name = "lessonOfCurs";
      this.lessonOfCurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.lessonOfCurs.Size = new System.Drawing.Size(839, 315);
      this.lessonOfCurs.TabIndex = 4;
      this.lessonOfCurs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.lessonOfCurs_CellFormatting);
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "cursName";
      this.dataGridViewTextBoxColumn2.HeaderText = "Kursnummer";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Width = 70;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "cursDescription";
      this.dataGridViewTextBoxColumn3.HeaderText = "Name";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Width = 200;
      // 
      // startDate
      // 
      this.startDate.DataPropertyName = "start";
      this.startDate.HeaderText = "Datum";
      this.startDate.Name = "startDate";
      this.startDate.ReadOnly = true;
      this.startDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // dataGridViewTimeTextBoxColumn1
      // 
      this.dataGridViewTimeTextBoxColumn1.DataPropertyName = "start";
      this.dataGridViewTimeTextBoxColumn1.HeaderText = "Start";
      this.dataGridViewTimeTextBoxColumn1.Name = "dataGridViewTimeTextBoxColumn1";
      this.dataGridViewTimeTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTimeTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewTimeTextBoxColumn1.Width = 50;
      // 
      // dataGridViewTimeTextBoxColumn2
      // 
      this.dataGridViewTimeTextBoxColumn2.DataPropertyName = "end";
      this.dataGridViewTimeTextBoxColumn2.HeaderText = "Ende";
      this.dataGridViewTimeTextBoxColumn2.Name = "dataGridViewTimeTextBoxColumn2";
      this.dataGridViewTimeTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTimeTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewTimeTextBoxColumn2.Width = 50;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "building";
      this.dataGridViewTextBoxColumn4.HeaderText = "Gebäude";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Width = 70;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "tutor";
      this.dataGridViewTextBoxColumn5.HeaderText = "Tutor";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      this.dataGridViewTextBoxColumn5.Width = 200;
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "modul";
      this.dataGridViewTextBoxColumn6.HeaderText = "Modul";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.ReadOnly = true;
      this.dataGridViewTextBoxColumn6.Width = 200;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(8, 36);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(31, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Kurs:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Modul:";
      // 
      // CursCombobox
      // 
      this.CursCombobox.FormattingEnabled = true;
      this.CursCombobox.Location = new System.Drawing.Point(69, 33);
      this.CursCombobox.Name = "CursCombobox";
      this.CursCombobox.Size = new System.Drawing.Size(121, 21);
      this.CursCombobox.TabIndex = 1;
      // 
      // ModuleCombobox
      // 
      this.ModuleCombobox.FormattingEnabled = true;
      this.ModuleCombobox.Location = new System.Drawing.Point(69, 6);
      this.ModuleCombobox.Name = "ModuleCombobox";
      this.ModuleCombobox.Size = new System.Drawing.Size(121, 21);
      this.ModuleCombobox.TabIndex = 0;
      this.ModuleCombobox.SelectedIndexChanged += new System.EventHandler(this.ModuleCombobox_SelectedIndexChanged);
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "cursDescription";
      this.dataGridViewTextBoxColumn1.HeaderText = "Name";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 200;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allgmeinToolStripMenuItem,
            this.infoToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(863, 24);
      this.menuStrip1.TabIndex = 5;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // allgmeinToolStripMenuItem
      // 
      this.allgmeinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem,
            this.beendenToolStripMenuItem});
      this.allgmeinToolStripMenuItem.Name = "allgmeinToolStripMenuItem";
      this.allgmeinToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
      this.allgmeinToolStripMenuItem.Text = "Allgmein";
      // 
      // einstellungenToolStripMenuItem
      // 
      this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
      this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.einstellungenToolStripMenuItem.Text = "Einstellungen";
      this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
      // 
      // beendenToolStripMenuItem
      // 
      this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
      this.beendenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.beendenToolStripMenuItem.Text = "Beenden";
      this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
      // 
      // infoToolStripMenuItem
      // 
      this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem,
            this.nachUpdateSuchenToolStripMenuItem});
      this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
      this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
      this.infoToolStripMenuItem.Text = "Info";
      // 
      // überToolStripMenuItem
      // 
      this.überToolStripMenuItem.Name = "überToolStripMenuItem";
      this.überToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
      this.überToolStripMenuItem.Text = "Über ...";
      this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
      // 
      // nachUpdateSuchenToolStripMenuItem
      // 
      this.nachUpdateSuchenToolStripMenuItem.Name = "nachUpdateSuchenToolStripMenuItem";
      this.nachUpdateSuchenToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
      this.nachUpdateSuchenToolStripMenuItem.Text = "Nach Update suchen";
      this.nachUpdateSuchenToolStripMenuItem.Click += new System.EventHandler(this.nachUpdateSuchenToolStripMenuItem_Click);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(863, 422);
      this.Controls.Add(this.tabStudiHelper);
      this.Controls.Add(this.menuStrip1);
      this.Name = "Main";
      this.Text = "Main";
      this.tabStudiHelper.ResumeLayout(false);
      this.LessonsOfDayTab.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.LessonsOfDay)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mergedLessonBindingSource)).EndInit();
      this.LessonsOfWeekTab.ResumeLayout(false);
      this.LayoutWeek.ResumeLayout(false);
      this.SundayPanel.ResumeLayout(false);
      this.SaturdayPanel.ResumeLayout(false);
      this.FridayPanel.ResumeLayout(false);
      this.ThursdayPanel.ResumeLayout(false);
      this.WednesdayPanel.ResumeLayout(false);
      this.TuesdayPanel.ResumeLayout(false);
      this.HeaderSetDate.ResumeLayout(false);
      this.MondayPanel.ResumeLayout(false);
      this.lessonsOfCurs.ResumeLayout(false);
      this.lessonsOfCurs.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lessonOfCurs)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabStudiHelper;
        private System.Windows.Forms.TabPage LessonsOfDayTab;
        private System.Windows.Forms.DateTimePicker DayPickerDay;
        private System.Windows.Forms.TabPage LessonsOfWeekTab;
        private System.Windows.Forms.Button loadLessonsOfDay;
        private System.Windows.Forms.DataGridView LessonsOfDay;
        private System.Windows.Forms.BindingSource mergedLessonBindingSource;
        private System.Windows.Forms.TableLayoutPanel LayoutWeek;
        private System.Windows.Forms.DateTimePicker dayPickerWeek;
        private System.Windows.Forms.Panel SundayPanel;
        private System.Windows.Forms.Label SundayLabel;
        private System.Windows.Forms.Panel SaturdayPanel;
        private System.Windows.Forms.Label SaturdayLabel;
        private System.Windows.Forms.Panel FridayPanel;
        private System.Windows.Forms.Label FridayLabel;
        private System.Windows.Forms.Panel ThursdayPanel;
        private System.Windows.Forms.Label ThursdayLabel;
        private System.Windows.Forms.Panel TuesdayPanel;
        private System.Windows.Forms.Panel WednesdayPanel;
        private System.Windows.Forms.Label WednesdayLabel;
        private System.Windows.Forms.Label TuesdayLabel;
        private System.Windows.Forms.Panel HeaderSetDate;
        private System.Windows.Forms.Button loadLessonsOfWeek;
        private System.Windows.Forms.Panel MondayPanel;
        private System.Windows.Forms.Label MondayLabel;
        private System.Windows.Forms.Panel LegendPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursDescription;
        private DataGridViewTimeTextBoxColumn startDataGridViewTextBoxColumn;
        private DataGridViewTimeTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modulDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage lessonsOfCurs;
        private System.Windows.Forms.Button loadOfCurs;
        private System.Windows.Forms.DataGridView lessonOfCurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CursCombobox;
        private System.Windows.Forms.ComboBox ModuleCombobox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewDateTextBoxColumn startDate;
        private DataGridViewTimeTextBoxColumn dataGridViewTimeTextBoxColumn1;
        private DataGridViewTimeTextBoxColumn dataGridViewTimeTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allgmeinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachUpdateSuchenToolStripMenuItem;
    }
}

