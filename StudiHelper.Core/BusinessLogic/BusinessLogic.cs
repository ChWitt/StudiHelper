
namespace StudiHelper.Core.BusinessLogic
{
  using System;
  using System.Collections.Generic;
  using System.Drawing;
  using System.Windows.Forms;
  using StudiHelper.Core.Objects;

  /// <summary>
  /// Interface of the logic for the StudiHelper
  /// </summary>
  public interface IBusinessLogic
  {
    /// <summary>
    /// Deletes the curs.
    /// </summary>
    /// <param name="cursID">The curs identifier.</param>
    void DeleteCurs(int cursID);

    /// <summary>
    /// Deletes the lessons.
    /// </summary>
    /// <param name="lessonIDs">The lesson i ds.</param>
    void DeleteLessons(List<int> lessonIDs);

    /// <summary>
    /// Gets the curses.
    /// </summary>
    /// <returns>all curses</returns>
    Dictionary<string, Curs> GetCurses();

    /// <summary>
    /// Gets the curses by modul.
    /// </summary>
    /// <param name="modulID">The modul identifier.</param>
    /// <returns>all curses in the module</returns>
    List<Curs> GetCursesByModul(int modulID);

    /// <summary>
    /// Gets the merged lessons of curs.
    /// </summary>
    /// <param name="cursId">The curs identifier.</param>
    /// <returns>merged lessons by curse</returns>
    List<MergedLesson> GetMergedLessonsOfCurs(int cursId);

    /// <summary>
    /// Gets the merged lessons of day.
    /// </summary>
    /// <param name="day">The day.</param>
    /// <returns>merged lessons by day</returns>
    List<MergedLesson> GetMergedLessonsOfDay(DateTime day);

    /// <summary>
    /// Gets the merged lessons of week.
    /// </summary>
    /// <param name="day">The day.</param>
    /// <param name="legendLabels">The legend labels.</param>
    /// <param name="lessonLabels">The lesson labels.</param>
    /// <returns>merged lessons by week</returns>
    List<MergedLesson> GetMergedLessonsOfWeek(DateTime day, out Dictionary<string, Label> legendLabels, out Dictionary<DayOfWeek, List<Label>> lessonLabels);

    /// <summary>
    /// Gets the modules.
    /// </summary>
    /// <returns>get all modules</returns>
    List<Module> GetModules();
  }

  /// <summary>
  /// the logic of the StudiHelper
  /// </summary>
  public class BusinessLogic : IBusinessLogic
  {
    /// <summary>
    /// Deletes the curs.
    /// </summary>
    /// <param name="cursID">The curs identifier.</param>
    public void DeleteCurs(int cursID)
    {
      DataAccess.DataSourceConnectionFactory.GetInstance().DeleteCurs(cursID);
    }

    /// <summary>
    /// Deletes the lessons.
    /// </summary>
    /// <param name="lessonIDs">The lesson i ds.</param>
    public void DeleteLessons(List<int> lessonIDs)
    {
      DataAccess.DataSourceConnectionFactory.GetInstance().DeleteLessons(lessonIDs);
    }

    /// <summary>
    /// Gets the curses.
    /// </summary>
    /// <returns>
    /// all curses
    /// </returns>
    public Dictionary<string, Curs> GetCurses()
    {
      return DataAccess.DataSourceConnectionFactory.GetInstance().GetCurses();
    }

    /// <summary>
    /// Gets the curses by modul.
    /// </summary>
    /// <param name="modulID">The modul identifier.</param>
    /// <returns>
    /// all curses in the module
    /// </returns>
    public List<Curs> GetCursesByModul(int modulID)
    {
      return DataAccess.DataSourceConnectionFactory.GetInstance().GetCursesByModul(modulID);
    }

    /// <summary>
    /// Gets the merged lessons of curs.
    /// </summary>
    /// <param name="cursId">The curs identifier.</param>
    /// <returns>
    /// merged lessons by curse
    /// </returns>
    public List<MergedLesson> GetMergedLessonsOfCurs(int cursId)
    {
      List<MergedLesson> mergedLessons = DataAccess.DataSourceConnectionFactory.GetInstance().GetMergedLessonsOfCurs(cursId);
      this.ValidationMergedLessons(mergedLessons);
      mergedLessons.Sort();
      return mergedLessons;
    }

    /// <summary>
    /// Gets the merged lessons of day.
    /// </summary>
    /// <param name="day">The day.</param>
    /// <returns>
    /// merged lessons by day
    /// </returns>
    public List<MergedLesson> GetMergedLessonsOfDay(DateTime day)
    {
      List<MergedLesson> mergedLessons = DataAccess.DataSourceConnectionFactory.GetInstance().GetMergedLessonsOfDay(day);
      this.ValidationMergedLessons(mergedLessons);
      mergedLessons.Sort();
      return mergedLessons;
    }

