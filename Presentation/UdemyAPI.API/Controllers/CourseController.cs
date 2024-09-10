using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyAPI.Application.Features.Courses.Command.CreateCourse;
using UdemyAPI.Application.Features.Courses.Queries;

namespace UdemyAPI.API.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class CourseController : ControllerBase
	{
		private readonly IMediator _mediator;
        public CourseController(IMediator mediator)
        {
            _mediator = mediator;
        }
		[HttpGet]
		public async Task<IActionResult> GetAllCourses()
		{
			var response = await _mediator.Send(new GetAllCoursesQueryRequest());
			return Ok(response);
		}
		[HttpPost]
		public async Task<IActionResult> CreateCourse(CreateCourseCommandRequest request)
		{
			await _mediator.Send(request);
			return Ok();
		}
    }
}
