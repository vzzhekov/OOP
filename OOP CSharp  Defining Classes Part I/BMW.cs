using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_CSharp__Defining_Classes_Part_I
{
    public class BMW : Car
    {
        private int hp;
        public int HP
        {
            get { return this.hp; }
            set { this.hp = value; }
        }
        
        public BMW(int hp, string brand, string model) : base(brand, model) {

           
            
            this.hp = hp;
                }
            
        }


    }

