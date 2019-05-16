using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DontRot.Bll.Dtos;
using DontRot.Bll.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DontRot.Api.Controllers
{
	[Route( "api/[controller]" )]
	[ApiController]
	public class SlotController : ControllerBase
	{
		public ISlotService SlotService { get; }
		public IMapper Mapper { get; }

		public SlotController( ISlotService slotService, IMapper mapper )
		{
			SlotService = slotService;
			Mapper = mapper;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Slot>> GetAllSlot()
		{
			return Mapper.Map<List<Slot>>( SlotService.GetSlots() );
		}

		// GET: api/Slot/5
		[HttpGet( "{id}" )]
		public ActionResult<Slot> GetSlot( int id )
		{
			return Mapper.Map<Slot>( SlotService.GetSlot( id ) );
		}
	}
}