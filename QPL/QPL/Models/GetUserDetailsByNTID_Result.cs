//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QPL.Models
{
    using System;
    
    public partial class GetUserDetailsByNTID_Result
    {
        public int UserId { get; set; }
        public string NT_ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string DisplayName { get; set; }
        public string Domain { get; set; }
        public string Email { get; set; }
        public string Project { get; set; }
        public string Skills { get; set; }
        public string Hobbies { get; set; }
        public string PictureUrl { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; }
    }
}