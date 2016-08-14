using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// for the time being
using ERP_UOS.StringFun01;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Reflection;
using System.Deployment;
using System.Drawing;


namespace ERP_UOS
{
    public static class clsGVar
    {
        public static int BranchID = 0;
        public static string DBConnectString = string.Empty;

        public const string Pwd1 = "smc786";
        //public const string UserName1 = "sa";
        //public const string Pwd1 = "abcbook123$%^";
        public const string UserName1 = "sa";
        //public const string Pwd1 = "abcbook";
        //public const string UserName1 = "appsuser";

        public const string DbName1 = "ERP_UOS";
        //public const string DbName1 = "NORTHWIND";
        //public const string gServerId1 = "(local)";
        //public const string gServerId1 = @"TEAMWIN7S\TEAMWIN7S";    // did not work from local and remote computer
        //public const string ServerName1 = "KomfitLenovo";    //  @"TEAMWIN7S"
        //public const string ServerName1 = "61.5.139.139";    //  @"TEAMWIN7S"
        public const string ServerName1 = "192.168.1.188";    //  @"TEAMWIN7S"
        //public const string ServerName1 = @"(Local)";    //  @"TEAMWIN7S"      
        //public const string ServerName1 = @"shoaibsiddiqui\sql2008";    //       
        //public const string ServerName1 = @"Shoaib-Lenovo\SQL2014";  
        //public const string ServerName1 = @"shoaibsiddiqui\sql2008";    //       
        //public const string ServerName1 = "Win2K8SVR";    //  @"TEAMWIN7S"    
        //public const string gServerId1 = "TOSHIBA2008EP";

        //public const string Pwd1 = CryptorEngine.Pwd;
        //public const string UserName1 = CryptorEngine.UserID;
        //public const string DbName1 = CryptorEngine.InitCat;
        //public const string ServerName1 = CryptorEngine.DataSrc;

        // **** Commented By Usama Naveed *******************
        public const string ConString1 = "Data Source= " + ServerName1 + ";Initial Catalog=" + DbName1 + ";User ID=" + UserName1 + "; Password=" + Pwd1;
        //public const string ConString1 = "Data Source= " + CryptorEngine.DataSrc + ";Initial Catalog=" + CryptorEngine.InitCat + ";User ID=" + CryptorEngine.UserID + "; Password=" + CryptorEngine.Pwd;

        public const string CoTitle1 = "Ranyal Industries (Pvt) Ltd.";

        // 2nd Connection
        public const string Pwd2 = "smc786";
        //public const string UserName2 = "sa";

        //public const string Pwd2 = "abcbook123$%^";
        public const string UserName2 = "sa";

        //public const string Pwd2 = "abcbook";
        //public const string UserName2 = "appsuser";
        //public const string gDbId2 = "scml";
        //public const string DbName2 = "NORTHWIND";
        public const string DbName2 = "ERP_UOS";
        //public const string DbName2 = "NizamiBrothers";
        //public const string gServerId2 = "(local)";
        //public const string ServerName2 = "@(Local)";     //  @"TEAMWIN7S" 
        //public const string ServerName2 = @"ShoaibPC";     //  @"TEAMWIN7S" 
        //public const string ServerName2 = "Win2K8SVR";    //  @"TEAMWIN7S"    
        public const string ServerName2 = @"Shoaib-Lenovo\SQL2014";  

        //public const string ServerName2 = "(Local)";
        //public const string gServerId2 = "TOSHIBA2008EP";
        public const string ConString2 = "Data Source= " + ServerName2 + ";Initial Catalog=" + DbName2 + ";User ID=" + UserName2 + "; Password=" + Pwd2;
        public const string CoTitle2 = "Company Name: 2nd Co.";

        // 3rd Connection
        public const string Pwd3 = "smc786";
        public const string UserName3 = "sa";
        public const string DbName3 = "Comfit2017";
        //public const string gServerId3 = "(local)";
        //public const string ServerName3 = @"Shoaib-Lenovo\SQL2014"; 
        //public const string ServerName3 = "SERVERRN";    //  @"TEAMWIN7S"    
        public const string ServerName3 = "192.168.1.188";    //  @"TEAMWIN7S"    

