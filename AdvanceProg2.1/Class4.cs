using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceProg2._1
{
    public class ComposedMission : IMission
    {
        //members
        private List<Func<double, double>> funcList;
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
                return "Composed";
            }
        }
        //constructor
        public ComposedMission(string name)
        {
            this.name = name;
        }
        public ComposedMission Add(Func<double, double> func)
        {
            funcList.Add(func);
            return this;
            
        }
        //methods
        public double Calculate(double value)
        {
            foreach(var f in funcList)
            {
                value = f(value);
            }
            OnCalculate?.Invoke(this, value);
            return value;
        }
        //event
        public event EventHandler<double> OnCalculate;
    }
}
