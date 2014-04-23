using StudiHelper.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudiHelper.BusinessLogic
{
  public class BusinessLogicFactory
  {
    private static IBusinessLogic BL;

    public static IBusinessLogic GetInstance()
    {
      if (BL == null)
      {
        BL = new BusinessLogic();
      }
      return BL;
    }

  }

  public interface IBusinessLogic
  {

    List< Module> GetModules();
    List< Curs> GetCursesByModul(int modulID);

    Dictionary<string, Curs> GetCurses();
    List<MergedLesson> GetMergedLessonsOfDay(DateTime day);
    List<MergedLesson> GetMergedLessonsOfWeek(DateTime day, out Dictionary<string, Label> legendLabels, out Dictionary<DayOfWeek, List<Label>> lessonLabels);
    List<MergedLesson> GetMergedLessonsOfCurs(int cursId);
  }

  public class BusinessLogic : IBusinessLogic
  {

    public Dictionary<string, Curs> GetCurses()
    {
      return DataAccess.DataSourceConnectionFactory.GetInstance().GetCurses();
    }

    public List<MergedLesson> GetMergedLessonsOfDay(DateTime day)
    {
      List<MergedLesson> mergedLessons = DataAccess.DataSourceConnectionFactory.GetInstance().GetMergedLessonsOfDay(day);
      ValidationMergedLessons(mergedLessons);
      mergedLessons.Sort();
      return mergedLessons;
    }

    public List<MergedLesson> GetMergedLessonsOfWeek(DateTime day, out Dictionary<string, Label> legendLabels, out Dictionary<DayOfWeek, List<Label>> lessonLabels)
    {
      legendLabels = new Dictionary<string, Label>();
      lessonLabels = new Dictionary<DayOfWeek, List<Label>>();

      List<Objects.MergedLesson> mergedLessons = DataAccess.DataSourceConnectionFactory.GetInstance().GetMergedLessonsOfWeek(day);
      ValidationMergedLessons(mergedLessons);
      mergedLessons.Sort();

      Dictionary<string, Curs> curses = DataAccess.DataSourceConnectionFactory.GetInstance().GetCurses();
      Color backgroundColor;
      Dictionary<string, Color> legendColorFields = new Dictionary<string, Color>();

      foreach (Objects.MergedLesson mergedLesson in mergedLessons)
      {
        if (!legendLabels.ContainsKey(mergedLesson.cursName))
        {
          backgroundColor = GetRandomColor(legendColorFields);
          legendColorFields[mergedLesson.cursName] = backgroundColor;
          legendLabels[mergedLesson.cursName] = GetLegendLabel(backgroundColor, mergedLesson, curses);
        }
        else
        {
          backgroundColor = legendColorFields[mergedLesson.cursName];
        }

        if (!lessonLabels.ContainsKey(mergedLesson.start.DayOfWeek))
        {
          lessonLabels[mergedLesson.start.DayOfWeek] = new List<Label>();
        }
        lessonLabels[mergedLesson.start.DayOfWeek].Add(GetLessonLabel(backgroundColor, mergedLesson));
      }

      return mergedLessons;
    }

    private void ValidationMergedLessons(List<MergedLesson> mergedLessons)
    {
      foreach (MergedLesson validationLesson in mergedLessons)
      {
        foreach (MergedLesson lesson in mergedLessons)
        {

          if (!validationLesson.lessonID.Equals(lesson.lessonID) && !validationLesson.confict)
          {
            if (validationLesson.start >= lesson.start && validationLesson.start <= lesson.end)
            {
              validationLesson.confict = true;
              lesson.confict = true;
              break;
            }

            if (validationLesson.end >= lesson.start && validationLesson.end <= lesson.end)
            {
              validationLesson.confict = true;
              lesson.confict = true;
              break;
            }
          }
        }
      }
    }

    private Label GetLegendLabel(Color backgroundColor, Objects.MergedLesson mergedLesson, Dictionary<string, Curs> curses)
    {
      Label legendLabel = new Label();
      legendLabel.AutoSize = false;
      legendLabel.Dock = DockStyle.Left;
      legendLabel.Name = mergedLesson.cursName;
      legendLabel.Text = curses[mergedLesson.cursName].Name + Environment.NewLine + curses[mergedLesson.cursName].Description;
      legendLabel.BackColor = backgroundColor;
      legendLabel.Width = 70;
      legendLabel.TextAlign = ContentAlignment.MiddleCenter;

      return legendLabel;
    }
    
    private Label GetLessonLabel(Color backgroundColor, Objects.MergedLesson mergedLesson)
    {
      Label lessonLabel = new Label();

      lessonLabel.AutoSize = false;
      lessonLabel.Dock = DockStyle.Top;
      lessonLabel.Name = mergedLesson.cursName + mergedLesson.start.ToShortTimeString();
      lessonLabel.BorderStyle = BorderStyle.Fixed3D;

      if (mergedLesson.confict)
      {
        lessonLabel.Text = "Achtung Überschneidung!\r" + mergedLesson.start.ToShortTimeString() + " - " + mergedLesson.end.ToShortTimeString();
      }
      else 
      {
        lessonLabel.Text = mergedLesson.start.ToShortTimeString() + " - " + mergedLesson.end.ToShortTimeString();
      }

      lessonLabel.BackColor = backgroundColor;
      lessonLabel.Height = 50;
      lessonLabel.TextAlign = ContentAlignment.MiddleCenter;
      lessonLabel.Tag = mergedLesson;

      return lessonLabel;
    }

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

    public List< Module> GetModules()
    {
      return DataAccess.DataSourceConnectionFactory.GetInstance().GetModules();
    }

    public List< Curs> GetCursesByModul(int modulID)
    {
      return DataAccess.DataSourceConnectionFactory.GetInstance().GetCursesByModul(modulID);
    }

    public List<MergedLesson> GetMergedLessonsOfCurs(int cursId)
    {
      List<MergedLesson> mergedLessons = DataAccess.DataSourceConnectionFactory.GetInstance().GetMergedLessonsOfCurs(cursId);
      ValidationMergedLessons(mergedLessons);
      mergedLessons.Sort();
      return mergedLessons;
    }
  }
}
