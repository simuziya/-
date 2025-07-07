using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.ViewModels
{
    internal class MainWindowViewModel:BindableBase
    {
        private string title = "ni好";
        public string Title
        {
            get { return title; }
            set { title = value;  RaisePropertyChanged(); }
        }
    }
}
