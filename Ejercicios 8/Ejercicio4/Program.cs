using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void positivoNegativoCero (int n1, ref int n2 ){
            if (n1 > 0){
                n2 = 1;
            } else if (n1 < 0){
                n2 = -1;
            } else {
                n2 = 0;
            }
        }
    
    
    }
}
