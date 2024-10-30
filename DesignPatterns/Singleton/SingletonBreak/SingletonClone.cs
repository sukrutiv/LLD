using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonBreak
{
    public class SingletonClone : ICloneable
    {

        private static volatile SingletonClone instance;
        private static object instanceLock = new object();
        public static SingletonClone Instance
        {
            get
            {
                if (instance != null) return instance;
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonClone();
                    }
                }
                return instance;
            }
        }
        private SingletonClone() { }    



        public object Clone()
        {
            return (SingletonClone)base.MemberwiseClone();
        }
    }
}
