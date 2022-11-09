using System;

namespace PoojaProject.Model
{
    public class Question : IEntity
    {
        public Question()
        {
        }

        public Question(int id)
        {
            Id = id;
        }

        public Question(int id, string name,int op1,int op2,int op3)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Op1 = op1;
            Op2 = op2;
            Op3 = op3;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Op1 { get; set; }
        public int Op2 { get; set; }
        public int Op3 { get; set; }
    }
}
