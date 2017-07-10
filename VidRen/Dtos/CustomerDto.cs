using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VidRen.Models;

namespace VidRen.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the customer's name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        // This is implicitly required as a byte is a not a nullable type
        public byte MembershipTypeId { get; set; }

        //[Min18IfAMember]
        public DateTime? Birthdate { get; set; }
    }
}