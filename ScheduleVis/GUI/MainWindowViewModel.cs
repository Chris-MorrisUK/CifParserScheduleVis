using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ScheduleVis
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            outputText = "Ready to Parse files";
        }

        public void AddMessage(string msg)
        {
            outputText += msg + Environment.NewLine;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OutputText"));
        }

        public void AddError(Exception exp,bool update=true)
        {
            outputText += exp.ToString() + Environment.NewLine;
            outputText += "at:" + Environment.NewLine;
            outputText += exp.StackTrace.ToString() + Environment.NewLine;
            if (exp.InnerException!=null)
                outputText += exp.InnerException.ToString() + Environment.NewLine;
            if(update)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OutputText"));
        }

        public void AddErrorBulk(List<Exception> errors)
        {
            foreach (Exception exp in errors)
                AddError(exp, false);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OutputText"));
        }

        private string outputText;
        public string OutputText
        {
            get
            {
                return outputText;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
