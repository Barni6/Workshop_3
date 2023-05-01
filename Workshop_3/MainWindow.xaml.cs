using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Workshop_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int penz = 0;
        ObservableCollection<Army> troopers; 
        public MainWindow()
        {
            InitializeComponent();
            troopers = new ObservableCollection<Army>()
            {
                new Army() {TrooperName="marine", Power=8, Vitality=6 ,Cost=6 },
                new Army() {TrooperName="pilot", Power=7, Vitality=3 ,Cost=10 },
                new Army() {TrooperName="infantry", Power=6, Vitality=8 ,Cost=10 },
                new Army() {TrooperName="sniper", Power=3, Vitality=3 ,Cost=7 },
                new Army() {TrooperName="engineer", Power=4, Vitality=6 ,Cost=8 },
            };

                            
                ProgressBar pb = new ProgressBar();
                pb.Width = 80;
                pb.Height = 15;
                pb.Minimum = 1;
                pb.Maximum = 10;
                pb.Value = 1;
                
 
                //ListBoxItem listBoxItem = new ListBoxItem();
                //listBoxItem.Content = pb;


            foreach (var item in troopers)
            {
                lb_troopers.Items.Add(item);
                grid_2.Children.Add(pb);
            }
            //lb_troopers.Items.Add(listBoxItem);        
        }

        private void bt_Add_Click(object sender, RoutedEventArgs e)
        {
             
            if (lb_troopers.SelectedItem != null && lb_troopers.SelectedItem is Army t)
            {
                lb_army.Items.Add(lb_troopers.SelectedItem);
                penz += t.Money();
            }

            money.Content = "Money: " + penz + "$";
  }

            private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Army t = lb_army.SelectedItem as Army;

            if (lb_army.SelectedItem != null)
            {
                lb_army.Items.Remove(lb_army.SelectedItem);
                penz -= t.Money();
            }
            money.Content = "Money: " + penz + "$";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TrooperEditor win = new TrooperEditor();
            win.DataContext = lb_army.SelectedItem;
            win.Show();
            if (lb_army.SelectedItem != null)
            {
                lb_army.Items.Add(win.army);
            }        
        }
    }
}
