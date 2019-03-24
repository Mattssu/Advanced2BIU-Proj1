using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{ 
    public delegate double delegateFunc(double num);
    class FunctionsContainer
    {
        //A function that returns intself
        private readonly delegateFunc defaultFunc = val => val;
        //A dictionary struct
        private Dictionary<string, delegateFunc> funcDict = new Dictionary<string, delegateFunc>();
        //Indexer
        public delegateFunc this[string funcKey]
        {
            get
            {
                delegateFunc func;
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
