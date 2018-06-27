using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_treeview_impl.ViewModels
{
    public class ViewModel2 : INotifyPropertyChanged, Models.IModel2
    {
        public int Val1 { get; set; }
        public int Val2 { get; set; } = 2;

        public event PropertyChangedEventHandler PropertyChanged;


    }
}
