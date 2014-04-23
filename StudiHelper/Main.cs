namespace StudiHelper
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Drawing;
  using System.Text;
  using System.Windows.Forms;
  using StudiHelper.Objects;

  public partial class Main : Form
  {
    public Main()
    {
      InitializeComponent();

      ModuleCombobox.DataSource = BusinessLogic.BusinessLogicFactory.GetInstance().GetModules();
    }

    private void loadLessonsOfDay_Click(object sender, EventArgs e)
    {
      this.LessonsOfDay.DataSource = BusinessLogic.BusinessLogicFactory.GetInstance().GetMergedLessonsOfDay(DayPickerDay.Value);
    }

    private void loadLessonsOfWeek_Click(object sender, EventArgs e)
    {
      Dictionary<string, Label> legendLabels;
      Dictionary<DayOfWeek, List<Label>> lessonLabels;

      List<Objects.MergedLesson> mergedLessons = BusinessLogic.BusinessLogicFactory.GetInstance().GetMergedLessonsOfWeek(dayPickerWeek.Value, out legendLabels, out lessonLabels);

      LayoutWeek.SuspendLayout();
      ClearFields();

      foreach (Label legendLabel in legendLabels.Values)
      {
        LegendPanel.Controls.Add(legendLabel);
      }
      SetLessonLabel(lessonLabels);

      LayoutWeek.ResumeLayout();
    }

    private void SetLessonLabel(Dictionary<DayOfWeek, List<Label>> lessonLabels)
    {
      foreach (DayOfWeek dayOfWeek in lessonLabels.Keys)
      {
        switch (dayOfWeek)
        {
          case DayOfWeek.Monday:
            SetLessenLabelToPanel(MondayPanel, lessonLabels[dayOfWeek]);
            break;

          case DayOfWeek.Tuesday:
            SetLessenLabelToPanel(TuesdayPanel, lessonLabels[dayOfWeek]);
            break;

          case DayOfWeek.Wednesday:
            SetLessenLabelToPanel(WednesdayPanel, lessonLabels[dayOfWeek]);
            break;

          case DayOfWeek.Thursday:
            SetLessenLabelToPanel(ThursdayPanel, lessonLabels[dayOfWeek]);
            break;

          case DayOfWeek.Friday:
            SetLessenLabelToPanel(FridayPanel, lessonLabels[dayOfWeek]);
            break;

          case DayOfWeek.Saturday:
            SetLessenLabelToPanel(SaturdayPanel, lessonLabels[dayOfWeek]);
            break;

          case DayOfWeek.Sunday:
            SetLessenLabelToPanel(SundayPanel, lessonLabels[dayOfWeek]);
            break;
        }
      }
    }

    private void SetLessenLabelToPanel(Panel panelOfDay, List<Label> lessonsOnDay)
    {
      foreach (Label lessonLabel in lessonsOnDay)
      {
        panelOfDay.Controls.Add(lessonLabel);
        lessonLabel.BringToFront();
        lessonLabel.Click += new EventHandler(OpenLesson);
      }
    }

    private void OpenLesson(object sender, EventArgs e)
    {
      Label lessonLabel = (Label)sender;
      MergedLesson lesson = (MergedLesson)lessonLabel.Tag;

      StringBuilder lessonInfo = new StringBuilder();

      lessonInfo.AppendLine(string.Format("Name: {0}", lesson.cursDescription));
      lessonInfo.AppendLine(string.Format("Start: {0}", lesson.start.ToShortTimeString()));
      lessonInfo.AppendLine(string.Format("Ende: {0}", lesson.end.ToShortTimeString()));
      lessonInfo.AppendLine(string.Format("Tutor: {0}", lesson.tutor));
      lessonInfo.AppendLine(string.Format("Gebäude: {0}", lesson.building.ToString()));

      MessageBox.Show(lessonInfo.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ClearSinglePanel(Panel dayPanel)
    {
      foreach (Control control in dayPanel.Controls)
      {
        control.Click -= OpenLesson;
      }
      dayPanel.Controls.Clear();
    }

    private void ClearFields()
    {
      // Clear all
      LegendPanel.Controls.Clear();

      ClearSinglePanel(MondayPanel);
      MondayPanel.Controls.Add(MondayLabel);

      ClearSinglePanel(ThursdayPanel);
      ThursdayPanel.Controls.Add(ThursdayLabel);

      ClearSinglePanel(TuesdayPanel);
      TuesdayPanel.Controls.Add(TuesdayLabel);

      ClearSinglePanel(WednesdayPanel);
      WednesdayPanel.Controls.Add(WednesdayLabel);

      ClearSinglePanel(FridayPanel);
      FridayPanel.Controls.Add(FridayLabel);

      ClearSinglePanel(SundayPanel);
      SundayPanel.Controls.Add(SundayLabel);

      ClearSinglePanel(SaturdayPanel);
      SaturdayPanel.Controls.Add(SaturdayLabel);
    }

    private void LessonsOfDay_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      MergedLesson lesson = (MergedLesson)this.LessonsOfDay.Rows[e.RowIndex].DataBoundItem;
      IsLessonIsOver(e, lesson);

      if (lesson.confict && (this.LessonsOfDay.Columns[e.ColumnIndex].Name == "startDataGridViewTextBoxColumn" || this.LessonsOfDay.Columns[e.ColumnIndex].Name == "endDataGridViewTextBoxColumn"))
      {
        e.CellStyle.BackColor = Color.Yellow;
        this.LessonsOfDay.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Stunden überschneiden sich mit anderen am Tag!";
      }
    }

    private void IsLessonIsOver( DataGridViewCellFormattingEventArgs e, MergedLesson lesson)
    {
      if (lesson.end < DateTime.Now)
      {
        e.CellStyle.BackColor = Color.LightGray;
      }

      if (lesson.end > DateTime.Now && lesson.start <= DateTime.Now)
      {
        e.CellStyle.BackColor = Color.LightGreen;
      }
    }

    private void ModuleCombobox_SelectedIndexChanged(object sender, EventArgs e)
    {
      CursCombobox.SelectedItem = null;

      CursCombobox.DataSource = BusinessLogic.BusinessLogicFactory.GetInstance().GetCursesByModul(((Module)ModuleCombobox.SelectedItem).ModuleID);
    }

    private void loadOfCurs_Click(object sender, EventArgs e)
    {
      if (ModuleCombobox.SelectedItem == null || CursCombobox.SelectedItem == null)
      {
        MessageBox.Show("Zuerst gewünschtes Modul und Kurs auswählen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      lessonOfCurs.DataSource = BusinessLogic.BusinessLogicFactory.GetInstance().GetMergedLessonsOfCurs(((Curs)CursCombobox.SelectedItem).CursID);
    }

    private void lessonOfCurs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      MergedLesson lesson = (MergedLesson)this.lessonOfCurs.Rows[e.RowIndex].DataBoundItem;
      IsLessonIsOver(e, lesson);
    }
  }

  #region "HelperClasses"

  public class DataGridViewTimeTextBoxColumn : DataGridViewTextBoxColumn
  {
    public DataGridViewTimeTextBoxColumn()
      : base()
    {
      CellTemplate = new DataGridViewTimeTextBoxCell();
    }
  }

  public class DataGridViewTimeTextBoxCell : DataGridViewTextBoxCell
  {
    public DataGridViewTimeTextBoxCell()
      : base()
    {
    }

    protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
    {
      cellStyle.Format = "HH:mm";

      return base.GetFormattedValue(value, rowIndex, ref cellStyle, valueTypeConverter, formattedValueTypeConverter, context);
    }

    public override Type EditType
    {
      get
      {
        return typeof(DataGridViewTextBoxEditingControl);
      }
    }
  }

  public class DataGridViewDateTextBoxColumn : DataGridViewTextBoxColumn
  {
    public DataGridViewDateTextBoxColumn()
      : base()
    {
      CellTemplate = new DataGridViewDateTextBoxCell();
    }
  }

  public class DataGridViewDateTextBoxCell : DataGridViewTextBoxCell
  {
    public DataGridViewDateTextBoxCell()
      : base()
    {
    }

    protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
    {
      cellStyle.Format = "ddd dd.MM.yy";

      return base.GetFormattedValue(value, rowIndex, ref cellStyle, valueTypeConverter, formattedValueTypeConverter, context);
    }

    public override Type EditType
    {
      get
      {
        return typeof(DataGridViewTextBoxEditingControl);
      }
    }
  }

  #endregion "HelperClasses"
}