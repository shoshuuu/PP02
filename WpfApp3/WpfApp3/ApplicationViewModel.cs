using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Contact> Contacts { get; set; }
        private Contact selectedContact;
        public Contact SelectedContact
        {
            get { return selectedContact; }
            set
            {
                selectedContact = value;
                OnPropertyChanged("Selected Contact");
            }
        }

   
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        Contact contact = new Contact();
                        Contacts.Add(contact);
                        SelectedContact = contact;
                    }));
            }
        }

        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                    (removeCommand = new RelayCommand(obj =>
                    {
                        Contact phone = obj as Contact;
                        Contacts.Remove(SelectedContact);
                    },
                    (obj) => Contacts.Count > 0));
            }
        }

        public ApplicationViewModel()
        {
            Contacts = new ObservableCollection<Contact>
            {
                new Contact { FirstName="Абонент", LastName="1", PhoneNumber="11111111"},
                new Contact { FirstName="Абонент", LastName="2", PhoneNumber="22222222"},
                new Contact { FirstName="Абонент", LastName="3", PhoneNumber="33333333"},
                new Contact { FirstName="Абонент", LastName="4", PhoneNumber="44444444"},
                new Contact { FirstName="Абонент", LastName="5", PhoneNumber="554555555"}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
