using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroLMSDeveloper.Domain
{
    //Класс "Дисциплина" 
    public class Discipline
    {
        public string   Name { get; set; }//Название дисциплины
        public Guid Id { get; set; }//Идентификатор дисциплины 
        public Lesson Lesson { get; set; }//Занятие (объект класса «Занятие»)
    }
}
