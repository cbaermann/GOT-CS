using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace GOT.Models
{
    public class ViewShowViewModel
    {
        public List<Show> showList{get;set;}
        public Show thisShow{get;set;}
        public List<User> Users{get;set;}
        public UserShow UserShow{get;set;}
        public User thisUser{get;set;}

    }
}