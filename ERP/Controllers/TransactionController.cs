using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;
using ERP.Models;
using ERP.Models.VMClasses;
using System.Threading;

namespace ERP.Controllers
{
    public class TransactionController : Controller
    {
        TransactionHandler Handler = new TransactionHandler();


        // GET: Transaction


        #region(---------------------------------------- Salesman Opening Stocks-----------------------------------------)

        public ActionResult SalesmanOpeningStock()
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            if (CommonDAL.UserRights("6","001"))
            {
                ViewBag.CurrentDate = Handler.GetCurrentDate();
                ViewBag.ItemList = Handler.GetSaleItems();

                //using(AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
                //{
                //    ViewBag.RegionList = DefinitionContext.GetDistinctRegion().ToList();
                //}

                using (AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
                {
                    var List = DefinitionContext.GetDistinctRegion().ToList();
                    ViewBag.RegionDDL = new SelectList(List, "RegionCode", "RegionDescription");
                }

                //ViewBag.SalesmanDDL = new SelectList(Handler.GetEmpList().ToList(), "EmpCode", "EmpName");

                //ViewBag.RegionList = Handler.GetRegion();
                //ViewBag.GetEmpList = Handler.GetEmpList();
                

                return View();
            }
            else
            {
                return RedirectToAction("PageNotFound", "Home");
            }
           
        }



        [HttpPost]
        public ActionResult GetSOSDetail(string GetSOSDate)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            List<SalesmanOpeningStockVM> SOSDetail = new List<SalesmanOpeningStockVM>();
            string UpdTrue = "";

            if (CommonDAL.UserRights("6","003"))
            {
                 SOSDetail = Handler.GetDinstinctSOSNo(GetSOSDate).ToList();
                 UpdTrue = "Update";
            }
            

