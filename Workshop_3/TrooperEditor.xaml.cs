using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Workshop_3
{
    /// <summary>
    /// Interaction logic for TrooperEditor.xaml
    /// </summary>
    public partial class TrooperEditor : Window
    {
        public ObservableCollection<Army> army;

        public TrooperEditor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            army = new ObservableCollection<Army>()
            {
                new Army() {Power=int.Parse(power.Text), Vitality=int.Parse(Vitality.Text) ,Cost= int.Parse(Cost.Text)},
        };

        }
    }
}
