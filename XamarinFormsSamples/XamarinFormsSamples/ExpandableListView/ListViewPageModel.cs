using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XamarinFormsSamples.ExpandableListView
{
    public class ListViewPageModel
    {
        public ObservableCollection<Person> PersonsList { get; set; }

        public Person PreviousSelectedPerson { get; set; }
        private Person _selectedPerson { get; set; }
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                if (_selectedPerson != value)
                {
                    _selectedPerson = value;
                    // ExpandOrCollapseSelectedItem();
                    _selectedPerson.FirstName = "Updated Value";
                }
            }
        }

        private void ExpandOrCollapseSelectedItem()
        {
            if(PreviousSelectedPerson != null)
            {
                PersonsList.Where(t => t.Id == PreviousSelectedPerson.Id).FirstOrDefault().IsVisible =
                false;
            }

            PersonsList.Where(t => t.Id == SelectedPerson.Id).FirstOrDefault().IsVisible =
                true;
            PreviousSelectedPerson = SelectedPerson;
        }

        public ListViewPageModel()
        {
            PersonsList = new ObservableCollection<Person>
            {
                new Person(){ Id = 1, FirstName = "John", LastName= "Smith", City = "Los Angeles", MobileNo = "9988776655" },
                new Person(){ Id = 2, FirstName = "Alex", LastName= "Clark", City = "London", MobileNo = "9988776644" },
                new Person(){ Id = 3, FirstName = "Ellen",LastName= "Hill", City = "Sydney", MobileNo = "9988776633" },
                new Person(){ Id = 4, FirstName = "Grace",LastName= "HALE", City = "New York", MobileNo = "9988776622" }
            };
        }

    }

    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int Id { get; set; }
        // public string FirstName { get; set; }
        private string _firstName { get; set; }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged();
                }
            }
        }
        public string LastName { get; set; }
        public string City { get; set; }
        public string MobileNo { get; set; }

        private bool _isVisible { get; set; }
        public bool IsVisible
        {
            get { return _isVisible; }
            set
            {
                if (_isVisible != value)
                {
                    _isVisible = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
