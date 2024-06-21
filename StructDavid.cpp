#include <iostream>
#include <string>

using namespace std;


struct Persona {
    string nombre;
    int edad;
    float altura;
};

int main() {
  
    Persona persona1;

    
    persona1.nombre = "Ulises García";
    persona1.edad = 15;
    persona1.altura = 1.75;

    
    cout << "Nombre: " << persona1.nombre << endl;
    cout << "Edad: " << persona1.edad << endl;
    cout << "Altura: " << persona1.altura << endl;

    return 0;
}
