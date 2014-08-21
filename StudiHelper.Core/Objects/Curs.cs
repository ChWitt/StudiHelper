namespace StudiHelper.Core.Objects
{
  public enum ERelevance : short
  {
    PF = 1,
    WP = 2,
    W = 3
  }

  /// <summary>
  /// Class that display an object of type 'Curs'
  /// </summary>
  public class Curs
  {
    /// <summary>
    /// Gets or sets the credit points.
    /// </summary>
    /// <value>
    /// The credit points.
    /// </value>
    public int CreditPoints { get; set; }

    /// <summary>
    /// Gets or sets the curs identifier.
    /// </summary>
    /// <value>
    /// The curs identifier.
    /// </value>
    public int CursID { get; set; }

    /// <summary>
    /// Gets or sets the curs information.
    /// </summary>
    /// <value>
    /// The curs information.
    /// </value>
    public string CursInfo { get; set; }

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
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the relevance.
    /// </summary>
    /// <value>
    /// The relevance.
    /// </value>
    public ERelevance Relevance { get; set; }

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="System.String" /> that represents this instance.
    /// </returns>
    public override string ToString()
    {
      return this.Description + " (" + this.Name + ")";
    }
  }
}