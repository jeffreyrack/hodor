using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace CSUSM.CS441.SheriffHodor.Data
{
    /// <summary>
    /// ObservableList : an ObservableCollection which notify on item's property change as well.
    /// </summary>
    /// <typeparam name="T">An item implementing INotifyPropertyChanged.</typeparam>
    public class ObservableList<T> : ObservableCollection<T> where T : INotifyPropertyChanged
    {
        public ObservableList() : base()
        {
            CollectionChanged += new NotifyCollectionChangedEventHandler(CollectionChangedHandler);
        }

        private void CollectionChangedHandler(object o, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
                foreach (var item in e.NewItems)
                    (item as INotifyPropertyChanged).PropertyChanged += new PropertyChangedEventHandler(PropertyChangedHandler);
            if (e.OldItems != null)
                foreach (Object item in e.OldItems)
                    (item as INotifyPropertyChanged).PropertyChanged -= new PropertyChangedEventHandler(PropertyChangedHandler);
        }
        private void PropertyChangedHandler(object o, PropertyChangedEventArgs e)
        {
            var a = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset);
            OnCollectionChanged(a);
        }
    }
}
