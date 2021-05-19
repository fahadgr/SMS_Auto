﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AT_Tahur_SUITEEntities : DbContext
    {
        public AT_Tahur_SUITEEntities()
            : base("name=AT_Tahur_SUITEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PartyDiscount> PartyDiscounts { get; set; }
        public virtual DbSet<SaleItem> SaleItems { get; set; }
        public virtual DbSet<SaleParty> SaleParties { get; set; }
        public virtual DbSet<Farm> Farms { get; set; }
        public virtual DbSet<DailyIntake> DailyIntakes { get; set; }
        public virtual DbSet<DailyProduction> DailyProductions { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<DailyDispatch> DailyDispatches { get; set; }
        public virtual DbSet<CompanyEmp> CompanyEmps { get; set; }
        public virtual DbSet<CompanySetup> CompanySetups { get; set; }
        public virtual DbSet<DailyStockReceive> DailyStockReceives { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Recovery> Recoveries { get; set; }
        public virtual DbSet<RegionSetup> RegionSetups { get; set; }
        public virtual DbSet<SalesmanOpeningStock> SalesmanOpeningStocks { get; set; }
        public virtual DbSet<InvoiceTableSrNo> InvoiceTableSrNoes { get; set; }
        public virtual DbSet<ShortCash> ShortCashes { get; set; }
        public virtual DbSet<SaleInvoiceDetail> SaleInvoiceDetails { get; set; }
        public virtual DbSet<SaleInvoiceMaster> SaleInvoiceMasters { get; set; }
    
        public virtual ObjectResult<string> GetDinstinctParty(string companyCode)
        {
            var companyCodeParameter = companyCode != null ?
                new ObjectParameter("CompanyCode", companyCode) :
                new ObjectParameter("CompanyCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetDinstinctParty", companyCodeParameter);
        }
    
        public virtual ObjectResult<GetDinstinctPartyDiscount_Result> GetDinstinctPartyDiscount(string companyCode)
        {
            var companyCodeParameter = companyCode != null ?
                new ObjectParameter("CompanyCode", companyCode) :
                new ObjectParameter("CompanyCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDinstinctPartyDiscount_Result>("GetDinstinctPartyDiscount", companyCodeParameter);
        }
    
        public virtual ObjectResult<GetDinstinctDSRNo_Result> GetDinstinctDSRNo(string companyCode)
        {
            var companyCodeParameter = companyCode != null ?
                new ObjectParameter("CompanyCode", companyCode) :
                new ObjectParameter("CompanyCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDinstinctDSRNo_Result>("GetDinstinctDSRNo", companyCodeParameter);
        }
    
        public virtual ObjectResult<GetDinstinctSOSNo_Result> GetDinstinctSOSNo(string companyCode)
        {
            var companyCodeParameter = companyCode != null ?
                new ObjectParameter("CompanyCode", companyCode) :
                new ObjectParameter("CompanyCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDinstinctSOSNo_Result>("GetDinstinctSOSNo", companyCodeParameter);
        }
    
        public virtual ObjectResult<CountPartyDis_Result> CountPartyDis(string companyCode)
        {
            var companyCodeParameter = companyCode != null ?
                new ObjectParameter("CompanyCode", companyCode) :
                new ObjectParameter("CompanyCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CountPartyDis_Result>("CountPartyDis", companyCodeParameter);
        }
    
        public virtual ObjectResult<GetDistinctRecovery_Result> GetDistinctRecovery(string companyCode)
        {
            var companyCodeParameter = companyCode != null ?
                new ObjectParameter("CompanyCode", companyCode) :
                new ObjectParameter("CompanyCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDistinctRecovery_Result>("GetDistinctRecovery", companyCodeParameter);
        }
    
        public virtual ObjectResult<GetDistinctRegion_Result> GetDistinctRegion()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDistinctRegion_Result>("GetDistinctRegion");
        }
    
        public virtual ObjectResult<ButterAllQty_Result> ButterAllQty(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ButterAllQty_Result>("ButterAllQty", fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<MilkAllQty_Result> MilkAllQty(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MilkAllQty_Result>("MilkAllQty", fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<RaitaAllQty_Result> RaitaAllQty(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RaitaAllQty_Result>("RaitaAllQty", fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<YougartAllQty_Result> YougartAllQty(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<YougartAllQty_Result>("YougartAllQty", fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<SaleTaxRegisterFBR_Result> SaleTaxRegisterFBR(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SaleTaxRegisterFBR_Result>("SaleTaxRegisterFBR", fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<string> DistinctDPCode()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("DistinctDPCode");
        }
    
        public virtual ObjectResult<GetSalePartiesFast_Result> GetSalePartiesFast()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSalePartiesFast_Result>("GetSalePartiesFast");
        }
    
        public virtual ObjectResult<Nullable<int>> CountAllParties()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CountAllParties");
        }
    
        public virtual ObjectResult<FindItemTax_Result> FindItemTax(string itemCode)
        {
            var itemCodeParameter = itemCode != null ?
                new ObjectParameter("ItemCode", itemCode) :
                new ObjectParameter("ItemCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FindItemTax_Result>("FindItemTax", itemCodeParameter);
        }
    
        public virtual ObjectResult<FindItemRate_Result> FindItemRate(string regionCode, string itemCode)
        {
            var regionCodeParameter = regionCode != null ?
                new ObjectParameter("RegionCode", regionCode) :
                new ObjectParameter("RegionCode", typeof(string));
    
            var itemCodeParameter = itemCode != null ?
                new ObjectParameter("ItemCode", itemCode) :
                new ObjectParameter("ItemCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FindItemRate_Result>("FindItemRate", regionCodeParameter, itemCodeParameter);
        }
    
        public virtual ObjectResult<string> GetDistinctDispatchList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetDistinctDispatchList");
        }
    
        public virtual ObjectResult<GetRegionPartiesFast_Result> GetRegionPartiesFast(string regionCode)
        {
            var regionCodeParameter = regionCode != null ?
                new ObjectParameter("RegionCode", regionCode) :
                new ObjectParameter("RegionCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetRegionPartiesFast_Result>("GetRegionPartiesFast", regionCodeParameter);
        }
    
        public virtual ObjectResult<string> GetDistinctShortCash()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetDistinctShortCash");
        }
    
        public virtual ObjectResult<GetDEOPerfomance_Result> GetDEOPerfomance(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDEOPerfomance_Result>("GetDEOPerfomance", fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<GetDEOPerfomance1_Result> GetDEOPerfomance1(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("fromDate", fromDate) :
                new ObjectParameter("fromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("toDate", toDate) :
                new ObjectParameter("toDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDEOPerfomance1_Result>("GetDEOPerfomance1", fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<AgingReport_Result> AgingReport(Nullable<System.DateTime> fromDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AgingReport_Result>("AgingReport", fromDateParameter);
        }
    
        public virtual ObjectResult<Sp_LastSaleParties_Result> Sp_LastSaleParties()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_LastSaleParties_Result>("Sp_LastSaleParties");
        }
    
        public virtual int SP_Insert_SaleInvoiceDetail(string invoiceNo, Nullable<System.DateTime> invoiceDate, string manInvoiceNo, string repInvoiceNo, string partyCode, string mainPartyCode, string transType, string itemCode, Nullable<double> saleQty, Nullable<double> rate, Nullable<double> damage, Nullable<double> replace, Nullable<double> fOC, Nullable<double> sampling, Nullable<double> scheme, Nullable<double> retrn, Nullable<double> wHT, Nullable<double> discPer, Nullable<double> discAmt, Nullable<double> amount, Nullable<double> furtherTaxPer, Nullable<double> furtherTaxAmt, Nullable<double> incTaxAmt, Nullable<double> excTaxAmt, Nullable<double> saleTaxPer, Nullable<double> saleTaxAmt)
        {
            var invoiceNoParameter = invoiceNo != null ?
                new ObjectParameter("InvoiceNo", invoiceNo) :
                new ObjectParameter("InvoiceNo", typeof(string));
    
            var invoiceDateParameter = invoiceDate.HasValue ?
                new ObjectParameter("InvoiceDate", invoiceDate) :
                new ObjectParameter("InvoiceDate", typeof(System.DateTime));
    
            var manInvoiceNoParameter = manInvoiceNo != null ?
                new ObjectParameter("ManInvoiceNo", manInvoiceNo) :
                new ObjectParameter("ManInvoiceNo", typeof(string));
    
            var repInvoiceNoParameter = repInvoiceNo != null ?
                new ObjectParameter("RepInvoiceNo", repInvoiceNo) :
                new ObjectParameter("RepInvoiceNo", typeof(string));
    
            var partyCodeParameter = partyCode != null ?
                new ObjectParameter("PartyCode", partyCode) :
                new ObjectParameter("PartyCode", typeof(string));
    
            var mainPartyCodeParameter = mainPartyCode != null ?
                new ObjectParameter("MainPartyCode", mainPartyCode) :
                new ObjectParameter("MainPartyCode", typeof(string));
    
            var transTypeParameter = transType != null ?
                new ObjectParameter("TransType", transType) :
                new ObjectParameter("TransType", typeof(string));
    
            var itemCodeParameter = itemCode != null ?
                new ObjectParameter("ItemCode", itemCode) :
                new ObjectParameter("ItemCode", typeof(string));
    
            var saleQtyParameter = saleQty.HasValue ?
                new ObjectParameter("SaleQty", saleQty) :
                new ObjectParameter("SaleQty", typeof(double));
    
            var rateParameter = rate.HasValue ?
                new ObjectParameter("Rate", rate) :
                new ObjectParameter("Rate", typeof(double));
    
            var damageParameter = damage.HasValue ?
                new ObjectParameter("Damage", damage) :
                new ObjectParameter("Damage", typeof(double));
    
            var replaceParameter = replace.HasValue ?
                new ObjectParameter("Replace", replace) :
                new ObjectParameter("Replace", typeof(double));
    
            var fOCParameter = fOC.HasValue ?
                new ObjectParameter("FOC", fOC) :
                new ObjectParameter("FOC", typeof(double));
    
            var samplingParameter = sampling.HasValue ?
                new ObjectParameter("Sampling", sampling) :
                new ObjectParameter("Sampling", typeof(double));
    
            var schemeParameter = scheme.HasValue ?
                new ObjectParameter("Scheme", scheme) :
                new ObjectParameter("Scheme", typeof(double));
    
            var retrnParameter = retrn.HasValue ?
                new ObjectParameter("Retrn", retrn) :
                new ObjectParameter("Retrn", typeof(double));
    
            var wHTParameter = wHT.HasValue ?
                new ObjectParameter("WHT", wHT) :
                new ObjectParameter("WHT", typeof(double));
    
            var discPerParameter = discPer.HasValue ?
                new ObjectParameter("DiscPer", discPer) :
                new ObjectParameter("DiscPer", typeof(double));
    
            var discAmtParameter = discAmt.HasValue ?
                new ObjectParameter("DiscAmt", discAmt) :
                new ObjectParameter("DiscAmt", typeof(double));
    
            var amountParameter = amount.HasValue ?
                new ObjectParameter("Amount", amount) :
                new ObjectParameter("Amount", typeof(double));
    
            var furtherTaxPerParameter = furtherTaxPer.HasValue ?
                new ObjectParameter("FurtherTaxPer", furtherTaxPer) :
                new ObjectParameter("FurtherTaxPer", typeof(double));
    
            var furtherTaxAmtParameter = furtherTaxAmt.HasValue ?
                new ObjectParameter("FurtherTaxAmt", furtherTaxAmt) :
                new ObjectParameter("FurtherTaxAmt", typeof(double));
    
            var incTaxAmtParameter = incTaxAmt.HasValue ?
                new ObjectParameter("IncTaxAmt", incTaxAmt) :
                new ObjectParameter("IncTaxAmt", typeof(double));
    
            var excTaxAmtParameter = excTaxAmt.HasValue ?
                new ObjectParameter("ExcTaxAmt", excTaxAmt) :
                new ObjectParameter("ExcTaxAmt", typeof(double));
    
            var saleTaxPerParameter = saleTaxPer.HasValue ?
                new ObjectParameter("SaleTaxPer", saleTaxPer) :
                new ObjectParameter("SaleTaxPer", typeof(double));
    
            var saleTaxAmtParameter = saleTaxAmt.HasValue ?
                new ObjectParameter("SaleTaxAmt", saleTaxAmt) :
                new ObjectParameter("SaleTaxAmt", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Insert_SaleInvoiceDetail", invoiceNoParameter, invoiceDateParameter, manInvoiceNoParameter, repInvoiceNoParameter, partyCodeParameter, mainPartyCodeParameter, transTypeParameter, itemCodeParameter, saleQtyParameter, rateParameter, damageParameter, replaceParameter, fOCParameter, samplingParameter, schemeParameter, retrnParameter, wHTParameter, discPerParameter, discAmtParameter, amountParameter, furtherTaxPerParameter, furtherTaxAmtParameter, incTaxAmtParameter, excTaxAmtParameter, saleTaxPerParameter, saleTaxAmtParameter);
        }
    
        public virtual int SP_Insert_SaleInvoiceMaster(string companyCode, string invoiceNo, string manInvoiceNo, string repInvoiceNo, Nullable<System.DateTime> invoiceDate, string regionCode, string partyCode, string mainPartyCode, string empCode, string exemptTax, string partyStatus, Nullable<double> discount, Nullable<double> totalAmt, Nullable<double> saleTaxAmt, Nullable<double> furtherTaxAmt, Nullable<double> netTotal, string delFlag, string postFlag, string transType, string updUser, Nullable<System.DateTime> updDate, string updTerm, Nullable<double> incTaxAmt, Nullable<double> excTaxAmt)
        {
            var companyCodeParameter = companyCode != null ?
                new ObjectParameter("CompanyCode", companyCode) :
                new ObjectParameter("CompanyCode", typeof(string));
    
            var invoiceNoParameter = invoiceNo != null ?
                new ObjectParameter("InvoiceNo", invoiceNo) :
                new ObjectParameter("InvoiceNo", typeof(string));
    
            var manInvoiceNoParameter = manInvoiceNo != null ?
                new ObjectParameter("ManInvoiceNo", manInvoiceNo) :
                new ObjectParameter("ManInvoiceNo", typeof(string));
    
            var repInvoiceNoParameter = repInvoiceNo != null ?
                new ObjectParameter("RepInvoiceNo", repInvoiceNo) :
                new ObjectParameter("RepInvoiceNo", typeof(string));
    
            var invoiceDateParameter = invoiceDate.HasValue ?
                new ObjectParameter("InvoiceDate", invoiceDate) :
                new ObjectParameter("InvoiceDate", typeof(System.DateTime));
    
            var regionCodeParameter = regionCode != null ?
                new ObjectParameter("RegionCode", regionCode) :
                new ObjectParameter("RegionCode", typeof(string));
    
            var partyCodeParameter = partyCode != null ?
                new ObjectParameter("PartyCode", partyCode) :
                new ObjectParameter("PartyCode", typeof(string));
    
            var mainPartyCodeParameter = mainPartyCode != null ?
                new ObjectParameter("MainPartyCode", mainPartyCode) :
                new ObjectParameter("MainPartyCode", typeof(string));
    
            var empCodeParameter = empCode != null ?
                new ObjectParameter("EmpCode", empCode) :
                new ObjectParameter("EmpCode", typeof(string));
    
            var exemptTaxParameter = exemptTax != null ?
                new ObjectParameter("ExemptTax", exemptTax) :
                new ObjectParameter("ExemptTax", typeof(string));
    
            var partyStatusParameter = partyStatus != null ?
                new ObjectParameter("PartyStatus", partyStatus) :
                new ObjectParameter("PartyStatus", typeof(string));
    
            var discountParameter = discount.HasValue ?
                new ObjectParameter("Discount", discount) :
                new ObjectParameter("Discount", typeof(double));
    
            var totalAmtParameter = totalAmt.HasValue ?
                new ObjectParameter("TotalAmt", totalAmt) :
                new ObjectParameter("TotalAmt", typeof(double));
    
            var saleTaxAmtParameter = saleTaxAmt.HasValue ?
                new ObjectParameter("SaleTaxAmt", saleTaxAmt) :
                new ObjectParameter("SaleTaxAmt", typeof(double));
    
            var furtherTaxAmtParameter = furtherTaxAmt.HasValue ?
                new ObjectParameter("FurtherTaxAmt", furtherTaxAmt) :
                new ObjectParameter("FurtherTaxAmt", typeof(double));
    
            var netTotalParameter = netTotal.HasValue ?
                new ObjectParameter("NetTotal", netTotal) :
                new ObjectParameter("NetTotal", typeof(double));
    
            var delFlagParameter = delFlag != null ?
                new ObjectParameter("DelFlag", delFlag) :
                new ObjectParameter("DelFlag", typeof(string));
    
            var postFlagParameter = postFlag != null ?
                new ObjectParameter("PostFlag", postFlag) :
                new ObjectParameter("PostFlag", typeof(string));
    
            var transTypeParameter = transType != null ?
                new ObjectParameter("TransType", transType) :
                new ObjectParameter("TransType", typeof(string));
    
            var updUserParameter = updUser != null ?
                new ObjectParameter("UpdUser", updUser) :
                new ObjectParameter("UpdUser", typeof(string));
    
            var updDateParameter = updDate.HasValue ?
                new ObjectParameter("UpdDate", updDate) :
                new ObjectParameter("UpdDate", typeof(System.DateTime));
    
            var updTermParameter = updTerm != null ?
                new ObjectParameter("UpdTerm", updTerm) :
                new ObjectParameter("UpdTerm", typeof(string));
    
            var incTaxAmtParameter = incTaxAmt.HasValue ?
                new ObjectParameter("IncTaxAmt", incTaxAmt) :
                new ObjectParameter("IncTaxAmt", typeof(double));
    
            var excTaxAmtParameter = excTaxAmt.HasValue ?
                new ObjectParameter("ExcTaxAmt", excTaxAmt) :
                new ObjectParameter("ExcTaxAmt", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Insert_SaleInvoiceMaster", companyCodeParameter, invoiceNoParameter, manInvoiceNoParameter, repInvoiceNoParameter, invoiceDateParameter, regionCodeParameter, partyCodeParameter, mainPartyCodeParameter, empCodeParameter, exemptTaxParameter, partyStatusParameter, discountParameter, totalAmtParameter, saleTaxAmtParameter, furtherTaxAmtParameter, netTotalParameter, delFlagParameter, postFlagParameter, transTypeParameter, updUserParameter, updDateParameter, updTermParameter, incTaxAmtParameter, excTaxAmtParameter);
        }
    
        public virtual ObjectResult<Sp_PartyAnalysis_Result> Sp_PartyAnalysis()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_PartyAnalysis_Result>("Sp_PartyAnalysis");
        }
    
        public virtual int SP_MergeSaleDetail(string regionCode, string partyCode)
        {
            var regionCodeParameter = regionCode != null ?
                new ObjectParameter("RegionCode", regionCode) :
                new ObjectParameter("RegionCode", typeof(string));
    
            var partyCodeParameter = partyCode != null ?
                new ObjectParameter("PartyCode", partyCode) :
                new ObjectParameter("PartyCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_MergeSaleDetail", regionCodeParameter, partyCodeParameter);
        }
    
        public virtual ObjectResult<Sp_GetMissingCalculationInvoices_Result> Sp_GetMissingCalculationInvoices()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_GetMissingCalculationInvoices_Result>("Sp_GetMissingCalculationInvoices");
        }
    
        public virtual ObjectResult<SP_NewAgingReport_Result> SP_NewAgingReport(Nullable<System.DateTime> fromDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_NewAgingReport_Result>("SP_NewAgingReport", fromDateParameter);
        }
    }
}