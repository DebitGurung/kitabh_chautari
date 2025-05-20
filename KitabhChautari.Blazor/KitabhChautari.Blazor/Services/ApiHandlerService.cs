namespace KitabhChautari.Blazor.Services
{
    public class ApiHandlerService
    {
        private readonly HttpClient _http;
        private readonly List<KitabhChautari.Blazor.Models.AuthorDto> _authors = new();

        public ApiHandlerService(HttpClient httpClient)
        {
            _http = httpClient;
        }

        public async Task<KitabhChautari.Blazor.Models.AuthorDto?> AddAuthorAsync(KitabhChautari.Blazor.Models.AuthorDto author)
        {
            try
            {
                var response = await _http.PostAsJsonAsync("api/authors", author);
                response.EnsureSuccessStatusCode();
                var createdAuthor = await response.Content.ReadFromJsonAsync<KitabhChautari.Blazor.Models.AuthorDto>();
                if (createdAuthor != null)
                {
                    _authors.Add(createdAuthor);
                }
                return createdAuthor;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Failed to add author.", ex);
            }
        }
    }
}