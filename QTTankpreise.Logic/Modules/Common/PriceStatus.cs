using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTTankpreise.Logic.Modules.Common
{
    public enum PriceStatus
    {
        [Display(Name = "Bester Preis")]
        BestPrice = 0,

        [Display(Name = "Am nächsten")]
        NearestPrice = 1,

        [Display(Name = "Durchschnitt")]
        AveragePrice = 2,

        [Display(Name = "Hervorsage für morgen")]
        PredictedPrice = 3,
    }
}
