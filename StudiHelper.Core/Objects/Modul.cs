namespace StudiHelper.Core.Objects
{
  /// <summary>
  /// Class that display an object of type 'Module'
  /// </summary>
  public class Module
  {
    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    /// <value>
    /// The description.
    /// </value>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the module identifier.
    /// </summary>
    /// <value>
    /// The module identifier.
    /// </value>
    public int ModuleID { get; set; }

    /// <summary>
    /// Gets or sets the module information.
    /// </summary>
    /// <value>
    /// The module information.
    /// </value>
    public string ModuleInfo { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the number.
    /// </summary>
    /// <value>
    /// The number.
    /// </value>
    public int Number { get; set; }

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="System.String" /> that represents this instance.
    /// </returns>
    public override string ToString()
    {
      return this.Name + " (" + this.Number.ToString() + ")";
    }
  }
}