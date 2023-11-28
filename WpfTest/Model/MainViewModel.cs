using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfTest.Model
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// 回写数据到视图
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string title = string.Empty;

        public string textVal = string.Empty;

        public List<UIElement> tabLists = new List<UIElement>();
        public ObservableCollection<PagesModel> tabPages = new ObservableCollection<PagesModel>();
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                NotifyPropertyChanged();
            }
        }

        public string TextVal
        {
            get
            {
                return textVal;
            }
            set
            {
                textVal = value;
                NotifyPropertyChanged();
            }
        }

        public List<UIElement> TabLists
        {
            get
            {
                return tabLists;
            }
            set
            {
                tabLists = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<PagesModel> TabPages
        {
            get { return tabPages; }
            set
            {
                tabPages = value;
                NotifyPropertyChanged();
            }
        }



        public ObservableCollection<MenuItem> MenuItems { get => menuItems; set { menuItems = value; NotifyPropertyChanged(); } }


        public class PagesModel
        {
            public string? headerName { get; set; }

            public string? Uri { get; set; }

            // 重写ToString方法在TabControl 缩放的时候可以展示
            public override string ToString()
            {
                return headerName ?? "";
            }
        }

        //命令
        private RelayCommand routeCommand;
        private ObservableCollection<MenuItem> menuItems;

        public RelayCommand RouteCommand
        {
            get
            {

                if (routeCommand == null) return new RelayCommand(() => ShowMessage(), true);
                return routeCommand;
            }
            set
            {
                routeCommand = value;
            }
        }

        private void ShowMessage()
        {
            MessageBox.Show("提示");
        }

        public class MenuItem
        {
            public string? Title { get; set; }

            public ObservableCollection<MenuItem> Children { get; set; } = new ObservableCollection<MenuItem>();
        }

    }

}
