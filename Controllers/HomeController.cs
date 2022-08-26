using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using U18220909_HW004.Models;


namespace U18220909_HW004.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public new ActionResult User()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Stats()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Donate()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult PartnerIndex()
        {
            List<Partners> partner = GetTestData();
            return View(partner);
        }
        private List<Partners> GetTestData()
        {
            List<Partners> partner = new List<Partners>();

            Partners par1 = new Partners(0128596320, "Jan", "Ris", "Spar", "Jan.Spar@gmail.com", 85963214, "moneyDonation");
            Partners par2 = new Partners(0129635321, "Jain", "Art", "Shoprite", "Jain.Shoprite@gmail.com", 85968896, "moneyDonation");
            Partners par3 = new Partners(0119635321, "Arti", "Art", "Shoprite", "Arti.Checkers@gmail.com", 84986596, "FoodDonation");
            Partners par4 = new Partners(0118535322, "Maya", "Art", "Shoprite", "Maya.Shoprite@gmail.com", 84968336, "FoodDonation");
            Partners par5 = new Partners(0156335323, "Chris", "Art", "Shoprite", "Chris.Okfurniture@gmail.com", 85965521, "ApplicationsDonation");
            Partners par6 = new Partners(0129635385, "John", "Art", "Shoprite", "John.lewis@gmail.com", 85968963, "ApplicationsDonation");
            Partners par7 = new Partners(0129635395, "Jane", "Art", "Shoprite", "Jane.Boxer@gmail.com", 82369541, "moneyDonation");




            partner.Add(par1);
            partner.Add(par2);
            partner.Add(par3);
            partner.Add(par4);
            partner.Add(par5);
            partner.Add(par6);
            partner.Add(par6);
            return partner;

        }
        public ActionResult VolunterIndex()

        {
            List<Volunteers> volunter = GetData();
            return View(volunter);
        }
        private List<Volunteers> GetData()
        {
            List<Volunteers> volunteer = new List<Volunteers>();
            Volunteers vol1 = new Volunteers(0799631685, 9905260000255, "Jess", "ali", "jess@gmail.com", "10:00", "GardingTraining");
            Volunteers vol2 = new Volunteers(0799631688, 9206260000256, "Jeli", "sia", "Jeli@gmail.com", "09:00", "GardingTraining");
            Volunteers vol3 = new Volunteers(0769631658, 9107260088256, "Jan", "stain", "Jan@gmail.com", "11:00", "GardingTraining");
            Volunteers vol4 = new Volunteers(0769685688, 9808260099285, "John", "stern", "John@gmail.com", "10:00", "GardingTraining");
            Volunteers vol5 = new Volunteers(0669631682, 9809260000286, "mpho", "seete", "mpho@gmail.com", "09:00", "GardingTraining");
            Volunteers vol6 = new Volunteers(0669631663, 9801060000295, "mphoza", "seeta", "mphoza@gmail.com", "12:00", "GardingTraining");
            Volunteers vol7 = new Volunteers(0639631691, 9803260000296, "jezz", "sira", "jezz@gmail.com", "15:00", "GardingTraining");
            Volunteers vol8 = new Volunteers(0639631652, 9702260330282, "Jayne", "sita", "Jayne@gmail.com", "15:00", "GardingTraining");
            Volunteers vol9 = new Volunteers(0649631644, 9606260910571, "alyne", "siya", "alyne@gmail.com", "11:00", "GardingTraining");
            Volunteers vol10 = new Volunteers(0659631633, 9605260086256, "betty", "sitta", "betty@gmail.com", "08:00", "GardingTraining");


            volunteer.Add(vol1);
            volunteer.Add(vol2);
            volunteer.Add(vol3);
            volunteer.Add(vol4);
            volunteer.Add(vol5);
            volunteer.Add(vol6);
            volunteer.Add(vol7);
            volunteer.Add(vol8);
            volunteer.Add(vol9);
            volunteer.Add(vol10);
            return volunteer;
        }
        public ActionResult DonorRecepientI()
        {
            List<DonorRecepients> recepients = GetiData();
            return View(recepients);
        }
        private List<DonorRecepients> GetiData()
        {
            List<DonorRecepients> recepients = new List<DonorRecepients>();
            DonorRecepients rec1 = new DonorRecepients(0799631528, 9603028877081, "Maria", "Seteno", "maria@gamil.com,", "180 sedibeng pretoria");
            DonorRecepients rec2 = new DonorRecepients(0799631688, 9206260000256, "Jeli", "sia", "Jeli@gmail.com", "120 tlakong Limpopo");
            DonorRecepients rec3 = new DonorRecepients(0769631658, 9107260088256, "Jan", "stain", "Jan@gmail.com", "phase 5 Mamelodi Pretoria");
            DonorRecepients rec4 = new DonorRecepients(0769685688, 9808260099285, "John", "stern", "John@gmail.com", "phase 5 Mamelodi Pretoria");
            DonorRecepients rec5 = new DonorRecepients(0639631691, 9803260000296, "jezz", "sira", "jezz@gmail.com", "130 alexandre Johannesburg");
            DonorRecepients rec6 = new DonorRecepients(0639631652, 9702260330282, "Jayne", "sita", "Jayne@gmail.com", "120 tlakong North west");
            DonorRecepients rec7 = new DonorRecepients(0649631644, 9606260910571, "alyne", "siya", "alyne@gmail.com", " 120 katlegong Gauteng");
            DonorRecepients rec8 = new DonorRecepients(0659631633, 9605260086256, "betty", "sitta", "betty@gmail.com", "180 william Brooklyn");



            recepients.Add(rec1);
            recepients.Add(rec2);
            recepients.Add(rec3);
            recepients.Add(rec4);
            recepients.Add(rec5);
            recepients.Add(rec6);
            recepients.Add(rec7);
            recepients.Add(rec8);

            return recepients;
        }
    }
}


