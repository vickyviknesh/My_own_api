using Microsoft.AspNetCore.Mvc;

namespace backendprojects.Controllers;

using backendprojects.Models;

[ApiController]
[Route("[controller]")]
public class newsapiController : ControllerBase
{
    private readonly NewsapiContext da;

    public newsapiController(NewsapiContext sa)
    {
        this.da=sa;
    } 

    [HttpGet("newsapi")]

    public Liveapi GetLiveapis(string newsnamess)
    {
        try
        {
            return da.Liveapis.Where(e=>e.Newsname.Equals(newsnamess)).FirstOrDefault();
        }
        catch(SystemException)
        {
            throw;
        }
    }

   }

