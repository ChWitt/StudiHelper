/// <summary>
/// Name space for all objects in this project
/// </summary>
namespace StudiHelper.Core.Objects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class that display an object of type 'Module'
    /// </summary>
    public class Module
    {
        /// <summary>
        /// The module identifier
        /// </summary>
      private int moduleID;

        /// <summary>
        /// The number
        /// </summary>
        private int number;

        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The description
        /// </summary>
        private string description;

        /// <summary>
        /// Initializes a new instance of the <see cref="Module"/> class.
        /// </summary>
        public Module()
        {
            this.moduleID = 0;
            this.number = 0;
            this.name = string.Empty;
            this.description = string.Empty;
        }

        /// <summary>
        /// Gets or sets the module.
        /// </summary>
        /// <value>
        /// The module.
        /// </value>
        public int ModuleID
        { 
            get { return this.moduleID; } 
            set { this.moduleID = value; } 
        }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public int Number
        { 
            get { return this.number; } 
            set { this.number = value; } 
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
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description
        { 
            get { return this.description; } 
            set { this.description = value; } 
        }

        public override string ToString()
        {
          return Name + " (" + Number.ToString() + ")";
        }
    }
}
