using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM
{

    public enum Gender
    {
        Boy,
        Girl
    }

    class InforData
    {
        public string Name { get; set; }
        public int Bonus { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string ImagePath { get; set; }

      

        public InforData()
        {
            this.Name = "oscar";
            this.Email = "oscarchang69@hotmail.com";
            this.Birthday = new DateTime(1975, 1, 17);
            this.Gender = Gender.Boy;
            this.ImagePath = "me.jpg";
                
        }

    }


}