        //public const string gServerId3 = "TOSHIBA2008EP";
        public const string ConString3 = "Data Source= " + ServerName3 + ";Initial Catalog=" + DbName3 + ";User ID=" + UserName3 + "; Password=" + Pwd3;
        public const string CoTitle3 = "Komfit";
        //  
        public const int frmZero = 0;
        public const int DocTypeZero = 0;
        public const int FiscalZero = 0;
        //        
        public const int frmDriver = 1005;
        public const int frmCountry = 1006;
        public const int frmProvince = 1007;
        public const int frmCity = 1008;
        public const int frmVehicle = 1009;
        public const int frmSalutation = 1010;
        public const int frmWorkShop = 1011;
        public const int frmAddress = 1012;
        //================================================ constANTS =========================================================
        // ***************************************************************
        //                  constANT FOR GRID COLORS
        // ***************************************************************
        //////public const int cnstBgColor                        = &HFEF9E9
        //////public const int cnstBgAltColor                     = &HECFFFF
        //////public const int cnstFColor                         = &H0&
        //////public const int cnstSFColor                        = &H80FFFF
        //////public const int cnstSBColor                        = &HA00000

        // ***************************************************************
        //                  For Screen Resolution
        // ***************************************************************
        public const int cnstResolutionWidth720 = 720;
        public const int cnstResolutionHeight576 = 576;
        public const int cnstResolutionWidth1024 = 1024;
        public const int cnstResolutionHeight768 = 768;

        // ***************************************************************
        //  Modules ID detail = 58
        // ***************************************************************
        public const int cnstModuleAccountIt = 262;
        public const int cnstModulePayroll = 263;
        public const int cnstModuleIMS = 264;
        public const int cnstModuleAssetManager = 265;
        public const int cnstModuleBudgeting = 266;
        public const int cnstModuleRptDesigner = 274;

        // ***************************************************************
        //  Report General Preference Page Format Set --- cnstRptPageFormat = 56
        // ***************************************************************
        public const int cnstRptPageFormatNA = 256;
        public const int cnstRptPageFormatPage1 = 257;
        public const int cnstRptPageFormatPage1of3 = 258;
        public const int cnstRptPageFormat_1 = 259;

        // ***************************************************************
        //  cnstRptPageAlignment = 65
        // ***************************************************************
        public const int cnstPageAlignLeft = 310;
        public const int cnstPageAlignCenter = 311;
        public const int cnstPageAlignRight = 312;

        // ***************************************************************
        //  cnstPostDatedChq  = 71
        // ***************************************************************
        public const int cnstCheqPostDated = 518;
        public const int cnstCheqCleared = 519;
        public const int cnstCheqDishonoured = 520;
        public const int cnstCheqReturnCashed = 521;
        public const int cnstCheqWronglyEntered = 522;

        // ***************************************************************
        //                  constANT FOR Validation
        // ***************************************************************
        public const int cnstChallanFee = 387;
        public const int cnstSecurityFee = 388;
        public const int cnstRegistrationFee = 389;
        public const int cnstAdmissionFee = 390;
        public const int cnstTransferFee = 391;
        public const int cnstItemChFee = 395;
        public const int cnstItemComputer = 397;
        public const int cnstItemFine = 398;
        public const int cnstItemOther = 399;
        public const int cnstUnPaidStatus = 412;
        public const int cnstPaidStatus = 411;
        public const int cnstCancelStatus = 413;
        public const int cnstArrearStatus = 453;
        public const int cnstResolutionWidth = 640;
        public const int cnstResolutionHeight = 480;
        public const int cnstChDebit = 438;
        public const int cnstChCredit = 439;
        public const int cnstVChallanFee = 421;
        public const int cnstVSecurityFee = 427;
        public const int cnstVRegistrationFee = 423;
        public const int cnstVAdmissionFee = 419;
        public const int cnstVTransferFee = 425;
        public const int cnstInstChallanType = 344;
        public const int cnstGenericGrouping = 6;
        public const int cnstIssuedDate = 441;
        public const int cnstDueDate = 442;
        public const int cnstValidityDate = 443;
        public const int cnstInstArrears = 452;
        public const int cnstInstSecurity = 451;
        public const int cnstScrollStatus = 345;
        public const int cnstScrollRelease = 455;
        public const int cnstSTFTeacher = 539;
        public const int cnstATNPresent = 458;
        public const int cnstATNLeave = 459;
        public const int cnstATNAbsent = 460;
        public const int cnstATNNA = 461;
        public const int cnstRefundedSec = 465;
        public const int cnstEXMMonthlyTest = 566;
        public const int cnstExmOccuranceMonthly = 467;
        public const int cnstExmOccuranceOnce = 468;
        public const int cnstFormPrivileges = 70;
        public const int cnstPostDatedChq = 71;

        //  ***************************
        //  Privileges ID
        //  ***************************

