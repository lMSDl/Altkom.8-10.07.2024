using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._8_10._07._2024.DesignPatterns.Creational.Builder
{
    internal class VehicleBuilderFacade : BaseBuilder<Vehicle>
    {
        public VehicleBuilderFacade(Vehicle item) : base(item)
        {
        }

        public VehilceBuilder Parts => new VehilceBuilder(Item);
        public VehilceProductionInfoBuilder Info => new VehilceProductionInfoBuilder(Item);
    }
}
