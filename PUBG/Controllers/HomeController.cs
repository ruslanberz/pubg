using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PUBG.Data;
using PUBG.Models;
using RestSharp;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;
using Tesseract;

namespace PUBG.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)

        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        const string SessionName = "_Name";
        const string res = "";

        public IActionResult  Index()
        {
            if (User.Identity.IsAuthenticated == true)
            {
                List<ApplicationUser> all = _context.Users.ToList();
                string test = all.FirstOrDefault().Fullname;
                HttpContext.Session.SetString(SessionName, User.Identity.Name);
                string s = HttpContext.Session.GetString(SessionName);
                var u = _context.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);//null qayidacaq
                ViewBag.Created = u.CreationDate.ToShortDateString();
                ViewBag.User = u.Fullname;


            }
            HomeViewModel model = new HomeViewModel()
            {
                Sliders = _context.Sliders.ToList(),
                Blogs = _context.Blogs.ToList(),
                Advertisements = _context.Advertisements.OrderByDescending(x => x.Id).ToList(),
                galleryPhotos = _context.GalleryPhotos.ToList()
            };

            return View(model);

        }

        [HttpPost]
        public JsonResult Contact(string name,string email, string message)
        {
            string ad = name;
            string e_poct = email;
            string messaj = message;
            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Host = "smtp.yandex.com";

            var body = name  + "<span> yeni bir mesaj saxladı</span>"+ "<br />" + "<span>Əlaqə emaili:" +e_poct+"</span>" + "<br />" + "<span> Mesaj:</span><br />" + messaj;
            // setup Smtp authentication
            System.Net.NetworkCredential credentials =
                new System.Net.NetworkCredential("no-reply@smartgames.az", "strongpass123@@@");
            client.UseDefaultCredentials = false;
            client.Credentials = credentials;

            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("no-reply@smartgames.az", "No-Reply");


            msg.To.Add("admin@smartgames.az");
            msg.Subject = "Sayta yeni mesaj göndərilib";
            msg.IsBodyHtml = true;
            msg.Body = body;

            try

            {
                client.Send(msg);
                return Json(new { message = "Ok" });

            }
            catch (Exception ex)
            {
                var st = ex;
                return Json(new { message = "500" });
            }

          
        }

        public ActionResult Rules()
        {
            Rule current = _context.Rules.FirstOrDefault();
            return View(current);
        }
        //public void SendMail(string servis)
        //{
        //    foreach (var address in _context.Subscriptions)
        //    {
        //        SmtpClient client = new SmtpClient();
        //        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //        client.Port = 587;
        //        client.EnableSsl = true;
        //        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //        client.Host = "smtp.yandex.com";

        //        var body = "<span>Yeni bir </span>" + servis + "<span> xidməti qəbul olundu. Zəhmət olmasa yoxlayın.</span>";
        //        // setup Smtp authentication
        //        System.Net.NetworkCredential credentials =
        //            new System.Net.NetworkCredential("info1@smartgames.az", "SMARTPASS123@@@");
        //        client.UseDefaultCredentials = false;
        //        client.Credentials = credentials;

        //        MailMessage msg = new MailMessage();
        //        msg.From = new MailAddress("info1@smartgames.az", "Info");


        //        msg.To.Add(address.Email);
        //        msg.Subject = "Mail Delivery test";
        //        msg.IsBodyHtml = true;
        //        msg.Body = body;

        //        try

        //        {
        //            client.Send(msg);

        //        }
        //        catch (Exception ex)
        //        {
        //            var st = ex;

        //        }
        //    }
        //    //Mail sifre 



        //}
        [HttpGet]
        public IActionResult Advertisement(int Id)
        {
            Advertisement ad = _context.Advertisements.Find(Id);
            if (ad != null)
            {
                return View(ad);
            }
            return View(nameof(Index));
        }
        [HttpPost]

        public JsonResult Subscribe(string Email)
        {
            string a = "12/21/2019";
            string format = "d";
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime b = DateTime.ParseExact(a,format,provider);
            Subscriptions check = _context.Subscriptions.FirstOrDefault(x => x.Email.ToLower() == Email.ToLower());
            if (check == null)
            {
                Subscriptions toadd = new Subscriptions();
                toadd.Email = Email;
                _context.Subscriptions.Add(toadd);
                _context.SaveChanges();
                return Json(new { message = "Ok" });
            }
            else

            {
                return Json(new { message = "Already" });
            }


        }
        [HttpPost]
        public JsonResult Validate(string PubgUsername)
        {

            ApplicationUser check = _context.Users.FirstOrDefault(x => x.PubgUsername == PubgUsername);

            if (check == null)
            {
                return Json(new { valid = true, message = "Ok" });
            }
            else
            {
                return Json(new { valid = false, message = "Belə istifadəçi artıq qeydiyyatdan keçib" });
            }
        }


        public async  Task<IActionResult> Cabinet()
        {
            if (User.Identity.IsAuthenticated == false)
            {
                return View(nameof(Index));
            }
            else

            {
                HttpContext.Session.SetString(SessionName, User.Identity.Name);
                Season currentSeason = _context.Seasons.FirstOrDefault(x => x.IsActive == true);
                string s = HttpContext.Session.GetString(SessionName);
                var u = _context.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);
                ViewBag.Count = await ImageHandle(u);
                CabinetVw current = new CabinetVw();
                current.User = u;
                current.Xal = _context.Posteds.Where(z => z.SeasonId == currentSeason.Id).Sum(c => c.Point);
                current.Say = _context.Posteds.Where(z => z.ApplicationUserId ==current.User.Id && z.SeasonId == currentSeason.Id).Count();
                current.SeasonName = currentSeason.Name;
                current.Image = _context.Posteds.Where(z => z.ApplicationUserId == current.User.Id && z.SeasonId == currentSeason.Id).Select(x => x.ImagePath).ToList();
                //ApplicationUser usr = _context.Users.FirstOrDefault(x => x.UserName == HttpContext.Session.GetString(SessionName));
                //usr.PreviousLogin = DateTime.UtcNow.AddHours(4);
                //_context.SaveChanges();
                return View(current);
            }

        }
        [ActionName("CabinetToken")]
        public async Task<IActionResult> Cabinet (string token)
        {
            if (User.Identity.IsAuthenticated == false)
            {
                return View(nameof(Index));
            }
            else

            {
                HttpContext.Session.SetString(SessionName, User.Identity.Name);
                Season currentSeason = _context.Seasons.FirstOrDefault(x => x.IsActive == true);
                string s = HttpContext.Session.GetString(SessionName);
                var u = _context.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);
                ViewBag.Count = await ImageHandle(u,token);
                CabinetVw current = new CabinetVw();
                current.User = u;
                current.Xal = _context.Posteds.Where(z => z.SeasonId == currentSeason.Id).Sum(c => c.Point);
                current.Say = _context.Posteds.Where(z => z.ApplicationUserId == current.User.Id && z.SeasonId == currentSeason.Id).Count();
                current.SeasonName = currentSeason.Name;
                ApplicationUser usr = _context.Users.FirstOrDefault(x => x.UserName == HttpContext.Session.GetString(SessionName));
                current.Image = _context.Posteds.Where(z => z.ApplicationUserId == current.User.Id && z.SeasonId == currentSeason.Id).Select(x => x.ImagePath).ToList();
                usr.PreviousLogin = DateTime.UtcNow.AddHours(4);
                _context.SaveChanges();
                return View("Cabinet", current);
            }

        }
        [HttpGet]
        public async Task<IActionResult> ImageHandle(ApplicationUser currentUser, string token="")
        {
            int count = 0;
            if (currentUser.PreviousLogin != null)
            {

                string link = "https://graph.facebook.com/v4.0/me?fields=id,name,feed.since(";
                string time = currentUser.PreviousLogin.ToString("s", DateTimeFormatInfo.InvariantInfo); //bunu userin prevLogin - den gotureceyik ok//api key deyis
                string linkEnd = "){message,application,full_picture,created_time}&&access_token=";
                                                                                                 
                string fullLink = link + time + linkEnd+token;
                var client = new RestClient(fullLink);
                var request = new RestRequest();
                // do whatever else you want/need to, to the request
                // ...

               

                //// ... and use it like we used to
                var response = client.Execute(request);
                

                var usersFB = JsonConvert.DeserializeObject<FacebookImage>(response.Content);
                if (usersFB.Feed != null)
                {
                    foreach (var item in usersFB.Feed.data.ToList())
                    {

                        if (item.application != null)
                        {
                            if (item.application.name == "PUBG Mobile")
                            {
                                var uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                               
                                
                                await CropImage(item.full_picture);

                                string imageName = item.created_time.ToString("dd-MM-yyyy-HH-mm") + currentUser.PubgUsername + ".jpg";

                                string res;
                                using (var engine = new TesseractEngine(Path.Combine(".\\", "tessdata"), "eng", EngineMode.Default))
                                {

                                    using (var image = Pix.LoadFromFile(".\\Uploads\\foo.jpg"))
                                    {

                                        using (var page = engine.Process(image))
                                        {

                                            res = page.GetText();

                                        }

                                    }
                                }
                                int val = res.IndexOf("#");

                                if (val > 0)
                                {
                                    var rating = res.Substring(val, 3);
                                    string value = rating.Substring(1, 2);
                                    var trm = value.Trim();
                                    if (trm == "|" || trm == "l" || trm == "1")
                                    {
                                        trm = "1";
                                        count++;
                                        Posted post = new Posted();

                                        post.Season = _context.Seasons.FirstOrDefault(x => x.IsActive == true);
                                        post.SeasonId = _context.Seasons.FirstOrDefault(x => x.IsActive == true).Id;
                                        post.ImagePath = imageName;
                                        post.CreatedAt = item.created_time;
                                        post.ApplicationUser = currentUser;
                                        post.ApplicationUserId = currentUser.Id;
                                        _context.Posteds.Add(post);
                                        _context.SaveChanges();
                                        await CropImage2(item.full_picture, imageName,uploadFolder);

                                    }

                                }


                            }
                        }
                    }

                }
            }
           




            //return Content(count.ToString());
            return RedirectToAction("cabinet");
        }

        //public async Task<IActionResult> ImageHandle(ApplicationUser currentUser, string token)
        //{
        //    int count = 0;
        //    if (currentUser.PreviousLogin != null)
        //    {

        //        string link = "https://graph.facebook.com/v4.0/me?fields=id,name,feed.since(";
        //        string time = currentUser.PreviousLogin.ToString("s", DateTimeFormatInfo.InvariantInfo); //bunu userin prevLogin - den gotureceyik ok//api key deyis
        //        string linkEnd = "){message,application,full_picture,created_time}&&access_token=";
        //        string fullLink = link + time + linkEnd+token;
        //        var client = new RestClient(fullLink);
        //        var request = new RestRequest();
        //        // do whatever else you want/need to, to the request
        //        // ...



        //        //// ... and use it like we used to
        //        var response = client.Execute(request);


        //        var usersFB = JsonConvert.DeserializeObject<FacebookImage>(response.Content);
        //        if (usersFB.Feed != null)
        //        {
        //            foreach (var item in usersFB.Feed.data.ToList())
        //            {

        //                if (item.application != null)
        //                {
        //                    if (item.application.category == "Games" && item.application.name == "PUBG Mobile")
        //                    {
        //                        var uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");


        //                        await CropImage(item.full_picture);

        //                        string imageName = item.created_time.ToString("dd-MM-yyyy-HH-mm") + currentUser.PubgUsername + ".jpg";

        //                        string res;
        //                        using (var engine = new TesseractEngine(Path.Combine(".\\", "tessdata"), "eng", EngineMode.TesseractAndCube))
        //                        {

        //                            using (var image = Pix.LoadFromFile(".\\Uploads\\foo.jpg"))
        //                            {

        //                                using (var page = engine.Process(image))
        //                                {

        //                                    res = page.GetText();

        //                                }

        //                            }
        //                        }
        //                        int val = res.IndexOf("#");

        //                        if (val > 0)
        //                        {
        //                            var rating = res.Substring(val, 3);
        //                            string value = rating.Substring(1, 2);
        //                            var trm = value.Trim();
        //                            if (trm == "|" || trm == "l" || trm == "1")
        //                            {
        //                                trm = "1";
        //                                count++;
        //                                Posted post = new Posted();

        //                                post.Season = _context.Seasons.FirstOrDefault(x => x.IsActive == true);
        //                                post.SeasonId = _context.Seasons.FirstOrDefault(x => x.IsActive == true).Id;
        //                                post.ImagePath = imageName;
        //                                post.CreatedAt = item.created_time;
        //                                post.ApplicationUser = currentUser;
        //                                post.ApplicationUserId = currentUser.Id;
        //                                _context.Posteds.Add(post);
        //                                _context.SaveChanges();
        //                                await CropImage2(item.full_picture, imageName, uploadFolder);

        //                            }

        //                        }


        //                    }
        //                }
        //            }

        //        }
        //    }





        //    //return Content(count.ToString());
        //    return RedirectToAction("cabinet");
        //}

        private async static Task CropImage(string a)
        {
           
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(a)
                    .ConfigureAwait(false);

                using (var inputStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                {
                    using (var image = System.Drawing.Image.FromStream(inputStream))
                    {
                        
                        var path = Path.Combine(".\\Uploads", "foo.jpg");
                        Rectangle cropArea = new Rectangle(70, 120, 200, 100);
                        Bitmap bmpImage = new Bitmap(image);
                        bmpImage= bmpImage.Clone(cropArea, bmpImage.PixelFormat);
                        bmpImage.Save(path);
                    }
                }
            }

          
        }

        private async static Task CropImage2(string a, string imageName, string uploadFolder )
        {

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(a)
                     .ConfigureAwait(false);

                string filePath = Path.Combine(uploadFolder,imageName );

                using (var inputStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                {
                    using (var image = SixLabors.ImageSharp.Image.Load(inputStream))
                    {

                        var path = filePath;

                        image.Clone(
                            ctx => ctx.Crop(580, 300)).Save(path);

                    }
                }
            }


        }

        public async static Task CropPoint(string a) {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(a)
                    .ConfigureAwait(false);
            
           using ( var inputStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false)){
                using (var image = SixLabors.ImageSharp.Image.Load(inputStream))
                {
                    var path = Path.Combine(".\\Uploads", "too.jpg");

                    image.Save(path);
                    Rectangle cropRect = new Rectangle();
                    Bitmap src = System.Drawing.Image.FromFile(".\\Uploads\\too.jpg") as Bitmap;
                    Bitmap target = new Bitmap(Convert.ToInt32( cropRect.Width),Convert.ToInt32( cropRect.Height), System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                    using (Graphics g = Graphics.FromImage(target))
                    {
                        g.DrawImage(src, new Rectangle(200, 200, target.Width, target.Height),
                                         cropRect,
                                         GraphicsUnit.Pixel);
                        target.Save(".\\Uploads\\too2.jpg");

                    }
                }
            }

        
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //public ActionResult Cryp()
        //{
        //    var pass = "pubg123";
        //    var s= Crypto.Hash(pass);
        //    return Content(s);
        //}

    }
}
