using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace MVVM_Base.Implementations
{
    public class AdvancedObservableCollection<T> : ObservableCollection<T>, IObservableCollection<T>
    {
        private bool _suppressNotification;

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (!_suppressNotification)
            {
                base.OnCollectionChanged(e);
            }
        }

        public void AddRange(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            _suppressNotification = true;

            foreach (var item in collection)
            {
                Add(item);
            }
            _suppressNotification = false;
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        public IObservableCollection<TNew> Cast<TNew>(Func<T, TNew> factory) where TNew : T
        {
            var newCollection = new AdvancedObservableCollection<TNew>();

            for (var i = 0; i < Items.Count; i++)
                newCollection[i] = factory(Items[i]);

            return newCollection;
        }
    }
}