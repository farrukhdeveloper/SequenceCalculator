using SequenceGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using SequenceGenerator.ViewModels;

namespace SequenceGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult GenerateSequence()
        {
            return View();
        }

        [HttpPost]
        public ActionResult processSequence(sequenceModel seq)
        {
            var viewModel = new ListsViewModel();
            try
            {
                if (ModelState.IsValid)
                {
                    Utility ut = new Utility();
                        var numbers = ut.getNumbers(seq.limitValue);
                        var even = ut.getEvenSequence(seq.limitValue);
                        var odd = ut.getOddSequence(seq.limitValue);
                        var replaced = ut.getReplacedSequence(seq.limitValue);
                        var fab = ut.getFibonacciSequence(seq.limitValue) ;

                         viewModel = new ListsViewModel()
                         {
                             numbers = numbers,
                             oddNumber = odd,
                             evenNumber = even,
                             replacedNumber = replaced,
                             Fibonacci = fab

                         };
                        List<ListsViewModel> viewModelList = new List<ListsViewModel>();
                        viewModelList.Add(viewModel);
                        return View(viewModelList);

                }
            }
            catch (Exception ex)
            {
                return View("Error");
               
            }
            return View("Error");
            

        }



    }
}