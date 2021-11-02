using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroLMSDeveloper.Domain
{
    /// <summary>
    /// Тип занятия
    /// </summary>
    ///<param name = "LaboratoryWork">Лабораторная работа</param>
    ///<param name = "PracticalLesson">Практическое занятие</param>
    ///<param name = "LaboratorPracticalModule">Лабораторно-практический модуль</param>
    ///<param name = "CourseWork">Курсовая работа</param>
    ///<param name = "CourseProject">Курсовой проект</param>
    public enum TypeLesson
    {
        LaboratoryWork,
        PracticalLesson,
        LaboratorPracticalModule,
        CourseWork,
        CourseProject

    }
    //Класс "Занятия"
    public class Lesson
    {
        //Скалярные свойства
        public Guid Id { get; set; }
        public TypeLesson TypeLesson { get; set; }
        public string Name { get; set; }
        public double LaborIntensity { get; set; }

        //Свойства навигации
        public List<ExerciseBlock> ExerciseBlocks { get; set; } = new List<ExerciseBlock>();
    }
}
