using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateManagement.Models.Entities
{
    public class REMRole : IdentityRole
    {
        public virtual ICollection<REMUserRole> UserRoles { get; set; }
        public virtual ICollection<REMRoleClaim> RoleClaims { get; set; }
    }

    public class REMUserRole : IdentityUserRole<string>
    {
        public virtual REMUser User { get; set; }
        public virtual REMRole Role { get; set; }
    }

    public class REMUserClaim : IdentityUserClaim<string>
    {
        public virtual REMUser User { get; set; }
    }

    public class REMUserLogin : IdentityUserLogin<string>
    {
        public virtual REMUser User { get; set; }
    }

    public class REMRoleClaim : IdentityRoleClaim<string>
    {
        public virtual REMRole Role { get; set; }
    }

    public class REMUserToken : IdentityUserToken<string>
    {
        public virtual REMUser User { get; set; }
    }

    public class REMUser : IdentityUser
    {
        public virtual ICollection<REMUserClaim> Claims { get; set; }
        public virtual ICollection<REMUserLogin> Logins { get; set; }
        public virtual ICollection<REMUserToken> Tokens { get; set; }
        public virtual ICollection<REMUserRole> Role { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(255)]
        public string Address { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(100)]
        public string State { get; set; }

        [Required]
        [MaxLength(15)]
        public string ZipCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string Country { get; set; }
    }

    [Table("Owners")]
    public class Owner : REMUser
    {
        public ICollection<Property> Properties { get; set; }
    }

    [Table("Tenants")]
    public class Tenant : REMUser
    {
        [Required]
        public DateTime MoveInDate { get; set; }

        [Required]
        public DateTime MoveOutDate { get; set; }

        [Required]
        public string PropertyId { get; set; }

        [ForeignKey("PropertyId")]
        public Property Property { get; set; }

        public ICollection<Offer> Offers { get; set; }
        public ICollection<Lease> Leases { get; set; }
    }


    [Table("Agents")]
    public class Agent : REMUser
    {
        [Required]
        [MaxLength(100)]
        public string AgencyName { get; set; }

        [Required]
        [MaxLength(255)]
        public string AgencyAddress { get; set; }

        [Required]
        [MaxLength(100)]
        public string AgencyCity { get; set; }

        [Required]
        [MaxLength(100)]
        public string AgencyState { get; set; }

        [Required]
        [MaxLength(15)]
        public string AgencyZipCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string AgencyCountry { get; set; }

        public ICollection<Property> Properties { get; set; }
    }

    public enum PropertyType
    {
        Commercial = 1,
        Residential,
        Land
    }

    public enum ResidentialType
    {
        Apartment = 1,
        Villa,
        Townhouse,
        Condominium
    }

    [Table("Properties")]
    public class Property
    {
        public string Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int NumberOfBedrooms { get; set; }

        [Required]
        public int NumberOfBathrooms { get; set; }

        [Required]
        public int SquareFeet { get; set; }

        [Required]
        [MaxLength(255)]
        public string Address { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(100)]
        public string State { get; set; }

        [Required]
        [MaxLength(100)]
        public string Country { get; set; }

        [Required]
        [MaxLength(15)]
        public string PostalCode { get; set; }

        public PropertyType PropertyType { get; set; }

        public ICollection<Offer> Offers { get; set; }
        public ICollection<Lease> Leases { get; set; }
    }

    [Table("CommercialProperties")]
    public class CommercialProperty : Property
    {
        public string OfficeSpaceSquareFeet { get; set; }
    }

    [Table("ResidentialProperties")]
    public class ResidentialProperty : Property
    {
        public int NumberOfFloors { get; set; }
        public ResidentialType ResidentialType { get; set; }
    }

    [Table("LandProperties")]
    public class LandProperty : Property
    {
        public string LotSize { get; set; }
    }


    [Table("Offers")]
    public class Offer
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [Column("Amount")]
        public decimal Amount { get; set; }

        [Required]
        [Column("OfferDate")]
        public DateTime OfferDate { get; set; }
    }

    [Table("Leases")]
    public class Lease
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [Column("StartDate")]
        public DateTime StartDate { get; set; }

        [Required]
        [Column("EndDate")]
        public DateTime EndDate { get; set; }

        [Required]
        [Column("MonthlyRent")]
        public decimal MonthlyRent { get; set; }
    }

}
