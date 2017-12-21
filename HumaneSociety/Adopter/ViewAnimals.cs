using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopter
{
    class ViewAnimals
    {
        AdopterEnvironment returnToPage;
        IDatabase dB;
        public ViewAnimals(IDatabase dB)
        {
            this.dB = dB;
            
        }
    }
}
