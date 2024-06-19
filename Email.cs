using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlEnv
{
    public  class Email
    {
       
        public string provedor { get; private set; }
        public string email { get; private set; }   
        public string password { get; private set; }

        public Email(string provedor, string email, string password)
        {
            this.provedor = provedor ?? throw new ArgumentNullException(nameof(provedor));
            this.email = email ?? throw new ArgumentNullException(nameof(email));
            this.password = password ?? throw new ArgumentNullException(nameof(password));
        }

        public void SendEmail(List<string> emailsTo, string subject, string body, List<string> attachaments )
        {

        }

    }
}
