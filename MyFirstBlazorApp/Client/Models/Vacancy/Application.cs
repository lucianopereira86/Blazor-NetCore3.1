using System;

namespace MyFirstBlazorApp.Client.Models.Vacancy
{
    public class Application
    {
        public DateTime Date { get; set; }
        public string Text { get; set; }

        public  Candidate Candidate { get; set; }
    }
}
