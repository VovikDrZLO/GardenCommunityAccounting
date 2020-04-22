using GardenCommunityAccounting.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace GardenCommunityAccounting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowMViewModel();
            IncomDocCM.AddHandler(MenuItem.ClickEvent, new RoutedEventHandler(mi_Click));
            using (ApplicationContext db = new ApplicationContext())
            {
                /*Land land1 = new Land { Number = 1654 };               
                // добавляем их в бд
                db.Land.Add(land1);                
                db.SaveChanges();*/
                var incomeDocType = db.DocumentTypes.Where(d => d.IsIncome);
                //IncomingDocumentsBtn.ContextMenu.DataContext = incomeDocType;
                var outcomeDocType = db.DocumentTypes.Where(d => d.IsOutcome);
            }            
        }
        void mi_Click(object sender, RoutedEventArgs e)
        {
            var v = ((DocumentItem)((MenuItem)e.OriginalSource).DataContext).Id;
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var t = (DatePicker)sender;
            var v = t.Text;
        }

        private void IncomDocBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }

    public class DocumentItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class MainWindowMViewModel : INotifyPropertyChanged
    {

        public MainWindowMViewModel()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                IncomeDocumentTypes = db.DocumentTypes.Where(d => d.IsIncome).Select(p => new DocumentItem {Id = p.Id, Name = p.Name }).ToList();
            }
        }

        private List<DocumentItem> _IncomeDocumentTypes = null;

        public List<DocumentItem> IncomeDocumentTypes
        {
            get
            {
                return _IncomeDocumentTypes;
            }
            set
            {

                if (_IncomeDocumentTypes == null)
                {
                    _IncomeDocumentTypes = value;
                    Notify("IncomeDocumentTypes");
                }

            }
        }
        public void ItemChanged(object paramssd)
        {
            var t = "gfg";
        }

        private void Notify(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
