//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BotInstagram.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string DeviceID { get; set; }
        public Nullable<bool> IsBuy { get; set; }
        public Nullable<bool> IsVerify { get; set; }
        public string VerifyCode { get; set; }
        public Nullable<System.DateTime> LoginDate { get; set; }
    }
}
