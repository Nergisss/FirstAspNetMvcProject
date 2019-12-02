using System;

namespace OtoparkProje.Models
{
    public class TodoItem
    {

        public Guid Id{get;set;}
        public bool IsDone{get;set;}
        public string Title{get;set;}
        public DateTimeOffset? DueAt { get; set; }//soru işareti sayesinde null değer gelebilir demek


    }

}