        public const int cnstFormPrivileges_SaleOrder = 500;
        public const int cnstFormPrivileges_InvoiceFactory = 501;
        public const int cnstFormPrivileges_ChequeRecVoc = 502;
        public const int cnstFormPrivileges_RetChequeRecVoc = 503;
        public const int cnstFormPrivileges_CashReceipt = 504;
        public const int cnstFormPrivileges_CashPayment = 505;
        public const int cnstFormPrivileges_JournalVoucher = 506;
        public const int cnstFormPrivileges_DiscountVoucher = 507;
        public const int cnstFormPrivileges_LocalPurchase = 508;
        public const int cnstFormPrivileges_ChequeRetCash = 509;
        public const int cnstFormPrivileges_PostDtCheque = 510;
        public const int cnstFormPrivileges_JVChange = 511;
        public const int cnstFormPrivileges_PurchaseReturn = 512;
        public const int cnstFormPrivileges_ItemOpeningBal = 513;
        public const int cnstFormPrivileges_ItemDesc = 514;
        public const int cnstFormPrivileges_AccountDesc = 515;
        public const int cnstFormPrivileges_CustDesc = 516;
        public const int cnstFormPrivileges_CategoryDes = 517;
        public const int cnstFormPrivileges_BankReceipt = 523;
        public const int cnstFormPrivileges_BankPayment = 524;
        public const int cnstFormPrivileges_DOFactory = 525;
        public const int cnstFormPrivileges_UOMSetup = 526;
        public const int cnstFormPrivileges_SaleContract = 527;
        public const int cnstFormPrivileges_DN = 528;
        public const int cnstFormPrivileges_PO = 529;
        public const int cnstFormPrivileges_GateInward = 530;
        public const int cnstFormPrivileges_GOW = 531;
        public const int cnstFormPrivileges_ItemConv = 532;
        public const int cnstFormPrivileges_GOWDelivery = 533;
        public const int cnstFormPrivileges_FinishRec = 534;
        public const int cnstFormPrivileges_GtoGShift = 535;
        public const int cnstFormPrivileges_IssueItem = 536;
        public const int cnstFormPrivileges_RetIssueItem = 537;
        public const int cnstFormPrivileges_FormulaDef = 538;
        public const int cnstFormPrivileges_PackFormulaDef = 539;
        public const int cnstFormPrivileges_GroupSizeColor = 540;
        public const int cnstFormPrivileges_CustDisc = 541;
        public const int cnstFormPrivileges_MainGroup = 542;
        public const int cnstFormPrivileges_AccountLedger = 543;
        public const int cnstFormPrivileges_ItemLedger = 544;
        public const int cnstFormPrivileges_SalesReturn = 545;
        public const int cnstFormPrivileges_CashSales = 546;
        public const int cnstFormPrivileges_IOWIPItem = 547;
        public const int cnstFormPrivileges_ItemPlateFormDef = 548;
        public const int cnstFormPrivileges_ContChrgTmpl = 549;
        public const int cnstFormPrivileges_ClaimContactor = 550;
        public const int cnstFormPrivileges_InvoiceView = 551;
        public const int cnstFormPrivileges_ItemRateChange = 552;
        public const int cnstFormPrivileges_GOWDesti = 553;
        public const int cnstFormPrivileges_GIWDesti = 554;
        public const int cnstFormPrivileges_JVI = 563;
        public const int cnstFormPrivileges_JVA = 564;
        public const int cnstFormPrivileges_CPVB = 565;
        public const int cnstFormPrivileges_DailyRpt = 566;
        public const int cnstFormPrivileges_CreateVoc = 567;
        public const int cnstFormPrivileges_CPVBBr = 568;
        public const int cnstFormPrivileges_JVABr = 569;
        public const int cnstFormPrivileges_RawMatCons = 570;
        public const int cnstFormPrivileges_PurcImport = 571;
        public const int cnstFormPrivileges_DailyBatch = 572;
        public const int cnstFormPrivileges_FinDist = 573;
        public const int cnstFormPrivileges_MapItem = 574;
        public const int cnstFormPrivileges_MapItemSizeWise = 575;
        public const int cnstFormPrivileges_FinGdsCostCentre = 576;
        public const int cnstFormPrivileges_ProdPlan = 577;
        public const int cnstFormPrivileges_InvTax = 578;
        public const int cnstFormPrivileges_PrefInv = 579;
        public const int cnstFormPrivileges_LCOpening = 580;
        public const int cnstFormPrivileges_LCCost = 581;
        public const int cnstFormPrivileges_Pref = 582;

        //
        public const int cnstFormPrivileges_GLCOA = 601;

        // Form Privileges Variables Begin
        public static bool blnAddNew = false;
        public static bool blnModifyExisting = false;
        public static bool blnPrint = false;
        public static bool blnDelete = false;
        public static bool blnPostCancel = false;
        public static bool blnUnpost = false;
        public static bool blnView = false;
        // Form Privileges Variables End

