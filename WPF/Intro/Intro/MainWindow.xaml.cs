using System;
using System.Collections.Generic;
using System.IO;
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
using Newtonsoft.Json;

namespace Intro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<string> workList = new List<string>();
        static string material;
        static string finish;
        static string purchase;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            this.DescriptionTextBox.Text = "";
            this.LengthTextBox.Text = "";
            this.MassTextBox.Text = "";
            this.NoteTextBox.Text = "";
            this.PartNumTextBox.Text = "";
            this.RevisionTextBox.Text = "";
            this.SCodeTextBox.Text = "";
            this.SNameTextBox.Text = "";
            this.StatusTextBox.Text = "";

            this.AssemplyCB.IsChecked = this.DrillCB.IsChecked = this.FoldCB.IsChecked = this.LaserCB.IsChecked
            = this.LatheCB.IsChecked = this.PlasmaCB.IsChecked = this.PurchesCB.IsChecked = this.RollCB.IsChecked
            = this.SawCB.IsChecked = this.WeldCB.IsChecked = false;

            this.RowMaterialComboBox.SelectedIndex = 0;
            this.FinishComboBox.SelectedIndex = 0;
            this.PurchesComboBox.SelectedIndex = 0;

            workList.Clear();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            Item item = new Item
            {
                Description = DescriptionTextBox.Text,
                Length = Double.Parse(LengthTextBox.Text),
                Mass = Int32.Parse(MassTextBox.Text),
                Note = NoteTextBox.Text,
                PartNumber = Int32.Parse(PartNumTextBox.Text),
                Revision = RevisionTextBox.Text,
                SupplierCode = Int32.Parse(SCodeTextBox.Text),
                SupplierName = SNameTextBox.Text,
                Status=StatusTextBox.Text,
                WorkCentres=workList,
                Material=material,
                Finish=finish,
                PruchaseInfo=purchase
            };

            using (StreamWriter sw=new StreamWriter("../../../output.txt"))
            {
                sw.WriteAsync(item.ToString());
            }

            string JSONdata = JsonConvert.SerializeObject(item,Formatting.Indented);
            File.WriteAllText("../../../output.json", JSONdata);

            Reset();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            this.AssemplyCB.IsChecked = this.DrillCB.IsChecked = this.FoldCB.IsChecked = this.LaserCB.IsChecked
            = this.LatheCB.IsChecked = this.PlasmaCB.IsChecked = this.PurchesCB.IsChecked = this.RollCB.IsChecked
            = this.SawCB.IsChecked = this.WeldCB.IsChecked = false;

            this.RowMaterialComboBox.SelectedIndex = 0;
            this.FinishComboBox.SelectedIndex = 0;
            this.PurchesComboBox.SelectedIndex = 0;

            workList.Clear();
        }

        private void CB_Checked(object sender, RoutedEventArgs e)
        {
            workList.Add(((CheckBox)sender).Content.ToString());
        }

        private void CB_Unchecked(object sender, RoutedEventArgs e)
        {
            string item = ((CheckBox)sender).Content.ToString();
            if(workList.Contains(item))
            {
                workList.Remove(item);
            }
        }

        private void RowMaterilaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            material = ((ComboBoxItem)((ComboBox)sender).SelectedValue).Content.ToString();
        }

        private void FinishComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            finish = ((ComboBoxItem)((ComboBox)sender).SelectedValue).Content.ToString();
        }

        private void PurchaseComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            purchase = ((ComboBoxItem)((ComboBox)sender).SelectedValue).Content.ToString();
        }
    }
}
