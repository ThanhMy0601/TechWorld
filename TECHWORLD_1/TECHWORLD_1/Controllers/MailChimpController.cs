using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using TECHWORLD_1.Models;

namespace TECHWORLD_1.Controllers
{
    public class MailChimpController : Controller
    {
        private readonly TechWorld_2Context db;
        public MailChimpController(TechWorld_2Context ctx)
        {
            db = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Print()
        {

            return View();
        }
        public IActionResult Excel()
        {

            var comlumHeadrs = new string[]
            {
                "STT",
                "Địa chỉ Email",
                "Họ Tên",
                "Địa Chỉ",
                "Số điện Thoại",
                "Ngày sinh"
            };

            byte[] result;

            using (var package = new ExcelPackage())
            {
                // add a new worksheet to the empty workbook

                var worksheet = package.Workbook.Worksheets.Add("DSKhachHang"); //Worksheet name
                using (var cells = worksheet.Cells[1, 1, 1, 5]) //(1,1) (1,5)
                {
                    cells.Style.Font.Bold = true;
                }

                //First add the headers
                for (var i = 0; i < comlumHeadrs.Count(); i++)
                {
                    worksheet.Cells[1, i + 1].Value = comlumHeadrs[i];
                }

                //Add values
                IList<KhachHang> customerList = db.KhachHang.ToList();
                //int totalRows = customerList.Count();
                var j = 2; var stt = 1;
                foreach (var employee in customerList)
                {
                    worksheet.Cells["A" + j].Value = stt;
                    worksheet.Cells["B" + j].Value = employee.HoTen;
                    worksheet.Cells["C" + j].Value = employee.Email;
                    worksheet.Cells["D" + j].Value = employee.DiaChi;
                    worksheet.Cells["E" + j].Value = employee.DienThoai;
                    worksheet.Cells["F" + j].Value = employee.NgaySinh;
                    stt++;
                    j++;
                }
                result = package.GetAsByteArray();
            }

            return File(result, "application/ms-excel", $"DSKhachHang.xlsx");
        }

        public IActionResult CSV()
        {
            var comlumHeadrs = new string[]
            {
                "Địa chỉ Email",
                "Họ Tên",
                "Địa Chỉ",
                "Số điện Thoại",
                "Ngày sinh"
            };
            IList<KhachHang> customerList = db.KhachHang.ToList();

            var employeeRecords = (from employee in customerList
                                   select new object[]
                                    {
                                            employee.Email,
                                            $"{employee.HoTen}",
                                            $"\"{employee.DiaChi}\"", //Escaping ","
                                            $"\"{employee.DienThoai}\"",
                                            employee.NgaySinh,
                                    }).ToList();

            // Build the file content
            var employeecsv = new StringBuilder();
            employeeRecords.ForEach(line =>
            {
                employeecsv.AppendLine(string.Join(",", line));
            });

            byte[] buffer = Encoding.Unicode.GetBytes($"{string.Join(",", comlumHeadrs)}\r\n{employeecsv.ToString()}");
            return File(buffer, "text/csv", $"DSKhachHang.csv");

        }
    }
}