﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MTD.CouchBot.Domain.Dtos.Discord;
using MTD.CouchBot.Data.EF;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MTD.CouchBot.Dals.Implementations
{
    public class GuildDal : IGuildDal
    {
        CouchDbContext _couchDbContext;

        public GuildDal(CouchDbContext couchDbContext)
        {
            _couchDbContext = couchDbContext;
        }

        public async Task<Guild> AddNewGuild(Guild newGuild)
        {
            await _couchDbContext.Guilds.AddAsync(newGuild);
            await _couchDbContext.SaveChangesAsync();

            return newGuild;
        }

        public async Task<User> AddNewUser(User user)
        {
            await _couchDbContext.Users.AddAsync(user);
            await _couchDbContext.SaveChangesAsync();

            return user;
        }

        public async Task<List<Guild>> GetAllGuilds()
        {
            return await _couchDbContext.Guilds.ToListAsync();
        }

        public async Task<Guild> GetGuildById(string id)
        {
            return await _couchDbContext.Guilds.FirstOrDefaultAsync(g => g.GuildId.Equals(id));
        }

        public async Task<List<Guild>> GetGuildsForLive()
        {
            return await _couchDbContext.Guilds.Where(g => g.AllowLive).ToListAsync();
        }

        public async Task<User> GetUserByUserId(string userId)
        {
            return await _couchDbContext.Users.FirstOrDefaultAsync(u => u.UserId.Equals(userId));
        }

        public async Task RemoveGuild(Guild guild)
        {
            _couchDbContext.Guilds.Remove(guild);
            await _couchDbContext.SaveChangesAsync();
        }

        public async Task UpdateGuild(Guild guild)
        {
            _couchDbContext.Guilds.Update(guild);
            await _couchDbContext.SaveChangesAsync();
        }
    }
}
