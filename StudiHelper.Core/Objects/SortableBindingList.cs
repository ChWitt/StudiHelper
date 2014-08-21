using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace StudiHelper.Core.Objects
{
  public class SortableBindingList<T> : BindingList<T>, ITypedList
  {
    private ListSortDirection CurrentDirection;
    private PropertyDescriptor CurrentProperty;
    private PropertyDescriptorCollection Properties;

    public SortableBindingList() : base()
    {
      PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(typeof(T), new Attribute[] { new BrowsableAttribute(true) });
      Properties = pdc.Sort();
    }

    protected override bool IsSortedCore { get { return base.IsSortedCore; }}


    protected override ListSortDirection SortDirectionCore {get {return base.SortDirectionCore;}}
    
    protected override PropertyDescriptor SortPropertyCore {get {return base.SortPropertyCore;}}
    
    protected override bool SupportsSortingCore { get { return true; }}

    public void AddRange(IEnumerable<T> itemsToAdd)
    {
      foreach (T item in itemsToAdd)
      {
        this.Add(item);
      }
    }

    public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
    {
      PropertyDescriptorCollection pdc = null;

      if (null == listAccessors)
      {
        pdc = Properties;
      }
      else
      {
        pdc = ListBindingHelper.GetListItemProperties(listAccessors[0].PropertyType);
      }

      return pdc;
    }

    public string GetListName(PropertyDescriptor[] listAccessors)
    {
      return typeof(T).Name;
    }

    protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
    {
      List<T> helper = (List<T>)this.Items;
      this.CurrentProperty = prop;
      this.CurrentDirection = direction;
      helper.Sort(Compare);
    }

    private int Compare(T a, T b)
    {
      object valA = CurrentProperty.GetValue(a);
      object valB = CurrentProperty.GetValue(b);

      IComparable icA = valA as IComparable;
      IComparable icB = valB as IComparable;

      if (icA == null && icB == null)
      {
        return 0;
      }

      if (icA == null && icB != null)
      {
        return CurrentDirection == ListSortDirection.Ascending ? -1 : 1;
      }

      if (icA != null && icB == null)
      {
        return CurrentDirection == ListSortDirection.Ascending ? 1 : -1;
      }

      if (CurrentDirection == ListSortDirection.Ascending)
      {
        return icA.CompareTo(icB);
      }
      else
      {
        return -icA.CompareTo(icB);
      }
    }
  }
}