using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Entities
{
    public class ClubCard
    {
        //static int clubCardId;
        [Key]
        public int NumCard { get; set; }
       // public Customer Customer { get; set; }
        public int NumPoint { get; set; }
        public DateTime DateOfJoin { get; set; }

        //static ClubCard()
        //{
        //    clubCardId = 1;
        //}
      
        //public ClubCard()
        //{
        //    NumCard = clubCardId++;
        //    NumPoint = 0;
        //    DateOfJoin = DateTime.Now;
        //}
    }
}

    

