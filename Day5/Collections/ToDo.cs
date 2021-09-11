using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public override string ToString()
        {
            return $"Id: {this.Id}, Title: {this.Title}";
        }
    }
}
