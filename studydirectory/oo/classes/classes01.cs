using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public class Person{
    string name;
    int age;
    bool isOfAge;

    public Person(string name, int age){
      this.isOfAge = false;
      this.name = name;
      this.age = age;
      if(age>=18){this.isOfAge = true;}
    }

    public void printInfo(){
      Console.Write($"{name}, {age}");
      if(isOfAge){
        Console.WriteLine("\nIs of age.");
      }else{
        Console.WriteLine("\nIs not of age");
      }
    }
  }
  public static void Main (string[] args) {
    Person person1 = new Person("Luca", 15);
    Person person2 = new Person("Mary", 18);
    Person person3 = new Person("John", 30);
    person1.printInfo();
    person2.printInfo();
    person3.printInfo();
  }

 
}
