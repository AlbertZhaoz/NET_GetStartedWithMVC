using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace GetStartedWithASPNETMVC_Plugin
{
    public class ReadFileController: Controller
    {
        public ActionResult ReadTxtFile()
        {
            string path = @"F:\Code_Repo\03_Test\PowerAutomate\GithubRepo.txt";
            var content = System.IO.File.ReadAllText(path);
            ViewBag.content = content;
            //跳转到根目录下的Views/ReadFile/ReadTxtFile.cshtml文件中
            return View("~/Views/ReadFile/ReadTxtFile.cshtml");
        }
    }
}