        public static void chkPriv(int FormPrivID)
        {
            string lSQL = string.Empty;
            DataSet ds = new DataSet();
            DataRow dRow;

            lSQL = " SELECT AllowAddNew, AllowModify, AllowPrint, AllowDelete, AllowPost, AllowUnPost, AllowView "
                 + " FROM FormPrivileges "
                 + " WHERE FormID = " + FormPrivID.ToString() + " AND UserID = " + clsGVar.UserID.ToString();

            try
            {
                ds = clsDbManager.GetData_Set(lSQL, "FormPrivileges");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dRow = ds.Tables[0].Rows[0];
                    // Starting title as 0
                    
                    //txtManualDoc.Text = ds.Tables[0].Rows[0]["doc_strid"].ToString();
                    //msk_VocDate.Text = ds.Tables[0].Rows[0]["doc_date"].ToString();
                    //txtRemarks.Text = ds.Tables[0].Rows[0]["doc_remarks"].ToString();
                    //lblCreatedBy.Text = ds.Tables[0].Rows[0]["created_by"].ToString();
                    //lblCreatedOn.Text = ds.Tables[0].Rows[0]["created_date"].ToString();
                    //lblModifiedBy.Text = ds.Tables[0].Rows[0]["modified_by"].ToString();
                    //lblModifiedOn.Text = ds.Tables[0].Rows[0]["modified_date"].ToString();

                    if (ds.Tables[0].Rows[0]["AllowAddNew"].Equals(1))
                    {
                        blnAddNew = true;
                    }

                    if (ds.Tables[0].Rows[0]["AllowModify"].Equals(1))
                    {
                        blnModifyExisting = true;
                    }

                    if (ds.Tables[0].Rows[0]["AllowPrint"].Equals(1))
                    {
                        blnPrint = true;
                    }

                    if (ds.Tables[0].Rows[0]["AllowDelete"].Equals(1))
                    {
                        blnDelete = true;
                    }

                    if (ds.Tables[0].Rows[0]["AllowPost"].Equals(1))
                    {
                        blnPostCancel = true;
                    }

                    if (ds.Tables[0].Rows[0]["AllowUnPost"].Equals(1))
                    {
                        blnUnpost = true;
                    }

                    if (ds.Tables[0].Rows[0]["AllowView"].Equals(1))
                    {
                        blnView = true;
                    }
                    
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ds.Clear();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to Get Account Code...", ex.ToString());
            }
        }

        //// Concession Duration
        //public const int cnstDurationOneTime        As Byte = 1
        //public const int cnstDurationContinuous     As Byte = 2
        //public const int cnstDurationFromTo         As Byte = 3
        //// Concession On
        //public const int cnstConTution              As Byte = 1
        //public const int cnstConTotal               As Byte = 2
        //public const int cnstConFullWave            As Byte = 3
        //public const int cnstConFines               As Byte = 4
        ////  Item Billing
        //  public const int cnstBillStudent As Integer = 0
        //  public const int cnstBillStaff As Integer = 1
        //  public const int cnstBillBulk As Integer = 2

        // public const bool blnIsLoginInside = false; 
        // public const bool blnOrgExist = false;   
        // 
        //  Currency Picture Setting
        public const string CurrencyPicture = "0,00";
        public const string strDefaultZeroValue = "0.00";

        public const int JVR = 267;
        public const int CRV = 268;
        public const int CPV = 269;
        public const int BRV = 270;
        public const int BPV = 271;
        public const int INV = 272;
        public const int GRN = 273;
        public const int CIV = 274;
        public const int CGR = 275;
        public const int DVE = 276;
        public const int OPN = 277;
        public const int CNT = 278;
        public const int FTF = 279;
        public const int CLC = 280;
        public const int CWC = 281;
        public const int INVU = 283;
        public const int GRNU = 284;
        public const int FTS = 285;
        public const int MFC = 286;
        public const int MLC = 287;
        public const int XCV = 288;
        public const int LCO = 289;
        public const int LCI = 290;
        public const int CPVB = 291;
        public const int GRNCrLocal = 292;
        public const int GRNCrImport = 293;
        public const int GateInwardNew = 294;
        public const int SaleOrderEntry = 295;
        public const int GateOutward = 296;
        public const int JVE = 297;
        public const int IOB = 298;
        public const int JVA = 299;
        public const int FinItem = 300;
        public const int JVI = 301;
        public const int FD = 302;
        public const int FinDist = 303;
        public const int Map = 304;
        public const int CPVBr = 305;
        public const int FinGdsCost = 306;
        public const int RMC = 307;
        public const int CustInv = 308;
        public const int UserPriv = 309;
        public const int MapSize = 310;
        public const int ModifyItems = 311;
        public const int SRT = 312;


