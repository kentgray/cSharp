using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Drills
{

    public struct Student
    {
        private int _id;
        private string _name;

        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Student(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} and Name = {1}\n", this._id, this._name);
        }
    }
}