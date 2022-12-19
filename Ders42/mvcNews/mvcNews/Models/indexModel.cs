using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcNews.Models
{
    public class indexModel
    {
        public List<Kategori> Kategoriler { get; set; }
        public List<Haber> Haberler { get; set; }
    }
}