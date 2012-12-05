using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Nancy.Demo.KnockoutJS.Model;
using Nancy.ModelBinding;

namespace Nancy.Demo.KnockoutJS.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = parameters => View["Index"];

            Get["/tasks"] = parameters => new[] { new { title = "Get Milk", isDone = false }, new { title = "Pick kids up", isDone = true } };

            Post["/tasks"] = parameters =>
                                 {
                                     
                                     var model = this.Bind<List<Task>>();
                                     //Update database

                                     return "Saved";
                                 };
        }
    }
}