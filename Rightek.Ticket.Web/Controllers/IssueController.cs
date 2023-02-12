using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Rightek.Ticket.Web.Controllers;

// [Authorize]
public class IssueController : BaseController
{
    // issue/10
    public IActionResult Index(int id)
    {
        if (id < 1) return RedirectToAction(nameof(List));

        ViewBag.Id = id;
        return View("Detail");
    }

    // issue/list
    public IActionResult List() => View();

    // issue/new
    public IActionResult New() => View();

    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public IActionResult New(object m) => View();
}