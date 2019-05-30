using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace MVVM_Base
{
    public interface IObservableCollection<T> : INotifyCollectionChanged, INotifyPropertyChanged, IList<T>
    {
        void AddRange(IEnumerable<T> collection);
        IObservableCollection<TNew> Cast<TNew>(Func<T, TNew> factory) where TNew : T;
    }
}