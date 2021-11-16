using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RDLC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        //public ActionResult Index()
        //{
        //    ViewBag.Title = "Home Page";
        //    EmpReport();

        //    return View();
        //}

        //public async Task<ActionResult> Index()
        //{


        //    //var dcrCountData = await _webReportService.GetHqWiseDcrCount(model);

        //    string mimetype = "";
        //    int extension = 1;
        //    string path = Server.MapPath("~/Reports/Rdlc/Report1.rdlc");


        //    LocalReport localReport = new LocalReport();

        //    localReport.ReportPath = path;

        //    var rd = new ReportDataSource("DataSet1", GetEmployee());
        //    localReport.DataSources.Add(rd);
        //    string mimeType;
        //    string encoding;
        //    string fileNameExtension;
        //    Warning[] warnings;
        //    string[] streams;
        //    var deviceInfo = "";

        //    var result = localReport.Render("pdf", deviceInfo, out mimeType,
        //            out encoding,
        //            out fileNameExtension,
        //            out streams,
        //            out warnings);

        //    return File(result, "application/pdf");
        //}

        //public async Task<ActionResult> Index()
        //{


        //    //var dcrCountData = await _webReportService.GetHqWiseDcrCount(model);

        //    string mimetype = "";
        //    int extension = 1;
        //    string path = Server.MapPath("~/Reports/Rdlc/DigitalAgreement.rdlc");


        //    LocalReport localReport = new LocalReport();

        //    localReport.ReportPath = path;

        //    var rd = new ReportDataSource("DataSet1", GetDigitalAgreement());
        //    localReport.DataSources.Add(rd);
        //    string mimeType;
        //    string encoding;
        //    string fileNameExtension;
        //    Warning[] warnings;
        //    string[] streams;
        //    var deviceInfo = "";

        //    var result = localReport.Render("pdf", deviceInfo, out mimeType,
        //            out encoding,
        //            out fileNameExtension,
        //            out streams,
        //            out warnings);

        //    return File(result, "application/pdf");
        //}

        public async Task<ActionResult> Index()
        {


            //var dcrCountData = await _webReportService.GetHqWiseDcrCount(model);

            string mimetype = "";
            int extension = 1;
            //string path = Server.MapPath("~/Reports/Rdlc/DCRTerritory.rdlc");
            string path = Server.MapPath("~/Reports/Rdlc/DCRReport.rdlc");
            //string path = Server.MapPath("~/Reports/Rdlc/DCR.rdlc");
            //string path = Server.MapPath("~/Reports/Rdlc/DCRChecking.rdlc");


            LocalReport localReport = new LocalReport();

            localReport.ReportPath = path;

            var rd = new ReportDataSource("DataSet1", GetDCRChecking());
            //var rd = new ReportDataSource("DataSet1", GetDCRChecking());
            //var rd = new ReportDataSource("DataSet1", GetDCRChecking());
            localReport.DataSources.Add(rd);
            string mimeType;
            string encoding;
            string fileNameExtension;
            Warning[] warnings;
            string[] streams;
            var deviceInfo = "";
            var result = localReport.Render("pdf", deviceInfo, out mimeType,
                    out encoding,
                    out fileNameExtension,
                    out streams,
                    out warnings);

            return File(result, "application/pdf");
        }
        


        private List<DCRChecking> GetDCRChecking()
        {
            List<DCRChecking> lstDCRChecking = new List<DCRChecking>();

                DCRChecking objDCRChecking = new DCRChecking()
                {
                    Territory = "001",
                    EmployeeId = "P001",
                    Name = "Mahmud Koli",
                    TName = "Rangpur",
                    TCode = "A-RN-31",
                    Day=1

                };

                lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "001",
                EmployeeId = "P001",
                Name = "Mahmud Koli",
                TName = "Rangpur",
                TCode = "A-RN-31",
                Day = 3

            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "001",
                EmployeeId = "P001",
                Name = "Mahmud Koli",
                TName = "Rangpur",
                TCode = "A-RN-31",
                Day = 5

            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "001",
                EmployeeId = "P001",
                Name = "Mahmud Koli",
                TName = "Rangpur",
                TCode = "A-RN-31",
                Day = 15

            };

            lstDCRChecking.Add(objDCRChecking);



            objDCRChecking = new DCRChecking()
            {
                Territory = "001",
                EmployeeId = "P002",
                Name = "Remon",
                TName = "Dhanmondi",
                TCode = "A-RN-32",
                Day = 2,

            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "001",
                EmployeeId = "P002",
                Name = "Remon",
                TName = "Dhanmondi",
                TCode = "A-RN-32",
                Day = 6,

            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "001",
                EmployeeId = "P002",
                Name = "Remon",
                TName = "Dhanmondi",
                TCode = "A-RN-32",
                Day = 31,

            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "002",
                EmployeeId = "P003",
                Name = "Nasir Uddin",
                TName = "Jatrabari",
                TCode = "A-RN-33",
                Day = 1,
              

            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "002",
                EmployeeId = "P003",
                Name = "Nasir Uddin",
                TName = "Jatrabari",
                TCode = "A-RN-33",
                Day = 2,


            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "002",
                EmployeeId = "P003",
                Name = "Nasir Uddin",
                TName = "Jatrabari",
                TCode = "A-RN-33",
                Day = 5,


            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "002",
                EmployeeId = "P003",
                Name = "Nasir Uddin",
                TName = "Jatrabari",
                TCode = "A-RN-33",
                Day = 6,


            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "002",
                EmployeeId = "P003",
                Name = "Nasir Uddin",
                TName = "Jatrabari",
                TCode = "A-RN-33",
                Day = 31,


            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "002",
                EmployeeId = "P004",
                Name = "Mahmudul",
                TName = "Mogbazar",
                TCode = "A-RN-34",
                Day =2,

            };

            lstDCRChecking.Add(objDCRChecking);
            objDCRChecking = new DCRChecking()
            {
                Territory = "002",
                EmployeeId = "P004",
                Name = "Mahmudul",
                TName = "Mogbazar",
                TCode = "A-RN-34",
                Day = 4,

            };

            lstDCRChecking.Add(objDCRChecking);
            objDCRChecking = new DCRChecking()
            {
                Territory = "002",
                EmployeeId = "P004",
                Name = "Mahmudul",
                TName = "Mogbazar",
                TCode = "A-RN-34",
                Day = 5,

            };

            lstDCRChecking.Add(objDCRChecking);
            objDCRChecking = new DCRChecking()
            {
                Territory = "002",
                EmployeeId = "P004",
                Name = "Mahmudul",
                TName = "Mogbazar",
                TCode = "A-RN-34",
                Day = 6,

            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "002",
                EmployeeId = "P004",
                Name = "Mahmudul",
                TName = "Mogbazar",
                TCode = "A-RN-34",
                Day = 31,

            };

            lstDCRChecking.Add(objDCRChecking);












            objDCRChecking = new DCRChecking()
            {
                Territory = "003",
                EmployeeId = "P005",
                Name = "A",
                TName = "Rangpur",
                TCode = "A-RN-35",
                Day = 1

            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "003",
                EmployeeId = "P005",
                Name = "A",
                TName = "Rangpur",
                TCode = "A-RN-35",
                Day = 3

            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "003",
                EmployeeId = "P006",
                Name = "B",
                TName = "Rangpur",
                TCode = "A-RN-36",
                Day = 5

            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "003",
                EmployeeId = "P006",
                Name = "B",
                TName = "Rangpur",
                TCode = "A-RN-36",
                Day = 15

            };

            lstDCRChecking.Add(objDCRChecking);



            objDCRChecking = new DCRChecking()
            {
                Territory = "004",
                EmployeeId = "P007",
                Name = "C",
                TName = "Dhanmondi",
                TCode = "A-RN-37",
                Day = 2,

            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "004",
                EmployeeId = "P007",
                Name = "C",
                TName = "Dhanmondi",
                TCode = "A-RN-37",
                Day = 6,

            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "004",
                EmployeeId = "P008",
                Name = "D",
                TName = "Dhanmondi",
                TCode = "A-RN-38",
                Day = 31,

            };

            lstDCRChecking.Add(objDCRChecking);

            objDCRChecking = new DCRChecking()
            {
                Territory = "004",
                EmployeeId = "P008",
                Name = "D",
                TName = "Jatrabari",
                TCode = "A-RN-38",
                Day = 1,


            };

            lstDCRChecking.Add(objDCRChecking);

            //objDCRChecking = new DCRChecking()
            //{
            //    Territory = "002",
            //    EmployeeId = "P003",
            //    Name = "Nasir Uddin",
            //    TName = "Jatrabari",
            //    TCode = "A-RN-33",
            //    Day = 2,


            //};

            //lstDCRChecking.Add(objDCRChecking);

            //objDCRChecking = new DCRChecking()
            //{
            //    Territory = "002",
            //    EmployeeId = "P003",
            //    Name = "Nasir Uddin",
            //    TName = "Jatrabari",
            //    TCode = "A-RN-33",
            //    Day = 5,


            //};

            //lstDCRChecking.Add(objDCRChecking);

            //objDCRChecking = new DCRChecking()
            //{
            //    Territory = "002",
            //    EmployeeId = "P003",
            //    Name = "Nasir Uddin",
            //    TName = "Jatrabari",
            //    TCode = "A-RN-33",
            //    Day = 6,


            //};

            //lstDCRChecking.Add(objDCRChecking);

            //objDCRChecking = new DCRChecking()
            //{
            //    Territory = "002",
            //    EmployeeId = "P003",
            //    Name = "Nasir Uddin",
            //    TName = "Jatrabari",
            //    TCode = "A-RN-33",
            //    Day = 31,


            //};

            //lstDCRChecking.Add(objDCRChecking);

            //objDCRChecking = new DCRChecking()
            //{
            //    Territory = "002",
            //    EmployeeId = "P004",
            //    Name = "Mahmudul",
            //    TName = "Mogbazar",
            //    TCode = "A-RN-34",
            //    Day = 2,

            //};

            //lstDCRChecking.Add(objDCRChecking);
            //objDCRChecking = new DCRChecking()
            //{
            //    Territory = "002",
            //    EmployeeId = "P004",
            //    Name = "Mahmudul",
            //    TName = "Mogbazar",
            //    TCode = "A-RN-34",
            //    Day = 4,

            //};

            //lstDCRChecking.Add(objDCRChecking);
            //objDCRChecking = new DCRChecking()
            //{
            //    Territory = "002",
            //    EmployeeId = "P004",
            //    Name = "Mahmudul",
            //    TName = "Mogbazar",
            //    TCode = "A-RN-34",
            //    Day = 5,

            //};

            //lstDCRChecking.Add(objDCRChecking);
            //objDCRChecking = new DCRChecking()
            //{
            //    Territory = "002",
            //    EmployeeId = "P004",
            //    Name = "Mahmudul",
            //    TName = "Mogbazar",
            //    TCode = "A-RN-34",
            //    Day = 6,

            //};

            //lstDCRChecking.Add(objDCRChecking);

            //objDCRChecking = new DCRChecking()
            //{
            //    Territory = "002",
            //    EmployeeId = "P004",
            //    Name = "Mahmudul",
            //    TName = "Mogbazar",
            //    TCode = "A-RN-34",
            //    Day = 31,

            //};

            //lstDCRChecking.Add(objDCRChecking);


            return lstDCRChecking;
        }

           }

    public class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string State { get; set; }
    }


    public class Argeement
    {
        public string CandidateId { get; set; }
        public string CandidateName { get; set; }
        public string OldFACode { get; set; }
        public string FACode { get; set; }
        public string AgreementOpenDate { get; set; }
        public string MonthName { get; set; }
        public string Day { get; set; }
        public string Year { get; set; }
        public string BMDistrictName { get; set; }
        public string SignaturePath { get; set; }
        public string MonthDigit { get; set; }
    }

    public class DCRChecking
    {
        public string EmployeeId { get; set; }
        public string Territory { get; set; }
        public string Name { get; set; }
        public string TCode { get; set; }
        public string TName { get; set; }
        public int Day { get; set; }
    }
}
