using QRCoder;
using QRScanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static QRCoder.PayloadGenerator;
namespace QRScanner.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult CreateQRCode()
        {
            return View(new QRCodeModel());
        }
        [HttpPost]
        public ActionResult CreateQRCode(QRCodeModel qrCodeModel)
        {
            Payload payload = new Url(qrCodeModel.QRCodeText);
            QRCodeGenerator codeGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = codeGenerator.CreateQrCode(payload);
            QRCoder.PngByteQRCode pngByte = new PngByteQRCode(qrCodeData);
            var QrByte = pngByte.GetGraphic(20);
            string base64Url = Convert.ToBase64String(QrByte);
            qrCodeModel.QRImageUrl = "data:image/png;base64," + base64Url;
            return View("CreateQRCode", qrCodeModel);
        }
    }
}