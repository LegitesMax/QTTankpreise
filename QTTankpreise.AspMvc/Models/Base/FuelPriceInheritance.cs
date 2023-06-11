//@GeneratedCode
namespace QTTankpreise.AspMvc.Models.Base
{
    partial class FuelPrice : QTTankpreise.AspMvc.Models.VersionModel
    {
        public static FuelPrice Create(Logic.Entities.Base.FuelPrice entity)
        {
            return new FuelPrice
            {
                Id = entity.Id,
                CompanyName= entity.CompanyName,
                Distance= entity.Distance,
                Price = entity.Price,
                PriceStatus = entity.PriceStatus
            };
        }
    }
}
