# -QR-Code-Generator-ASP.NET-MVC
This is a simple ASP.NET MVC application that allows users to generate QR codes based on input text, using the QRCoder library.
✨ Features:
Input any text/URL to generate a QR code.
The QR code will be rendered directly on the page.
Supports real-time preview using Base64 image rendering.
🛠️ Tech Stack:
ASP.NET MVC 5
C#
QRCoder (QR Code generation library)
HTML & Razor Views
📂 Project Structure:
/Controllers
    HomeController.cs

/Models
    QRCodeModel.cs

/Views/Home
    CreateQRCode.cshtml

/Content & /Scripts
    (Standard ASP.NET MVC folders)
🚀 How it works:
User inputs a URL or text in a textbox.
Submits the form to the backend.
The backend generates the QR code using the QRCoder library.
The QR code is returned as a Base64 string and displayed as an image on the same page.