        // ********** For Report Designer ******************

        public const int Note = 204;
        public const int CACode = 205;
        public const int Formula = 206;
        public const int Manual = 207;
        public const int Heading = 209;
        public const int XLSFile = 210;

        // ********** For Report Designer ******************

        /*
        public enum GVocType
        { 
            JVR = 267
                ,
            CRV = 268
                ,
            CPV = 269
                ,
            BRV = 270
                ,
            BPV = 271
        }
*/
        public enum Pref
        {
            Cash = 1,
            Bank = 2,
            Customer = 3,
            Vendor = 4,
            LC = 5,
            Insurance = 6,
            OpCharges = 7,
            CashPurcLocal = 8,
            CrPurcLocal = 9,
            DiscPurcLocal = 10,
            PurcRetLocal = 11,
            CashPurcImport = 12,
            CrPurcImport = 13,
            DiscPurcImport = 14,
            PurcRetImport = 15,
            CashSalesLocal = 16,
            CrSalesLocal = 17,
            DiscSalesLocal = 18,
            SalesRetLocal = 19,
            CashSalesImport = 20,
            CrSalesImport = 21,
            DiscSalesImport = 22,
            SalesRetImport = 23,
            FinCharges = 24,
            AdminCharges = 25,
            CostGoodsSold = 26,
            DepCostGoodsSold = 27,
            DepAdminExp = 28,
            Assets = 29,
            FixedAssets = 30,
            CurrAssets = 31,
            Liability = 32,
            Equity = 33,
            Loans = 34,
            ProfitLoss = 35,
            PurcLocal = 36,
            PurcImport = 37,
            SalesLocal = 38,
            SalesExport = 39,
            SalesTaxPurc = 40,
            SalesTaxFurPurc = 41,
            SalesTaxSale = 42,
            SalesTaxFurSale = 43,
            ElectricityBill = 44,
            SuiGasBill = 45,
            SalesTaxACDPurc = 46
        }

        public enum CValidation
        {
            BloodGroup = 36
            ,
            CityID = 301
                ,
            STDef = 300
                ,
            Royality = 302
                ,
            Masks = 303
                ,
            Reason = 304
                ,
            Subjects = 305
                ,
            TeachingAid = 306
                ,
            Stage = 307
                ,
            Session = 308
                ,
            Lessons = 309
                ,
            LPType = 310
                ,
            BookType = 311
                ,
            Relation = 312
                ,
            Occupation = 313
                ,
            Sections = 314
                ,
            Religion = 315
                ,
            Concession = 316
                ,
            Disease = 317
                ,
            Illness = 318
                ,
            History = 319
                ,
            Concern = 320
                ,
            Finds = 321
                ,
            Misc = 322
                ,
            Fever = 324
                ,
            Injuries = 325
                ,
            Immunization = 326
                ,
            AssociationFee = 327
                ,
            MedExamination = 330
                ,
            AvailableAt = 328
                ,
            Specialization = 329
                ,
            Timing = 328
                ,
            MedObservation = 331
                ,
            PhyExamination = 332
                ,
            PhyObservation = 333
                ,
            RefProcedure = 334
                ,
            Eye = 329
                ,
            Sight = 330
                ,
            EarStatus = 335
                ,
            YesNo = 331
                ,
            Venue = 336
                ,
            Transpotation = 337
                ,
            Months = 332
                ,
            ShotMonth = 333
                ,
            ChallanType = 334
                ,
            ChallanBank = 335
                ,
            ChallanGroupWith = 336
                ,
            ChallanAppliedFor = 337
                ,
            FeeStatus = 338
                ,
            SchoolAccounts = 339
                ,
            PaymentMode = 340
                ,
            ChallanStatus = 341
                ,
            ChVoucherFor = 339
                ,
            ChFigure = 340
                ,
            ChVoucherType = 341
                ,
            ChFineStarts = 342
                ,
            ChFineEnds = 343
                ,
            FigTution = 428
                ,
            FigAdmission = 429
                ,
            FigRegistration = 430
                ,
            FigTransfer = 431
                ,
            FigSecurity = 432
                ,
            FigComputerCharges = 433
                ,
            FigOthers = 434
                ,
            FigFines = 435
                ,
            FigArrears = 436
                ,
            FigGross = 437
                ,
            FigRoyalty = 440
                ,
            FigNetPayment = 446
                ,
            StaffType = 342
                ,
            TimePart = 348
                ,
            ResultStatus = 346
                ,
            Attendance = 347
                ,
            SecurityRefund = 349
                ,
            ExamTypes = 344
                ,
            ExamGrades = 345
                ,
            ExamGradesEquivalent = 346
                ,
            ExamOccurence = 350
                ,
            PromotionStatus = 351
                ,
            MoveClassStatus = 352
                ,
            AcademicYearStatus = 353
                ,
            AccessoryType = 347
                ,
            BuildingType = 348
                ,
            Discipline = 349
                , Degree = 350
        }
        ////  Array Declaration for storing names of all Medical Health forms to run
        //public string[] strFormNames;
        //// 
        ////  Array Declaration for storing names of all Medical Assessment forms to run
        //public string[] strFormMA;
        ////  Array Declaration for storing names of all Events forms to run
        //public string[] strFormEV;
        //// 
        ////  AcadTree Opening Forms Declaration for all forms
        //public bool blnAcadTree;
        //public int lngYearDef;
        //public int lngClassDef;
        //public int lngSyllabusDef;
        //public int lngLessonDef;
        // 
        // Date constants for Report forms (in <all> case)
        public const string cnstMinDate = "01/01/1600";
        public const string cnstMaxDate = "31/12/9999";
        public const string cnstFromDate = "01/07/2015";
        // 
        //  EventDefinition Form Declaration for all forms
        //public bool blnEventList;
        //public bool lngEventDef;
        //// 
        ////  Profile Opening form Declaration
        //public bool blnRegisteration;

