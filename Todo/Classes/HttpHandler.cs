using System.Text;

namespace Todo.Classes;

public class HttpHandler
{
    private readonly HttpClient _httpClient = new();

    public async Task<string> GetAsync(string url)
    {
        try
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode(); // Throws an exception if the status code is not a success code (2xx)
            return await response.Content.ReadAsStringAsync();
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"HTTP GET request failed: {ex.Message}");
            throw; // Re-throw the exception for the caller to handle
        }
    }

    public async Task<string> PostAsync(string url, string content)
    {
        try
        {
            var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, httpContent);
            response.EnsureSuccessStatusCode(); // Throws an exception if the status code is not a success code (2xx)
            return await response.Content.ReadAsStringAsync();
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"HTTP POST request failed: {ex.Message}");
            throw; // Re-throw the exception for the caller to handle
        }
    }
}