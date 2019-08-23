using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace GOT.Models
{
    public class NewShowViewModel
    {
        public Show newShow{get;set;}
        public UserShow UserShow{get;set;}

    }
}