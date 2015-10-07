using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechProject.Data;
using TechProject.Data.Models;

namespace TechProject.HelperClass
{
    public class Helper
    {
        
        public Category Getcategory(string cat)
        {
            if (cat == ((Category)Category.OBC).ToString())
            {
                return Category.OBC;
            }
            else if (cat == ((Category)Category.SC).ToString())
            {
                return Category.SC;
            }
            else if (cat == ((Category)Category.ST).ToString())
            {
                return Category.ST;
            }
            return Category.UR;
        }
        
    }
}