using System;
using System.Collections.Generic;

class MainClass {
  struct Student{
    public string name;
    public int grade;

    public Student(string name, int grade){
      this.name = name;
      this.grade = grade;
    }
  }

  struct Classroom{
    public int id;
    public string name;
    public List<Student> students;

    public Classroom(int id, string name, List<Student> students){
      this.id = id;
      this.name = name;
      this.students = students;
    }

    public void ShowInformation(){
      Console.WriteLine($"=====================\n{name}\n{id}\nStudents: ");
      foreach(Student student in students){
        Console.WriteLine(student);
      }
    }
  }

  public static void Main (string[] args) {
    List<Student> classroomOne = new List<Student>();
    classroomOne.Add(new Student("Immanuel Kant", 5));
    classroomOne.Add(new Student("Frederich Hegel", 8));
    classroomOne.Add(new Student("Aristotle", 9));
    List<Student> classroomTwo = new List<Student>();
    classroomTwo.Add(new Student("I", 4));
    classroomTwo.Add(new Student("F", 2));
    classroomTwo.Add(new Student("(){}", 10));
    List<Student> classroomThree = new List<Student>();
    classroomThree.Add(new Student("A", 1));
    classroomThree.Add(new Student("B", 2));
    classroomThree.Add(new Student("C", 3));

    List<Classroom> MyClassroomList = new List<Classroom>();
    MyClassroomList.Add(new Classroom(1, "Classroom One", classroomOne));
    MyClassroomList.Add(new Classroom(2, "Classroom Two", classroomTwo));
    MyClassroomList.Add(new Classroom(3, "Classroom Three", classroomThree));

    foreach(Classroom MyClassroom in MyClassroomList){
      MyClassroom.ShowInformation();
    }
  }
}
