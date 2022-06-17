using System;
using System.Collections.Generic;
using System.Text;

namespace Class_task
{
    interface City
    { 
        Human [] humans { get; }

        public void AddHuman(Human human);
        public Human[] SearchHumans(string search);
        
    }
}
