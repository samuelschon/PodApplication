using Data.Services;
using SharedModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Controllers
{
    public class CategoryController
    {

        private SerializerService serializer = new SerializerService();

        public void CreateCategory(string name) {

            Category category = new Category(name);
            serializer.SerializeCategory(category);            
        
        }

        public void DeleteCategory(string categoryName) {

            List<Category> currentCategories = serializer.DeserializeCategory();

             currentCategories.RemoveAll(x => x.Name == categoryName);

            serializer.DeleteAllCategories();

            foreach  (Category category in currentCategories)
            {
                serializer.SerializeCategory(category);
            }
        
        }

        public List<Category> GetCategories() {

           return serializer.DeserializeCategory();
        
        
        }

    }
}
