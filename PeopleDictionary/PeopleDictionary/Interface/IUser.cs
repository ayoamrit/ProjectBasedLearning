using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PeopleDictionary.Interface
{
    public interface IUser
    {
        string Name { get; set; }
        string Email { get; set; }
        string Role { get; set; }

        List<string> Duties { get; set; }
    }
}
