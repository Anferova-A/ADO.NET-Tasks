using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public class Book
    {
        public Author Author { get; }
        public string Title { get; }
        public int Pages { get; }
        public string PublishingHouse { get; }
        public int DateOfPublic { get; }
        public int DateOfWrite { get; }

        public Book (Author author, string title, int pages, string publishinghouse, int dateofpublic, int dateodwrite)
        {
            if (title == string.Empty)
            {
                throw new ArgumentException("Название не может быть пустой строкой");
            }
            if (pages <= 0)
            {
                throw new ArgumentException("Страниц должно быть больше 0");
            }
            if (publishinghouse == string.Empty)
            {
                throw new ArgumentException("Издательство не может быть пустой строкой");
            }
            if (dateofpublic <= 0)
            {
                throw new ArgumentException("Дата публикации не может быть меньше 0");
            }
            if (dateodwrite <= 0)
            {
                throw new ArgumentException("Дата написания не может быть меньше 0");
            }
            Author = author;
            Title = title;
            Pages = pages;
            PublishingHouse = publishinghouse;
            DateOfPublic = dateofpublic;
            DateOfWrite = dateodwrite;
        }

        public override string ToString()
            => string.Format($"Автор: {Author}; {Title}, {Pages}, {PublishingHouse}, {DateOfPublic}, {DateOfWrite}");
        
    }
}
