using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        //members
        private delegateFunc func;
        //properties
        public String Name { get; }
        public String Type
        {
            get
            {
                return "Single";
            }
        }
        //constructor
        public SingleMission(delegateFunc func,string name)
        {
            this.func = func;
            this.Name = name;
        }
        //methods
        public double Calculate(double value)
        {
            if(func != null)
            {
                value = func(value);
            }
            OnCalculate?.Invoke(this, value);
            return value;
        }
        //event
        public event EventHandler<double> OnCalculate;
    }
}
