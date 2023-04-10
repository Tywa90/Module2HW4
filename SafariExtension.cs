using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public static class SafariExtension
    {
        public static IAnimalsGroup FindByName (this IAnimalsGroup[] animals, string name)
        {
            foreach (var item in animals)
            {
                if (item.Name != null && item.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                {
                    return item;
                }
            }
            return null;
        }
    }
}

