/************************************************************************ 
 * Projt Name  :  LearnMVC.Models       
 * File Name   :  UserGroup 
 * Version     :  v1.0.0.0       
 * Author 	   :  TradeSupport2 
 * Create Time :  5/6/2016 2:28:43 PM 
 * Update Time :  5/6/2016 2:28:43 PM 
 * Summary     :
************************************************************************ 
 * Copyright @ Zhuwei Wu 2016. All rights reserved. 
************************************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace LearnMVC.Models
{
    public class UserGroup
    {
        [Key]
        public int GroupID { get; set; }

        /// <summary>
        /// Group Name
        /// </summary>
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Length must be {1} to {0}")]
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Name")]
        public string Name { get; set; }


        /// <summary>
        /// 用户组类型<br />
        /// 0普通类型（普通注册用户），1特权类型（像VIP之类的类型），3管理类型（管理权限的类型）
        /// </summary>
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Group Type")]
        public int GroupType { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [Required(ErrorMessage = "Required")]
        [StringLength(50, ErrorMessage = "Less {0} Characters")]
        [Display(Name = "说明")]
        public string Description { get; set; }

    }
}
