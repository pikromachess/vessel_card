using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using vesssel_card.Classes;

namespace vesssel_card
{
   
    public partial class VesselCard : Window
    {
        private int? _documentId;

        private string _pathFile;

        public VesselCard(Document document = null)
        {
            InitializeComponent();
            cb_vesselType.ItemsSource= VesselType.GetAll();
            cb_journalYear.ItemsSource = JournalYear.GetAll();
            FillCard(document);
        }
        private void FillCard (Document document) 
        {
            if (document == null)
                return;

            _documentId = document.Id;

            cb_vesselType.Text = document.VesselType;
            cb_journalYear.Text = document.JournalYear.ToString();
            cb_lengthType.Text = document.LengthType;
            tb_lengthValue.Text = document.LengthValue.ToString();
            tb_width.Text = document.Width.ToString();
            tb_sideHeight.Text = document.SideHeight.ToString();
            tb_draught.Text = document.Draught.ToString();
            tb_displacement.Text = document.Displacement.ToString();
            tb_deadweight.Text = document.Deadweight.ToString();
            tb_speed.Text = document.Speed.ToString();
            _pathFile = document.PathFile;
            DisplayFile(_pathFile);
        }


        private double? TryConvertToDouble(string text, string errorText)
        {
            double? value = null;

            if (!string.IsNullOrEmpty(text))
            {
                if (double.TryParse(text, out double valueDouble))
                {
                    value = valueDouble;
                }
                else
                {
                    throw new System.Exception(errorText);
                }
            }

            return value;
        }

        private void ClickTrySave(object sender, RoutedEventArgs e)
        {
            string errorText = string.Empty;


            string vesselTypeText = cb_vesselType.Text;
            string journalYearText = cb_journalYear.Text;
            string lengthTypeText= cb_lengthType.Text;
            string lengthValueText = tb_lengthValue.Text;
            string widthText = tb_width.Text;
            string sideHeightText = tb_sideHeight.Text;
            string draughtText = tb_draught.Text;
            string displacementText = tb_displacement.Text;
            string deadweightText = tb_deadweight.Text;
            string speedText = tb_speed.Text;

            if (string.IsNullOrEmpty (vesselTypeText))
            {
                MessageBox.Show("Тип судна не заполнен!"); 
            }
           

            if (!int.TryParse(journalYearText, out int journalYear))
            {
                MessageBox.Show("Год журнала заполнен некорретно!"); 
            }

            if (string.IsNullOrEmpty(lengthTypeText))
            {
                MessageBox.Show("Тип длины не выбран!");
            }
          
            try
            {
                double? lengthValue = TryConvertToDouble(lengthValueText, "Длина заполнена некорреткно!");
                double? width = TryConvertToDouble(widthText, "Ширина заполнена некорректно!");
                double? sideHeight = TryConvertToDouble(sideHeightText, "Высота борта заполнено некорретно!");
                double? draught = TryConvertToDouble(draughtText, "Осадка заполнена некорретно!");
                double? displacement = TryConvertToDouble(displacementText, "Водоизмещение заполнено некорретно!");
                double? deadweight = TryConvertToDouble(deadweightText, "Дедвейт заполнен некорретно!");
                double? speed = TryConvertToDouble(speedText, "Скорость заполнена некорретно!");

                var newDocument = new Document(vesselTypeText, journalYear, lengthTypeText, lengthValue, width, sideHeight, draught, displacement, deadweight, speed, _pathFile);
                newDocument.Save(_documentId);
                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }

        private void ClickLoadFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            

            if (openFileDialog.ShowDialog() == true)
            {
                _pathFile = Path.Combine( "Files", Path.GetFileName(openFileDialog.FileName));

                File.Copy(openFileDialog.FileName, Path.Combine(Environment.CurrentDirectory,_pathFile), overwrite:true);

                DisplayFile(_pathFile);

            }
        }
        private void DisplayFile(string pathFile)
        {
            if (string.IsNullOrEmpty(pathFile)) 
                return;

            string fullPath = Path.Combine(Environment.CurrentDirectory, pathFile);
            WebBrowserPdf.Navigate(new Uri($"file:///{fullPath.Replace("\\", "/")}"));
        }

        private void ClickDelete(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Уверены что хотите удалить документ?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                var collection = DocumentCollection.GetCollection();
                collection.DeleteByID(_documentId);
                DialogResult = true;
                Close();
            }
             
        }
    }

    }
