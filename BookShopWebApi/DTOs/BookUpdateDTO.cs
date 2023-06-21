namespace BookShopWebApi.DTOs
{
    public class BookUpdateDTO
    {
        public string? BookName { get; set; }
        public int YearOfCreation { get; set; }
        public string? Author { get; set; }
        public string? Izdat { get; set; }
    }
}
