using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMay
{
    public class Group
    {
        private string name;
        private int bottles;
        private int batteries;

        public Group()
        {
        }

        public Group(Group other)
        {
            this.name = other.name;
            this.bottles = other.bottles;
            this.batteries = other.batteries;
        }

        public void AddBottles(int bottlesToAdd)
        {
            this.bottles += bottlesToAdd;
        }

        public int GetBatteries()
        {
            return batteries;
        }

        public int GetBottles()
        {
            return bottles;
        }

        public string GetName()
        {
            return name;
        }
    }
}
