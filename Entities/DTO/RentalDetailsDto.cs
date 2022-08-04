using System;
using Core.Entities;

namespace Entities.DTO {
    public class RentalDetailsDto : IEntity {
        public string CarName { get; set; }
        public string  CustomerName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}