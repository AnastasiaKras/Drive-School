//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrivingSchool
{
    using System;
    using System.Collections.Generic;
    
    public partial class lessons
    {
        public int Id { get; set; }
        public string Категория { get; set; }
        public int Группа { get; set; }
        public string ФИО { get; set; }
        public string Инструктор { get; set; }
        public string Количество_часов_вождения { get; set; }
        public string Итоговая_сумма_за_занятия_по_вождению { get; set; }
    }
}
