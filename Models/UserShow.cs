using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace GOT.Models
{
    public class UserShow
    {
        [Key]
        public int UserShowId{get;set;}

        public int UserId{get;set;}
        public User User{get;set;}
        public int ShowId{get;set;}
        public Show Show{get;set;}
    }
}