using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroLMSDeveloper.Domain
{
    //Класс «Вариант задания»
    public class VariantExercise
    {
        public Guid Id { get; set; }//Идентификатор

        public int Number { get; set; }//Номер варианта
        public double CoefficientComplexity { get; set; }//Коэффициент трудности

        public LinkContent LinkContent { get; set; }//Контент

        public Exercise Exercise { get; set; }//Контент

    }
}
