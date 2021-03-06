﻿using Common.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SLSM.MoblieWeb.Models.Resquest.Home
{
    /// <summary>
    /// 根据手机号登入请求
    /// </summary>
    public class LoginByPhoneRequest
    {
        /// <summary>
        /// 用户手机号码
        /// </summary>
        [PhoneValid]
        public string UserPhone { get; set; }
        /// <summary>
        /// 图片验证码
        /// </summary>
        //[PhoneValid]
        public string ImageCode { get; set; }
        

        /// <summary>
        /// 用户手机验证码
        /// </summary>
        public string PhoneCode { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }
    }
}