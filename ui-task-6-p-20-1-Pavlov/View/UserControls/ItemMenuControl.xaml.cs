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

namespace ui_task_6_p_20_1_Pavlov.View.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ItemMenuControl.xaml
    /// </summary>
    public partial class ItemMenuControl : UserControl
    {
        private MainWindow _context;

        public ItemMenuControl(ItemMenu itemMenu, MainWindow context)
        {
            InitializeComponent();

            _context = context;

            ExpanderMenu.Visibility = itemMenu.SubItems == null ? Visibility.Collapsed : Visibility.Visible;
            ListViewItemMenu.Visibility = itemMenu.SubItems != null ? Visibility.Visible : Visibility.Collapsed;

            DataContext = itemMenu;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _context.SwitchControl(((SubItem)((ListView)sender).SelectedItem).UControl);
        }
    }
}
