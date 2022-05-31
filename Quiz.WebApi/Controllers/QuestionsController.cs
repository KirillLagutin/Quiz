using Microsoft.AspNetCore.Mvc;
using Quiz.WebApi.DB;

namespace Quiz.WebApi.Controllers;

[ApiController]
[Route("api/v1/questions")]
public class QuestionsController : ControllerBase
{
    [HttpGet]
    public JsonResult GetAllTasks()
    {
        return new JsonResult(DataBase.GetAllQuestions());
    }
}