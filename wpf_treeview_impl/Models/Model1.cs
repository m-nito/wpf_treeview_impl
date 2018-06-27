using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_treeview_impl.Models
{
    public class Model1 : IModel1
    {
        public int Val1 { get; set; } = 0;
        public string Val2 { get; set; } = "str1";
    }
    public interface IModel1 {
        int Val1 { get; set; }
        string Val2 { get; set; }
    }
}
