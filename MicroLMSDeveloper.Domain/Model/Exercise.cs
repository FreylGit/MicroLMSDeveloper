using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroLMSDeveloper.Domain
{
    //Класс «Задание»
    public class Exercise
    {
        public Guid Id { get; set; }//Идентификатор
        public TypeTask TypeTask { get;set; }//Тип (эксперимент (групповое задание), тест, индивидуальное задание)
        public int Number { get; set; }//Номер задания

        public double CoefficientComplexity { get; set; }//Коэффициент трудности

        public ExerciseBlock ExerciseBlock { get; set; }//Блок заданий (объект класса «Блок заданий»)

        public LinkContent LinkContent { get; set; }//Контент (объект класса «Ссылка на контент»)


    }
}
