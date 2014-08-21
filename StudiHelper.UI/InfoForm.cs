using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudiHelper.UI
{
  public partial class InfoForm : Form
  {
    public InfoForm()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Sets the titel.
    /// </summary>
    /// <param name="titel">The titel.</param>
    public void SetTitel (string titel)
    {
      this.titel.Text = titel;
    }

    /// <summary>
    /// Sets the information text.
    /// </summary>
    /// <param name="infoText">The information text.</param>
    public void SetInfoText (string infoText)
    {
      this.infoField.Text = infoText;
    }

    /// <summary>
    /// Handles the Click event of the close control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void close_Click(object sender, EventArgs e)
    {
      this.Close();
    }

  }
}
