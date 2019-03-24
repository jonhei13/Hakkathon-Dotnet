using aver.core.Models;
using aver.Helpers;
using aver.services;
using aver.services.ArionApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aver.Controllers
{
    public class SettingsController : Controller
    {
        public BusinessHelper helper = new BusinessHelper();
        public ArionApi arionHelper = new ArionApi();
        public Icd10Helper icdHelper = new Icd10Helper();
        // GET: Settings
        public ActionResult Index()
        {
            Settings model = new Settings();
            List<Icd10Model> classifications = new List<Icd10Model>();
            helper.GetDiagnosisIds("0206929999").ForEach((code) =>
            {
                classifications.Add(icdHelper.GetIcd10Classification(code));
            });
            model.Classifications = classifications;
            return View(model);
        }
    }
}