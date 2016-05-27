/************************************************************************ 
 * Projt Name  :  LearnMVC.Models       
 * File Name   :  UserConfig 
 * Version     :  v1.0.0.0       
 * Author 	   :  TradeSupport2 
 * Create Time :  5/6/2016 2:30:17 PM 
 * Update Time :  5/6/2016 2:30:17 PM 
 * Summary     :
************************************************************************ 
 * Copyright @ Zhuwei Wu 2016. All rights reserved. 
************************************************************************/
using System;
using System.ComponentModel.DataAnnotations;


namespace LearnMVC.Models
{
    public class UserConfig
    {
        [Key]
        public int ConfigID { get; set; }

        /// <summary>
        /// 启用注册
        /// </summary>
        [Display(Name = "Enable Register")]
        [Required(ErrorMessage = "Required")]
        public bool Enable { get; set; }

        /// <summary>
        /// 禁止使用的用户名<br />
        /// 用户名之间用“|”隔开
        /// </summary>
        [Display(Name = "Prohibit User Name")]
        public string ProhibitUserName { get; set; }

        /// <summary>
        /// 启用管理员验证
        /// </summary>
        [Display(Name = "Administration Verify")]
        [Required(ErrorMessage = "Required")]
        public bool EnableAdminVerify { get; set; }

        /// <summary>
        /// 启用邮件验证
        /// </summary>
        [Display(Name = "Email Verify")]
        [Required(ErrorMessage = "Required")]
        public bool EnableEmailVerify { get; set; }

        /// <summary>
        /// 默认用户组Id
        /// </summary>
        [Display(Name = "Default Group Id")]
        [Required(ErrorMessage = "Required")]
        public int DefaultGroupID { get; set; }

    }
}
