using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_one_SAD
{
	class teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string _class { get; set; }
        public string section { get; set; }

        public teacher(int id, string name, string cla, string section)
        {
            this.ID = id;
            this._class = cla;
            this.section = section;
            this.Name = name;
        }

    }
}
