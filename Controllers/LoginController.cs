using GetStartedWithASPMVC_SqlsugarDbcontext;
using GetStartedWithASPNETMVC.Utility;
using GetStartedWithASPNETMVC.Utility.Filter;
using GetStartedWithASPNETMVC_Interface;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetStartedWithASPNETMVC.Controllers
{
    public class LoginController : Controller
    {
        // 这个控制器用来通过构造函数注入服务
        private readonly ICustomService _service = null;

        public LoginController(ICustomService service)
        {
            this._service = service;
        }

        [HttpGet]
        [CsutomAllowAnonymousAttribute] // 不进行验证
        public ActionResult Log()
        {
            return View();
        }

        [HttpGet]
        public ActionResult LogSuccess()
        {
            return View();
        }


        [HttpPost]
        [CsutomAllowAnonymousAttribute] //不进行验证
        public ActionResult Log(string name, string password, string verify)
        {
            //1.验证验证码
            //2.查询数据库，验证用户信息
            //3.把用户信息写入到Session中去；
            //4.跳转到主页中
            //string formName = base.HttpContext.Request.Form["Name"];
            if (!string.Equals(verify, HttpContext.Session["CheckCode"].ToString(), StringComparison.InvariantCultureIgnoreCase))
            {
                ModelState.AddModelError("failed", "用户名或者密码错误");
                return View();
            }
            //通过数据库查询用户名和密码
            var queryResult = _service.Query<T_CurrentUser>(c => c.Name == name).First();
            if (queryResult != null)
            {
                if (password.Equals(queryResult.Password))
                {
                    HttpContext.Session["T_CurrentUser"] = queryResult;
                    return base.Redirect("LogSuccess");
                    //return View("~/Views/Login/LogSuccess.cshtml");
                    //return base.Redirect("/Home/Index");
                }
                else
                {
                    ModelState.AddModelError("failed", "用户名或者密码错误");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("failed", "用户名或者密码错误");
                return View();
            }
        }

        /// <summary>
        /// 验证码  直接写入Response
        /// </summary>
        [CsutomAllowAnonymousAttribute] // 不进行验证
        public void VerifyCode()
        {
            string code = "";
            // 绘制出图片，通用类库
            Bitmap bitmap = VerifyCodeHelper.CreateVerifyCode(out code);
            base.HttpContext.Session["CheckCode"] = code;
            bitmap.Save(base.Response.OutputStream, ImageFormat.Gif);
            base.Response.ContentType = "image/gif";
        }


        [HttpPost]
        [CsutomAllowAnonymousAttribute] // 不进行验证
        public ActionResult Logout()
        {
            //1.登录成功----写了Session数据
            //2.注销   登出---清除session

            #region Cookie
            HttpCookie myCookie = HttpContext.Request.Cookies["T_CurrentUser"];
            if (myCookie != null)
            {
                myCookie.Expires = DateTime.Now.AddMinutes(-1);//设置过期时间
                HttpContext.Response.Cookies.Add(myCookie);
            }

            #endregion Cookie

            #region Session
            var sessionUser = HttpContext.Session["T_CurrentUser"];
            if (sessionUser != null && sessionUser is T_CurrentUser)
            {
                T_CurrentUser currentUser = (T_CurrentUser)HttpContext.Session["T_CurrentUser"];

            }
            HttpContext.Session["T_CurrentUser"] = null;//表示将制定的键的值清空，并释放掉，
            HttpContext.Session.Remove("T_CurrentUser");
            HttpContext.Session.Clear();//表示将会话中所有的session的键值都清空，但是session还是依然存在，
            HttpContext.Session.RemoveAll();//
            HttpContext.Session.Abandon();//就是把当前Session对象删除了，下一次就是新的Session了   
            #endregion Session
            return RedirectToAction("Log", "Login"); ;
        }
    }
}