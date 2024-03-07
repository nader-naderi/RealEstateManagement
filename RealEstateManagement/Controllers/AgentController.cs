using Microsoft.AspNetCore.Mvc;

namespace RealEstateManagement.Controllers
{
    public class AgentController : Controller
    {
        public IActionResult Index()
        {
            //var agents = _repository.GetAgents();
            //return View(agents);
            return View();
        }

        public IActionResult Profile(int id)
        {
            //var agent = _repository.GetAgentById(id);
            //return View(agent);
            return View();
        }
    }
}
