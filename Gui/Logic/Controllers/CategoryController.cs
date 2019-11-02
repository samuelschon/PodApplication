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

        public void CreateCategory(string name) 
        {
            Category category = new Category(name);
            serializer.SerializeCategory(category);                   
        }

        public void DeleteCategory(string categoryName) 
        {
            List<Category> currentCategories = serializer.DeserializeCategory(); 
            /*##########Borde brytas ut i en egen metod############### */

             currentCategories.RemoveAll(x => x.Name == categoryName);

            serializer.DeleteAllCategories();
            /*##########Borde brytas ut i en egen metod############### */

            foreach (Category category in currentCategories)
            {
                serializer.SerializeCategory(category);
            }       
        }

        public void EditCategory(string oldName, string newName)
        {
            DeleteCategory(oldName);
            CreateCategory(newName);

            List<Feed> feedList = serializer.Deserialize();

            foreach (Feed feed in feedList)
            {
                if (feed.Category == oldName) {

                    feed.Category = newName;
                
                }
            }

            serializer.SerializeList(feedList);
            

            
        }

        public List<Category> GetCategories() 
        {
           return serializer.DeserializeCategory();
        }

        public List<Feed> GetFeeds() {

            return serializer.Deserialize();
        
        }

        public bool DoesCategoryExist(string categoryName) 
        {
            bool exists = false;

            foreach (Category category in GetCategories())
            {
                if (category.Name == categoryName) {

                    exists = true;
                    break;
                
                }
            }
            return exists;            
        }

    }
}
