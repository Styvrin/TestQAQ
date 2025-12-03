using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    internal class GruopDate
    {
        private string name;
        private string header;
        private string footer;

        public GruopDate (string name, string header)
        {
            this.name = name;
            this.header = header;
           
        }

        public string Name
        { 
            get 
            { 
                return name; 
            } 
            set
            { 
                this.name = value; 
            }
        }
        public string Header
        {
            get
            { 
                return header; 
            }
            set 
            { 
                this.header = value; 
            }
        }
        public string Footer
        {
            get
            {
                return footer;
            }
            set
            {
                this.footer = value;
            }
        }
    }
}
