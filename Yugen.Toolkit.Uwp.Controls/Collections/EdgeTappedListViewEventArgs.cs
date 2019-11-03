using System;
using Windows.UI.Xaml.Controls;

namespace Yugen.Toolkit.Uwp.Controls.Collections
{
    public class EdgeTappedListViewEventArgs : EventArgs
    {
        public ListViewItem ListViewItem { get; }

        public EdgeTappedListViewEventArgs(ListViewItem listViewItem)
        {
            ListViewItem = listViewItem;
        }
    }
}