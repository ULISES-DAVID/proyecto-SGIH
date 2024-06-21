#include <iostream>
using namespace std;

struct Me{
    string nombre;
    string apellido;
    int edad;
    string sexo;
    string ocupacion;
};

int main (){
    Me me;
    cout << "hola, ingrese sus datos personales \n";
    cout << "Nombre: ";
    cin >> me.nombre;
    cout << "Apellido: ";
    cin >> me.apellido;
    cout << "Edad: ";
    cin >> me.edad;
    cout << "sexo: ";
    cin >> me.sexo;
    cout << "Su ocupacion: ";
    cin >> me.ocupacion;


    cout << "Hola " << me.nombre << "\n"; 
    cout <<  "edad: " << me.edad ;
    cout << "\n";
    cout << "sexo: "<<me.sexo ;
    cout << "\n";
    cout << "ocupacion: "<< me.ocupacion;

    return 0;


}
