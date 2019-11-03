using Data.Services;
using SharedModels.Models;
using System.Collections.Generic;

namespace Logic.Controllers
{
    public class CategoryController
    {
        private SerializerService serializer = new SerializerService();

        private List<Category> currentCategories;
        private List<Feed> currentFeeds;

        public void CreateCategory(string name) 
        {
            Category category = new Category(name);
            serializer.SerializeCategory(category);                   
        }

        public void DeleteCategory(string categoryName) 
        {
            currentCategories = serializer.DeserializeCategory(); 
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

            currentFeeds = serializer.Deserialize();

            foreach (Feed feed in currentFeeds)
            {
                if (feed.Category == oldName) {

                    feed.Category = newName;
                
                }
            }

            serializer.SerializeList(currentFeeds);
            

            
        }

        public List<Category> GetCategories() 
        {
           return serializer.DeserializeCategory();
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
