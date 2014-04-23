/// <summary>
/// Name space for all objects in this project
/// </summary>
namespace StudiHelper.Objects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class that display an object of type 'Tutor'
    /// </summary>
    public class Tutor
    {
        /// <summary>
        /// The tutor identifier
        /// </summary>
      private int tutorID;

        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Tutor"/> class.
        /// </summary>
        public Tutor()
        {
            this.tutorID = 0;
            this.name = string.Empty;
        }

        /// <summary>
        /// Gets or sets the tutor identifier.
        /// </summary>
        /// <value>
        /// The tutor identifier.
        /// </value>
        public int TutorID
        { 
            get { return this.tutorID; } 
            set { this.tutorID = value; } 
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        { 
            get { return this.name; } 
            set { this.name = value; } 
        }
    }
}
