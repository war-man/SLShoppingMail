﻿using Common.Result;
using log4net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http.Filters;

namespace Common.Filter.WebApi
{
    /// <summary>
    /// WebApi异常过滤器
    /// </summary>
    public class WebApiExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            ResultJson resultJson = new ResultJson();
            resultJson.HttpCode = 600;
            //信息
            //resultJson.Message = actionExecutedContext.Exception.Message;
            resultJson.Message = "程序出现错误，请联系管理员！";
            actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(System.Net.HttpStatusCode.OK, resultJson);
            //创建日志记录组件实例
            ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            //记录错误日志
            log.Error("error", actionExecutedContext.Exception);
            base.OnException(actionExecutedContext);                                
        }
    }
}
