using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWebApp_DAL.Model
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [Required]
        public string Salutation { get; set; }
        
        public List<string> SalutationList { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Required]
        public string SSN { get; set; }
        [Required]
        [Display(Name = "Street Address")]
        [DataType(DataType.MultilineText)]
        public string AddressLine1 { get; set; }
        [Required]
        [Display(Name = "Apt/Fl No.")]
        public string AddressLine2 { get; set;}
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public List<string> StateList { get; set; }

        
        public string ZipCode { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        
    }




}
