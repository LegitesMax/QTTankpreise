using QTTankpreise.Logic.Modules.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTTankpreise.Logic.Entities.Base
{
    public class FuelPrice : VersionEntity
    {

        public string CompanyName { get; set; } = string.Empty;
        public PriceStatus PriceStatus { get; set; } = new();
        public double Price { get; set; }
        public string Distance { get; set; } = string.Empty;
        
    }
}
