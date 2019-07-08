using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace csharpcornerauthorionicapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("charppolicy")]
    public class UserController : ControllerBase
    {
        // GET api/values
        [HttpGet("{s}/{st}/{id}")]
        public ActionResult<IEnumerable<string>> Get(string s, string st = "", int id = 0)
        {
            return Ok(JsonConvert.SerializeObject(GetAllUser(s, st, id), Formatting.Indented));
        }

        public List<User> GetAllUser(string s, string st = "", int id = 0)
        {
            List<User> Author = new List<User>();

            if (s == null && id == 0)
                return Author;

                Author.Add(new User
                {
                    Id = 1,
                    role = "Admin",
                    biodata = "C# Corner, Mindcracker",
                    intro = "Startup Advisor, Speaker, Author, Architecture, Innovation",
                    joineddate = "Oct 29 2004",
                    location = "Philadelphia USA",
                    name = "Mahesh Chand",
                    profilelink = "https://www.c-sharpcorner.com/members/mahesh-chand",
                    profilepicture = "https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/AuthorImage/mahesh20160308020632.png"
                });
                Author.Add(new User
                {
                    Id = 2,
                    role = "Admin",
                    biodata = "C# Corner Chief Editor and 3-times Microsoft MVP. I hold Masters degree in Computer Science and Applications and Bachelor’s degree in Mathematics. I am responsible for content publishing, product development, and migration of existing contents. I am also responsible for hiring new team members and managing the existing team",
                    intro = "Not Available",
                    joineddate = "May 16 2005",
                    location = "Noida India",
                    name = "Praveen Moosad",
                    profilelink = "https://www.c-sharpcorner.com/members/praveen-moosad",
                    profilepicture = "https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/AuthorImage/prvn_13197120160516052234.jpg"
                });
                Author.Add(new User
                {
                    Id = 3,
                    role = "Editor",
                    biodata = "Not Available",
                    intro = "Editing and writing",
                    joineddate = "Dec 30 2015",
                    location = "USA",
                    name = "TRIX MIDDLEKAUFF",
                    profilelink = "https://www.c-sharpcorner.com/members/trix-middlekauff",
                    profilepicture = "https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/AuthorImage/26e38620180810040748.jpg"
                });
                Author.Add(new User
                {
                    Id = 4,
                    role = "Editor",
                    biodata = "With an extensive hands-on experience of over 9 years, Pranav is working as Sr. Technical Editor in C# Corner team. He holds an MBA as well as a B-Tech degree in Information Technology. Here, he is responsible for editing and developing high-quality technical content, covering the news from the tech world, and editing all the day-to-day content being published on C# Corner, making it more readable and worth publishing.",
                    intro = "Content curation, Copywriting, Copyediting,Tech writing, PHP/MySq",
                    joineddate = "May 16 2016",
                    location = "Delhi India",
                    name = "PRANAV MITTAL",
                    profilelink = "https://www.c-sharpcorner.com/members/pranav14",
                    profilepicture = "https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/AuthorImage/90108c20190521012831.jpg"
                });
                Author.Add(new User
                {
                    Id = 5,
                    role = "MVP",
                    biodata = "Ankur Mistry is working as an Agile Coach, Certified Scrum Master (CSM), CSPO, He is C#Corner MVP (2018, 2017 and 2016), C#Corner Surat Chapter Lead, Speaker, CSP and Masters in Computer Application. Having 12 + years of experience in IT and his area of interest is C#, ASP.NET, SQL Server, Project Management, Scrum, Agile, crystal reports, MVC, WCF, Web Services, SSRS, HTML etc.",
                    intro = "CSPO, CSP, CSM, C#, ASP.NET, SQL Server, crystal reports, MVC",
                    joineddate = "Dec 19 2009",
                    location = "Mumbai India",
                    name = "ANKUR MISTRY",
                    profilelink = "https://www.c-sharpcorner.com/members/ansh-mistry",
                    profilepicture = "https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/AuthorImage/ansh0603198220160402071949.jpg"
                });
                Author.Add(new User
                {
                    Id = 6,
                    role = "MVP",
                    biodata = "Sr. SharePoint Developer working with Microsoft SharePoint (2010, 2013, 2016 and SharePoint Online), PowerApps, PowerBI, ASP.NET with C# and VB. Have hands on experience on Microsoft Azure. Love to remain on cutting edge of the technical knowledge",
                    intro = "SharePoint , Office365, PowerApp, Microsoft Flow, Azure, PowerBI",
                    joineddate = "Jul 29 2016",
                    location = "Surat India",
                    name = "AAKASH MAURYA",
                    profilelink = "https://www.c-sharpcorner.com/members/aakash-morya2",
                    profilepicture = "https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/AuthorImage/d864b220180523093106.png"
                });
                Author.Add(new User
                {
                    Id = 7,
                    role = "Author",
                    biodata = "A Software Engineer, experience with developing Web Application with the use of Microsoft technologies",
                    intro = "AngularJS, ASP.NET, nopCommerce,ASP.NET CORE,React js",
                    joineddate = "Jan 29 2019",
                    location = "Surat India",
                    name = "SMITEN KALATHIYA",
                    profilepicture = "https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/AuthorImage/01d00520190609091138.jpg",
                    profilelink = "https://www.c-sharpcorner.com/members/smiten-kalathiya3"
                });
            if (!string.IsNullOrEmpty(s))
                Author = Author.Where(a => a.name.ToLower().Contains(s.ToLower())).ToList();

            if(!string.IsNullOrEmpty(st))
                Author = Author.Where(a => a.role.Contains(st)).ToList();

            if(id != 0)
                Author = Author.Where(a => a.Id == id).ToList();

            return Author;

        }
    }
}
