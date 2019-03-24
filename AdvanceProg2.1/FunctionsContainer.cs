using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceProg2._1
{
    class FunctionsContainer
    {
        //A function that returns intself
        private readonly Func<double, double> defaultFunc = val => val;
        //A dictionary struct
        private Dictionary<string, Func<double, double>> funcDict = new Dictionary<string, Func<double, double>>();
        //Indexer
        public Func<double,double> this[string funcKey]
        {
            get
            {
                Func<double, double> func;
                if (funcDict.TryGetValue(funcKey, out func))
                {
                    return func;
                }
                else
                {
                    funcDict[funcKey] = defaultFunc;
                    return defaultFunc;
                }
            }
            set
            {
                funcDict[funcKey] = value;
            }
        }
        //return keys func
        public List<string> getAllMissions()
        {
            return new List<string>(funcDict.Keys);
        }
    }
}
