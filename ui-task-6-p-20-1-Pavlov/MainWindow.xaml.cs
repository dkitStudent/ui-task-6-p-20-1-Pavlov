using MaterialDesignThemes.Wpf;
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
using ui_task_6_p_20_1_Pavlov.Core;
using ui_task_6_p_20_1_Pavlov.View.UserControls;

namespace ui_task_6_p_20_1_Pavlov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var menuReg = new List<SubItem>();
            menuReg.Add(new SubItem("Клиенты", new CustomerControl()));
            menuReg.Add(new SubItem("Поставщики"));
            menuReg.Add(new SubItem("Сотрудники"));
            menuReg.Add(new SubItem("Товары"));
            var itemMenu0 = new ItemMenu("Регистрация", menuReg, PackIconKind.Register);

            var menuSchedule = new List<SubItem>();
            menuSchedule.Add(new SubItem("Услуги"));
            menuSchedule.Add(new SubItem("Встречи"));
            var itemMenu1 = new ItemMenu("Расписание", menuSchedule, PackIconKind.Schedule);

            var menuReports = new List<SubItem>();
            menuReports.Add(new SubItem("Клиенты"));
            menuReports.Add(new SubItem("Поставщики"));
            menuReports.Add(new SubItem("Товары"));
            menuReports.Add(new SubItem("Склад"));
            menuReports.Add(new SubItem("Продажи"));
            var itemMenu2 = new ItemMenu("Отчёты", menuReports, PackIconKind.FileReport);

            var menuCosts = new List<SubItem>();
            menuCosts.Add(new SubItem("Постоянные"));
            menuCosts.Add(new SubItem("Вне-бюджет"));
            var itemMenu3 = new ItemMenu("Расходы", menuCosts, PackIconKind.ShoppingBasket);

            var menuExit = new List<SubItem>();
            menuExit.Add(new SubItem("Да"));
            menuExit.Add(new SubItem("Нет"));
            var itemMenu4 = new ItemMenu("Выход", menuExit, PackIconKind.Logout);

            Menu.Children.Add(new ItemMenuControl(itemMenu0, this));
            Menu.Children.Add(new ItemMenuControl(itemMenu1, this));
            Menu.Children.Add(new ItemMenuControl(itemMenu2, this));
            Menu.Children.Add(new ItemMenuControl(itemMenu3, this));
            Menu.Children.Add(new ItemMenuControl(itemMenu4, this));
        }

        internal void SwitchControl(object sender)
        {
            var screen = ((UserControl)sender);

            if (screen != null)
            {
                GridMainContent.Children.Clear();
                GridMainContent.Children.Add(screen);
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
