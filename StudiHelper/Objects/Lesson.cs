/// <summary>
/// Name space for all objects in this project
/// </summary>
namespace StudiHelper.Objects
{
    using System;

    public enum Building : short
    {
        None = 0,
        AB = 1,
        NB = 2,
        Ext = 3
    }

    /// <summary>
    /// Class that display an object of type 'Lesson'
    /// </summary>
    public class Lesson
    {
        /// <summary>
        /// The lesson identifier
        /// </summary>
        private int lessonID;

        /// <summary>
        /// The curs identifier
        /// </summary>
        private int cursID;

        /// <summary>
        /// The start
        /// </summary>
        private DateTime start;

        /// <summary>
        /// The end
        /// </summary>
        private DateTime end;

        /// <summary>
        /// The building
        /// </summary>
        private Building building;

        /// <summary>
        /// Initializes a new instance of the <see cref="Lesson"/> class.
        /// </summary>
        public Lesson()
        {
            this.lessonID = 0;
            this.cursID = 0;
            this.start = DateTime.MinValue;
            this.end = DateTime.MinValue;
            this.building = Building.None;
        }

        public int LessonID
        {
            get { return this.lessonID; }
            set { this.lessonID = value; }
        }

        public int CursID
        {
            get { return this.cursID; }
            set { this.cursID = value; }
        }

        public DateTime Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public DateTime End
        {
            get { return this.end; }
            set { this.end = value; }
        }
    
        public Building BuildingOfLesson
        {
            get { return this.building; }
            set { this.building = value; }
        }
    }

    public class MergedLesson : IComparable<MergedLesson>
  {
      
      public MergedLesson()
      {
        confict = false;
      }

      public int lessonID { get; set; }

    public string cursName { get; set; }
    public string cursDescription { get; set; }
    public DateTime start { get; set; }
    public DateTime end { get; set; }
    public Building building { get; set; }
    public string tutor { get; set; }
    public string modul { get; set; }

    public bool confict { get; set; }

      public int CompareTo(MergedLesson obj)
    {
      return start.CompareTo(obj.start);
    }

  }
}