using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Unit6.Models.CAR
{
    internal class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
        }
    }
}
