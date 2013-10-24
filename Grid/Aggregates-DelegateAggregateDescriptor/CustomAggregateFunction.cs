using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Grid;

namespace Aggregates_DelegateAggregateDescriptor
{
    public class TotalSalarySumAggregateFunction : IAggregateFunction
    {
        private double totalSalary = 0;

        public void Accumulate(object value)
        {
            totalSalary += (double)value;
        }

        public object GetValue()
        {
            return totalSalary;
        }

        public void Merge(IAggregateFunction aggregateFunction)
        {
            var function = aggregateFunction as TotalSalarySumAggregateFunction;
            if (function != null)
            {
                this.totalSalary += function.totalSalary;
            }
        }

        public IAggregateFunction Clone()
        {
            return new TotalSalarySumAggregateFunction();
        }
    }

    public class RegularSalaryDifferenceAggregateFunction : IAggregateFunction
    {
        private double minSalary = double.MaxValue;
        private double maxSalary;

        public void Accumulate(object value)
        {
            var salary = (double)value;
            if (salary < minSalary)
                minSalary = salary;
            if (salary > maxSalary)
                maxSalary = salary;
        }

        public object GetValue()
        {
            double difference = maxSalary - minSalary;
            return difference;
        }

        public void Merge(IAggregateFunction aggregateFunction)
        {
            var function = aggregateFunction as RegularSalaryDifferenceAggregateFunction;
            if (function != null)
            {
                if (this.minSalary > function.minSalary)
                    this.minSalary = function.minSalary;
                if (this.maxSalary < function.maxSalary)
                    this.maxSalary = function.maxSalary;
            }
        }

        public IAggregateFunction Clone()
        {
            return new RegularSalaryDifferenceAggregateFunction();
        }
    }
}