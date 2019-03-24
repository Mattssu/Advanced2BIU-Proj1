using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceProg2._1
{
    public class SingleMission : IMission
    {
        //members
        private Func<double, double> func;
        private string name;
        //properties
        public String Name
        {
            get
            {
                return name;
            }
        }
        public String Type
        {
            get
            {
                return "Single";
            }
        }
        //constructor
        public SingleMission(Func<double,double> func,string name)
        {
            this.func = func;
            this.name = name;
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