        public const int cnstCityID = 3;
        //  SP_Sibling form status variables
        public const int cnstActive = 1;    // Compair with Disabled
        public const int cnstInActive = 0;
        //  SP_sibling Amount length

        // public const for Size And Color

        // commented by Bira
        //public const int intSizeId = 0;
        //public const int intColorId = 0;
        //public const int intHeight                          = 220;
        //public const int CloseAll = 0;
        // tring  abc = clsDbManager.GetTitle("cnf_appsetup", "appsetup_id", "appsetup_strval", 10001);

        public const string maskGLCode = "0-0-00-00-0000";
        public const string maskDate = "00/00/0000";

        //  Category Number
        public const int cnstShift = 1;
        public const int cnstGodown = 2;
        public const int cnstColor = 3;
        public const int cnstCharges = 4;
        public const int cnstSize = 5;
        public const int cnstItem_Group = 6;
        public const int cnstShoe_Part = 7;
        public const int cnstType = 8;
        public const int cnstLC = 9;
        public const int cnstPurpose = 10;
        public const int cnstMachine_No = 11;
        public const int cnstContractor = 12;
        public const int cnstDiscount = 13;
        public const int cnstAdda = 14;
        public const int cnstMain_Group = 15;
        public const int cnstPacking = 16;

        //================================================ constANTS =========================================================
        //
        public static int SystemGL
        {
            get
            {
                return 1;
            }
        }
        public static int SystemInventory
        {
            get
            {
                return 2;
            }
        }

        public static int SystemInventoryFinished
        {
            get
            {
                return 3;
            }
        }
        public static int SystemInventoryRawMaterial
        {
            get
            {
                return 4;
            }
        }
        public static int SystemPayRoll
        {
            get
            {
                return 5;
            }
        }

        public static int LocID { get; set; }
        public static int GrpID { get; set; }
        public static int CoID { get; set; }
        public static int YrID { get; set; }
        public static int UserID { get; set; }
        //
        public static int GrpTitle { get; set; }
        public static string CoTitle { get; set; }
        public static string CoTitleSt { get; set; }
        public static string YrTitle { get; set; }
        public static string UserTitle { get; set; }
        //
        public static int AppUserID { get; set; }
        public static string AppUserTitle { get; set; }
        public static DateTime YrDateStart { get; set; }
        public static DateTime YrDateEnd { get; set; }

        public static string AppUserName { get; set; }
        public static string AppUserFullName { get; set; }
        public static string AppUserSt { get; set; }
        public static string AppUserDesc { get; set; }
        public static bool AppUserPwChangeNext { get; set; }
        public static bool AppUserPwCannotChange { get; set; }
        public static bool AppUserPwNeverExpires { get; set; }
        public static bool AppUserPwTimeRestriction { get; set; }
        public static int AppUserPwFailAttempts { get; set; }

        public static int FromMonth { get; set; }
        public static int ToMonth { get; set; }
        public static int FromYear { get; set; }
        public static int ToYear { get; set; }

        //public static string FromDate = ("01/" + clsGVar.FromMonth + "/" + clsGVar.FromYear).ToString();
        //public static string ToDate = ("31/" + clsGVar.ToMonth + "/" + clsGVar.ToYear).ToString();

