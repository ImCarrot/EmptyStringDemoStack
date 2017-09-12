using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EmptyStringDummy
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        public MainPage()
        {
            this.InitializeComponent();
            Loaded += (s, e) =>
            {
                DataSource = new ObservableCollection<string>(new List<string>()
                {
                    "1. Batman",
                    "2. Spiderman",
                    "3. Hulk",
                    "4. Superman",
                    "",
                    "6. Wonder Woman"

                });

            };

        }


        private ObservableCollection<string> dataSource;
        public ObservableCollection<string> DataSource
        {
            get { return dataSource; }
            set { dataSource = value; RaisePropertyChanged(nameof(DataSource)); }
        }




        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
