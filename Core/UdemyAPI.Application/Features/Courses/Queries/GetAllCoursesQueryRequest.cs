﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAPI.Application.Features.Courses.Queries
{
	public class GetAllCoursesQueryRequest : IRequest<IList<GetAllCoursesQueryResponse>>
	{

	}
}
