namespace Solve_Task
{
    internal class Program
    {
        public static Book TraceBook(Book book)
        {
            return book;
        }
        static void Main(string[] args)
        {
            Book book = new Book("978-0-596-52068-9", "Title01",new string[]{ "Mahmoud","Ahmed"},new DateTime(2004,8,7),2000);
            Book book01 = new Book("333-1-596-5555-3", "Title02", new string[]{ "Amr"},new DateTime(2010,3,7),2000);
            Book book02 = new Book("345-3-765-8987-7", "Title03", new string[]{ "Yasser","Mohamed"},new DateTime(1998,8,6),50000);
            Book book03 = new Book("2345-77-183-62074-7", "Title04", new string[]{ "May","Yousef"},new DateTime(2004,8,7),6000);

            List<Book> books = [book, book01, book02, book03];

            LibraryEngine.ProcessBooks(books, TraceBook);
           
        }
    }
}
