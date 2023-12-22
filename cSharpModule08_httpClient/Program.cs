using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HttpClientExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            #region HTTPGet
            //using (HttpClient httpClient = new HttpClient())
            //{
            //    string apiUrl = "https://jsonplaceholder.typicode.com/posts/1"; // Example API endpoint



            //    try
            //    {
            //        HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

            //        if (response.IsSuccessStatusCode)
            //        {
            //            string jsonResponse = await response.Content.ReadAsStringAsync();

            //            // Deserialize the JSON response using Newtonsoft.Json
            //            PostData post = JsonConvert.DeserializeObject<PostData>(jsonResponse);

            //            // Display the parsed data
            //            Console.WriteLine($"Post ID: {post.Id}");
            //            Console.WriteLine($"Title: {post.Title}");
            //            Console.WriteLine($"Body: {post.Body}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"HTTP Request Error: {response.StatusCode}");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"An error occurred: {ex.Message}");
            //    }
            //}
            #endregion

            #region HTTPPost

            //using (HttpClient httpClient = new HttpClient())
            //{
            //    string apiUrl = "https://jsonplaceholder.typicode.com/posts"; // JSONPlaceholder API endpoint for posts

            //    try
            //    {
            //        // Create a sample post data object
            //        PostData post = new PostData
            //        {
            //            Id = 1,
            //            Title = "Sample Title new",
            //            Body = "This is a sample body."
            //        };

            //        // Serialize the object to JSON
            //        string jsonPostData = JsonConvert.SerializeObject(post);

            //        // Create a StringContent with JSON data
            //        StringContent content = new StringContent(jsonPostData, Encoding.UTF8, "application/json");

            //        HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);

            //        if (response.IsSuccessStatusCode)
            //        {
            //            string jsonResponse = await response.Content.ReadAsStringAsync();
            //            Console.WriteLine($"Response: {jsonResponse}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"HTTP Request Error: {response.StatusCode}");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"An error occurred: {ex.Message}");
            //    }
            //}

            #endregion

            #region HttpHandler


            //HttpClientHandler handler = new HttpClientHandler
            //{
            //    UseProxy = false, // Disable using a proxy
            //    UseCookies = false, // Disable handling cookies
            //    AllowAutoRedirect = false,
            //    Credentials= new NetworkCredential("username","password")

            //    // You can set other properties like ClientCertificateOptions, AutomaticDecompression, etc.
            //};



            //using (HttpClient httpClient = new HttpClient(handler))
            //{
            //    string apiUrl = "https://jsonplaceholder.typicode.com/posts"; // JSONPlaceholder API endpoint for posts



            //    try
            //    {




            //        // Create a sample post data object
            //        PostData post = new PostData
            //        {
            //            Id = 1,
            //            Title = "Sample Title new",
            //            Body = "This is a sample body."
            //        };

            //        // Serialize the object to JSON
            //        string jsonPostData = JsonConvert.SerializeObject(post);

            //        // Create a StringContent with JSON data
            //        StringContent content = new StringContent(jsonPostData, Encoding.UTF8, "application/json");

            //        HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);

            //        if (response.IsSuccessStatusCode)
            //        {
            //            string jsonResponse = await response.Content.ReadAsStringAsync();
            //            Console.WriteLine($"Response: {jsonResponse}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"HTTP Request Error: {response.StatusCode}");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"An error occurred: {ex.Message}");
            //    }
            //}


            #endregion

            #region HttpAuth

        //    using (HttpClient httpClient = new HttpClient())
        //    {
        //        string apiUrl = "https://webapp1731977.azurewebsites.net/api/v1/Product/1"; // GitHub API endpoint for user information
        //        string bearerToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJyZWFkZXJAZXhhbXBsZS5jb20iLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJSZWFkZXIiLCJleHAiOjE3MDMyMzg5ODksImlzcyI6Imh0dHBzOi8vbG9jYWxob3N0OjcyMjUvIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NzIyNS8ifQ.Wv0WjnD9QpFNdI9YsUxlpL1ZSzK3b2643qFZqhniPUA"; // Replace with your actual personal access token

        //        //  Set the Bearer token in the Authorization header
        //        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
        //        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));

        //        try
        //        {
        //            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

        //            if (response.IsSuccessStatusCode)
        //            {
        //                string jsonResponse = await response.Content.ReadAsStringAsync();

        //                // Deserialize the JSON response using Newtonsoft.Json
        //                Product product = JsonConvert.DeserializeObject<Product>(jsonResponse);

        //                // Display the parsed data
        //                Console.WriteLine($"Post ID: {product.Id}");
        //                Console.WriteLine($"Title: {product.Name}");
        //                Console.WriteLine($"Des: {product.Description}");
        //                Console.WriteLine($"Price: {product.Price}");
        //                Console.WriteLine($"ImageUrl: {product.ImageUrl}");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"HTTP Request Error: {response.StatusCode}");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"An error occurred: {ex.Message}");
        //        }
        //    }
        //}


        #endregion




    }



    public class PostData
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public int Price { get; set; }

        public string? ImageUrl { get; set; }
    }


}