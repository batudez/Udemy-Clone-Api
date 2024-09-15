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
			if (request.file == null || request.file.Length == 0)
				return BadRequest("Dosya yüklenemedi");

			// wwwroot dizinine yol oluşturuyoruz
			var wwwRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

			// Eğer 'uploads' klasörü yoksa oluşturuyoruz
			if (!Directory.Exists(wwwRootPath))
			{
				Directory.CreateDirectory(wwwRootPath);
			}

			// Dosyanın tam yolunu oluşturuyoruz
			var filePath = Path.Combine(wwwRootPath, request.file.FileName);

			// Dosyayı wwwroot/uploads dizinine kaydediyoruz
			using (var stream = new FileStream(filePath, FileMode.Create))
			{
				await request.file.CopyToAsync(stream);
			}
			request.LessonVideoUrl = Path.Combine("uploads",request.file.FileName);
			var response = await _mediator.Send(request);
			return Ok(response);

		}
		
	}
}
