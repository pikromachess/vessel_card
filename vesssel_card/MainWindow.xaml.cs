using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using vesssel_card.Classes;

namespace vesssel_card
{

    public partial class MainWindow : Window
    {
        private ObservableCollection<Document> _fullDocuments;
        private ObservableCollection<Document> _displayDocuments;

        public MainWindow()
        {
            InitializeComponent();
            LoadDocuments();
        }
        private void LoadDocuments()
        {
            DocumentCollection collection = DocumentCollection.GetCollection();

            _fullDocuments = new ObservableCollection<Document>(collection.Documents);
            _displayDocuments = new ObservableCollection<Document>(collection.Documents);
            UpdateDisplayDocments();
        }

        private void UpdateDisplayDocments()
        {
            dg_documents.ItemsSource = _displayDocuments;
        }

        private void ClickCreate(object sender, RoutedEventArgs e)
        {
            VesselCard window = new VesselCard();
            window.ShowDialog();
            if (window.DialogResult == true) 
            {
                LoadDocuments();
            }

        }

        private void dg_documents_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            VesselCard window = new VesselCard(dg_documents.SelectedItem as Document);
            window.ShowDialog();
            if (window.DialogResult == true)
            {
                LoadDocuments();
            }

        }

        private void tb_searchTextChanged(object sender, TextChangedEventArgs e)
        {
            string searchVesselType = tb_searchVesselType.Text?.ToLower() ?? string.Empty;
            string searchJournalYear = tb_searchJournalYear.Text?.ToLower() ?? string.Empty;
            string searchLengthType = tb_searchLengthType.Text?.ToLower() ?? string.Empty;
            string searchLengthValue = tb_searchLengthValue.Text?.ToLower() ?? string.Empty;
            string searchWidth = tb_searchWidth.Text?.ToLower() ?? string.Empty;
            string searchSideHeight = tb_searchSideHeight.Text?.ToLower() ?? string.Empty;
            string searchDraught = tb_searchDraught.Text?.ToLower() ?? string.Empty;
            string searchDisplacement = tb_searchDisplacement.Text?.ToLower() ?? string.Empty;
            string searchDeadweight = tb_searchDeadweight.Text?.ToLower() ?? string.Empty;
            string searchSpeed = tb_searchSpeed.Text?.ToLower() ?? string.Empty;

            _displayDocuments = new ObservableCollection<Document>(_fullDocuments.Where(doc =>
                (string.IsNullOrEmpty(searchVesselType) || (doc.VesselType?.ToLower().Contains(searchVesselType) == true)) &&
                (string.IsNullOrEmpty(searchJournalYear) || doc.JournalYear.ToString().ToLower().Contains(searchJournalYear)) &&
                (string.IsNullOrEmpty(searchLengthType) || (doc.LengthType?.ToLower().Contains(searchLengthType) == true)) &&
                FilterByRealTimeInput(doc.LengthValue, searchLengthValue) &&
                FilterByRealTimeInput(doc.Width, searchWidth) &&
                FilterByRealTimeInput(doc.SideHeight, searchSideHeight) &&
                FilterByRealTimeInput(doc.Draught, searchDraught) &&
                FilterByRealTimeInput(doc.Displacement, searchDisplacement) &&
                FilterByRealTimeInput(doc.Deadweight, searchDeadweight) &&
                FilterByRealTimeInput(doc.Speed, searchSpeed)));

            UpdateDisplayDocments();
        }

        private bool FilterByRealTimeInput(double? nullableValue, string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return true;

            if (!nullableValue.HasValue)
                return false;

            return FilterByRealTimeInput(nullableValue.Value, searchText);
        }

        private bool FilterByRealTimeInput(double value, string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return true;

            searchText = searchText.Trim().ToLower();
            string valueStr = value.ToString(CultureInfo.InvariantCulture).ToLower();

            if (searchText.StartsWith(">=") && searchText.Length > 2)
            {
                if (double.TryParse(searchText.Substring(2), out double filterValue))
                    return value >= filterValue;
                return valueStr.Contains(searchText.Substring(2));
            }
            else if (searchText.StartsWith("<=") && searchText.Length > 2)
            {
                if (double.TryParse(searchText.Substring(2), out double filterValue))
                    return value <= filterValue;
                return valueStr.Contains(searchText.Substring(2));
            }
            else if (searchText.StartsWith(">") && searchText.Length > 1)
            {
                if (double.TryParse(searchText.Substring(1), out double filterValue))
                    return value > filterValue;
                return valueStr.Contains(searchText.Substring(1));
            }
            else if (searchText.StartsWith("<") && searchText.Length > 1)
            {
                if (double.TryParse(searchText.Substring(1), out double filterValue))
                    return value < filterValue;
                return valueStr.Contains(searchText.Substring(1));
            }
            else if (searchText.Contains("-"))
            {
                var parts = searchText.Split('-');
                if (parts.Length == 2)
                {
                    bool minValid = double.TryParse(parts[0], out double min);
                    bool maxValid = double.TryParse(parts[1], out double max);

                    if (minValid && maxValid)
                        return value >= min && value <= max;

                
                    return valueStr.Contains(searchText);
                }
            }

            
            return valueStr.Contains(searchText);
        }

    }
}

   