using StudiHelper.Core.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace StudiHelper.Core.DataAccess
{

  public class DataSourceConnectionFactory
  {
    private static IDataSourceConnection Connection;

    public static IDataSourceConnection GetInstance()
    {
      if (Connection == null)
      {
        Connection = new DataSourceConnection();
      }
      return Connection;
    }

  }

  public interface IDataSourceConnection
  {
    SqlConnection GetConnection();

    List< Module> GetModules();
    Dictionary<string, Curs> GetCurses();
    List< Curs> GetCursesByModul(int modulID);

    List<MergedLesson> GetMergedLessonsOfDay(DateTime day);
    List<MergedLesson> GetMergedLessonsOfWeek(DateTime day);
    List<MergedLesson> GetMergedLessonsOfCurs(int cursId);

  }

  public class DataSourceConnection : IDataSourceConnection
  {
      
    public SqlConnection GetConnection() 
    {
      string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\DataSource\\Data.mdf;Integrated Security=True";
      return new SqlConnection(connString);
    }


    public List< Module> GetModules()
    {
      List<Module> moduls = new List< Module>();

      using (SqlConnection Connection = GetConnection())
      {
        Connection.Open();
        SqlCommand command = new SqlCommand("SELECT * FROM Modul", Connection);

        SqlDataReader dataReader = command.ExecuteReader();
        while (dataReader.Read())
        {

          Module modul = new Module()
          {
            ModuleID = (int)dataReader["moduleID"],
            Number = (int)dataReader["number"],
            Name = (string)dataReader["name"],
            Description = dataReader["description"] == DBNull.Value ? string.Empty : (string)dataReader["description"]
          };

          moduls.Add(modul);
        }
      }

      return moduls;
    }

    public List< Curs> GetCursesByModul(int modulID)
    {
      List<Curs> curses = new List< Curs>();

      using (SqlConnection Connection = GetConnection())
      {
        Connection.Open();
        SqlCommand command = new SqlCommand("SELECT * FROM Curs WHERE modulID = @modulID", Connection);
        command.Parameters.AddWithValue("@modulID", modulID);

        SqlDataReader dataReader = command.ExecuteReader();
        while (dataReader.Read())
        {

          Curs curs = new Curs()
          {
            CursID = (int)dataReader["cursID"],
            Name = (string)dataReader["name"],
            ModuleID = (int)dataReader["modulID"],
            CreditPoints = (int)dataReader["creditPoints"],
            Description = dataReader["description"] == DBNull.Value ? string.Empty : (string)dataReader["description"]
          };

          curses.Add( curs);
        }
      }

      return curses;
    }
    public Dictionary<string, Curs> GetCurses()
    {
      Dictionary<string, Curs> curses = new Dictionary<string,Curs>();

      using (SqlConnection Connection = GetConnection())
      {
        Connection.Open();
        SqlCommand command = new SqlCommand("SELECT * FROM Curs", Connection);

        SqlDataReader dataReader = command.ExecuteReader();
        while (dataReader.Read())
        {

          Curs curs = new Curs()
          {
            CursID = (int)dataReader["cursID"],
            Name = (string)dataReader["name"],
            ModuleID = (int)dataReader["modulID"],
            CreditPoints = (int)dataReader["creditPoints"],
            Description = dataReader["description"] == DBNull.Value ? string.Empty : (string)dataReader["description"] 
          };
            
          curses.Add(curs.Name, curs);
        }
      }

      return curses;
    }

    public List<MergedLesson> GetMergedLessonsOfDay(DateTime day)
    { 
      List<MergedLesson> mergedLessons = new List<MergedLesson>();

      using (SqlConnection Connection = GetConnection())
      {
        Connection.Open();
        SqlCommand command = new SqlCommand("SELECT * FROM GetAllOfDay(@Day)", Connection);

        command.Parameters.AddWithValue("@Day", day);
        
        SqlDataReader dataReader = command.ExecuteReader();
        while (dataReader.Read())
        {

          MergedLesson mergedLesson = new MergedLesson()
          {
            lessonID = (int)dataReader["lessonID"],
            cursName = (string)dataReader["cursName"],
            cursDescription = (string)dataReader["cursDescription"],
            start = (System.DateTime)dataReader["start"],
            end = (System.DateTime)dataReader["end"],
            building = (Building)((int)dataReader["building"]),
            tutor = (string)dataReader["tutorName"],
            modul = (string)dataReader["modulName"]
          };
          
          mergedLessons.Add(mergedLesson);
        }
      }
      
      return mergedLessons;
    }

    public List<MergedLesson> GetMergedLessonsOfWeek(DateTime day)
    {
      List<MergedLesson> mergedLessons = new List<MergedLesson>();

      using (SqlConnection Connection = GetConnection())
      {
        Connection.Open();
        SqlCommand command = new SqlCommand("SELECT * FROM GetAllOfWeek(@FirstDayOfWeek, @LastDayOfWeek)", Connection);

        DateTime firstDayOfWeek, lastDayOfWeek;
        firstDayOfWeek = day.AddDays(CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek - day.DayOfWeek);
        lastDayOfWeek = firstDayOfWeek.AddDays(6);

        command.Parameters.AddWithValue("@FirstDayOfWeek", firstDayOfWeek);
        command.Parameters.AddWithValue("@LastDayOfWeek", lastDayOfWeek);

        SqlDataReader dataReader = command.ExecuteReader();
        while (dataReader.Read())
        {

          MergedLesson mergedLesson = new MergedLesson()
          {
            lessonID = (int)dataReader["lessonID"],
            cursName = (string)dataReader["cursName"],
            cursDescription = (string)dataReader["cursDescription"],
            start = (System.DateTime)dataReader["start"],
            end = (System.DateTime)dataReader["end"],
            building = (Building)((int)dataReader["building"]),
            tutor = (string)dataReader["tutorName"],
            modul = (string)dataReader["modulName"]
          };

          mergedLessons.Add(mergedLesson);
        }
      }

      return mergedLessons;
    }

    public List<MergedLesson> GetMergedLessonsOfCurs(int cursId)
    {
      List<MergedLesson> mergedLessons = new List<MergedLesson>();

      using (SqlConnection Connection = GetConnection())
      {
        Connection.Open();
        SqlCommand command = new SqlCommand("SELECT * FROM GetAllOfCurs(@cursID)", Connection);

        command.Parameters.AddWithValue("@cursID", cursId);

        SqlDataReader dataReader = command.ExecuteReader();
        while (dataReader.Read())
        {

          MergedLesson mergedLesson = new MergedLesson()
          {
            lessonID = (int)dataReader["lessonID"],
            cursName = (string)dataReader["cursName"],
            cursDescription = (string)dataReader["cursDescription"],
            start = (System.DateTime)dataReader["start"],
            end = (System.DateTime)dataReader["end"],
            building = (Building)((int)dataReader["building"]),
            tutor = (string)dataReader["tutorName"],
            modul = (string)dataReader["modulName"]
          };

          mergedLessons.Add(mergedLesson);
        }
      }

      return mergedLessons;
    }
  }
}
