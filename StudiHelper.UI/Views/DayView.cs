using System;
namespace StudiHelper.UI
{
  using System.Windows.Forms;
  using StudiHelper.Core.BusinessLogic;

  /// <summary>
  /// View to display all lessons on day
  /// </summary>
  public partial class DayView : UserControl
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="DayView"/> class.
    /// </summary>
    public DayView()
    {
      this.InitializeComponent();
    }

    /// <summary>
    /// Handles the Click event of the loadLessonsOfDay control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void loadLessonsOfDay_Click(object sender, EventArgs e)
    {
      this.LessonsOfDay.DataSource = BusinessLogicFactory.GetInstance().GetMergedLessonsOfDay(DayPickerDay.Value);
    }
  }
}