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
    /// Class that display an object of type 'Curs'
    /// </summary>
  public class Curs
    {
        /// <summary>
        /// The curs identifier
        /// </summary>
      private int cursID;

        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The credit points
        /// </summary>
        private int creditPoints;

        /// <summary>
        /// The module identifier
        /// </summary>
        private int moduleID;

        /// <summary>
        /// Initializes a new instance of the <see cref="Curs"/> class.
        /// </summary>
        public Curs()
        {
            this.cursID = 0;
            this.name = string.Empty;
            this.creditPoints = 0;
            this.moduleID = 0;
            this.Description = string.Empty;
        }

        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the curs identifier.
        /// </summary>
        /// <value>
        /// The curs identifier.
        /// </value>
        public int CursID
        { 
            get { return this.cursID; } 
            set { this.cursID = value; } 
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

        /// <summary>
        /// Gets or sets the credit points.
        /// </summary>
        /// <value>
        /// The credit points.
        /// </value>
        public int CreditPoints
        { 
            get { return this.creditPoints; } 
            set { this.creditPoints = value; } 
        }

        /// <summary>
        /// Gets or sets the module identifier.
        /// </summary>
        /// <value>
        /// The module identifier.
        /// </value>
        public int ModuleID
        { 
            get { return this.moduleID; } 
            set { this.moduleID = value; } 
        }

        public override string ToString()
        {
          return Description + " (" + Name + ")";
        }
    }
}
