using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        //members
        private List<delegateFunc> funcList = new List<delegateFunc>();
        //properties
        public String Name { get; }
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
            this.Name = name;
        }
        public ComposedMission Add(delegateFunc func)
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
