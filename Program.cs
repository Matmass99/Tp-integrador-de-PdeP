using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Theading.Tasks;

namespace yaar
{
    class Program
    {
        static void Main(string[] args)
        {
            claseBarco barco;
            barco  = new claseBarco();
            barco.capacidad = 1000;
            claseCiudadCostera ciudadCostera;
            ciudadCostera  = new ciudadCostera();
            ciudadCostera.cantidadHabitantes = 100000;
            clasePirata pirata;
            pirata = new clasePirata();
            pirata.nivelEbriedad = 10;
            pirata.cantidadMonedas = 150;
            claseBusquedaDelTesoro busquedaDelTesoro;
            busquedaDelTesoro = new claseBusquedaDelTesoro();
            claseConvertirseEnLeyenda convertirseEnLeyenda;
            convertirseEnLeyenda = new claseConvertirseEnLeyenda();
            claseSaqueo saqueo;
            saqueo  = new claseSaqueo(); 
        }
    }
}
