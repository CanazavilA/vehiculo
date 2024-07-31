using System.Drawing;

namespace miLibreria{
    class vehiculo {
       public string Color;
       public string modelo;
       public int anno;
       public void ponercolor(string pcolor){
        Color =pcolor;
       }
     public string desplazar(){ 
        return "desplazando.....";

     }
     public void frenar(){
        Console.WriteLine("brrsssssss...........");
     }
     public void mostrarcolor(){
        System.Console.WriteLine("el color del auto es "+ Color);
     }


    }

    class auto: vehiculo{

        public int capacidadbaul;
        public void ponercolorauto(string pcolor){

            this.Color = pcolor;

        }


    }

    class moto: vehiculo {
        public void willy(){
            Console.WriteLine("whiiiiiiii :D......");
        }

    }
}