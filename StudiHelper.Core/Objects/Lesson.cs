/// <summary>
/// Name space for all objects in this project
/// </summary>
namespace StudiHelper.Core.Objects
{
  using System;

  /// <summary>
  /// Class that display an object of type 'Lesson'
  /// </summary>
  public class Lesson
  {
    /// <summary>
    /// Gets or sets the building.
    /// </summary>
    /// <value>
    /// The building.
    /// </value>
    public string Building { get; set; }

    /// <summary>
    /// Gets or sets the curs identifier.
    /// </summary>
    /// <value>
    /// The curs identifier.
    /// </value>
    public int CursID { get; set; }

    /// <summary>
    /// Gets or sets the end.
    /// </summary>
    /// <value>
    /// The end.
    /// </value>
    public DateTime End { get; set; }

    /// <summary>
    /// Gets or sets the lesson identifier.
    /// </summary>
    /// <value>
    /// The lesson identifier.
    /// </value>
    public int LessonID { get; set; }

    /// <summary>
    /// Gets or sets the start.
    /// </summary>
    /// <value>
    /// The start.
    /// </value>
    public DateTime Start { get; set; }
  }
}