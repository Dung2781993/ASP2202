using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_Sharp.Models
{
    class Cat : Animal
    {
        public Cat()
        {
            /*
                Lớp Cat kế thừa lớp Animal
                mà các thuộc tính Weight, Height, Legs có phạm vi là protected nên được phép kế thừa
                Từ đó lớp Cat có thể sử dụng mà không cần phải khai báo

             */
            Weight = 500;
            Height = 20;
            Legs = 2;
        }
    }
}
