using System.Net;
using Infrastructure.Database.DTO;

namespace _exApp.DefaultResponses
{
    public class ApplicationDefaultResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public EApplicationDto EApplicationDto { get; set; }
        public string ErrorMessage { get; set; }
    }
}