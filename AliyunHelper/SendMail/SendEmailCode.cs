﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyunHelper.SendMail
{

    /// <summary>
    /// 模版CODE
    /// </summary>
    public enum Enum_SendEmailCode
    {
        /// <summary>
        /// 身份验证验证码
        /// </summary>
        AuthenticationCode = 0,
        /// <summary>
        /// 短信测试
        /// </summary>
        SMSTest = 1,
        /// <summary>
        /// 登录确认验证码
        /// </summary>
        LoginConfirmationCode = 2,
        /// <summary>
        /// 登录异常验证码
        /// </summary>
        LoginExceptionAuthenticationCode = 3,
        /// <summary>
        /// 用户注册验证码
        /// </summary>
        UserRegistrationVerificationCode = 4,
        /// <summary>
        /// 修改密码验证码
        /// </summary>
        ModifyPasswordAuthenticationCode = 5,
        /// <summary>
        /// 信息变更验证码
        /// </summary>
        MessageChangeVerificationCode = 6,
        /// <summary>
        /// 支付通知
        /// </summary>
        NoticeOfPaymentCode = 8,
        /// <summary>
        /// 发货通知
        /// </summary>
        NoticeOfDeliveryCode = 9
    }

    public static partial class GetString
    {
        #region MyRegion
        ///// <summary>
        ///// 根据模型获取对应信息
        ///// </summary>
        ///// <param name="Enum_Model">当前枚举</param>
        ///// <returns></returns>
        //public static string Enum_GetString(this Enum_SendEmailCode Enum_Model)
        //{
        //    string result = string.Empty;
        //    switch (Enum_Model)
        //    {
        //        case Enum_SendEmailCode.AuthenticationCode:
        //            result = "SMS_76606423";
        //            break;
        //        case Enum_SendEmailCode.SMSTest:
        //            result = "SMS_76606422";
        //            break;
        //        case Enum_SendEmailCode.LoginConfirmationCode:
        //            result = "SMS_76606421";
        //            break;
        //        case Enum_SendEmailCode.LoginExceptionAuthenticationCode:
        //            result = "SMS_76606420";
        //            break;
        //        case Enum_SendEmailCode.UserRegistrationVerificationCode:
        //            result = "SMS_76606419";
        //            break;
        //        case Enum_SendEmailCode.ModifyPasswordAuthenticationCode:
        //            result = "SMS_76606418";
        //            break;
        //        case Enum_SendEmailCode.MessageChangeVerificationCode:
        //            result = "SMS_76606417";
        //            break;
        //        case Enum_SendEmailCode.HealthyEatingAppUserRegistration:
        //            result = "SMS_78365027";
        //            break;
        //        default:
        //            result = "";
        //            break;
        //    }
        //    return result;
        //} 
        #endregion


        /// <summary>
        /// 根据模型获取对应信息
        /// </summary>
        /// <param name="Enum_Model">当前枚举</param>
        /// <returns></returns>
        public static string Enum_GetString(this Enum_SendEmailCode Enum_Model)
        {
            string result = string.Empty;
            switch (Enum_Model)
            {
                case Enum_SendEmailCode.AuthenticationCode:
                    result = "SMS_130800025";
                    break;
                case Enum_SendEmailCode.SMSTest:
                    result = "SMS_130800025";
                    break;
                case Enum_SendEmailCode.LoginConfirmationCode:
                    result = "SMS_130800024";
                    break;
                case Enum_SendEmailCode.LoginExceptionAuthenticationCode:
                    result = "SMS_130800023";
                    break;
                case Enum_SendEmailCode.UserRegistrationVerificationCode:
                    result = "SMS_130800022";
                    break;
                case Enum_SendEmailCode.ModifyPasswordAuthenticationCode:
                    result = "SMS_130800021";
                    break;
                case Enum_SendEmailCode.MessageChangeVerificationCode:
                    result = "SMS_130800020";
                    break;
                case Enum_SendEmailCode.NoticeOfPaymentCode:
                    result = "SMS_150576962";
                    break;
                case Enum_SendEmailCode.NoticeOfDeliveryCode:
                    result = "SMS_150572032";
                    break;
                default:
                    result = "";
                    break;
            }
            return result;
        }
    }
}
