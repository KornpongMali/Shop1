namespace Grabfood {
 class Program {   
  static void Main(string[] args) {
   

   Console.Write("Input Day of Week:");
   int  Day = int.Parse(Console.ReadLine());

int Monday =  1;
   int TUEday =  2;
   int WEDday =  3;
   int THUday =  4;
   int FRIday =  5;
   int SATday =  6;
   int SUNday =  7;
   
   Console.Write("Input Time of Day :");
   
   int  Time = int.Parse(Console.ReadLine());
   
   int  Time0800 =   8;
   int  Time0900 =   9;
   int  Time1000 =  10;
   int  Time1100 =  11;
   int  Time1200 =  12;
   int  Time1300 =  13;
   int  Time1400 =  14;
   int  Time1500 =  15;
   int  Time1600 =  16;
   int  Time1700 =  17;
   int  Time1800 =  18;
   
   Console.Write("Input menu:");
   
   string menu = Console.ReadLine();
    switch(menu){
        case "Breakfast Set":
        if(Day>=5-1){
            Console.WriteLine("Please enter a valid menu");
        }
        else{
            Console.WriteLine("Sorry your order is out of stock");
        }
        
            Console.WriteLine("Weekend Set");
    
        break;
        
        case "Weekend Set":
        if(Day>=2-1){
            Console.WriteLine("Please enter a valid menu");
        }
        else{
            Console.WriteLine("Sorry your order is out of stock");
        }
        
         break;
         
          case "Coffee":
          if(Day>=3-1){
            Console.WriteLine("Please enter a valid menu");
        }
        else{
            Console.WriteLine("Sorry your order is out of stock");
        }
        
         break;

    }

   }
     
  }
 
   
  }
 
