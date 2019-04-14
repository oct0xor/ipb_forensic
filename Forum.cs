using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NulledViewer
{
    class Forum
    {
        public int Id { get; set; }
        public int Topics { get; set; }
        public int Posts { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }

        public TreeNode Node { get; set; }
    }
}
