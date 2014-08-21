namespace StudiHelper.UI
{
  using System;
  using System.Windows.Forms;

  /// <summary>
  /// Main Form
  /// </summary>
  public partial class MainForm : Form
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class.
    /// </summary>
    public MainForm()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Handles the Click event of the settingsMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    /// <exception cref="System.NotImplementedException"></exception>
    private void settingsMenuItem_Click(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Handles the Click event of the closeMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void closeMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    /// <summary>
    /// Handles the Click event of the infoMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    /// <exception cref="System.NotImplementedException"></exception>
    private void infoMenuItem_Click(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Handles the Click event of the updateMenuItem control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    /// <exception cref="System.NotImplementedException"></exception>
    private void updateMenuItem_Click(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }
  }
}