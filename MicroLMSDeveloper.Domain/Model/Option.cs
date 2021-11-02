using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroLMSDeveloper.Domain
{
    public enum TypeOption
    {
        EnterForm,
        DownloadFile,
        DownloadImage,
        DownloadVideo
    }
    //Класс «Опция»
    public class Option
    {
        public Guid Id { get; set; }//Идентификатор
        public int Number { get; set; }//Номер опции 

        public TypeOption TypeOption { get; set; }//Тип опции 
        public string Description { get; set; }//Описание

        public int Format { get; set; }//Формат 
        public Exercise Exercise { get; set; }//Задание 

    }
}
