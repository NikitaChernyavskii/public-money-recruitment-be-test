﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace VacationRental.Api.Models
{
    [ExcludeFromCodeCoverage]
    public class CalendarViewModel
    {
        public int RentalId { get; set; }
        public List<CalendarDateViewModel> Dates { get; set; }
    }
}