            return Json(new { SOSDetail = SOSDetail,UpdTrue = UpdTrue }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult GetSingleSOSNo(string SOSNo)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            List<SalesmanOpeningStockVM> ItemList = Handler.GetSingleSOSNo(SOSNo);
            
            return Json(ItemList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetRegionEmp(string RegionCode)
        {
            var RegionEmp = Handler.GetRegionEmp(RegionCode);

            return Json(RegionEmp, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult ItemDiscountSOS(ItemDiscountVM[] ItemDiscountSOS)
        {


            Session["ItemDiscountSOS"] = ItemDiscountSOS;

            return Json(ItemDiscountSOS, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SalesmanOpeningStock(SalesmanOpeningStock Obj,string SOSDate)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            TempData["SuccessMsg"] = Handler.AddEditSalesmanOpeningStock(Obj,SOSDate);

            return RedirectToAction("SalesmanOpeningStock");
        }

        [HttpPost]
        public ActionResult DeleteSOS(string SOSNo)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            bool data = Handler.DeleteSOS(SOSNo);

            return Json(data, JsonRequestBehavior.AllowGet);
        }


        #endregion

        #region(--------------------------------------Daily Stock Receive----------------------------------------------)
        public ActionResult DailyStockReceive()
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            if (CommonDAL.UserRights("5","001"))
            {
                
                ViewBag.ItemList = Handler.GetSaleItems();
                using (AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
                {
                    //ViewBag.RegionList = DefinitionContext.GetDistinctRegion().ToList();
                    var List = DefinitionContext.GetDistinctRegion().ToList();
                    ViewBag.RegionDDL = new SelectList(List, "RegionCode", "RegionDescription");
                }
               
                //ViewBag.RegionList = Handler.GetRegion();
                ViewBag.CurrentDate = Handler.GetCurrentDate();

                return View();
            }
            else
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            
        }

        [HttpPost]
        public ActionResult GetDSDDetail(string GetDSRDate)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            List<DailyStockReceiveVM> DSDDetail = new List<DailyStockReceiveVM>();
            string UpdTrue = "";

            if (CommonDAL.UserRights("5","003"))
            {
                DSDDetail = Handler.GetDinstinctDSRNoInfo(GetDSRDate).ToList();
                UpdTrue = "Update";
            }

            return Json(new { DSDDetail=DSDDetail,UpdTrue = UpdTrue }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetSingleDSRNo(string DSRNo)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            List<DailyStockReceiveVM> ItemList = Handler.GetSingleDSRNo(DSRNo);
            ViewBag.ItemList = null;
            return Json(ItemList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult ItemDiscountDSR(ItemDiscountVM[] ItemDiscountDSR)
        {
            Session["ItemDiscountDSR"] = ItemDiscountDSR;

            return Json(ItemDiscountDSR, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DailyStockReceive(DailyStockReceive Obj,string DSRDate)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            TempData["SuccessMsg"] = Handler.AddEditDailyStockReceive(Obj,DSRDate);
            return RedirectToAction("DailyStockReceive");
        }
        #endregion


        #region(---------------------------------------------------Sale Item------------------------------------------------------)

        public ActionResult SaleItem()
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            if (CommonDAL.UserRights("10","001"))
            {
                ViewBag.ItemList = Handler.GetSaleItems();

                return View();
            }
            else
            {
                return RedirectToAction("PageNotFound", "Home");
            }
        }

        public ActionResult GetItemImg()
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            if (Request.Files.Count > 0)
            {
                HttpPostedFileBase ItemPic = Request.Files[0];

                Session["ItemImg"] = ItemPic;
            }

            return Json(JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetSingleItem(string ItemCode)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            var data = Handler.GetSingleItem(ItemCode);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        

        [HttpPost]
        public ActionResult SaleItem(SaleItem Obj)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            //if (Session["ItemImg"] != null)
            //{
            //    HttpPostedFileBase ItemPic = (HttpPostedFileBase)Session["ItemImg"];
            //    if (ItemPic.FileName != "")
            //    {

            //        Obj.ItemPic = new byte[ItemPic.ContentLength];
            //        ItemPic.InputStream.Read(Obj.ItemPic, 0, ItemPic.ContentLength);
            //    }

            //}
            //else
            //{
            //    Obj.ItemPic = Obj.ItemPic;
            //}

            if (Request.Files.Count > 0)
            {
                HttpPostedFileBase ItemPic = Request.Files[0];
                if (ItemPic.FileName != "")
                {
                    Obj.ItemPic = new byte[ItemPic.ContentLength];
                    ItemPic.InputStream.Read(Obj.ItemPic, 0, ItemPic.ContentLength);
                }
                else
                {
                    Obj.ItemPic = Session["ItemPic"] as byte[];
                }

            }


            TempData["SuccessMsg"] = Handler.AddEditSaleItem(Obj);

            return RedirectToAction("SaleItem");
        }

        #endregion

        #region(-----------------------------------------------------Sale Invoice --------------------------------------------)

        public ActionResult SaleInvoice()
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            if (CommonDAL.UserRights("7","001"))
            {
                //ViewBag.PartyDDL = new SelectList(Handler.GetSaleParties().ToList(), "PartyCode", "PartyName");

                using (AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
                {
                    var List = DefinitionContext.GetDistinctRegion().ToList();
                    ViewBag.RegionDDL = new SelectList(List, "RegionCode", "RegionDescription");
                }

                //ViewBag.SalesmanDDL = new SelectList(Handler.GetEmpList().ToList(), "EmpCode", "EmpName");

                ViewBag.ItemDDL = new SelectList(Handler.GetSaleItemsWithCode(), "ItemCode", "ItemDesc");

                ViewBag.CurrentDate = Handler.GetCurrentDate();

                //ViewBag.EmpList = Handler.GetEmpList();
                //ViewBag.RegionList = Handler.GetRegion();
                //ViewBag.PartyList = Handler.GetSaleParties();
                //ViewBag.ItemList = Handler.GetSaleItems();

                return View();
            }
            else
            {
                return RedirectToAction("PageNotFound", "Home");
            }
           
        }


        public ActionResult GetDamagerInvoices(string DamageDate)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            List<SaleInvoiceMasterVM> DamageInvoice = new List<SaleInvoiceMasterVM>();
            if (CommonDAL.UserRights("7", "003"))
            {
                DamageInvoice = Handler.GetSaleInvoiceWithEmp(DamageDate);

                return Json(DamageInvoice, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(DamageInvoice, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult GetMultiRegionEmp(string[] RegionCode)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            var GetRegionEmp = Handler.GetMultiRegionEmp(RegionCode);

            return Json(new { GetRegionEmp }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetRegionParty(string RegionCode)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            var Data = Handler.GetRegionParty(RegionCode);
            var GetRegionEmp = Handler.GetRegionEmp(RegionCode);

            return Json(new {Data,GetRegionEmp }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DDLPartyDetail(string RegionCode, string PartyCode)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            var Party = Handler.DDLPartyDetail(RegionCode,PartyCode);
            return Json(Party,JsonRequestBehavior.AllowGet);
        }

        
        public ActionResult GetRegionDateInvoiceData(string RegionCode,string InvoiceDate)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            List<InvoiceTableSrNo> InvoiceTable;

            DateTime Date = DateTime.ParseExact(InvoiceDate, "dd/MM/yyyy", null);
          
            using (AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
            {
                InvoiceTable = DefinitionContext.InvoiceTableSrNoes.Where(x => x.RegionCode == RegionCode && x.InvoiceDate == Date).ToList();

                Session["InvoiceTable"] = InvoiceTable;
                return Json(JsonRequestBehavior.AllowGet);
            }
         
        }

      
        public ActionResult GetRegionDateManInvoice(string ManInvoiceNo)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            if (CommonDAL.UserRoleName() == "DEO")
            {
                if (Handler.CheckInvoiceDate(ManInvoiceNo))
                {
                    using (AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
                    {
                        var InvoiceTable = Session["InvoiceTable"] as List<InvoiceTableSrNo>;
                   
                        var SrNo = InvoiceTable.Where(x => x.ManInvoiceNo.Trim() == ManInvoiceNo.Trim()).Select(x => x.SrNo).FirstOrDefault();
                        SrNo++;
                   
                        var ManInvoice = InvoiceTable.Where(x => x.SrNo == SrNo).Select(x => x.ManInvoiceNo).FirstOrDefault();
                   
                        return Json(ManInvoice.Trim(), JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    return Json(new { Input = "NoData", ItemDetail = "NoData" }, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                using (AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
                {
                    var InvoiceTable = Session["InvoiceTable"] as List<InvoiceTableSrNo>;

                    var SrNo = InvoiceTable.Where(x => x.ManInvoiceNo.Trim() == ManInvoiceNo.Trim()).Select(x => x.SrNo).FirstOrDefault();
                    SrNo++;

                    var ManInvoice = InvoiceTable.Where(x => x.SrNo == SrNo).Select(x => x.ManInvoiceNo).FirstOrDefault();

                    return Json(ManInvoice.Trim(), JsonRequestBehavior.AllowGet);
                }
            }
        }

       
        public ActionResult GetRegionDateManInvoicePre(string ManInvoiceNo)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            if (CommonDAL.UserRoleName() == "DEO")
            {
                if (Handler.CheckInvoiceDate(ManInvoiceNo))
                {
                    using (AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
                    {
                        var InvoiceTable = Session["InvoiceTable"] as List<InvoiceTableSrNo>;
                   
                        var SrNo = InvoiceTable.Where(x => x.ManInvoiceNo.Trim() == ManInvoiceNo.Trim()).Select(x => x.SrNo).FirstOrDefault();
                        SrNo--;
                   
                        var ManInvoice = InvoiceTable.Where(x => x.SrNo == SrNo).Select(x => x.ManInvoiceNo).FirstOrDefault();
                   
                        return Json(ManInvoice.Trim(), JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    return Json(new { Input = "NoData", ItemDetail = "NoData" }, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                using (AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
                {
                    var InvoiceTable = Session["InvoiceTable"] as List<InvoiceTableSrNo>;

                    var SrNo = InvoiceTable.Where(x => x.ManInvoiceNo.Trim() == ManInvoiceNo.Trim()).Select(x => x.SrNo).FirstOrDefault();
                    SrNo--;

                    var ManInvoice = InvoiceTable.Where(x => x.SrNo == SrNo).Select(x => x.ManInvoiceNo).FirstOrDefault();

                    return Json(ManInvoice.Trim(), JsonRequestBehavior.AllowGet);
                }
            }
        }

        public ActionResult CheckPartyDiscount(string RegionCode,string PartyCode,string ItemCode)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            using (AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
            {
                var Data = Handler.GetSinglePartyDiscount(RegionCode, PartyCode, ItemCode);

                var Item = DefinitionContext.FindItemTax(ItemCode).FirstOrDefault();

                var ItemRate = DefinitionContext.FindItemRate(RegionCode, ItemCode).FirstOrDefault();

                //var ItemRate = Handler.DDLItemRate(RegionCode, ItemCode);

                //var Item = Handler.GetSingleItemTax(ItemCode);

                return Json(new { Data, Item, ItemRate }, JsonRequestBehavior.AllowGet);
            }
            
        }

        public ActionResult GetSingleInvoice(int InvoiceNo)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            var Input = Handler.GetSingleMasterInvoice(InvoiceNo);
            List<SaleInvoiceDetailVM> ItemDetail = Handler.GetSingleDetailInvoice(InvoiceNo);

            return Json(new { Input = Input, ItemDetail = ItemDetail }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetSingleManInvoice(string ManInvoiceNo)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
           if(CommonDAL.UserRights("7", "003"))
           {
               if (CommonDAL.UserRoleName() == "DEO")
               {
                   if (Handler.CheckInvoiceDate(ManInvoiceNo))
                   {
                       var Input = Handler.GetSingleMasterManInvoice(ManInvoiceNo);
              
                       List<SaleInvoiceDetailVM> ItemDetail = Handler.GetSingleDetailManInvoice(ManInvoiceNo);
              
                       return Json(new { Input = Input, ItemDetail = ItemDetail }, JsonRequestBehavior.AllowGet);
                   }
                   else
                   {
                       return Json(new { Input = "NoData", ItemDetail = "NoData" }, JsonRequestBehavior.AllowGet);
                   }
               }
               else
               {
                   var Input = Handler.GetSingleMasterManInvoice(ManInvoiceNo);
              
                   List<SaleInvoiceDetailVM> ItemDetail = Handler.GetSingleDetailManInvoice(ManInvoiceNo);
              
                   return Json(new { Input = Input, ItemDetail = ItemDetail }, JsonRequestBehavior.AllowGet);
               }
            }
            else
            {
                return Json(new { Input = "NoData", ItemDetail = "NoData" }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult CheckLock()
        {
            var Lock = HttpContext.Application["Lock"];
            return Json(Lock,JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult SaleInvoiceDetail(SaleInvoiceDetail[] ItemTable)
        {
           
                Session["SaleInvoiceDetail"] = ItemTable;

                return Json(JsonRequestBehavior.AllowGet);
           
        }
       
        [HttpPost]
        public ActionResult SaleInvoice(SaleInvoiceMaster Obj,string InvoiceDate)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            var Msg = "";
            var SecMsg = "";
            var ThirdMsg = "";
            var FourthMsg = "";
            var FifthMsg = "";

             Msg = Handler.AddEditSaleInvoice(Obj, InvoiceDate);

            if (Msg == "DeadLock")
            {
                SecMsg  = Handler.AddEditSaleInvoiceAgain();

                if (SecMsg == "DeadLock Occur, Try Again . . . !")
                {
                    ThirdMsg = Handler.AddEditSaleInvoiceAgain();

                    if (ThirdMsg == "DeadLock Occur, Try Again . . . !")
                    {
                        FourthMsg = Handler.AddEditSaleInvoiceAgain();

                        if (FourthMsg == "DeadLock Occur, Try Again . . . !")
                        {
                            FifthMsg = Handler.AddEditSaleInvoiceAgain();

                            if (FifthMsg == "DeadLock Occur, Try Again . . . !")
                            {
                                TempData["DeadLockMsg"] = FifthMsg;
                            }
                            else
                            {
                                TempData["DeadLockMsg"] = FifthMsg;
                            }
                        }
                        else
                        {
                            TempData["DeadLockMsg"] = FourthMsg;
                        }
                    }
                    else
                    { 
                       TempData["SuccessMsg"] = ThirdMsg;
                    }
                }
                else
                {
                    TempData["SuccessMsg"] = SecMsg;
                }
            }
            else
            {
                TempData["SuccessMsg"] = Msg;
            }
           
            return RedirectToAction("SaleInvoice");
        }

        public ActionResult TryAgain()
        {
            using(AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
            {
                SaleInvoiceMaster MasterData = new SaleInvoiceMaster();
                List<SaleInvoiceDetail> DetailData = new List<SaleInvoiceDetail>();

                MasterData = Session["MasterData"] as SaleInvoiceMaster;
                DetailData = Session["DetailData"] as List<SaleInvoiceDetail>;

                DefinitionContext.SaleInvoiceMasters.Add(MasterData);
                DefinitionContext.SaleInvoiceDetails.AddRange(DetailData);
                DefinitionContext.SaveChanges();
                TempData["SuccessMsg"] = "Saved Successfully . . . !";

            }
           
            return RedirectToAction("SaleInvoice");
        }


        [HttpPost]
        public ActionResult CheckManInvoice(string ManInvoiceNo)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            bool data = Handler.CheckManInvoice(ManInvoiceNo);

            return Json(data, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult DeleteInvoice(int InvoiceNo)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            bool data = Handler.DeleteInvoice(InvoiceNo);

            return Json(data, JsonRequestBehavior.AllowGet);
        }


        #endregion

        public ActionResult SaleInvoiceResponsive()
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            using (AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
            {
                var List = DefinitionContext.GetDistinctRegion().ToList();
                ViewBag.RegionDDL = new SelectList(List, "RegionCode", "RegionDescription");
            }

            ViewBag.ItemDDL = Handler.GetSaleItems();
            ViewBag.CurrentDate = DateTime.Now.ToString("dd/MM/yyyy");
            ViewBag.UniqNo = DateTime.Now.ToString("ddMMyyyy-HHmmss");
            ViewBag.SaleInvoice = Handler.GetSaleInvoiceCurrentDate().ToList();

            return View();
        }

        [HttpPost]
        public ActionResult SaleInvoiceResponsive(SaleInvoiceMaster Obj, string InvoiceDate, string FormName)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            var Msg = "";
           
            Msg = Handler.AddEditSaleInvoice(Obj, InvoiceDate);
           
            TempData["SuccessMsg"] = Msg;
            
            return RedirectToAction("SaleInvoiceResponsive");
        }



        #region (---------------------------------------------------------Recovery Against Sale------------------------------------------------------)

        public ActionResult RecoveryAgainstSale()
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            if (CommonDAL.UserRights("8","001"))
            {
               
                //ViewBag.SaleInvoice = Handler.GetCreditSaleInvoices();
                //using (AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
                //{
                //    ViewBag.RegionList = DefinitionContext.GetDistinctRegion().ToList();
                //}

                //ViewBag.PartyDDL = new SelectList(Handler.GetDistinctMainParty().ToList(), "PartyCode", "PartyName");

                using (AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
                {
                    var List = DefinitionContext.GetDistinctRegion().ToList();
                    ViewBag.RegionDDL = new SelectList(List, "RegionCode", "RegionDescription");
                }

                ViewBag.SalesmanDDL = new SelectList(Handler.GetEmpList().ToList(), "EmpCode", "EmpName");

                //ViewBag.RegionList = Handler.GetRegion();
                ViewBag.ItemList = Handler.GetSaleItems();
                return View();
            }
            else
            {
                return RedirectToAction("PageNotFound", "Home");
            }
          
        }

        [HttpPost]
        public ActionResult GetRecoveryDetailDateWise(string GetRecDate)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            List<RecoveryVM> RecDetail = new List<RecoveryVM>();
            string UpdTrue = "";

            if (CommonDAL.UserRights("8", "003"))
            {
                RecDetail = Handler.GetAllRecoveryList(GetRecDate).ToList();
                UpdTrue = "Update";
            }

            return Json( new { RecDetail = RecDetail,UpdTrue = UpdTrue}, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetSingleRecovery(string RecoveryNo)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            List<RecoveryVM> List = Handler.GetSingleRecovery(RecoveryNo);

            return Json(List, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetRecoveryDetail(Recovery[] ItemTable)
        {
            Session["RecoveryDetail"] = ItemTable;

            return Json(JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult RecoveryAgainstSale(Recovery Obj,string RecoveryDate)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            TempData["SuccessMsg"] = Handler.AddEditRecovery(Obj,RecoveryDate);

            return RedirectToAction("RecoveryAgainstSale");
        }

        [HttpPost]
        public ActionResult DeleteRecovery(string RecoveryNo)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            bool data = Handler.DeleteRecovery(RecoveryNo);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        #endregion


        #region(------------------------------------------Party Discount--------------------------------------------)

        public ActionResult PartyDiscount()
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            using (AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
            {
                ViewBag.RegionList = DefinitionContext.GetDistinctRegion().ToList();
            }

            //ViewBag.RegionList = Handler.GetRegion();
            ViewBag.PartyList = Handler.GetSaleParties();
            ViewBag.GetPDList = Handler.GetPartyDiscount();

            return View();
        }

        public ActionResult PartyDiscountNew()
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            if (CommonDAL.UserRights("9","001"))
            {
                ViewBag.CurrentDate = Handler.GetCurrentDate();
                //ViewBag.RegionList = Handler.GetRegion();
                //ViewBag.PartyList = Handler.GetSaleParties();
                ViewBag.ItemList = Handler.GetSaleItems();
                //ViewBag.PdList = Handler.GetDistinctPartyDiscountInfo();

                //ViewBag.PartyDDL = new SelectList(Handler.GetSaleParties().ToList(), "PartyCode", "PartyName");

                using (AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
                {
                    var List = DefinitionContext.GetDistinctRegion().ToList();
                    ViewBag.RegionDDL = new SelectList(List, "RegionCode", "RegionDescription");
                }

                return View();
            }
            else
            {
                return RedirectToAction("PageNotFound", "Home");
            }
           
        }

        public ActionResult SinglePartyDDL(string RegionCode, string PartyCode)
        {
            SaleParty Party = new SaleParty();

           

           
                Party = Handler.DDLPartyDetail(RegionCode, PartyCode);
               
           

            return Json(Party, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CheckDiscountedParty(string RegionCode,string PartyCode)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            bool data = Handler.CheckPartyDiscount(RegionCode,PartyCode);

            return Json(data, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult GetSinglePartyDiscount(string RegionCode,string PartyCode)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            string UpdTrue = "";
            List<SinglePartyDiscountNewVM> ItemList = new List<SinglePartyDiscountNewVM>();
            if (CommonDAL.UserRights("9", "003"))
            {
                ItemList = Handler.GetSinglePartyDiscountNew(RegionCode, PartyCode);
                UpdTrue = "Update";
                ViewBag.ItemList = null;
            }

               
            return Json( new { ItemList=ItemList,UpdTrue=UpdTrue }, JsonRequestBehavior.AllowGet);
        }

      

        [HttpPost]
        public JsonResult ItemDiscountDetail(ItemDiscountVM[] ItemTable)
        {
            Session["ItemTable"]  = ItemTable;
          
            return Json(ItemTable, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult PartyDiscountNew(Discount Obj)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            TempData["SuccessMsg"] = Handler.AddNewPartyDiscount(Obj);

            return RedirectToAction("PartyDiscountNew");
        }

        [HttpPost]
        public ActionResult GetRegionPartyDDL(string RegionCode)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            List<SaleParty> List = new List<SaleParty>();
            List = Handler.GetRegionParty(RegionCode).ToList();

            return Json(List, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetMulitRegionPartyDDL(string[] RegionCode)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            List<SaleParty> List = new List<SaleParty>();
            List = Handler.GetMultipleRegionParty(RegionCode).ToList();

            return Json(List, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetRegionCreditPartyDDL(string RegionCode)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            List<SaleParty> List = new List<SaleParty>();
            List = Handler.GetRegionCreditParty(RegionCode).ToList();

            return Json(List, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetRegionPartyFast(string RegionCode)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            List<GetRegionPartiesFast_Result> List = new List<GetRegionPartiesFast_Result>();
            List = Handler.GetRegionPartyFast(RegionCode).ToList();

            return Json(List, JsonRequestBehavior.AllowGet);
        }

        //[HttpPost]
        //public ActionResult PartyDiscount(PartyDiscount Obj)
        //{
        //    if (Session["CompanyCode"] == null)
        //    {
        //        return RedirectToAction("Login", "Home");
        //    }

        //    TempData["SuccessMsg"] = Handler.AddEditPartyDiscount(Obj);

        //    return RedirectToAction("PartyDiscount");
        //}

        [HttpPost]
        public ActionResult ItemDiscountedRate(string RegionCode,string STaxReg,string Category)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            List<ItemDiscountRateVM> ItemList = Handler.GetItemDiscountedRate(RegionCode, STaxReg, Category).ToList();
           
            return Json(ItemList, JsonRequestBehavior.AllowGet);
        }

        #endregion


        #region ---------------------------------------------------(Short Cash)-----------------------------------------------------------

        public ActionResult ShortCash()
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            using (AT_Tahur_SUITEEntities DefinitionContext = new AT_Tahur_SUITEEntities())
            {
                var List = DefinitionContext.GetDistinctRegion().ToList();
                ViewBag.RegionDDL = new SelectList(List, "RegionCode", "RegionDescription");
            }

            ViewBag.CurrentDate = Handler.GetCurrentDate();
            ViewBag.CSList = Handler.GetDistinctShortCash().ToList();

            return View();
        }

        [HttpPost]
        public ActionResult GetSingleShortCash(string CSCode)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            List<ShortCashVM> ItemList = Handler.GetSingleShortCash(CSCode);
           
            return Json(ItemList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult ShortCashDetail(ShortCash[] ItemTable)
        {
            Session["ShortCashDetail"] = ItemTable;

            return Json(ItemTable, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShortCash(ShortCash Obj)
        {

            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            TempData["SuccessMsg"] = Handler.AddEditShortCash(Obj);

            return RedirectToAction("ShortCash");
        }

        [HttpPost]
        public ActionResult DeleteShortCash(string CSCode)
        {
            if (Session["CompanyCode"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            bool data = Handler.DeleteShortCash(CSCode);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        #endregion

    }
}