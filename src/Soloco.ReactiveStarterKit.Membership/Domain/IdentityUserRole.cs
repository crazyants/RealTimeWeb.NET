using System;

namespace Soloco.ReactiveStarterKit.Membership.Models
{
    public class IdentityUserRole
    {
        public virtual Guid UserId { get; set; }
        public virtual Guid RoleId { get; set; }
    }
}