using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ui_task_6_p_20_1_Pavlov.Core
{
    public class ItemMenu
    {
        public string MenuHeader { get; private set; }
        public PackIconKind Icon { get; private set; }
        public List<SubItem> SubItems { get; private set; }
        public UserControl UControl { get; private set; }

        public ItemMenu(string menuHeader, List<SubItem> subItems, PackIconKind icon)
        {
            MenuHeader = menuHeader;
            SubItems = subItems;
            Icon = icon;
        }   
    }
}
