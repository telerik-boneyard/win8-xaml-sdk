using System.Collections.ObjectModel;
using Telerik.Core;

namespace Aggregates_DelegateAggregateDescriptor
{
    public class ViewModel : ViewModelBase
    {
        private double salaryDifference;
        private double totalSalary;

        public ViewModel()
        {
            SetData();
        }

        public ObservableCollection<Employee> Employees { get; set; }

        public void SetData()
        {
            this.Employees = new ObservableCollection<Employee>();

            this.Employees.Add(new Employee { Name = "Peter", RegularWorkingDays = 22, DoublePaidDays = 3, DailyPayment = 30, Bonuses = 200 });
            this.Employees.Add(new Employee { Name = "Melisa", RegularWorkingDays = 22, DoublePaidDays = 5, DailyPayment = 40, Bonuses = 0 });
            this.Employees.Add(new Employee { Name = "Lisa", RegularWorkingDays = 20, DoublePaidDays = 1, DailyPayment = 20, Bonuses = 0 });
            this.Employees.Add(new Employee { Name = "Michael", RegularWorkingDays = 22, DoublePaidDays = 2, DailyPayment = 40, Bonuses = 100 });
            this.Employees.Add(new Employee { Name = "Sonya", RegularWorkingDays = 20, DoublePaidDays = 0, DailyPayment = 30, Bonuses = 150 });
            this.Employees.Add(new Employee { Name = "Maya", RegularWorkingDays = 23, DoublePaidDays = 3, DailyPayment = 30, Bonuses = 20 });
            this.Employees.Add(new Employee { Name = "Jane", RegularWorkingDays = 21, DoublePaidDays = 0, DailyPayment = 30, Bonuses = 50 });
            this.Employees.Add(new Employee { Name = "Simon", RegularWorkingDays = 22, DoublePaidDays = 1, DailyPayment = 60, Bonuses = 20 });
            this.Employees.Add(new Employee { Name = "Robert", RegularWorkingDays = 23, DoublePaidDays = 3, DailyPayment = 30, Bonuses = 80 });
            this.Employees.Add(new Employee { Name = "Jack", RegularWorkingDays = 22, DoublePaidDays = 0, DailyPayment = 50, Bonuses = 120 });
            this.Employees.Add(new Employee { Name = "Stephen", RegularWorkingDays = 21, DoublePaidDays = 3, DailyPayment = 30, Bonuses = 20 });
            this.Employees.Add(new Employee { Name = "Tomas", RegularWorkingDays = 20, DoublePaidDays = 2, DailyPayment =40, Bonuses = 0 });
            this.Employees.Add(new Employee { Name = "Patrick", RegularWorkingDays = 22, DoublePaidDays = 1, DailyPayment = 30, Bonuses = 30 });
            this.Employees.Add(new Employee { Name = "Edwin", RegularWorkingDays = 22, DoublePaidDays = 3, DailyPayment = 40, Bonuses = 30 });
            this.Employees.Add(new Employee { Name = "Sara", RegularWorkingDays = 18, DoublePaidDays = 0, DailyPayment = 30, Bonuses = 0 });           
        }

        public double SalaryDifference
        {
            get
            {
                return salaryDifference;
            }
            set
            {
                salaryDifference = value;
                OnPropertyChanged();
            }
        }

        public double TotalSalary
        {
            get
            {
                return totalSalary;
            }
            set
            {
                totalSalary = value;
                OnPropertyChanged();
            }
        }
    }
}