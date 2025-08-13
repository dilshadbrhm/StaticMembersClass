using StaticMembersClassTask.Models;
using System.Xml.Linq;

namespace StaticMembersClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Student student = new Student("dIlShaD","IbRaHimLi");
            Student student2 = new Student("TEST", "TESTOV");


            student.GetInfo();
                  student2.GetInfo();
        }
    }
}
