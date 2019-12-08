using System;
using System.Collections.Generic;

namespace MyFirstBlazorApp.Client.Models.Vacancy
{
    public class VacancyData
    {
        public string Title { get; set; }
        public DateTime ClosingDate { get; set; }
        public Address Address { get; set; }

        public List<Application> Applications { get; set; }
    }
}
