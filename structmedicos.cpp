#include <iostream>
#include <string>
using namespace std;

struct medico{
    string nombreMedico;
    string especialidad;
    string areaMedica;
    int edad;

}medicos={"Fernanda","medico","directora general",32};

int main () 
{
   
cout<<"los datos del medico son  :";
cout<<medicos.nombreMedico;
cout<<medicos.especialidad;
cout<<medicos.areaMedica;
cout<<medicos.edad;
  return 0;
}
