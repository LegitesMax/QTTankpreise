﻿//@GeneratedCode
namespace QTTankpreise.WebApi.Models.Base
{
    using System;
    ///
    /// Generated by the generator
    ///
    public partial class FuelPriceEdit
    {
        ///
        /// Generated by the generator
        ///
        static FuelPriceEdit()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public FuelPriceEdit()
        {
            Constructing();
            
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        public System.String CompanyName { get; set; } = string.Empty;
        ///
        /// Generated by the generator
        ///
        public QTTankpreise.Logic.Modules.Common.PriceStatus PriceStatus { get; set; }
        ///
        /// Generated by the generator
        ///
        public System.Double Price { get; set; }
        ///
        /// Generated by the generator
        ///
        public System.String Distance { get; set; } = string.Empty;
    }
}
