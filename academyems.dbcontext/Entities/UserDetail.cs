﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace academyems.dbcontext.Entities
{
    [Table(name: "user_detail")]
    public class UserDetail : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("user_code")]
        public string UserCode { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [Column("identity_id")]
        public string IdentityId { get; set; }

        [Column("identity_type")]
        public string IdentityType { get; set; }

        [Column("mobile_no")]
        public int MobileNo { get; set; }

        [Column("email")]
        public string EMail { get; set; }

        //[ForeignKey("Address")]
        //[Column("address_id")]
        //public int AddressId { get; set; }

        [Column("hashed_password")]
        public string HashedPassword { get; set; }

        //public virtual Address Address { get; set; }
    }
}