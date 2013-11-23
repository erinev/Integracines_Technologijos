using System.ComponentModel;
using System.Web.Services;

namespace ErikoWebServisas
{
    [WebService(Namespace = "http://ktu.lt/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class ManoWebServisas : WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}