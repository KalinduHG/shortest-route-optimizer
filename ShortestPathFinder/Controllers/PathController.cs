using Microsoft.AspNetCore.Mvc;
using ShortestPathFinder.Models;
using ShortestPathFinder.Services;

namespace ShortestPathFinder.Controllers
{
    public class PathController : Controller
    {
        private readonly GraphService _graphService;

        public PathController()
        {
            _graphService = new GraphService();
        }

        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Calculate(string fromNode, string toNode)
        {
            var graph = GraphData.GetGraph();

            var result = _graphService.ShortestPath(fromNode, toNode, graph);
            return Json(result);
        }


    }
}
