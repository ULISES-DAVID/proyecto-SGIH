#include <iostream>
using namespace std;
struct Medico
{
    string nombre;
    int edad;
};
int main()
{
    Medico medico;
    cout<<"Digite su nombre ";
    cin>>medico.nombre;
    cout<<"Digite su edad ";
    cin>>medico.edad;
    cout<<"Bienvenido "<<medico.nombre;
    return 0;
}