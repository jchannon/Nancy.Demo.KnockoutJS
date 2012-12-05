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

            Get["/tasks"] = parameters =>
                                {
                                    //Get data from database
                                    var model = new[]
                                               {
                                                   new Task {Title = "Get Milk", IsDone = false},
                                                   new Task {Title = "Pick kids up", IsDone = true}
                                               };

                                    return model;
                                };

            Post["/tasks"] = parameters =>
                                 {
                                     //Bind posted data
                                     var model = this.Bind<List<Task>>();

                                     //Update database

                                     return "Saved";
                                 };
        }
    }
}