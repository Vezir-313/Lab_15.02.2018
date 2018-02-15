using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._02._2018
{
    class Akademi
    {
        public Akademi(string name)
        {
            this.Name = name;
            this.groups = new List<Group>();
        }
        public string Name { get; set; }
        public  List<Group> groups;

        public void YeniQrup(Group g)
        {
           if(g != null && string.IsNullOrEmpty(g.Name.Trim()) ==false)
            {
                groups.Add(g);
            }
            else
            {
                Console.WriteLine("Qrupu duzgun daxil edin");
            }
        }
    }
}
