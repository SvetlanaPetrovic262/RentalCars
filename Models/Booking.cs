﻿namespace RentalCars.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int CardId { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
