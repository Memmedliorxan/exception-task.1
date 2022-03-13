namespace EXCEPTION_task1.Services
{
    internal class BookNotFoundException
    {
        private string v;

        public BookNotFoundException(string v)
        {
            this.v = v;
        }

        public BookNotFoundException(string v, BookNotFoundException bookNotFoundException)
        {
            this.v = v;
        }
    }
}