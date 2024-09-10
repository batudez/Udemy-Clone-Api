using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAPI.Application.DTOs;
using UdemyAPI.Application.Interfaces.Automapper;
using UdemyAPI.Application.Interfaces.UnitOfWorks;
using UdemyAPI.Domain.Entities;

namespace UdemyAPI.Application.Features.Courses.Queries
{
	public class GetAllCoursesQueryHandler : IRequestHandler<GetAllCoursesQueryRequest, IList<GetAllCoursesQueryResponse>>
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
        public GetAllCoursesQueryHandler(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
			_mapper = mapper;
        }
        public async Task<IList<GetAllCoursesQueryResponse>> Handle(GetAllCoursesQueryRequest request, CancellationToken cancellationToken)
		{
			var courses = await _unitOfWork.GetReadRepository<Course>().GetAllAsync(include: x =>
			x.Include(c => c.Category)
			.Include(t => t.Trainer));

			var trainer = _mapper.Map<TrainerDto, Trainer>(new Trainer());
			var category = _mapper.Map<CategoryDto, Category>(new Category());

			var map = _mapper.Map<GetAllCoursesQueryResponse, Course>(courses);

			return map;
		}
	}
}
