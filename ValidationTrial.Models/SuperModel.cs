using System;
using System.Collections.Generic;

namespace ValidationTrial.Models
{
    //https://www.vogue.com/article/the-top-models-fall-2018-collections
    public class SuperModel
    {
        public string ModelName { get; set; }

        public string Hometown { get; set; }

        public List<string> Designers { get; set; }
    }
}
