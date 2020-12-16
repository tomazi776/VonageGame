using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VonageGame.Models
{
    public class Move
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Action<int> Action { get; set; }
        public Move()
        {

        }
    }
}
