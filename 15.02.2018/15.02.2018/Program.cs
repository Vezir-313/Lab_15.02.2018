using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._02._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.money = 90; // set
            //Console.WriteLine( p.money );  //get


            //==================================================================================================================
            //Akademi ca = new Akademi("Code");


            //Group p502 = new Group("P502");
            //Group p501 = new Group("P501");
            //Group p500 = new Group("P500");


            //ca.YeniQrup(p502);
            //ca.YeniQrup(p501);
            //ca.YeniQrup(p500);



            //Student kenan = new Student("Kenan",28);
            //Student vezir = new Student("Vezir", 21);
            //Student musa = new Student("Musa", 16);
            //Student ali = new Student("Ali", 26);
            //Student kamal = new Student("Kamal", 27);
            //Student nicat = new Student("Nicat", 20);


            //p502.YeniTelebe(kenan);
            //p501.YeniTelebe(vezir);
            //p502.YeniTelebe(musa);
            //p501.YeniTelebe(ali);
            //p502.YeniTelebe(kamal);
            //p501.YeniTelebe(nicat);

            //p500.YeniTelebe(new Student("Kenan", 24) { surname = "Bagirov"});




            //var result = ca.groups.Where(x=> x.students.Where(g=>g.name == "Kenan" && g.surname=="Bagirov").ToList().Count > 0 );

            //=======================================================================================================================


            Dictionary<int, Student> students = new Dictionary<int, Student>();


            Student kenan = new Student("Kenan", 28);
            Student vezir = new Student("Vezir", 21);
            Student musa = new Student("Musa", 16);
            Student m = new Student("M", 16);


            students.Add(2,kenan);
            students.Add(3, vezir);
            students.Add(9, musa);

            students.Remove(2);


            foreach (var item in students)
            {
                Console.WriteLine(item.Key+" : "+item.Value.name);
            }



        }
    }


    


}


