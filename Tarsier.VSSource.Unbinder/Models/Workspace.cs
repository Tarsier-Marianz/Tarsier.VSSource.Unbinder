using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarsier.VSSource.Unbinder.Models {
    public class Workspace {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int FileCount { get; set; }
        public int ValidFiles { get; set; }
        public string Directory { get; set; }
        public string Comment { get; set; }
        public string LastDateUnbind { get; set; }
        public string Code { get; set; }
    }
}