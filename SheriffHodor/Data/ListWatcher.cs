using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CSUSM.CS441.SheriffHodor.Data
{
    /// <summary>
    /// ListWatcher: A custom type of list that is bound to another list.
    /// It has a predicate, and display only files that fulfill this predicates.
    /// 
    /// Author: Mathias Lang
    /// License: MIT
    /// </summary>
    class ListWatcher<I, C> : ICollection<I>
        where C : ICollection<I>, IBindingList
    {
        /// <summary>
        /// The items we are watching.
        /// This collection must implement IBindingList (IRaiseItemChangedEvents??).
        /// </summary>
        public C Origin
        {
            get { return this.origin; }
            set
            {
                this.origin.ListChanged -= onListChanged;
                value.ListChanged += onListChanged;
                this.origin = value;
                this.Filter = this.filter;
            }
        }
        /// <summary>
        /// The predicate we use to sort.
        /// If it's null, everything is displayed.
        /// </summary>
        public Predicate<I> Filter
        {
            get { return this.filter; }
            set
            {
                this.filter = value;
                if (this.origin != null)
                {
                    this.innerList.Clear();
                    var tmpFilter = value != null ? value : ((e) => { return true; });
                    foreach (var e in this.origin)
                        if (tmpFilter(e))
                            this.innerList.Add(e);
                }
            }
        }

        /// <summary>
        /// Construct a ListWatcher to watch on the specified collection with the given predicate.
        /// </summary>
        /// <param name="from">
        /// The collection to watch on.
        /// This collection must implement IBindingList (IRaiseItemChangedEvents??).
        /// </param>
        /// <param name="pred">The predicate to filter, or null if you want everything to be displayed.</param>
        public ListWatcher(C from, Predicate<I> pred = null) { this.setPair(from, pred); }

        /// <summary>
        /// Populate the ListWatcher to watch on the specified collection with the given predicate.
        /// </summary>
        /// <param name="from">
        /// The collection to watch on.
        /// This collection must implement IBindingList (IRaiseItemChangedEvents??).
        /// </param>
        /// <param name="pred">The predicate to filter, or null if you want everything to be displayed.</param>
        public void setPair(C from, Predicate<I> pred)
        {
            this.Filter = pred;
            this.Origin = from;
        }

        #region ICollection<T> Members
        public void Add(I item)
        {
            throw new InvalidOperationException("This list is a watcher only, which means you should not attempt to change its data.");
        }

        public bool Remove(I item)
        {
            throw new InvalidOperationException("This list is a watcher only, which means you should not attempt to change its data.");
        }

        public void Clear()
        {
            throw new InvalidOperationException("This list is a watcher only, which means you should not attempt to change its data.");
        }

        public bool Contains(I item)
        {
            return innerList.Contains(item);
        }

        public void CopyTo(I[] array, int arrayIndex)
        {
            innerList.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return innerList.Count; }
        }

        public bool IsReadOnly
        {
            get { return true; }
        }
        #endregion

        #region IEnumerable<T> Members
        public IEnumerator<I> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }
        #endregion

        #region IEnumerable Members
        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerList.GetEnumerator();
        }
        #endregion

        #region Private Members
        private IList<I> innerList = new List<I>();
        private C origin;
        private Predicate<I> filter;

        private void onListChanged(object o, ListChangedEventArgs a)
        {
            I item = (I)o;
            var tmpFilter = this.Filter != null ? this.Filter : ((e) => { return true; });
            if (tmpFilter(item))
                this.innerList.Add(item);
        }
        #endregion
    }
}
