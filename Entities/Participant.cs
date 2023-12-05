using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Entities
{
    public class Participant
    {
        public Guid Id {set; get;}
        public string? FirstName{set; get;}
        public string? LastName {set; get;}
        public string? Email {set; get;}
    }
}