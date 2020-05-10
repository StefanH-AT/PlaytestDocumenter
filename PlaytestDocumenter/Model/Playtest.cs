using System;
using System.Collections.Generic;
using System.Text;

namespace PlaytestDocumenter.Model
{
    class Playtest
    {
        public Template Template { get; set; }
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public DateTime StartTime { get; set; }
        public List<Map> Maps { get; set; }
    }
}
