using CommunityApplication.DTO;
using CommunityApplication.Features.Announcement.Command.CreateAnnouncementCommand;
using CommunityApplication.Features.Announcement.Command.UpdateAnnouncementCommand;
using CommunityApplication.Features.Announcement.DeleteAnnouncementCommand;
using CommunityApplication.Features.Announcement.Query.GetAllAnnouncementsQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CommunityApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnnouncementsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AnnouncementsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllAnnouncementsQuery());
            return Ok(result);
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById(long id)
        //{
        //    var result = await _mediator.Send(new GetAnnouncementByIdQuery(id));
        //    if (result == null) return NotFound();
        //    return Ok(result);
        //}

        [HttpPost]
        public async Task<IActionResult> Create(CreateAnnouncementDto dto)
        {
            var id = await _mediator.Send(new CreateAnnouncementCommand(dto));
            return Ok(new { AnnouncementId = id });
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateAnnouncementDto dto)
        {
            await _mediator.Send(new UpdateAnnouncementCommand(dto));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _mediator.Send(new DeleteAnnouncementCommand(id));
            return Ok();
        }
    }

}
