﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharedModels.Models;
using Newtonsoft.Json.Linq;

namespace Data.Services
{
    public class SerializerService
    {
        public string categoryPath = Environment.CurrentDirectory + "\\categories.json";
     
        public void Serialize(string path, Feed inObject)
        {
            List<Feed> listOfExistingItems = new List<Feed>();
           
            //Om filen finns läser vi ut den och lägger till den fil man vill lägg till och skriver över det befintliga som var där innan.
            if (File.Exists(path))
            {
                listOfExistingItems = Deserialize(path);
                listOfExistingItems.Add(inObject);


                var serializer = CreateSerializer();

                using (var sw = new StreamWriter(path))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(jw, listOfExistingItems);

                    }
                }

            }

            //annars skapar vi en ny fil och lägger till detta objekt i listan som är deklarerad högst upp i metoden(listOFExistingItems)
            else
            {
                using (var sw = new StreamWriter(path))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        var serializer = CreateSerializer();
                        listOfExistingItems.Add(inObject);
                        serializer.Serialize(jw, listOfExistingItems);

                    }
                }
            }
        }


        public void SerializeList(string path, List<Feed> inListFeeds)
        {
           

            //Om filen finns läser vi ut den och lägger till den fil man vill lägg till och skriver över det befintliga som var där innan.
            if (File.Exists(path))
            {
               
   
                var serializer = CreateSerializer();

                using (var sw = new StreamWriter(path))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(jw, inListFeeds);

                    }
                }

            }

            //annars skapar vi en ny fil och lägger till detta objekt i listan som är deklarerad högst upp i metoden(listOFExistingItems)
            else
            {
                using (var sw = new StreamWriter(path))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        var serializer = CreateSerializer();
                      
                        serializer.Serialize(jw, inListFeeds);

                    }
                }
            }
        }





        public void SerializeCategory(Category category) {

            var serializer = CreateSerializer();
            List<Category> categories = new List<Category>();

            if (File.Exists(categoryPath)) {

                categories = DeserializeCategory();
            
            }

            categories.Add(category);

                using (var sw = new StreamWriter(categoryPath))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(jw, categories);

                    }
                
            }

        }



        public List<Feed> Deserialize(string path)
        {
            List<Feed> feeez = new List<Feed>();
            if (File.Exists(path))
            {
                //Läser Json - Text
                var json = System.IO.File.ReadAllText(path);

                //Lägger json i en lista.
               feeez = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Feed>>(json);
          
            }

            return feeez;
        }

        public List<Category> DeserializeCategory()
        {

            List<Category> categories = new List<Category>();

            if (File.Exists(categoryPath))
            {
                //Läser Json - Text
                var json = System.IO.File.ReadAllText(categoryPath);

                //Lägger json i en lista.
                categories = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Category>>(json);

            }


            return categories;

        }

        
        public void DeleteAllCategories() {

            if (File.Exists(categoryPath)) { 
            
                File.Delete(categoryPath);
            
            }
        
        }

        private JsonSerializer CreateSerializer()
        {
            return new JsonSerializer
            {
                TypeNameHandling = TypeNameHandling.All
            };
        }



    }
}
