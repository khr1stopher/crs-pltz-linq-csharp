public class LinqQueries {
    private List<Book> booksCollection = new List<Book>();
    public LinqQueries () {
        using(StreamReader reader = new StreamReader("Books.json")) {
            string json = reader.ReadToEnd();
            this.booksCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() {
                PropertyNameCaseInsensitive = true
            });
        }
    }

    public IEnumerable<Book> GetAllCollection() {
        return booksCollection;
    }

}