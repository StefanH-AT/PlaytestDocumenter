using System;
using System.Collections.Generic;
using System.Text;

namespace PlaytestDocumenter.Model
{
    class Map
    {
        public string Name { get; set; }
        public Performance Performance { get; set; }
        public string Notes { get; set; }
        public TimeSpan CompletionTime { get; set; }
        public bool AttentionMarker { get; set; }
    }
}
