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
            barco.mision = busquedaDelTesoro;
            var piratas= new List<clasePirata>{pirata};
            barco.tripulantes = piratas;
            claseCiudadCostera ciudadCostera;
            ciudadCostera  = new ciudadCostera();
            ciudadCostera.cantidadHabitantes = 100000;
            clasePirata pirata;
            pirata = new clasePirata();
            pirata.nivelEbriedad = 10;
            pirata.cantidadMonedas = 150;
            var itemsQueLleva = new List<string>{"permiso de la corona","espada"};
            pirata.items = itemsQueLleva;
            pirata.invitante = pirata2;
            clasePirata pirata2;
            pirata2 = new clasePirata();
            pirata2.nivelEbriedad = 20;
            pirata2.cantidadMonedas = 250;
            var itemsQueLleva2 = new List<string>{"permiso de la corona","sombrero"};
            pirata2.items = itemsQueLleva2;
            pirata2.invitante = null;
            claseBusquedaDelTesoro busquedaDelTesoro;
            busquedaDelTesoro = new claseBusquedaDelTesoro();
            claseConvertirseEnLeyenda convertirseEnLeyenda;
            convertirseEnLeyenda = new claseConvertirseEnLeyenda();
            convertirseEnLeyenda.itemObligatorio = "espada";
            claseSaqueo saqueo;
            saqueo  = new claseSaqueo(); 
            saqueo.victima = ciudadCostera;
            
        }
    }
}
