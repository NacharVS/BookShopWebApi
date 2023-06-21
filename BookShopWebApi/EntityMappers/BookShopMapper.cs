using AutoMapper;
using BookShopWebApi.DTOs;
using Core;

namespace BookShopWebApi.EntityMappers
{
    public class BookShopMapper : Profile
    {
        public BookShopMapper()
        {
            CreateMap<Book, BookReadDTO>().ReverseMap();
            CreateMap<Book, BookUpdateDTO>().ReverseMap();
        }
    }
}
