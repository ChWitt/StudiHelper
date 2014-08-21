using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using StudiHelper.Core.Objects;

namespace StudiHelper.Core.DataAccess
{
  /// <summary>
  /// Interface of the DataConnection for the StudiHelper
  /// </summary>
  public interface IDataSourceConnection
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
    /// Gets the connection.
    /// </summary>
    /// <returns>an sql connection</returns>
    SqlConnection GetConnection();

    /// <summary>
    /// Gets the curses.
    /// </summary>
    /// <returns>a dictionary with all curses</returns>
    Dictionary<string, Curs> GetCurses();

    /// <summary>
    /// Gets the curses by modul.
    /// </summary>
    /// <param name="modulID">The modul identifier.</param>
    /// <returns>a list with all curses of a module</returns>
    List<Curs> GetCursesByModul(int modulID);

    /// <summary>
    /// Gets the merged lessons of curs.
    /// </summary>
    /// <param name="cursId">The curs identifier.</param>
    /// <returns>list with merged lessons of a curse</returns>
    List<MergedLesson> GetMergedLessonsOfCurs(int cursId);

    /// <summary>
    /// Gets the merged lessons of day.
    /// </summary>
    /// <param name="day">The day.</param>
    /// <returns>list with merged lessons of a day</returns>
    List<MergedLesson> GetMergedLessonsOfDay(DateTime day);

    /// <summary>
    /// Gets the merged lessons of week.
    /// </summary>
    /// <param name="day">The day.</param>
    /// <returns>list with merged lessons of a week</returns>
    List<MergedLesson> GetMergedLessonsOfWeek(DateTime day);

