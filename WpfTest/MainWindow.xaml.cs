using HandyControl.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
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
using WpfTest.attribute;
using WpfTest.Model;
using static WpfTest.Model.MainViewModel;

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : System.Windows.Window
    {

        MainViewModel model;

        List<PagesModel> PageTypes = new List<PagesModel>();
        public MainWindow()
        {
            InitializeComponent();

            #region 反射获取所有的Page
            List<Type> classTypes = typeof(MainWindow).Assembly.GetTypes().Where(f => f.Name.Contains("Page")).ToList();
            foreach (Type type in classTypes)
            {
                var mappers = type.GetCustomAttributes(typeof(PageAttribute), true);
                if (mappers.Length > 0)
                {
                    var page = mappers[0] as PageAttribute;
                    string pageName = page.Name;
                    string pageUri = page.Uri;
                    PageTypes.Add(new PagesModel
                    {
                        headerName = pageName,
                        Uri = pageUri,
                    });
                }
            }
            #endregion

            model = new MainViewModel();
            this.DataContext = model;
            #region TabControl添加页面
            //List<UIElement> items = new List<UIElement>();
            //Frame fm = new Frame();
            //fm.Source = new Uri("Pages/Page1.xaml",UriKind.Relative);
            //HandyControl.Controls.TabItem tab1 = new HandyControl.Controls.TabItem()
            //{ 
            //   Header = "test",
            //   Content= fm
            //};
            //items.Add(tab1);

            //fm = new Frame();
            //fm.Source = new Uri("Pages/Page2.xaml", UriKind.Relative);
            //tab1 = new HandyControl.Controls.TabItem()
            //{
            //    Header = "test2",
            //    Content = fm
            //};
            //items.Add(tab1);
            //model.TabLists = items;
            #endregion
            ObservableCollection<PagesModel> items = new ObservableCollection<PagesModel>();
            model.TabPages = items;

            ObservableCollection<MainViewModel.MenuItem> menuItems= new ObservableCollection<MainViewModel.MenuItem>();

            foreach (var type in PageTypes)
            {
                menuItems.Add(new MainViewModel.MenuItem
                {
                    Title = type.headerName,
                    Children = new ObservableCollection<MainViewModel.MenuItem> { new MainViewModel.MenuItem { Title = "children"} }
                });
            }

            model.MenuItems = menuItems;    
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            model.Title = model.TextVal;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            model.Title = "预览图片";
            new ImageBrowser(new Uri(@"C:\Users\HLT\Desktop\4.jpg")).Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // 从资源字典中查找元素
            var buttonStyle = (Style)App.Current.FindResource("SolidButton");
        }

        #region 侧边栏点击事件，添加page到TabControl
        private void SideMenuItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SideMenuItem item = (SideMenuItem)sender;
            SimpleText simpleText = (SimpleText)item.Header;
            string title = simpleText.Text;

            PagesModel page = PageTypes.Where(f => f.headerName == title).FirstOrDefault();

            if (page != null && !model.TabPages.Contains(page))
            {
                model.TabPages.Add(page);
            }

            int index = model.TabPages.IndexOf(page);
            if (index != -1)
            {
                tabControl.SelectedIndex = index;
            }
        }
        #endregion

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel panel= (StackPanel)sender;
            TextBlock textBlock = panel.Children[1] as TextBlock;
            string title = textBlock.Text;

            PagesModel page = PageTypes.Where(f => f.headerName == title).FirstOrDefault();

            if (page != null && !model.TabPages.Contains(page))
            {
                model.TabPages.Add(page);
            }

            int index = model.TabPages.IndexOf(page);
            if (index != -1)
            {
                tabControl.SelectedIndex = index;
            }
        }
    }
}
