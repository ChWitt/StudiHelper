
namespace StudiHelper.UI.Components
{
  using System;
  using System.ComponentModel;
  using System.Drawing;
  using System.Windows.Forms;
  using StudiHelper.Core.Objects;

  /// <summary>
  /// Data grid view for the StudiHelper to display lessons
  /// </summary>
  public partial class StudiHelperDataGrid : DataGridView
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="StudiHelperDataGrid"/> class.
    /// </summary>
    public StudiHelperDataGrid()
    {
      this.InitializeComponent();
      this.InitColumns();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="StudiHelperDataGrid"/> class.
    /// </summary>
    /// <param name="container">The container.</param>
    public StudiHelperDataGrid(IContainer container)
      : base()
    {
      container.Add(this);
    }

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.DataGridView.DataSourceChanged" /> event.
    /// </summary>
    /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
    protected override void OnDataSourceChanged(EventArgs e)
    {
      base.OnDataSourceChanged(e);
      this.InitColumns();
    }
    /// <summary>
    /// Initializes the columns.
    /// </summary>
    private void InitColumns()
    {
      this.Columns.Clear();

      int displayIndex = 0;

      DataGridViewColumn cursIDColumn = new DataGridViewTextBoxColumn
      {
        DataPropertyName = "cursName",
        DisplayIndex = displayIndex,
        HeaderText = "Nummer",
        Name = "cursName",
        ReadOnly = true,
        Visible = true,
        Width = 50
      };

      this.Columns.Add(cursIDColumn);
      displayIndex++;

      DataGridViewColumn cursDescriptionColumn = new DataGridViewTextBoxColumn
      {
        DataPropertyName = "cursDescription",
        DisplayIndex = displayIndex,
        HeaderText = "Beschreibung",
        Name = "cursDescription",
        ReadOnly = true,
        Visible = true,
        Width = 170
      };

      this.Columns.Add(cursDescriptionColumn);
      displayIndex++;

      DataGridViewColumn moduleColumn = new DataGridViewTextBoxColumn
      {
        DataPropertyName = "modul",
        DisplayIndex = displayIndex,
        HeaderText = "Modul",
        Name = "modul",
        ReadOnly = true,
        Visible = true,
        Width = 150
      };

      this.Columns.Add(moduleColumn);
      displayIndex++;

      DataGridViewColumn startDateColumn = new DateGridColumn
      {
        DataPropertyName = "start",
        DisplayIndex = displayIndex,
        HeaderText = "Datum",
        Name = "startDate",
        ReadOnly = true,
        Visible = true,
        Width = 70
      };

      this.Columns.Add(startDateColumn);
      displayIndex++;

      DataGridViewColumn startTimeColumn = new TimeGridColumn
      {
        DataPropertyName = "start",
        DisplayIndex = displayIndex,
        HeaderText = "Start",
        Name = "startTime",
        ReadOnly = true,
        Visible = true,
        Width = 50
      };

      this.Columns.Add(startTimeColumn);
      displayIndex++;

      DataGridViewColumn endTimeColumn = new TimeGridColumn
      {
        DataPropertyName = "end",
        DisplayIndex = displayIndex,
        HeaderText = "Ende",
        Name = "endTime",
        ReadOnly = true,
        Visible = true,
        Width = 50
      };

      this.Columns.Add(endTimeColumn);
      displayIndex++;

      DataGridViewColumn buldingColumn = new DataGridViewTextBoxColumn
      {
        DataPropertyName = "building",
        DisplayIndex = displayIndex,
        HeaderText = "Ort",
        Name = "building",
        ReadOnly = true,
        Visible = true,
        Width = 70
      };

      this.Columns.Add(buldingColumn);
      displayIndex++;

      DataGridViewColumn tutorColumn = new DataGridViewTextBoxColumn
      {
        DataPropertyName = "tutor",
        DisplayIndex = displayIndex,
        HeaderText = "Dozent",
        Name = "tutor",
        ReadOnly = true,
        Visible = true,
        Width = 150
      };

      this.Columns.Add(tutorColumn);
      displayIndex++;
    }

    /// <summary>
    /// Handles the CellFormatting event of the lessonOfCurs control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="DataGridViewCellFormattingEventArgs"/> instance containing the event data.</param>
    private void lessonOfCurs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      MergedLesson lesson = (MergedLesson)this.Rows[e.RowIndex].DataBoundItem;
      
      if (lesson != null)
      {
        this.SetLessonState(e, lesson);     
      }
    }

    /// <summary>
    /// Sets the state of the lesson.
    /// </summary>
    /// <param name="e">The <see cref="DataGridViewCellFormattingEventArgs"/> instance containing the event data.</param>
    /// <param name="lesson">The lesson.</param>
    private void SetLessonState(DataGridViewCellFormattingEventArgs e, MergedLesson lesson)
    {
      if (lesson.End < DateTime.Now)
      {
        e.CellStyle.BackColor = Color.LightGray;
      }

      if (lesson.End > DateTime.Now && lesson.Start <= DateTime.Now)
      {
        e.CellStyle.BackColor = Color.LightGreen;
      }

      if (lesson.Confict && (this.Columns[e.ColumnIndex].Name == "startTime" || this.Columns[e.ColumnIndex].Name == "endTime"))
      {
        e.CellStyle.BackColor = Color.Yellow;
        this.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Vorlesung überschneidet sich mit anderer!";
      }
    }
  }
}