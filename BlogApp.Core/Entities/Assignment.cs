using BlogApp.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Core.Entities
{
    public class Assignment : BaseEntity
    {
        public string Name { get; set; }
        public DateTime FinishTime { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
