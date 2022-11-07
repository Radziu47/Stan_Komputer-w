using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Policy;
using System.Windows;
using System.Windows.Documents;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Stan_Komputerów
{
    public class Cutting
    {
        public static async void GetLoginData()
        {
            // ReSharper disable once HeapView.ClosureAllocation
            List<User> model = null;

            var client = new HttpClient();
            var url = "http://localhost/ComputerStatusIPI/Users.php";
            
            try
            {
                var RespondMess = await client.GetAsync(url);
            
                
                string jsonRespond = await RespondMess.Content.ReadAsStringAsync();

                string[] array = jsonRespond.Split('{');

                List<string> array2 = new List<string>();

                for (int i = 0; i < array.Length; i++)
                {
                    var arr = array[i].Split(']');

                    for (int j = 0; j < arr.Length; j++)
                    {
                        array2.Add(arr[j]);
                    }
                }

                for (int i = 2; i < array2.Count-1; i++)
                {
                    Cutting2.Cutting(array2[i]);

                }
            }
            catch (Exception eror)
            {
                MessageBox.Show(eror.ToString());
                throw;
            }


        }
    }

    public class User
    {
        public string login { get; set; }
        public string pass { get; set; }
        public string IsRootOrNot { get; set; }
    }
}