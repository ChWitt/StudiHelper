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
      this.tabStudiHelper = new System.Windows.Forms.TabControl();
      this.LessonsOfDayTab = new System.Windows.Forms.TabPage();
      this.dayView1 = new StudiHelper.UI.DayView();
      this.LessonsOfWeekTab = new System.Windows.Forms.TabPage();
      this.weekView1 = new StudiHelper.UI.WeekView();
      this.lessonsOfCurs = new System.Windows.Forms.TabPage();
      this.cursView1 = new StudiHelper.UI.CursView();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.overviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.infoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.updateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabStudiHelper.SuspendLayout();
      this.LessonsOfDayTab.SuspendLayout();
      this.LessonsOfWeekTab.SuspendLayout();
      this.lessonsOfCurs.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabStudiHelper
      // 
      this.tabStudiHelper.Controls.Add(this.LessonsOfDayTab);
      this.tabStudiHelper.Controls.Add(this.LessonsOfWeekTab);
      this.tabStudiHelper.Controls.Add(this.lessonsOfCurs);
      this.tabStudiHelper.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabStudiHelper.Location = new System.Drawing.Point(0, 0);
      this.tabStudiHelper.Name = "tabStudiHelper";
      this.tabStudiHelper.SelectedIndex = 0;
      this.tabStudiHelper.Size = new System.Drawing.Size(863, 422);
      this.tabStudiHelper.TabIndex = 0;
      // 
      // LessonsOfDayTab
      // 
      this.LessonsOfDayTab.Controls.Add(this.dayView1);
      this.LessonsOfDayTab.Location = new System.Drawing.Point(4, 22);
      this.LessonsOfDayTab.Name = "LessonsOfDayTab";
      this.LessonsOfDayTab.Padding = new System.Windows.Forms.Padding(3);
      this.LessonsOfDayTab.Size = new System.Drawing.Size(855, 396);
      this.LessonsOfDayTab.TabIndex = 0;
      this.LessonsOfDayTab.Text = "Am Tag";
      this.LessonsOfDayTab.UseVisualStyleBackColor = true;
      // 
      // dayView1
      // 
      this.dayView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dayView1.Location = new System.Drawing.Point(3, 3);
      this.dayView1.Name = "dayView1";
      this.dayView1.Size = new System.Drawing.Size(849, 390);
      this.dayView1.TabIndex = 0;
      // 
      // LessonsOfWeekTab
      // 
      this.LessonsOfWeekTab.Controls.Add(this.weekView1);
      this.LessonsOfWeekTab.Location = new System.Drawing.Point(4, 22);
      this.LessonsOfWeekTab.Name = "LessonsOfWeekTab";
      this.LessonsOfWeekTab.Padding = new System.Windows.Forms.Padding(3);
      this.LessonsOfWeekTab.Size = new System.Drawing.Size(855, 396);
      this.LessonsOfWeekTab.TabIndex = 1;
      this.LessonsOfWeekTab.Text = "in der Woche";
      this.LessonsOfWeekTab.UseVisualStyleBackColor = true;
      // 
      // weekView1
      // 
      this.weekView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.weekView1.Location = new System.Drawing.Point(3, 3);
      this.weekView1.Name = "weekView1";
      this.weekView1.Size = new System.Drawing.Size(849, 390);
      this.weekView1.TabIndex = 0;
      // 
      // lessonsOfCurs
      // 
      this.lessonsOfCurs.Controls.Add(this.cursView1);
      this.lessonsOfCurs.Location = new System.Drawing.Point(4, 22);
      this.lessonsOfCurs.Name = "lessonsOfCurs";
      this.lessonsOfCurs.Padding = new System.Windows.Forms.Padding(3);
      this.lessonsOfCurs.Size = new System.Drawing.Size(855, 396);
      this.lessonsOfCurs.TabIndex = 2;
      this.lessonsOfCurs.Text = "Kurs anzeigen";
      this.lessonsOfCurs.UseVisualStyleBackColor = true;
      // 
      // cursView1
      // 
      this.cursView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cursView1.Location = new System.Drawing.Point(3, 3);
      this.cursView1.Name = "cursView1";
      this.cursView1.Size = new System.Drawing.Size(849, 390);
      this.cursView1.TabIndex = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overviewToolStripMenuItem,
            this.infoToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(863, 24);
      this.menuStrip1.TabIndex = 5;
      this.menuStrip1.Text = "menuStrip1";
      this.menuStrip1.Visible = false;
      // 
      // overviewToolStripMenuItem
      // 
      this.overviewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuItem,
            this.closeMenuItem});
      this.overviewToolStripMenuItem.Name = "overviewToolStripMenuItem";
      this.overviewToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
      this.overviewToolStripMenuItem.Text = "Allgmein";
      // 
      // settingsMenuItem
      // 
      this.settingsMenuItem.Name = "settingsMenuItem";
      this.settingsMenuItem.Size = new System.Drawing.Size(145, 22);
      this.settingsMenuItem.Text = "Einstellungen";
      this.settingsMenuItem.Visible = false;
      this.settingsMenuItem.Click += new System.EventHandler(this.settingsMenuItem_Click);
      // 
      // closeMenuItem
      // 
      this.closeMenuItem.Name = "closeMenuItem";
      this.closeMenuItem.Size = new System.Drawing.Size(145, 22);
      this.closeMenuItem.Text = "Beenden";
      this.closeMenuItem.Click += new System.EventHandler(this.closeMenuItem_Click);
      // 
      // infoToolStripMenuItem
      // 
      this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoMenuItem,
            this.updateMenuItem});
      this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
      this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
      this.infoToolStripMenuItem.Text = "Info";
      this.infoToolStripMenuItem.Visible = false;
      // 
      // infoMenuItem
      // 
      this.infoMenuItem.Name = "infoMenuItem";
      this.infoMenuItem.Size = new System.Drawing.Size(184, 22);
      this.infoMenuItem.Text = "Über ...";
      this.infoMenuItem.Click += new System.EventHandler(this.infoMenuItem_Click);
      // 
      // updateMenuItem
      // 
      this.updateMenuItem.Name = "updateMenuItem";
      this.updateMenuItem.Size = new System.Drawing.Size(184, 22);
      this.updateMenuItem.Text = "Nach Update suchen";
      this.updateMenuItem.Click += new System.EventHandler(this.updateMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(863, 422);
      this.Controls.Add(this.tabStudiHelper);
      this.Controls.Add(this.menuStrip1);
      this.Name = "MainForm";
      this.ShowIcon = false;
      this.Text = "Studenplaner";
      this.tabStudiHelper.ResumeLayout(false);
      this.LessonsOfDayTab.ResumeLayout(false);
      this.LessonsOfWeekTab.ResumeLayout(false);
      this.lessonsOfCurs.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabStudiHelper;
        private System.Windows.Forms.TabPage LessonsOfDayTab;
        private System.Windows.Forms.TabPage LessonsOfWeekTab;
        private System.Windows.Forms.TabPage lessonsOfCurs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem overviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenuItem;
        private StudiHelper.UI.DayView dayView1;
        private StudiHelper.UI.WeekView weekView1;
        private StudiHelper.UI.CursView cursView1;
    }
}

