/************************************************************************ 
 * Projt Name  :  LearnMVC.Models       
 * File Name   :  User 
 * Version     :  v1.0.0.0       
 * Author 	   :  TradeSupport2 
 * Create Time :  5/6/2016 2:25:01 PM 
 * Update Time :  5/6/2016 2:25:01 PM 
 * Summary     :
************************************************************************ 
 * Copyright @ Zhuwei Wu 2016. All rights reserved. 
************************************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace LearnMVC.Models
{
    
    public class User
    {
        [Key]
        public int UserID { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Length must be {1} to {0}")]
        [Required(ErrorMessage = "Required")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        /// <summary>
        /// Group ID
        /// </summary>
        [Required(ErrorMessage = "Required")]
        [Display(Name = "GroupID")]
        public int GroupID { get; set; }

        /// <summary>
        /// Display Name
        /// </summary>
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Length must be {1} to {0}")]
        [Required(ErrorMessage = "Required")]
        [Display(Name = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Password")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        /// 用户状态<br />
        /// 0正常，1锁定，2未通过邮件验证，3未通过管理员
        /// </summary>
        public int Status { get; set; }


        /// <summary>
        /// Registration Time
        /// </summary>
        public DateTime RegistrationTime { get; set; }


        /// <summary>
        /// Login Time
        /// </summary>
        public DateTime LoginTime { get; set; }


        /// <summary>
        /// Login IP
        /// </summary>
        public string LoginIP { get; set; }


        /// <summary>
        /// Group
        /// </summary>
        public virtual UserGroup Group { get; set; }

    }
}
