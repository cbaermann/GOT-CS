using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GOT.Models
{
    public class DashboardViewModel
    {
        public List<Show> currentShow{get;set;}
        public User currentUser{get;set;}
        public UserShow UserShow{get;set;}
        public List<User> Hosts{get;set;}


    }
}