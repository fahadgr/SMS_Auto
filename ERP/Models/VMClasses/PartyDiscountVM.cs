using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP.Models.VMClasses
{
    public class PartyDiscountVM
    {
        public string CompCode { get; set; }
        public string RegionCode { get; set; }
        public string RegionDescription { get; set; }
        public string PartyCode { get; set; }
        public string PartyName { get; set; }
        public string PDCode { get; set; }
        public Nullable<System.DateTime> PDDate { get; set; }
        public Nullable<decimal> MilkFF { get; set; }
        public Nullable<decimal> MilkLF { get; set; }
        public Nullable<decimal> MilkNeutraHalf { get; set; }
        public Nullable<decimal> MilkNeutra { get; set; }
        public Nullable<decimal> RawMilk { get; set; }
        public Nullable<decimal> MilkFF450 { get; set; }
        public Nullable<decimal> MilkFF250 { get; set; }
        public Nullable<decimal> MilkLF250 { get; set; }
        public Nullable<decimal> ChokoMilk { get; set; }
        public Nullable<decimal> MilkStrawBerry200 { get; set; }
        public Nullable<decimal> Ecolean { get; set; }
        public Nullable<decimal> PremaRotation { get; set; }
        public Nullable<decimal> YgrtNatural400 { get; set; }
        public Nullable<decimal> YgrtNatural80 { get; set; }
        public Nullable<decimal> YgrtNatural1kg { get; set; }
        public Nullable<decimal> YgrtStrawBerry90 { get; set; }
        public Nullable<decimal> YgrtStrawBerry80 { get; set; }
        public Nullable<decimal> YgrtLF400 { get; set; }
        public Nullable<decimal> YgrtBlueBerry90 { get; set; }
        public Nullable<decimal> YgrtMango80 { get; set; }
        public Nullable<decimal> YgrtVanilla100 { get; set; }
        public Nullable<decimal> YgrtSweet400 { get; set; }
        public Nullable<decimal> YgrtPouch500 { get; set; }
        public Nullable<decimal> Podina { get; set; }
        public Nullable<decimal> FreshCream { get; set; }
        public Nullable<decimal> RaitaZeera250 { get; set; }
        public Nullable<decimal> RaitaPodina250 { get; set; }
        public Nullable<decimal> RaitaZeera80 { get; set; }
        public Nullable<decimal> PineApple90 { get; set; }
        public Nullable<decimal> SmoothieMango220 { get; set; }
        public Nullable<decimal> SmoothieStrawberry220 { get; set; }
        public Nullable<decimal> Cream { get; set; }
        public Nullable<decimal> LabbanPlain { get; set; }
        public Nullable<decimal> LabbanStrawberry { get; set; }
        public Nullable<System.DateTime> UpdDate { get; set; }
        public string UpdUser { get; set; }
        public string UpdTerm { get; set; }
    }
}