using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Identity { get; set; }
        public string Name { get; set; }
        public string? Phone { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public DateTime? Birthday { get; set; }
        public ClubCard? ClubCard { get; set; }
    }
}
