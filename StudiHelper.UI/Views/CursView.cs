namespace StudiHelper.UI
{
  using System;
  using System.Collections.Generic;
  using System.Windows.Forms;
  using StudiHelper.Core.BusinessLogic;
  using StudiHelper.Core.Objects;

  /// <summary>
  /// View to display all lesssons of a curs
  /// </summary>
  public partial class CursView : UserControl
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="CursView"/> class.
    /// </summary>
    public CursView()
    {
      this.InitializeComponent();
    }

    /// <summary>
    /// Handles the Click event of the cursInfo control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void cursInfo_Click(object sender, EventArgs e)
    {
      if (this.CursIsSelected())
      {
        Curs selectedCurs = (Curs)CursCombobox.SelectedItem;

        using (InfoForm info = new InfoForm())
        {
          info.SetTitel(selectedCurs.ToString());
          info.SetInfoText(selectedCurs.CursInfo);
          info.ShowDialog();
        }
      }
    }

    /// <summary>
    /// Curses the is selected.
    /// </summary>
    /// <returns></returns>
    private bool CursIsSelected()
    {
      if (this.ModuleCombobox.SelectedItem == null || this.CursCombobox.SelectedItem == null)
      {
        MessageBox.Show("Wählen Sie zuerst ein Modul und einen Kurs aus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return false;
      }
      else
      {
        return true;
      }
    }

    /// <summary>
    /// Handles the Load event of the CursView control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void CursView_Load(object sender, EventArgs e)
    {
      if (!this.DesignMode)
      {
        this.ModuleCombobox.DataSource = BusinessLogicFactory.GetInstance().GetModules();
      }
    }

    /// <summary>
    /// Handles the Click event of the deleteCurs control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void deleteCurs_Click(object sender, EventArgs e)
    {
      if (!this.CursIsSelected())
      {
        return;
      }

      if (MessageBox.Show("Soll der Kurs wirklich gelöscht werden?", "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
      {
        BusinessLogicFactory.GetInstance().DeleteCurs(((Curs)CursCombobox.SelectedItem).CursID);
      }

      this.RefreshCurses(true);
    }

    /// <summary>
    /// Handles the Click event of the deleteLessons control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void deleteLessons_Click(object sender, EventArgs e)
    {
      if (!this.CursIsSelected())
      {
        return;
      }

      if (this.lessonOfCurs.DataSource == null ||
        this.lessonOfCurs.SelectedRows.Count == 0)
      {
        MessageBox.Show("Wählen Sie zuerst die zu löschenden Vorlesungen aus.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      if (MessageBox.Show("Sollen die markierten Vorlesungen wirklich gelöscht werden?", "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
      {
        List<int> lessonIDs = new List<int>();

        foreach (DataGridViewRow row in lessonOfCurs.SelectedRows)
        {
          lessonIDs.Add(((MergedLesson)row.DataBoundItem).LessonID);
        }

        BusinessLogicFactory.GetInstance().DeleteLessons(lessonIDs);
      }

      this.RefreshLessons();
    }

    /// <summary>
    /// Handles the Click event of the loadOfCurs control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void loadOfCurs_Click(object sender, EventArgs e)
    {
      if (this.CursIsSelected())
      {
        this.RefreshLessons();
      }
    }

    /// <summary>
    /// Handles the SelectedIndexChanged event of the ModuleCombobox control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void ModuleCombobox_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.RefreshCurses(false);
    }

    /// <summary>
    /// Handles the Click event of the moduleInfo control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void moduleInfo_Click(object sender, EventArgs e)
    {
      if (this.ModuleIsSelected())
      {
        Module selectedModule = (Module)ModuleCombobox.SelectedItem;

        using (InfoForm info = new InfoForm())
        {
          info.SetTitel(selectedModule.ToString());
          info.SetInfoText(selectedModule.ModuleInfo);
          info.ShowDialog();
        }
      }
    }

    /// <summary>
    /// Modules the is selected.
    /// </summary>
    /// <returns></returns>
    private bool ModuleIsSelected()
    {
      if (this.ModuleCombobox.SelectedItem == null)
      {
        MessageBox.Show("Wählen Sie zuerst ein Modul aus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return false;
      }
      else
      {
        return true;
      }
    }

    /// <summary>
    /// Refreshes the curses.
    /// </summary>
    private void RefreshCurses(bool refreshGrid)
    {
      this.CursCombobox.SelectedItem = null;
      this.CursCombobox.DataSource = BusinessLogicFactory.GetInstance().GetCursesByModul(((Module)ModuleCombobox.SelectedItem).ModuleID);

      if (refreshGrid)
      {
        this.lessonOfCurs.DataSource = null;
      }
    }

    /// <summary>
    /// Refreshes the lessons.
    /// </summary>
    private void RefreshLessons()
    {
      lessonOfCurs.DataSource = BusinessLogicFactory.GetInstance().GetMergedLessonsOfCurs(((Curs)CursCombobox.SelectedItem).CursID);
    }
  }
}