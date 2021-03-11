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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.wv.IsScriptNotifyAllowed = true;
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.wv.Source = new Uri("https://m.weibo.cn/search?containerid=100103type%3D1%26q%3D%E4%B8%AD%E5%9B%BD%E6%AF%9B%E8%B1%86%E9%A3%8E%E9%9D%A1%E8%A5%BF%E7%8F%AD%E7%89%99");
            this.wb.Source = new Uri("https://s.weibo.com/weibo?q=hello&Refer=SWeibo_box");
        }
    }
}
