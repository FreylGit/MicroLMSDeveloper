using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroLMSDeveloper.Domain
{
    //Класс «Блок заданий»

    public enum TypeTask
    {
        Experiment,
        Test,
        IndividualTask
    }
    public enum SubtypeTask
    {
        Allowable,
        Defense,
        FixingMaterial
    }
    public class ExerciseBlock
    {
        public Guid Id { get; set; }//Идентификатор

        public Guid LessonId { get; set; }
        public Lesson Lesson { get; set; }

        public TypeTask TypeTask { get; set; }//Тип 
        public SubtypeTask SubtypeTask { get; set; }//Подтип
        public string MethodicalInstructions { get; set; } = "";//Общие методические указания

        public LinkContent LinkContent { get; set; }//Контент (объект класса «Ссылка на контент»)

        public List<Exercise> Exercises { get; set; } = new List<Exercise>();//коллекция объектов класса «Здание»
    }
}
