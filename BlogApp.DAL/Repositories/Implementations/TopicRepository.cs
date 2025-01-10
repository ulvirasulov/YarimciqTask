using BlogApp.Core.Entities;
using BlogApp.DAL.Context;
using BlogApp.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Repositories.Implementations
{
    public class TopicRepository : Repository<Topic>, ITopicRepository
    {
        public TopicRepository(BlogAppDbContext context) : base(context)
        {
        }
    }
}
