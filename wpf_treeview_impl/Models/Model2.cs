using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_treeview_impl.Models
{
    public class Model2 : IModel2
    {
        public int Val1 { get; set; } = 0;
        public int Val2 { get; set; } = 1;
    }
    public interface IModel2 {
        int Val1 { get; set; }
        int Val2 { get; set; }
    }
}
