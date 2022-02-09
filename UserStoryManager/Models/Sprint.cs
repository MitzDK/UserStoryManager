using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserStoryManager.Models
{
    public class Sprint
    {
        public int No { get; set; }
        public int Du { get; set; }
        public string IconImg { get; set; }

        public Sprint()
        {
            
        }

        public Sprint(int no, int du, string iconImg)
        {
            No = no;
            Du = du;
            IconImg = iconImg;
        }
    }
}
