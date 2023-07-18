LinqQueries queries = new LinqQueries();

printValues(queries.GetAllCollection());

void printValues(IEnumerable<Book> BooksList) {
    Console.WriteLine("{0, -59} {1, 10} {2, 15}", "Titulo", "N. Paginas", "Fecha Publicacion");
    foreach (var book in BooksList) {
        Console.WriteLine("{0, -59} {1, 10} {2, 15}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
    }
}
