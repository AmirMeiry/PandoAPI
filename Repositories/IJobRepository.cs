using PandoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoAPI.Repositories
{
    public interface IJobRepository
    {
        Task<IEnumerable<Job>> Get();
        Task<Job> Get(int id);
        Task<Job> Create(Job job);
        Task Update(Job job);
        Task Delete(int id);
    }
}
