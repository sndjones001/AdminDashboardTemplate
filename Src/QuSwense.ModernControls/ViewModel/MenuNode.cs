using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuSwense.ModernControls.ViewModel
{
    public class MenuNode
    {
        private List<MenuNode> _childNodes;
        public List<MenuNode> ChildNodes { get => _childNodes = _childNodes ?? new List<MenuNode>(); }
        public string Text { get; set; }

        public MenuNode(string text)
        {
            Text = text;
        }
    }
}
