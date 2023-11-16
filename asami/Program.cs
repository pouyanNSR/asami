List<Student> students = new List<Student>();
string x = @"C:\Users\Nasiri-PC\Desktop\bob.txt";
StreamReader reader = new StreamReader(x);
File.OpenText(x);
while (!reader.EndOfStream) 
{

    Student student = new Student();

    string Line = reader.ReadLine();

    student.FName = Line.Split(',')[0];

    student.LName = Line.Split(',')[1];

    student.MathMark = Convert.ToDouble(Line.Split(',')[2]);

    student.Pishrafte1Mark = Convert.ToDouble(Line.Split(',')[3]);

    student.TafsirMark = Convert.ToDouble(Line.Split(',')[4]);

    student.KargahMark = Convert.ToDouble(Line.Split(',')[5]);

    student.EnglishMark = Convert.ToDouble(Line.Split(',')[6]);

    student.Pishrafte2Mark = Convert.ToDouble(Line.Split(',')[7]);

    student.SheygarayeeMark = Convert.ToDouble(Line.Split(',')[8]);

    student.TarbiatbadaniMark = Convert.ToDouble(Line.Split(',')[9]);

    students.Add(student);
}

foreach (var student in students)
{
    Console.WriteLine(student.FName);
    Console.WriteLine(student.LName);
    Console.WriteLine(student.TotalAverage().ToString("#.##"));
    Console.WriteLine();
}
class Student
{
    public string FName { get; set; }
    public string LName { get; set; }
    public double MathMark { get; set; }
    public double Pishrafte1Mark { get; set; }
    public double TafsirMark { get; set; }
    public double KargahMark { get; set; }
    public double EnglishMark { get; set; }
    public double Pishrafte2Mark { get; set; }
    public double SheygarayeeMark { get; set; }
    public double TarbiatbadaniMark { get; set; }
    
    public double TotalAverage()
    {
        return ((MathMark * 2) + (Pishrafte1Mark * 2) + (TafsirMark * 1) + (KargahMark * 1) + (EnglishMark * 2)
            + (Pishrafte2Mark * 3) + (SheygarayeeMark * 3) + (TarbiatbadaniMark * 1)) / 15;  
    }

}