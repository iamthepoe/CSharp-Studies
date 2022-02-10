using System;
using System.Collections.Generic;

class Program {
  
    struct Client{
      public string name;
      public int id;
      public Client(string name, int id){
        this.name = name;
        this.id = id;
      }
    }

    struct Room{
      public int id;
      public double rent;
      public Room(int id, double rent){
        this.id = id;
        this.rent = rent;
      }
    }
    static void Main(string[] args) {
       bool exit = false;
       int option = 0;
       List<Client> ClientList = new List<Client>();
       List<Room> RoomList = new List<Room>();
       while(!exit){
         Console.WriteLine("[1] - Adicionar Cliente\n[2] - Remover Cliente\n[3] - Listar Clientes\n[0] - Sair");
         option = int.Parse(Console.ReadLine());
         switch(option){
           case 1:
           
           break;
           case 2:
           
           break;
           case 3:
           
           break;
             
           default:
              exit = true;
              Console.Clear();
           break;
         }
       }
    }
}