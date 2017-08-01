using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataAccess;
using System.Threading;
using VDS.RDF;
using System.Threading.Tasks;
using VDS.RDF.Parsing;
using System.IO;
using System.Globalization;
using ScheduleVis.BO;


namespace ScheduleVis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();            
        }       

        private StarDogLinkedDataSource theDataSource
        {
            get
            {
                return ProgramState.TheDataSource;
            }
            set
            {
                ProgramState.TheDataSource = value;
            }
        }

        private void importStationList_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openDlg = new Microsoft.Win32.OpenFileDialog();
            openDlg.DefaultExt = ".msn"; 
            openDlg.Filter = "Master Station Name List (msn)|*.msn";
            openDlg.Title = "Station List to import";
            if (openDlg.ShowDialog(this) == true)
            {
                addMsg("Station List Loading");
                IFileController cntrl = new StationFileControl();
                FileParseBase parser = new FileParseBase();
                parser.MessageToDisplay += new FileParseBase.MessageDisplayDel(parser_MessageToDisplay);
                ProvInfo provInfo = new ProvInfo(txtName.Text,this.rbUri.IsChecked == true);
                List<Exception> Errors;
                IGraph stationNameGraph = parser.ParseFile(openDlg.FileName, provInfo, cntrl,out Errors);
                ((MainWindowViewModel)this.DataContext).AddErrorBulk(Errors);
                saveGraphToTurtle(stationNameGraph);
                saveGraphToRDF(stationNameGraph);
                
            }

        }

        void parser_MessageToDisplay(string msg, string title, MessageBoxImage img,bool displayBox)
        {
            if (displayBox)
                displayMessage(msg, title, img);
            addMsg(msg);
        }

        private void addMsg(string msg)
        {
            ((MainWindowViewModel)this.DataContext).AddMessage(msg);
        }

        private void saveGraphToTurtle(IGraph graphToSave)
        {
            Microsoft.Win32.SaveFileDialog saveDlg = new Microsoft.Win32.SaveFileDialog();
            saveDlg.DefaultExt = ".ttl";
            saveDlg.Filter = "Turtle Files|*.ttl";
            saveDlg.Title = "Output file";
            if (saveDlg.ShowDialog(this) == true)
            {
                graphToSave.SaveToFile(saveDlg.FileName);
            }
        }

        private void saveGraphToRDF(IGraph graphToSave)
        {
            Microsoft.Win32.SaveFileDialog saveDlg = new Microsoft.Win32.SaveFileDialog();
            saveDlg.DefaultExt = ".OWL";
            saveDlg.Filter = "OWL Files|*.OWL";
            saveDlg.Title = "Output file";
            if (saveDlg.ShowDialog(this) == true)
            {
                graphToSave.SaveToFile(saveDlg.FileName);
            }
        }



        private Uri generateTIPLOCUri(string tiploc)
        {
            string res = Properties.Settings.Default.ResourceBaseURI + tiploc;
            return UriFactory.Create(res);
        }

        //Saves invoking it every time, also allows for logging in the future, should it be deemed usefull
        private void displayMessage(string msg,string title,MessageBoxImage img)
        {
            this.Dispatcher.Invoke(new Action(() =>
            {
                MessageBox.Show(msg, title,MessageBoxButton.OK,img);
            }));
        }



        private void btnImportSchedules_Click(object sender, RoutedEventArgs e)
        {

            Microsoft.Win32.OpenFileDialog openDlg = new Microsoft.Win32.OpenFileDialog();
            openDlg.DefaultExt = ".mca";
            openDlg.Filter = "Complete schedule file|*.mca";
            openDlg.Title = "Schedule to Import";
            if (openDlg.ShowDialog(this) == true)
            {
                addMsg("Schedule Loading");
                IFileController cntrl = new ScheduleFileControl();
                FileParseBase parser = new FileParseBase();
                parser.MessageToDisplay += new FileParseBase.MessageDisplayDel(parser_MessageToDisplay);
                ProvInfo provInfo = new ProvInfo(txtName.Text, this.rbUri.IsChecked == true);
                List<Exception> Errors;
                IGraph stationNameGraph = parser.ParseFile(openDlg.FileName, provInfo, cntrl, out Errors);
                ((MainWindowViewModel)this.DataContext).AddErrorBulk(Errors);
                saveGraphToTurtle(stationNameGraph);
            }
        }

        private void btnCombinedImport_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openDlg = new Microsoft.Win32.OpenFileDialog();
            openDlg.DefaultExt = ".msn";
            openDlg.Filter = "Master Station Name List (msn)|*.msn";
            openDlg.Title = "Station List to import";
            if (openDlg.ShowDialog(this) == true)
            {
                addMsg("Starting Stations");
                IFileController cntrl = new StationFileControl();
                FileParseBase parser = new FileParseBase();
                parser.MessageToDisplay += new FileParseBase.MessageDisplayDel(parser_MessageToDisplay);
                ProvInfo provInfo = new ProvInfo(txtName.Text, this.rbUri.IsChecked == true);
                List<Exception> Errors;
                IGraph combinedGraph = parser.ParseFile(openDlg.FileName, provInfo, cntrl, out  Errors);
                addMsg("Done Stations");
                openDlg.DefaultExt = ".mca";
                openDlg.Filter = "Complete schedule file|*.mca";
                openDlg.Title = "Schedule to Import";
                if (openDlg.ShowDialog(this) == true)
                {
                    addMsg("Starting Schedule");
                    IFileController scheduledCntrl = new ScheduleFileControl();
                    List<Exception> ErrorsTwo;
                    IGraph resultingGraph = parser.ParseFile(openDlg.FileName, provInfo, scheduledCntrl, combinedGraph, out ErrorsTwo);
                    saveGraphToTurtle(resultingGraph);
                  //  saveGraphToRDF(resultingGraph);
                }
            }
        }



        
    }
}
