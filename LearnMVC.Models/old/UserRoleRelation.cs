using System.ComponentModel.DataAnnotations;


namespace LearnMVC.Models
{
    public class UserRoleRelation
    {
        [Key]
        public int RelationID { get; set; }

        [Required()]
        public int UserID { get; set; }

        [Required()]
        public int RoleID { get; set; }
    }
}
