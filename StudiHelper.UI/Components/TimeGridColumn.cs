
namespace StudiHelper.UI.Components
{
  using System;
  using System.ComponentModel;
  using System.Windows.Forms;

  /// <summary>
  /// Data grid view cell to show time values
  /// </summary>
  public class TimeGridCell : DataGridViewTextBoxCell
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeGridCell"/> class.
    /// </summary>
    public TimeGridCell()
      : base()
    {
    }

    /// <summary>
    /// Gets the type of the cell's hosted editing control.
    /// </summary>
    public override Type EditType
    {
      get
      {
        return typeof(DataGridViewTextBoxEditingControl);
      }
    }

    /// <summary>
    /// Gets the value of the cell as formatted for display.
    /// </summary>
    /// <param name="value">The value to be formatted.</param>
    /// <param name="rowIndex">The index of the cell's parent row.</param>
    /// <param name="cellStyle">The <see cref="T:System.Windows.Forms.DataGridViewCellStyle" /> in effect for the cell.</param>
    /// <param name="valueTypeConverter">A <see cref="T:System.ComponentModel.TypeConverter" /> associated with the value type that provides custom conversion to the formatted value type, or null if no such custom conversion is needed.</param>
    /// <param name="formattedValueTypeConverter">A <see cref="T:System.ComponentModel.TypeConverter" /> associated with the formatted value type that provides custom conversion from the value type, or null if no such custom conversion is needed.</param>
    /// <param name="context">A bitwise combination of <see cref="T:System.Windows.Forms.DataGridViewDataErrorContexts" /> values describing the context in which the formatted value is needed.</param>
    /// <returns>
    /// The formatted value of the cell or null if the cell does not belong to a <see cref="T:System.Windows.Forms.DataGridView" /> control.
    /// </returns>
    protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
    {
      cellStyle.Format = "HH:mm";
      return base.GetFormattedValue(value, rowIndex, ref cellStyle, valueTypeConverter, formattedValueTypeConverter, context);
    }
  }

  /// <summary>
  /// Data grid view column to show time values
  /// </summary>
  public class TimeGridColumn : DataGridViewTextBoxColumn
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeGridColumn"/> class.
    /// </summary>
    public TimeGridColumn()
      : base()
    {
      CellTemplate = new TimeGridCell();
    }
    
  }
}