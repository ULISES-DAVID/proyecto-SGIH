#include <iostream>
#include <string>
using namespace std;

struct Empleado {
    int edad;
    string nombre;
    string puesto;
    float salario;
    char genero; 
};

int main() {
    
    Empleado empleado1;

    cout << "Introduce el nombre del empleado: ";
    getline(cin, empleado1.nombre);
    
    cout << "Introduce la edad del empleado: ";
    cin >> empleado1.edad;
    cin.ignore(); 
    
    cout << "Introduce el puesto del empleado: ";
    getline(cin, empleado1.puesto);
    
    cout << "Introduce el salario del empleado: ";
    cin >> empleado1.salario;
    cin.ignore(); 
    
    cout << "Introduce el género del empleado (M/F): ";
    cin >> empleado1.genero;

    
    cout << "\nDatos del Empleado:" << endl;
    cout << "Nombre: " << empleado1.nombre << endl;
    cout << "Edad: " << empleado1.edad << endl;
    cout << "Puesto: " << empleado1.puesto << endl;
    cout << "Salario: " << empleado1.salario << endl;
    cout << "Género: " << empleado1.genero << endl;

    return 0;
}