using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    public interface IComponent
    {
        int GetNumber();
        double GetCost();
    }
}
