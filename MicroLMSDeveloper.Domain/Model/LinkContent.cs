using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroLMSDeveloper.Domain
{
    /// <summary>
    /// Тип
    /// </summary>
    ///<param name = "Book">Книга</param>
    ///<param name = "Document">Документ</param>
    ///<param name = "File">Файл</param>
    ///<param name = "Image">Изображение</param>
    ///<param name = "Video">Видео  </param>
    public enum Type
    {
        Book,
        Document,
        File,
        Image,
        Video
    }
    //Класс "Ссылка на контент"
    public class LinkContent
    {
        public Guid Id { get; set; }//Идентификатор документа в MicroCMS
        public Uri Url { get; set; }//URL микросервиса
        public Type Type { get; set; }//Тип 
    }
}
