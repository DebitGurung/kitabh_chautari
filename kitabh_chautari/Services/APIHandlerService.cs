using System.Net.Http.Json;

public class ApiHandlerService
{
    private readonly HttpClient _http;
    public List<Book> Books { get; private set; } = new();

    public ApiHandlerService(HttpClient http)
    {
        _http = http;
    }

    // GET all books
    public async Task LoadBooks()
    {
        Books = await _http.GetFromJsonAsync<List<Book>>("api/books") ?? new();
    }

    // GET single book
    public async Task<Book?> GetBook(int id)
    {
        return await _http.GetFromJsonAsync<Book>($"api/books/{id}");
    }

    // POST (Add) new book
    public async Task AddBook(Book book)
    {
        var response = await _http.PostAsJsonAsync("api/books", book);
        // Optional: Handle response status
        if (response.IsSuccessStatusCode)
        {
            await LoadBooks(); // Refresh list
        }
    }

    // PUT (Update) existing book
    public async Task UpdateBook(Book book)
    {
        var response = await _http.PutAsJsonAsync($"api/books/{book.Id}", book);
        if (response.IsSuccessStatusCode)
        {
            await LoadBooks(); // Refresh list
        }
    }

    // DELETE book
    public async Task DeleteBook(int id)
    {
        var response = await _http.DeleteAsync($"api/books/{id}");
        if (response.IsSuccessStatusCode)
        {
            await LoadBooks(); // Refresh list
        }
    }

    // Search books (example endpoint)
    public async Task<List<Book>> SearchBooks(string query)
    {
        return await _http.GetFromJsonAsync<List<Book>>($"api/books/search?q={query}") ?? new();
    }

    // In ApiHandlerService.cs
    public async Task<List<Book>> GetBestSellers()
    {
        return await _http.GetFromJsonAsync<List<Book>>("api/books/bestsellers") ?? new();
    }

    public async Task<List<Book>> GetFeaturedBooks()
    {
        return await _http.GetFromJsonAsync<List<Book>>("api/books/featured") ?? new();
    }
}