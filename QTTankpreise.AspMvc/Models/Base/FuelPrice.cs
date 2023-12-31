﻿//@GeneratedCode
namespace QTTankpreise.AspMvc.Models.Base
{
    using System;
    ///
    /// Generated by the generator
    ///
    
    public partial class FuelPrice
    {
        ///
        /// Generated by the generator
        ///
        static FuelPrice()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public FuelPrice()
        {
            Constructing();
            
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///

        [Display(Name = "Firma")]
        public System.String CompanyName { get; set; } = string.Empty;
        ///
        /// Generated by the generator
        ///

        
        public QTTankpreise.Logic.Modules.Common.PriceStatus PriceStatus { get; set; }
        ///
        /// Generated by the generator
        ///

        [Display(Name = "Preis")]
        public System.Double Price { get; set; }
        ///
        /// Generated by the generator
        ///

        [Display(Name = "Entfernung")]
        public System.String Distance { get; set; } = string.Empty;
        ///
        /// Generated by the generator
        ///
        public static QTTankpreise.AspMvc.Models.Base.FuelPrice Create()
        {
            BeforeCreate();
            var result = new QTTankpreise.AspMvc.Models.Base.FuelPrice();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTTankpreise.AspMvc.Models.Base.FuelPrice Create(object other)
        {
            BeforeCreate(other);
            var result = new QTTankpreise.AspMvc.Models.Base.FuelPrice();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTTankpreise.AspMvc.Models.Base.FuelPrice instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTTankpreise.AspMvc.Models.Base.FuelPrice instance, object other);
        ///
        /// Generated by the generator
        ///
        public static QTTankpreise.AspMvc.Models.Base.FuelPrice Create(QTTankpreise.Logic.Models.Base.FuelPrice other)
        {
            BeforeCreate(other);
            var result = new QTTankpreise.AspMvc.Models.Base.FuelPrice();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate(QTTankpreise.Logic.Models.Base.FuelPrice other);
        static partial void AfterCreate(QTTankpreise.AspMvc.Models.Base.FuelPrice instance, QTTankpreise.Logic.Models.Base.FuelPrice other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTTankpreise.Logic.Models.Base.FuelPrice other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                CompanyName = other.CompanyName;
                PriceStatus = other.PriceStatus;
                Price = other.Price;
                Distance = other.Distance;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTTankpreise.Logic.Models.Base.FuelPrice other, ref bool handled);
        partial void AfterCopyProperties(QTTankpreise.Logic.Models.Base.FuelPrice other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTTankpreise.AspMvc.Models.Base.FuelPrice other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                CompanyName = other.CompanyName;
                PriceStatus = other.PriceStatus;
                Price = other.Price;
                Distance = other.Distance;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTTankpreise.AspMvc.Models.Base.FuelPrice other, ref bool handled);
        partial void AfterCopyProperties(QTTankpreise.AspMvc.Models.Base.FuelPrice other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.Base.FuelPrice other)
            {
                result = Id == other.Id;
            }
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public override int GetHashCode()
        {
            return this.CalculateHashCode(CompanyName, PriceStatus, Price, Distance, Id);
        }
    }
}
