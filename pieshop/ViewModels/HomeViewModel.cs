using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pieshop.Models;

namespace pieshop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
