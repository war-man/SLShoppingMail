using System.Web.Http;
using WebActivatorEx;
using SLSM.Web;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace SLSM.Web
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "SLSM.Web");
                        //���XML����
                        c.IncludeXmlComments(GetXmlCommentsPath());
                    })
                .EnableSwaggerUi(c =>
                    {

                    });
        }

        /// <summary>
        /// ���XML����
        /// </summary>
        /// <returns></returns>
        private static string GetXmlCommentsPath()
        {
            return string.Format("{0}/bin/SLSM.Web.xml", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
