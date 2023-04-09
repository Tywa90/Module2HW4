using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public interface IAnimalsGroup
    {
        string Name { get; set; }
        int Speed { get; set; }
        int MaxWeight { get; set; }
    }
}
