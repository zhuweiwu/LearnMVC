using System.ComponentModel.DataAnnotations;

namespace LearnMVC.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }


        [Required(ErrorMessage = "Required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "{1} to {0} charaters")]
        [Display(Name = "Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Requied")]
        [Display(Name = "User Type")]
        public int Type { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(50, ErrorMessage = "Less {0} characters")]
        [Display(Name = "Description")]
        public string Description { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string TypeToString()
        {
            switch (Type)
            {
                case 0:
                    return "Normal";
                case 1:
                    return "Vip";
                case 2:
                    return "Administrator";
                default:
                    return "Unknow";
            }
        }
    }
}
