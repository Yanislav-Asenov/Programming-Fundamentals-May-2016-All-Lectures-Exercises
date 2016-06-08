using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLParser
{
    public class URLParser
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            int indexOfSlashes = input.IndexOf("://");

            string protocol = string.Empty;
            string resource = string.Empty;
            string server = string.Empty;
            if (indexOfSlashes != -1)
            {
                protocol = input.Substring(0, indexOfSlashes);
                input = input.Substring(protocol.Length + 3);
            }

            

            int indexOfResourceSlash = input.IndexOf('/');
            if (indexOfResourceSlash != -1)
            {
                resource = input.Substring(indexOfResourceSlash + 1);
                server = input.Substring(0, indexOfResourceSlash);
            }
            else
            {
                server = input.Substring(0);
            }
            

            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            Console.WriteLine("[server] = \"{0}\"", server);
            Console.WriteLine("[resource] = \"{0}\"", resource);
        }
    }
}
