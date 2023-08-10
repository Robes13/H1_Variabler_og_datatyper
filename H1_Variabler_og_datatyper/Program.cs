using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 16;
            double width = 5.1;
            // Linjen under virker ikke da vi erklærer at int area består af vores doubler width * length, hvilket vil give et komma tal - og derved ikke kan kompileres.
            int area = width * length;
            // Linjen under virker pga vi erklærer en double med nanvet d, som består af width * length. Grunden til dette virker er at 16 også er en del af doubles "range".
            double d = width * length;
        }
    }
}
