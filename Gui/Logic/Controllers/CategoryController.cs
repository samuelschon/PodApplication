using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Models;

namespace Logic.Controllers
{
  public class CategoryController
    {
        public void CreateCategory(string inName)
        {
            new Category(inName);
            //Lägg till XML-Sparning. 
        }

        public void DeleteCategory(string inName)
        {
            //Lägg till Delete.
        }

        public void EditCategory(string inName)
        {
            // Lägg till Edit.
        }
    }
}
