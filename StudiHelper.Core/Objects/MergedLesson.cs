using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiHelper.Core.Objects
{
  public class MergedLesson : IComparable<MergedLesson>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="MergedLesson"/> class.
    /// </summary>
    public MergedLesson()
    {
      this.Confict = false;
    }

    /// <summary>
    /// Gets or sets the building.
    /// </summary>
    /// <value>
    /// The building.
    /// </value>
    public string Building { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="MergedLesson"/> is confict.
    /// </summary>
    /// <value>
    ///   <c>true</c> if confict; otherwise, <c>false</c>.
    /// </value>
    public bool Confict { get; set; }

    /// <summary>
    /// Gets or sets the curs description.
    /// </summary>
    /// <value>
    /// The curs description.
    /// </value>
    public string CursDescription { get; set; }

    /// <summary>
    /// Gets or sets the name of the curs.
    /// </summary>
    /// <value>
    /// The name of the curs.
    /// </value>
    public string CursName { get; set; }

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
    /// Gets or sets the modul.
    /// </summary>
    /// <value>
    /// The modul.
    /// </value>
    public string Modul { get; set; }

    /// <summary>
    /// Gets or sets the start.
    /// </summary>
    /// <value>
    /// The start.
    /// </value>
    public DateTime Start { get; set; }

    /// <summary>
    /// Gets or sets the tutor.
    /// </summary>
    /// <value>
    /// The tutor.
    /// </value>
    public string Tutor { get; set; }

    /// <summary>
    /// Compares to.
    /// </summary>
    /// <param name="obj">The object.</param>
    /// <returns></returns>
    public int CompareTo(MergedLesson obj)
    {
      return this.Start.CompareTo(obj.Start);
    }
  }
}
