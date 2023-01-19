using System;

class Program
{
    public static void Main(string[] args)
    {
        Student st1 = new Student();
        st1.Name = "ali";
        st1.Surname = "yyy";
        st1.Class_ = 5;
        
        Student st2 = new Student("veli" , "xxx" , 0 , 2 );
        st1.showStudentInformation();
        st2.showStudentInformation();
        st2.sinifDusur();
        st2.sinifDusur();
        st2.showStudentInformation();
        
    }
}
class Student
{
    private string name;
    private string surname;
    private int StuId;
    private int class_;

    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public int StuId1 { get => StuId; set => StuId = value; }
    public int Class_ {
        get => class_; 
        set 
        { 
            if(value < 1)
            {
                System.Console.WriteLine("Sinif 1 den kücük olamaz.Sinif degeri 1 ayarlandı");
                class_ = 1;
            }
            else
                class_ = value;
        }
    }

    public Student(string name, string surname = null, int stuId = 0, int class_ = 0)
    {
        this.name = name;
        this.surname = surname;
        StuId = stuId;
        Class_ = class_;
    }
    public Student()
    {

    }

    public void showStudentInformation()
    {
        System.Console.WriteLine("****** Ogrenci Bilgileri ******");
        System.Console.WriteLine("Student Name :" + name);
        System.Console.WriteLine("Student Surname :" + surname);
        System.Console.WriteLine("Student Id :" + StuId);
        System.Console.WriteLine("Student Class :" + Class_);
    }

    public void sinifArttir()
    {
        this.Class_++;
    }
    public void sinifDusur()
    {
        this.Class_--;
    }
}