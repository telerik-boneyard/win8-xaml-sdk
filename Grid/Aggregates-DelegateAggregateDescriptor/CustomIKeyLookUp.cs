using Telerik.UI.Xaml.Controls.Grid;

namespace Aggregates_DelegateAggregateDescriptor
{
    public class RegularSalaryKeyLookUp : IKeyLookup
    {
        public object GetKey(object instance)
        {
            var employee = instance as Employee;

            double regularSalary = employee.RegularWorkingDays * employee.DailyPayment;

            return regularSalary;
        }
    }

    public class TotalEmployeeSalaryKeyLookup : IKeyLookup
    {
        public object GetKey(object instance)
        {
            var employee = instance as Employee;

            double totalSalary = (employee.RegularWorkingDays + 2 * employee.DoublePaidDays) * employee.DailyPayment + employee.Bonuses;

            return totalSalary;
        }
    }
}