    /// <summary>
    /// Gets the modules.
    /// </summary>
    /// <returns>list of the modules</returns>
    List<Module> GetModules();
  }

  /// <summary>
  /// the data connection of the StudiHelper
  /// </summary>
  public class DataSourceConnection : IDataSourceConnection
  {
    /// <summary>
    /// Deletes the curs.
    /// </summary>
    /// <param name="cursID">The curs identifier.</param>
    public void DeleteCurs(int cursID)
    {
      using (SqlConnection connection = this.GetConnection())
      {
        connection.Open();
        SqlCommand command = new SqlCommand("DeleteCurs", connection);
        command.CommandType = System.Data.CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@cursID", cursID);

        command.ExecuteNonQuery();
      }
    }

    /// <summary>
    /// Deletes the lessons.
    /// </summary>
    /// <param name="lessonIDs">The lesson i ds.</param>
    public void DeleteLessons(List<int> lessonIDs)
    {
      using (SqlConnection connection = this.GetConnection())
      {
        connection.Open();
        SqlCommand command = new SqlCommand("DELETE FROM Lesson WHERE lessonID = @lessonID", connection);
        command.Parameters.Add("@lessonID", System.Data.SqlDbType.Int);

        foreach (int lessonID in lessonIDs)
        {
          command.Parameters["@lessonID"].Value = lessonID;
          command.ExecuteNonQuery();
        }
      }
    }

    /// <summary>
    /// Gets the connection.
    /// </summary>
    /// <returns>
    /// an sql connection
    /// </returns>
    public SqlConnection GetConnection()
    {
      string connString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\DataSource\\Data.mdf;Integrated Security=True";
      return new SqlConnection(connString);
    }

    /// <summary>
    /// Gets the curses.
    /// </summary>
    /// <returns>
    /// a dictionary with all curses
    /// </returns>
    public Dictionary<string, Curs> GetCurses()
    {
      Dictionary<string, Curs> curses = new Dictionary<string, Curs>();

      using (SqlConnection connection = this.GetConnection())
      {
        connection.Open();
        SqlCommand command = new SqlCommand("SELECT * FROM Curs", connection);

        SqlDataReader dataReader = command.ExecuteReader();
        while (dataReader.Read())
        {
          Curs curs = new Curs()
          {
            CursID = (int)dataReader["cursID"],
            Name = (string)dataReader["name"],
            ModuleID = (int)dataReader["modulID"],
            CreditPoints = (int)dataReader["creditPoints"],
            Description = dataReader["description"] == DBNull.Value ? string.Empty : (string)dataReader["description"],
            CursInfo = dataReader["info"] == DBNull.Value ? string.Empty : (string)dataReader["info"],
            Relevance = (ERelevance)((int)dataReader["relevance"])
          };

          curses.Add(curs.Name, curs);
        }
      }

      return curses;
    }

    /// <summary>
    /// Gets the curses by modul.
    /// </summary>
    /// <param name="modulID">The modul identifier.</param>
    /// <returns>
    /// a list with all curses of a module
    /// </returns>
    public List<Curs> GetCursesByModul(int modulID)
    {
      List<Curs> curses = new List<Curs>();

      using (SqlConnection connection = this.GetConnection())
      {
        connection.Open();
        SqlCommand command = new SqlCommand("SELECT * FROM Curs WHERE modulID = @modulID", connection);
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
            Description = dataReader["description"] == DBNull.Value ? string.Empty : (string)dataReader["description"],
            CursInfo = dataReader["info"] == DBNull.Value ? string.Empty : (string)dataReader["info"],
            Relevance = (ERelevance)((int)dataReader["relevance"])
          };

          curses.Add(curs);
        }
      }

      return curses;
    }

    /// <summary>
    /// Gets the merged lessons of curs.
    /// </summary>
    /// <param name="cursId">The curs identifier.</param>
    /// <returns>
    /// list with merged lessons of a curse
    /// </returns>
    public List<MergedLesson> GetMergedLessonsOfCurs(int cursId)
    {
      List<MergedLesson> mergedLessons = new List<MergedLesson>();

      using (SqlConnection connection = this.GetConnection())
      {
        connection.Open();
        SqlCommand command = new SqlCommand("SELECT * FROM GetAllOfCurs(@cursID)", connection);

        command.Parameters.AddWithValue("@cursID", cursId);

        SqlDataReader dataReader = command.ExecuteReader();
        while (dataReader.Read())
        {
          MergedLesson mergedLesson = new MergedLesson()
          {
            LessonID = (int)dataReader["lessonID"],
            CursName = (string)dataReader["cursName"],
            CursDescription = (string)dataReader["cursDescription"],
            Start = (System.DateTime)dataReader["start"],
            End = (System.DateTime)dataReader["end"],
            Building = (string)dataReader["building"],
            Tutor = (string)dataReader["tutorName"],
            Modul = (string)dataReader["modulName"]
          };

          mergedLessons.Add(mergedLesson);
        }
      }

      return mergedLessons;
    }

    /// <summary>
    /// Gets the merged lessons of day.
    /// </summary>
    /// <param name="day">The day.</param>
    /// <returns>
    /// list with merged lessons of a day
    /// </returns>
    public List<MergedLesson> GetMergedLessonsOfDay(DateTime day)
    {
      List<MergedLesson> mergedLessons = new List<MergedLesson>();

      using (SqlConnection connection = this.GetConnection())
      {
        connection.Open();
        SqlCommand command = new SqlCommand("SELECT * FROM GetAllOfDay(@Day)", connection);

        command.Parameters.AddWithValue("@Day", day);

        SqlDataReader dataReader = command.ExecuteReader();
        while (dataReader.Read())
        {
          MergedLesson mergedLesson = new MergedLesson()
          {
            LessonID = (int)dataReader["lessonID"],
            CursName = (string)dataReader["cursName"],
            CursDescription = (string)dataReader["cursDescription"],
            Start = (System.DateTime)dataReader["start"],
            End = (System.DateTime)dataReader["end"],
            Building =(string)dataReader["building"],
            Tutor = (string)dataReader["tutorName"],
            Modul = (string)dataReader["modulName"]
          };

          mergedLessons.Add(mergedLesson);
        }
      }

      return mergedLessons;
    }

    /// <summary>
    /// Gets the merged lessons of week.
    /// </summary>
    /// <param name="day">The day.</param>
    /// <returns>
    /// list with merged lessons of a week
    /// </returns>
    public List<MergedLesson> GetMergedLessonsOfWeek(DateTime day)
    {
      List<MergedLesson> mergedLessons = new List<MergedLesson>();

      using (SqlConnection connection = this.GetConnection())
      {
        connection.Open();
        SqlCommand command = new SqlCommand("SELECT * FROM GetAllOfWeek(@FirstDayOfWeek, @LastDayOfWeek)", connection);

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
            LessonID = (int)dataReader["lessonID"],
            CursName = (string)dataReader["cursName"],
            CursDescription = (string)dataReader["cursDescription"],
            Start = (System.DateTime)dataReader["start"],
            End = (System.DateTime)dataReader["end"],
            Building = (string)dataReader["building"],
            Tutor = (string)dataReader["tutorName"],
            Modul = (string)dataReader["modulName"]
          };

          mergedLessons.Add(mergedLesson);
        }
      }

      return mergedLessons;
    }

    /// <summary>
    /// Gets the modules.
    /// </summary>
    /// <returns>
    /// list of the modules
    /// </returns>
    public List<Module> GetModules()
    {
      List<Module> moduls = new List<Module>();

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
            Description = dataReader["description"] == DBNull.Value ? string.Empty : (string)dataReader["description"],
            ModuleInfo = dataReader["info"] == DBNull.Value ? string.Empty : (string)dataReader["info"]
          };

          moduls.Add(modul);
        }
      }

      return moduls;
    }
  }

  /// <summary>
  /// Factory to get the data connection
  /// </summary>
  public class DataSourceConnectionFactory
  {
    private static IDataSourceConnection Connection;

    /// <summary>
    /// Gets the instance.
    /// </summary>
    /// <returns>a instance of the data connection</returns>
    public static IDataSourceConnection GetInstance()
    {
      if (Connection == null)
      {
        Connection = new DataSourceConnection();
      }
      return Connection;
    }
  }
}