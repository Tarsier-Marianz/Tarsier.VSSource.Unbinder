using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarsier.VSSource.Unbinder.Models {
    public class History {
        public int ID { get; set; }
        public int FileCount { get; set; }
        public string DateUnbind { get; set; }
        public string TimeUnbind { get; set; }
        public string Code { get; set; }
    }
}
