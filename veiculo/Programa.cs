using System.Security.AccessControl;
using miLibreria;

class programarPrincipal {

    static void Main(){
        vehiculo cacho = new vehiculo();

        vehiculo parapente = new vehiculo();

        cacho.anno = 1975;

        Console.WriteLine(cacho.desplazar());

        cacho.frenar();

        moto kawasaki = new moto();

        kawasaki.frenar();

        kawasaki.willy();

        auto renault = new auto();

        renault.capacidadbaul = 250;

        renault.ponercolor("azul");

        renault.mostrarcolor();
        
    
    }
}