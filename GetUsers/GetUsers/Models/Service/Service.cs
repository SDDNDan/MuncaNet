using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetUsers.Entities;
using System.Net.Http;
using Newtonsoft.Json;

namespace GetUsers.Models
{
    public class Service : IService
    {
        public Users Context;
        public string result;
        public Service(Users context)
        {
            this.Context = context;
        }

        public string GetUsers()
        {
            return "Carapace";
        }

        public void Initialization()
        {

           
            this.Context.SaveChanges();
            
        }

        async void GetData()
        {
            //We will make a GET request to a really cool website...

            string baseUrl = "https://jsonplaceholder.typicode.com/users";
            //The 'using' will help to prevent memory leaks.
            //Create a new instance of HttpClient
            using (HttpClient client = new HttpClient())
            {

                ////Setting up the response...         
                try
                {
                    HttpResponseMessage res = client.GetAsync(baseUrl).Result;

                    HttpContent content = res.Content;
                        
                    string data = content.ReadAsStringAsync().Result;

                    if (data != null)
                    {
                        this.result = data;
                    }
                    else
                    {
                        this.result = "Imi pare rau";
                    }
                        
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }       
            }

            ////var httpclient = new HttpClient();
            
            ////var response = httpclient.GetAsync(baseUrl).Result;
            
            ////return await response.Content.ReadAsStringAsync();
        }
       
        public void GetUsersApi()
        {
            GetData();
        }
    }
}
