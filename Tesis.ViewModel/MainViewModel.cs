using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Tesis.Model;

namespace Tesis.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
       
        private MainModel _model;
        private int id;
        private string name;
        private int age;
        private string email;
        private ICommand getCommand;
        private ICommand createCommand;
        private ICommand deleteCommand;
        private ICommand doubleClickCommand;
        private ICommand clearCommand;
        
        Boolean band = false;

        private List<Person> people;
        private Person personSelected;

        public Person PersonSelected
        {
            get { return personSelected; }
            set
            {
                if (personSelected == value) return;
                personSelected = value;
                OnPropertyChanged("PersonSelected");
            }
        }
        public int Id
        {
            get { return id; }
            set
            {
                if (id == value) return;
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (name == value) return;
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (age == value) return;
                age = value;
                OnPropertyChanged("Age");
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (email == value) return;
                email = value;
                OnPropertyChanged("Email");
            }
        }
       
        public ICommand GetCommand
        {
            get
            {
                if (getCommand == null)
                {
                    getCommand = new RelayCommand(x => this.getCommandExecute(), null);
                }
                return getCommand;
            }
        }
        public ICommand CreateCommand
        {
            get
            {
                if (createCommand == null)
                {
                    createCommand = new RelayCommand(x => this.createCommandExecute(), null);
                }
                return createCommand;
            }
        }
        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                {
                    deleteCommand = new RelayCommand(x => this.deleteCommandExecute(), null);
                }
                return deleteCommand;
            }
        }
        public ICommand DoubleClickCommand
        {
            get
            {
                if (doubleClickCommand == null)
                {
                    doubleClickCommand = new RelayCommand( x => this.doubleClickCommandExecute((Person) x), null);
                }
                return doubleClickCommand;
            }
        }
        public ICommand ClearCommand
        {
            get
            {
                if (clearCommand == null)
                {
                    clearCommand = new RelayCommand(x => this.clearCommandExecute(), null);
                }
                return clearCommand;
            }
        }

        public List<Person> People
        {
            get { return people; }
            set
            {
                if (people == value) return;
                people = value;
                OnPropertyChanged("People");
            }
        }

        public MainViewModel()
        {
            _model = new MainModel();          
            People = _model.GetPersonas();
        }

        private void getCommandExecute()
        {
            _model.GetPersonas();
        }
        private void createCommandExecute()
        {
            try
            {
                if (band == false)
                {

                    _model.CreatePersona(Name, Age, Email);
                    People = _model.GetPersonas();
                    clearCommandExecute();
                }
                else
                {
                    _model.UpdatePersonas(Id, Name, Age, Email);
                    People = _model.GetPersonas();
                    band = false;
                    clearCommandExecute();                   
                }
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void deleteCommandExecute()
        {
            try
            {
                _model.DeletePersona(PersonSelected);
                People = _model.GetPersonas();
            }
            catch (Exception exdel)
            {
                MessageBox.Show(exdel.Message, "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void clearCommandExecute()
        {
            Name = null;
            Age = 0;
            Email = null;
        }
        private void doubleClickCommandExecute(Person person)
        {
            Id = person.Id;
            Name= person.Name;
            Age = person.Age;
            Email = person.Email;
            band = true;
        }
    }
}
