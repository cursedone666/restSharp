using OpenQA.Selenium;
using RestSharp;

namespace RestAPI
{
    public static class CookieHelper
    {
        public static Cookie ExtractCookie(IRestResponse response, string cookieName)
        {
            Cookie res = null;
            foreach (var cookie in response.Cookies)
            {
                if (cookie.Name.Equals(cookieName))
                {
                    res = new Cookie(cookie.Name, cookie.Value, cookie.Domain, cookie.Path,  null);
                }
            }

            return res;
        }
    }
}
