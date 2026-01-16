using System.Net.Http.Json;

public class ApiService
{
    private readonly HttpClient _http;

    public ApiService()
    {
        _http = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:5001/api/")
        };
    }

    public async Task<List<Course>> GetCourses()
        => await _http.GetFromJsonAsync<List<Course>>("courses");

    public async Task AddCourse(Course course)
        => await _http.PostAsJsonAsync("courses", course);
}