        public static string FromDate;
        public static string ToDate;
        //public static string sqlFromDate;
        //public static string sqlToDate;
        
        
        //
        //private static string strgLGCY = "loc_id = " + gLocID.ToString() + " grp_id = " + gGrpID.ToString() + " co_id = " + gGrpID.ToString() ;
        //private static string strgLGCY = "loc_id = " + gLocID.ToString() + " grp_id = " + gGrpID.ToString() + " co_id = " + gGrpID.ToString() ;
        // General Ids Left
        public static int frmLeftGeneralIds
        {
            get
            {
                return 230 + 30;
            }
        }
        // General Ids Top
        public static int frmTopGeneralIds
        {
            get
            {
                return 0;
            }
        }

        // Inventory Left
        public static int frmLeftInventory
        {
            get
            {
                return frmLeftGeneralIds + 30 + 30;
            }
        }
        // Inventory Top
        public static int frmTopInventory
        {
            get
            {
                return frmTopGeneralIds + 30;
            }
        }
        // Form Color GL Horizontal Lines
        public static void SetFormColorGL(Label pLine1, Label pLine2, Label pLine3)
        {
            pLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))); // Blue Like
            pLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))); // Lighter then above
            pLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(208)))), ((int)(((byte)(222))))); // even Lighter then above 
        }
        // Form Color Inventory Horizontal Lines
        public static void SetFormColorInventory(Label pLine1, Label pLine2, Label pLine3)
        {
            pLine1.BackColor = System.Drawing.Color.Goldenrod;                                   // Blue Like
            pLine2.BackColor = System.Drawing.Color.Khaki;                                       // Lighter then above
            pLine3.BackColor = System.Drawing.Color.DarkKhaki;                                   // even Lighter then above 
        }

        public static string LGCY
        {
            get
            {
                //return "loc_id = " + LocID.ToString() + " and grp_id = " + GrpID.ToString() + " and  co_id = " + CoID.ToString() + " and  year_id = " + YrID.ToString();
                return "Doc_Fiscal_ID= 1 ";

            }
            //set
            //{
            //    myName = value;
            //}

        }
        public static string LGCYm
        {
            get
            {
                return "m.loc_id = " + LocID.ToString() + " and m.grp_id = " + GrpID.ToString() + " and  m.co_id = " + CoID.ToString() + " and  m.year_id = " + YrID.ToString();
            }
        }
        public static string LGCYd
        {
            get
            {
                return "d.loc_id = " + LocID.ToString() + " and d.grp_id = " + GrpID.ToString() + " and  d.co_id = " + CoID.ToString() + " and  d.year_id = " + YrID.ToString();
            }
        }


        public static void SelectOnEnter(TextBox pTextBox)
        {
            if (!String.IsNullOrEmpty(pTextBox.Text))
            {
                pTextBox.SelectAll();
                //pTextBox.SelectionStart = 0;
                //pTextBox.SelectionLength = pTextBox.Text.Length;
            }
        }

        public static void SelectOnEnter(MaskedTextBox pTextBox)
        {
            if (!String.IsNullOrEmpty(pTextBox.Text))
            {
                //pTextBox.SelectAll();
                pTextBox.SelectionStart = 0;
                pTextBox.SelectionLength = pTextBox.Text.Length;
            }
        }

        public static string LGCYg { get; set; }

        public static string PrefixLGCY { get; set; }

        public static string WithPrefixLGCY { get; set; }

        public static string JoinPrefixLGCY { get; set; }

        public static string WithJoinPrefixLGCY { get; set; }

        //public static string AppUserName { get; set; }

        public static void CheckVersion()
        {
            string lSQL = string.Empty;
            DataSet ds = new DataSet();
            DataRow dRow;
            string ver = string.Empty;
            string dbVersion = string.Empty;

            lSQL = " SELECT Version_ID FROM cmn_Version";

            ds = clsDbManager.GetData_Set(lSQL, "cmn_Version");

            if (ds.Tables[0].Rows.Count > 0)
            {
                //fAlreadyExists = true;
                dRow = ds.Tables[0].Rows[0];

                dbVersion = (ds.Tables[0].Rows[0]["Version_ID"] == DBNull.Value ? "" : ds.Tables[0].Rows[0]["Version_ID"].ToString());
            }

            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            //ver = String.Format(ver, version.Major, version.Minor, version.Build, version.Revision);
            ver = Convert.ToString(version);

            if (dbVersion != ver)
            {
                //MessageBox.Show("Please Update Your Software ! Your Version # " + ver);
            }
        }

        public static bool CheckAccPeriod(String date)
        {
            string lSQL = string.Empty;
            DataSet ds = new DataSet();

            lSQL = " DECLARE @Date DATETIME; "
                 + " SET @Date = '" + date + "';"
                 + " SELECT [Check] "
                 + " FROM AccPrefActivate "
                 + " WHERE @Date BETWEEN FromDate AND ToDate AND [Check] = 1";

            //lSQL = " DECLARE @Date DATETIME; "
            // + " SET @Date = '" + StrF01.D2Str(Convert.ToDateTime(date)) + "';"
            // + " SELECT [Check] "
            // + " FROM AccPrefActivate "
            // + " WHERE @Date BETWEEN FromDate AND ToDate AND [Check] = 1";

            ds = clsDbManager.GetData_Set(lSQL, "AccPrefActivate");

            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }

            else
            {
                MessageBox.Show("Period is Inactive, Saving Not Allowed !");
                return false;
            }
        }

        //public static DataSet getCurrFinYear(int FinanceID, int OrgID)
        //{
        //    string lSQL = string.Empty;
        //    DataSet ds = new DataSet();

        //    lSQL = " SELECT FromMonth, ToMonth, FromYear, ToYear "
        //         + " FROM AccPrefMaster "
        //         + " WHERE AccPrefID = " + FinanceID.ToString() + " AND OrgID = " + OrgID.ToString();

        //    ds = clsDbManager.GetData_Set(lSQL, "AccPrefMaster");

        //    return ds;
        //}

        public static bool chkFinYear(string date)
        {
            DateTime inputDate = Convert.ToDateTime(date);
            DateTime fromDate = Convert.ToDateTime(clsGVar.FromDate);
            DateTime toDate = Convert.ToDateTime(clsGVar.ToDate);

            if (inputDate >= fromDate && inputDate <= toDate)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static string sqlDate(string Date)
        {
            return StrF01.D2Str(Convert.ToDateTime(Date));
        }

        //public static string getCurrentOrganization()
        //{

        //}

        public static int getCurFinYearID()
        {
            string lSQL = string.Empty;
            DataSet ds = new DataSet();
            DataRow dRow;
            int finYearID = 0;

            lSQL = " SELECT TOP 1 AccPrefID "
                 + " FROM AccPrefTransaction "
                 + " WHERE IsHidden = 0";

            try
            {
                ds = clsDbManager.GetData_Set(lSQL, "AccPrefTransaction");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dRow = ds.Tables[0].Rows[0];
                    // Starting title as 0
                    finYearID = Convert.ToInt32(ds.Tables[0].Rows[0]["AccPrefID"] == DBNull.Value ? "" : ds.Tables[0].Rows[0]["AccPrefID"].ToString());
                }

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ds.Clear();
                }
            }
            catch
            {
                //MessageBox.Show("Unable to Get Account Code...", this.Text.ToString());
            }

            return finYearID;
        }
        
        public const string rptItemGrp = "http://192.168.1.188:888/Reports/Pages/ReportViewer.aspx?%2fGroup+Wise+Items&rs:Command=Render";

        public const string rptCustWiseSTSmry = "http://192.168.1.188:888/Reports/Pages/ReportViewer.aspx?%2fERP_UOSReports%2fSalesTaxSummary&rs:Command=Render";

        public static void SetGridColorScheme(DataGridView DGV1, int pGridColorScheme = 1)
        {
            #region Grid Color Scheme

            // Grid Color Scheme
            switch (pGridColorScheme)
            {
                case 1:
                    // Light Blue/Grey
                    //DGV1.BackgroundColor = Color.FromArgb(193, 208, 222);
                    //DGV1.GridColor = Color.FromArgb(102, 179, 64);
                    //DGV1.DefaultCellStyle.BackColor = Color.FromArgb(193, 208, 222);

                    DGV1.BackgroundColor = Color.FromArgb(193, 208, 222);
                    DGV1.GridColor = Color.FromArgb(75, 94, 129);
                    DGV1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
                    DGV1.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);        // black
                    DGV1.DefaultCellStyle.BackColor = Color.FromArgb(193, 208, 222);
                    break;
                case 2:
                    //
                    DGV1.BackgroundColor = Color.FromArgb(255, 255, 192);
                    DGV1.GridColor = Color.FromArgb(214, 10, 46);
                    DGV1.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
                    break;
            }

            #endregion
        }

        public static bool ViewAtStartup()
        {
            string lSQL = string.Empty;
            DataSet ds = new DataSet();
            DataRow dRow;
            int chk = 0;

            lSQL = " SELECT TOP 1 ViewAtStartup "
                 + " FROM CompanyInfo ";

            try
            {
                ds = clsDbManager.GetData_Set(lSQL, "CompanyInfo");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dRow = ds.Tables[0].Rows[0];
                    // Starting title as 0
                    chk = Convert.ToInt32(ds.Tables[0].Rows[0]["ViewAtStartup"]);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ds.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Unable to Get Account Code...");
            }

            if (chk == 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}

