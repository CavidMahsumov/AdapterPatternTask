using AdapterPattern.Model;
using AdapterPattern.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AdapterPattern.Adapter
{
    public class XML:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnpropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public ObservableCollection<User> _User_List { get; set; }
        public ObservableCollection<User> User_List { get { return _User_List; } set { _User_List = value; OnpropertyChanged(); } }


        private User _user;

        public User User { get { return _user; } set { _user = value; OnpropertyChanged(); } }


        public MainWindow MainWindows { get; set; }

        public MainWindowViewModel MainViewModels { get; set; }

        public XML()
        {

        }



        public void XML_Serialize()
        {
            

            var xml = new XmlSerializer(typeof(ObservableCollection<User>));
            using (var fs = new FileStream("UserXml.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, User_List);
            }
        }

        public void XML_Deserialize()
        {
            User user = null;

            var xml2 = new XmlSerializer(typeof(ObservableCollection<User>));

            using (var fs2 = new FileStream("UserXml.xml", FileMode.OpenOrCreate))
            {
                user = xml2.Deserialize(fs2) as User;
            }
        }
    }
}
