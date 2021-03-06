﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Core.Model;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
	public class MessageRepository : BaseRepository<Message>, IMessageRepository
    {
		private readonly ApplicationsDbContext _context;

		public MessageRepository(ApplicationsDbContext context) : base(context)
		{
			_context = context;
		}

		public override async Task<IEnumerable<Message>> GetAll()
		{
			var res = await _context.Messages
				.Include(s => s.AppUser)
				.Include(h => h.History).ToListAsync();
			return res;
		}

		public override async Task<Message> GetById(int id)
		{
			return await _context.Messages.FirstOrDefaultAsync(s => s.Id == id);
		}

		public IEnumerable<Message> GetNotificationByHistoryId(int HistoryId)
		{
			throw new NotImplementedException();
		}
    }
}
