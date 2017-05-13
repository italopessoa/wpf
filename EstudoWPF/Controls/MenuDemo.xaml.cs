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
using System.Windows.Shapes;

namespace Controls
{
    /// <summary>
    /// Interaction logic for MenuDemo.xaml
    /// </summary>
    public partial class MenuDemo : Window
    {
        public MenuDemo()
        {
            InitializeComponent();
            int[] Tab = new int[8];
            Tab[0] = 3;    Tab[1] = 4;    Tab[2] = 3;

            Tab[3] = 2;    Tab[4] = 3;    Tab[5] = -1;

            Tab[6] = 3;    Tab[7] = 3;

            int x = dominator(Tab);
            int a = x;
        }

        public int dominator(int[] tab)
        {
            int counter = 0;
            for (int x = 0; x < tab.Length; x++)
            {
                counter++;
                for (int y = 0; y < tab.Length; y++)
                {
                    if (tab[y] == tab[x])
                    {
                        counter++;
                    }

                }
                if (counter > tab.Length / 2) return tab[x];
            }

            return 0;
        }

    }
}
