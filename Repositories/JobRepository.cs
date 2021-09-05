using Microsoft.EntityFrameworkCore;
using PandoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoAPI.Repositories
{
    public class JobRepository : IJobRepository
    {
        private readonly JobContext _context;
        public JobRepository(JobContext context)
        {
            _context = context;
        }
        public async Task<Job> Create(Job job)
        {
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();

            return job;
            //throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            var jobToDelete = await _context.Jobs.FindAsync(id);
            _context.Jobs.Remove(jobToDelete);
            await _context.SaveChangesAsync();
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<Job>> Get()
        {
            return await _context.Jobs.ToListAsync();
            //throw new NotImplementedException();
        }

        public async Task<Job> Get(int id)
        {
            return await _context.Jobs.FindAsync(id);
            //throw new NotImplementedException();
        }

        public async Task Update(Job job)
        {
            _context.Entry(job).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            //throw new NotImplementedException();
        }
    }
}
