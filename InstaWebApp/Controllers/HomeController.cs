using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using InstaWebApp.Models;
namespace InstaWebApp.Controllers
{
    public class HomeController : Controller
    {
        //const string VerifyLink = "http://localhost:2523/home/EmailVerify";
        
        const string VerifyLink = "https://bsite.net/hadyPir/home/EmailVerify";

        //InstabotDBEntities db = new InstabotDBEntities();
        hadypir_instaEntities db = new hadypir_instaEntities();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpGet]
        public ActionResult EmailVerify(string user,string code)
        {
            var Us = db.Users.FirstOrDefault(o => o.Username == user && o.VerifyCode == code);
            if(Us != null && !Us.IsVerify.Value)
            {
                Us.IsVerify = true;
                db.Entry(Us).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            ViewBag.Result = "ایمیل شما با موفقیت تایید شد";
            ViewBag.Title = "تاییدیه ایمیل";

            return View("payment");
        }
        [HttpGet]
        public ActionResult ResetPassword(string email,string code)
        {
            var user = db.Users.FirstOrDefault(o => o.Email == email && o.VerifyCode == code);
            PassChanger pass = new PassChanger();
            if(user == null)
            {
                ViewBag.Result = "شناسایی نشدید ☹";
            }
            else
            {
                pass.id = user.ID;
                pass.email = user.Email;
                
            }
            return View(pass);
        }
        [HttpPost]
        public ActionResult PasswordReset(PassChanger pass)
        {
            try
            {
                ViewBag.Title = "changed Password";

                var user = db.Users.FirstOrDefault(o => o.ID == pass.id);
                if(user != null)
                {
                    user.Password = pass.Password;
                    db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    ViewBag.Result = "your password successfully changed. enjoy 😉";
                }
                else
                {
                    ViewBag.Result = "user not found !!!";
                }
                
            }
            catch (Exception e)
            {
                ViewBag.Result = "Error Found.";
            }

            return View("Payment");
        }
        [HttpGet]
        public ActionResult Pay(int? id,string code = null)
        {
            if (id.HasValue)
            {
                int geymat = 0;
                var discount = db.Discounts.FirstOrDefault(o => o.DiscountCode == code);
                if (code != null && discount != null)
                {
                    geymat = discount.DiscountedMoney.Value;
                }
                else
                {
                    geymat = db.Moneys.First().Cost;
                }

                if(geymat == 0 && id != null)
                {
                    var US = db.Users.FirstOrDefault(o => o.ID == id.Value);

                    var tmp = db.TempDatas.FirstOrDefault(o => o.Username == US.Username);

                    if (tmp == null)
                    {
                        db.TempDatas.Add(new TempData { Authority = "free_Counted", Username = US.Username, Email = US.Email, DiscountCode_ID = (discount != null) ? discount.ID : 0 });
                        db.SaveChanges();
                    }
                    else
                    {
                        tmp.Authority = "free_Counted";
                        db.Entry(tmp).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    US.IsBuy = true;
                    db.Entry(US).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    discount.Count--;
                    db.Entry(discount).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    ViewBag.Result = "اکانت فعال شد";
                    return View("Payment");
                }

                if (id != null)
                {
                    #region WebGate
                    System.Net.ServicePointManager.Expect100Continue = false;
                    Zarinpal.PaymentGatewayImplementationServicePortTypeClient zp = new Zarinpal.PaymentGatewayImplementationServicePortTypeClient();
                    string Authority;

                    int status = zp.PaymentRequest("592d9532-be22-11e8-9600-000c295eb8fc", geymat, "درگاه پرداخت برنامه اینستاباتر", "pirmohady@gmail.com", "09214430982", VerifyLink, out Authority);
                    if (status == 100)
                    {
                        var US = db.Users.FirstOrDefault(o => o.ID == id.Value);

                        var tmp = db.TempDatas.FirstOrDefault(o => o.Username == US.Username);

                        if(tmp == null)
                        {
                            db.TempDatas.Add(new TempData { Authority = Authority, Username = US.Username, Email = US.Email , DiscountCode_ID = (discount != null) ? discount.ID : 0 });
                            db.SaveChanges();
                        }
                        else
                        {
                            tmp.Authority = Authority;
                            db.Entry(tmp).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }

                        Response.Redirect("https://www.zarinpal.com/pg/StartPay/" + Authority);
                    }
                    else
                    {
                        ViewBag.Result = "مشکلی پیش آمده دوباره تکرار کنید";
                    }
                    #endregion
                }
                else
                {
                    ViewBag.Result = "درخواست مورد نظر یافت نشد";
                }
            }
            else
            {
                ViewBag.Result = "آیدی وجود ندارد";
            }

            return View("Payment");
        }
        [HttpGet]
        public ActionResult Verify()
        {
            if (HttpContext.Request["Status"] != null && HttpContext.Request["Status"] != "" && HttpContext.Request["Authority"] != null && HttpContext.Request["Authority"] != "")
            {
                if (HttpContext.Request["Status"] == "Ok")
                {
                    string Authority = HttpContext.Request["Authority"].ToString();
                    var temp = db.TempDatas.FirstOrDefault(o => o.Authority == Authority);
                    if (temp != null)
                    {
                        long refID;
                        System.Net.ServicePointManager.Expect100Continue = false;
                        Zarinpal.PaymentGatewayImplementationServicePortTypeClient zp = new Zarinpal.PaymentGatewayImplementationServicePortTypeClient();

                        int status = zp.PaymentVerification("592d9532-be22-11e8-9600-000c295eb8fc", Authority, 10000, out refID);

                        if (status == 100)
                        {
                            ViewBag.Result = "پرداخت با موفقیت انجام شد";
                            //set User Buyed software
                            var user = db.Users.FirstOrDefault(o => o.Username == temp.Username);
                            user.IsBuy = true;
                            db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                            //set time un temdata
                            temp.Time = DateTime.Now;
                            db.Entry(temp).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                            //reduce Discount able
                            var discount = db.Discounts.FirstOrDefault(o => o.ID == temp.DiscountCode_ID);
                            if(discount != null)
                            {
                                discount.Count--;
                                db.Entry(discount).State = System.Data.Entity.EntityState.Modified;
                                db.SaveChanges();
                            }
                        }
                        else
                        {
                            ViewBag.Result = "مشکلی پیش آمده دوباره وارد شوید";
                        }
                    }
                    else
                    {
                        ViewBag.Result = "این فاکتور وجود ندارد";
                    }
                }
                else
                {
                    ViewBag.Result = "در پرداخت مشکلی پیش آمده";
                }
            }
            else
            {
                ViewBag.Result = "درخواست نامعتبر";
            }
            return View("Payment");
        }
    }
    

}
