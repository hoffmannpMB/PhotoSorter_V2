using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace MVVM_Base
{
    public interface IRangeObservableCollection<T> : INotifyCollectionChanged, INotifyPropertyChanged, IList<T>, IReadOnlyList<T>, IList
    {
        void AddRange(IEnumerable<T> collection);
    }
}