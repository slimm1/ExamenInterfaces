using ExamenInterfaces.model;
using ExamenInterfaces.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ExamenInterfaces.http
{
    internal class ApiLoader
    {
        public static async Task<int> DoSomethingAsync(string fileA, string fileB)
        {
            MyFiles files = new MyFiles(fileA,fileB);
            // Simulamos una operación que lleva tiempo (por ejemplo, una solicitud HTTP)
            using (HttpClient httpClient = new HttpClient())
            {
                var result = await httpClient.PostAsJsonAsync(AppConstants.API_PATH,files);
                var data = await result.Content.ReadFromJsonAsync<int>();
                return data;
            }
        }
    }
}
