using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectXUnit.Interface
{
    internal interface IInterface1
    {
        Contact GetContact(int id);

        List<Contact> GetContacts();
    }
}
