using AutoMapper;
using ComputopRequestTest.Presentation.Contracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ComputopRequestTest.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParameterController : ControllerBase
    {
        private readonly ISender _mediator;
        private readonly IMapper _mapper;

        //public ParameterController(ISender mediator, IMapper mapper)
        //{
        //    _mediator = mediator;
        //    _mapper = mapper;
        //}

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            return Ok(new GetParametersResponse(
                new List<Parameter>
                { new Parameter("Amount", nameof(String))}));
        }
    }
}
