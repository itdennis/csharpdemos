using System;
using System.Collections.Generic;
using System.Text;

namespace demo01
{
    public static class DelegateAdvance
    {
        public static void SafeInvoke(this Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void SafeSaveChange(this Func<string> func)
        {
            var res = func.Invoke();
            if (true)
            {
                Console.WriteLine(res);
            }
        }
    }
}
