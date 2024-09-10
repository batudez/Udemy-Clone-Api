using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyAPI.Application.Features.Lessons.Command.CreateLesson;
using UdemyAPI.Application.Features.Lessons.Queries.GetLessonByCourseId;

namespace UdemyAPI.API.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class LessonController : ControllerBase
	{

		private readonly IMediator _mediator;
		public LessonController(IMediator mediator)
		{
			_mediator = mediator;
		}
		[HttpGet]
		public async Task<IActionResult> GetLessonByCourseId([FromQuery]GetLessonByCourseIdQueryRequest request)
		{
			var response = await _mediator.Send(request);
			return Ok(response);
		}
		[HttpPost]
		public async Task<IActionResult> CreateLesson(CreateLessonCommandRequest request)
		{
			var response = await _mediator.Send(request);
			return Ok(response);
		}
	}
}
