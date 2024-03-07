using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
    }

    public class Owner : REMUser
    {
        public ICollection<Property> Properties { get; set; }
    }

    public class Tenant : REMUser
    {
        public DateTime MoveInDate { get; set; }
        public DateTime MoveOutDate { get; set; }
    }

    public class Agent : REMUser
    {
        public string AgencyName { get; set; }
        public string AgencyAddress { get; set; }
        public string AgencyCity { get; set; }
        public string AgencyState { get; set; }
        public string AgencyZipCode { get; set; }
        public string AgencyCountry { get; set; }
    }
}
