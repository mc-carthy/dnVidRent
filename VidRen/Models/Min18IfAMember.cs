using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidRen.Models
{
    public class Min18IfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (
                customer.MembershipTypeId == MembershipType.Unknown || 
                customer.MembershipTypeId == MembershipType.PayAsYouGo
            )
            {
                return ValidationResult.Success;
            }

            if (customer.Birthdate == null)
            {
                return new ValidationResult("Birthdate is required for non-Pay As You Go memberships");
            }

            // TODO - This only calculates difference between current year and birth year, not an accurate age. Fine for now.
            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18) ? 
                ValidationResult.Success : 
                new ValidationResult("Customer must be over 18 for non-Pay As You Go membership");
        }
    }
}