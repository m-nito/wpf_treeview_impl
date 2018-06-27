using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace wpf_treeview_impl.ViewModels
{
    public class ViewModel1 : INotifyPropertyChanged, Models.IModel1
    {
        public int Val1 { get; set; }
        public string Val2 { get; set; } = "this is vm1";
        public List<Models.IModel2> ListModel2 { get; set; } = new List<Models.IModel2>() { new ViewModel2() { Val2 = 1 }, new ViewModel2() { Val2 = 2 } };

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
