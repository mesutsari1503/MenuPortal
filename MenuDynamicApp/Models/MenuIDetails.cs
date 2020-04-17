using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenuDynamicApp.Models
{
    public class MenuIDetails
    {
        private string name;

        public string Name   
        {
            get { return name; }   
            set { name = value; }     
        }
        private string link;

        public string Link
        {
            get { return link; }
            set { link = value; }
        }
      
    }
}