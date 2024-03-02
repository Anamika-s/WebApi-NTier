using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repository.Entities
{
    [Keyless]
    public class SpResults
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
    }
}
