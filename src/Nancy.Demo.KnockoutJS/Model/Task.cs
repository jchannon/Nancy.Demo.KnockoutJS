using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nancy.Demo.KnockoutJS.Model
{
    public class Task
    {
        public string Title { get; set; }

        public bool IsDone { get; set; }

        public bool _Destroy { get; set; }
    }
}