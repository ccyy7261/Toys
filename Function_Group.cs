using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Function_Group
    {
        //功能组  <功能名，{类名，方法名}>
        public static Dictionary<string, List<string>> Functions = new Dictionary<string, List<string>>();
        public static void Init()
        {
            Functions.Add("功能查询",new List<string> { "FunctionRefer", "FunctionRefer" });


        }

    }
}