    /// <summary>
    /// Gets the merged lessons of week.
    /// </summary>
    /// <param name="day">The day.</param>
    /// <param name="legendLabels">The legend labels.</param>
    /// <param name="lessonLabels">The lesson labels.</param>
    /// <returns>
    /// merged lessons by week
    /// </returns>
    public List<MergedLesson> GetMergedLessonsOfWeek(DateTime day, out Dictionary<string, Label> legendLabels, out Dictionary<DayOfWeek, List<Label>> lessonLabels)
    {
      legendLabels = new Dictionary<string, Label>();
      lessonLabels = new Dictionary<DayOfWeek, List<Label>>();

      List<Objects.MergedLesson> mergedLessons = DataAccess.DataSourceConnectionFactory.GetInstance().GetMergedLessonsOfWeek(day);
      this.ValidationMergedLessons(mergedLessons);
      mergedLessons.Sort();

      Dictionary<string, Curs> curses = DataAccess.DataSourceConnectionFactory.GetInstance().GetCurses();
      Color backgroundColor;
      Dictionary<string, Color> legendColorFields = new Dictionary<string, Color>();

      foreach (Objects.MergedLesson mergedLesson in mergedLessons)
      {
        if (!legendLabels.ContainsKey(mergedLesson.CursName))
        {
          backgroundColor = this.GetRandomColor(legendColorFields);
          legendColorFields[mergedLesson.CursName] = backgroundColor;
          legendLabels[mergedLesson.CursName] = this.GetLegendLabel(backgroundColor, mergedLesson, curses);
        }
        else
        {
          backgroundColor = legendColorFields[mergedLesson.CursName];
        }

        if (!lessonLabels.ContainsKey(mergedLesson.Start.DayOfWeek))
        {
          lessonLabels[mergedLesson.Start.DayOfWeek] = new List<Label>();
        }
        lessonLabels[mergedLesson.Start.DayOfWeek].Add(this.GetLessonLabel(backgroundColor, mergedLesson));
      }

      return mergedLessons;
    }

    /// <summary>
    /// Gets the modules.
    /// </summary>
    /// <returns>
    /// get all modules
    /// </returns>
    public List<Module> GetModules()
    {
      return DataAccess.DataSourceConnectionFactory.GetInstance().GetModules();
    }

    /// <summary>
    /// Gets the legend label.
    /// </summary>
    /// <param name="backgroundColor">Color of the background.</param>
    /// <param name="mergedLesson">The merged lesson.</param>
    /// <param name="curses">The curses.</param>
    /// <returns>get the named label for the legend</returns>
    private Label GetLegendLabel(Color backgroundColor, Objects.MergedLesson mergedLesson, Dictionary<string, Curs> curses)
    {
      Label legendLabel = new Label();
      legendLabel.AutoSize = false;
      legendLabel.Dock = DockStyle.Left;
      legendLabel.Name = mergedLesson.CursName;
      legendLabel.Text = curses[mergedLesson.CursName].Name + Environment.NewLine + curses[mergedLesson.CursName].Description;
      legendLabel.BackColor = backgroundColor;
      legendLabel.Width = 100;
      legendLabel.TextAlign = ContentAlignment.MiddleCenter;

      return legendLabel;
    }

    /// <summary>
    /// Gets the lesson label.
    /// </summary>
    /// <param name="backgroundColor">Color of the background.</param>
    /// <param name="mergedLesson">The merged lesson.</param>
    /// <returns>get the named label for the lesson</returns>
    private Label GetLessonLabel(Color backgroundColor, Objects.MergedLesson mergedLesson)
    {
      Label lessonLabel = new Label();

      lessonLabel.AutoSize = false;
      lessonLabel.Dock = DockStyle.Top;
      lessonLabel.Name = mergedLesson.CursName + mergedLesson.Start.ToShortTimeString();
      lessonLabel.BorderStyle = BorderStyle.Fixed3D;

      if (mergedLesson.Confict)
      {
        lessonLabel.Text = "Achtung Überschneidung!\r" + mergedLesson.Start.ToShortTimeString() + " - " + mergedLesson.End.ToShortTimeString();
      }
      else
      {
        lessonLabel.Text = mergedLesson.Start.ToShortTimeString() + " - " + mergedLesson.End.ToShortTimeString();
      }

      lessonLabel.BackColor = backgroundColor;
      lessonLabel.Height = 50;
      lessonLabel.TextAlign = ContentAlignment.MiddleCenter;
      lessonLabel.Tag = mergedLesson;

      return lessonLabel;
    }

    /// <summary>
    /// Gets the random color.
    /// </summary>
    /// <param name="legendFields">The legend fields.</param>
    /// <returns>get a background color for the lesson and legend label</returns>
    private Color GetRandomColor(Dictionary<string, Color> legendFields)
    {
      Color selectedColor;
      do
      {
        Random random = new Random();
        selectedColor = Color.FromArgb(150, random.Next(255), random.Next(255), random.Next(255));
      } while (legendFields.ContainsValue(selectedColor));

      return selectedColor;
    }

    /// <summary>
    /// Validations the merged lessons.
    /// </summary>
    /// <param name="mergedLessons">The merged lessons.</param>
    private void ValidationMergedLessons(List<MergedLesson> mergedLessons)
    {
      foreach (MergedLesson validationLesson in mergedLessons)
      {
        foreach (MergedLesson lesson in mergedLessons)
        {
          if (!validationLesson.LessonID.Equals(lesson.LessonID) && !validationLesson.Confict)
          {
            if (validationLesson.Start >= lesson.Start && validationLesson.Start <= lesson.End)
            {
              validationLesson.Confict = true;
              lesson.Confict = true;
              break;
            }

            if (validationLesson.End >= lesson.Start && validationLesson.End <= lesson.End)
            {
              validationLesson.Confict = true;
              lesson.Confict = true;
              break;
            }
          }
        }
      }
    }
  }

  /// <summary>
  /// the factory to get the business logic
  /// </summary>
  public class BusinessLogicFactory
  {
    private static IBusinessLogic BL;

    /// <summary>
    /// Gets the instance.
    /// </summary>
    /// <returns>a instance of the business logic</returns>
    public static IBusinessLogic GetInstance()
    {
      if (BL == null)
      {
        BL = new BusinessLogic();
      }
      return BL;
    }
  }
}