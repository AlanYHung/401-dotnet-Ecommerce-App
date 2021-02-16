using Ecommerce_App.Auth.Model.Dto;
using Ecommerce_App.Auth.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_App.Controllers
{
  public class LoginController : Controller
  {
    private IUserService userService;

    public LoginController(IUserService service)
    {
      userService = service;
    }

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Signup()
    {
      return View();
    }

    public IActionResult Error()
    {
      return View();
    }

/*    [HttpPost]
    public async Task<ActionResult<UserDto>> Register(RegisterUser data)
    {
      data.Roles = new List<string> { "guest" };
      var user = await userService.Register(data, this.ModelState);
      if(ModelState.IsValid)
      {
        return Redirect("/Login");
      }
      return Redirect("/Login/Error");
    }*/

    public IActionResult Welcome()
    {
      return View();
    }

    public IActionResult Profile()
    {
      return View();
    }
  }
}
