using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SequenceGenerator.ViewModels
{
    public class ListsViewModel
    {
        public int Id { get; set; }
        public List<int> numbers { get; set; }
        public List<int> oddNumber { get; set; }
        public List<int> evenNumber { get; set; }

        public List<string> replacedNumber { get; set; }
        public List<int> Fibonacci { get; set; }
    }
}