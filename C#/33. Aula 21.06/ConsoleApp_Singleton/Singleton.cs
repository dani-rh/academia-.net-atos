using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Singleton
{
    public class Singleton
    {

        private static Singleton singleton = null;
        private Singleton() 
        {
            
        }

        public static Singleton getInstance()
        {
            if(singleton == null) //se não tiver instanciado, permite a criação de uma instancia em singleton
            {
                singleton = new Singleton();
            }
            
            return singleton;
        }
    }
}
