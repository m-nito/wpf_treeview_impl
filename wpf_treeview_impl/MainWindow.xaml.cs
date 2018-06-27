using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_treeview_impl
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var p1 = new Pages.Page1();
            var vm1 = new List<ViewModels.ViewModel1>(){
                new ViewModels.ViewModel1(){
                    Val1 = 1
                },
                new ViewModels.ViewModel1(){
                    Val1 = 2
                },
                new ViewModels.ViewModel1(){
                    Val1 = 3
                }
            };
            p1.ParentTree.ItemsSource = vm1;
            this.Frame.Navigate(p1);

        }
    }
}
