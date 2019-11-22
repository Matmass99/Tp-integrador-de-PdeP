using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Theading.Tasks;

namespace yaar
{

    public class claseBarco{

        public claseBarco(){
            Capacidad = 0;
            Tripulante = [];
        }
        public
        public int Capacidad { get; set; }
/* Supuestamente soon las listas pero no se si se declaran asi
        private ArrayList _Tripulante;
        
        public ArrayList Tripulante{

            get {return _Tripulante;}
            set {_Tripulante = value;}
        }
*/
        public bool sosSaqueablePor(unPirata) {
		
            return unPirata.pasadoDeGrog();
	    
        }
        
        public bool esVulnerableA(otroBarco){
           
            return self.cantidadTripulantes() <= otroBarco.cantidadTripulantes() / 2;
        
        }
        
        public int cantidadTripulantes() {
		
            return tripulantes.size();
	    
        }

        public bool todosPasadosDeGrog() {
		
            return tripulantes.all { tripulante => tripulante.pasadoDeGrog() };
	    
        }

        public bool  puedeUnirse(unPirata) {
		
            return self.hayLugar() && mision.esUtil(unPirata);
	    
        }
        
        public bool hayLugar() {
		    
            return self.cantidadTripulantes() < capacidad;
	    
        }

        public  agregar(unTripulante) {
		    
            if (self.puedeUnirse(unTripulante)) {
			
                tripulantes.add(unTripulante);
		    
            }

	    }

        public cambiarMision(unaMision) {
		   
            tripulantes.removeAllSuchThat { tripulante => unaMision.esUtil(tripulante).negate() };
		   
            mision = unaMision;
	    
        }

        public  anclarEn(unaCiudad) {
		    
            self.todosTomanGrog();
		    
            self.perderMasEbrioEn(unaCiudad);
	   
        }

        public todosTomanGrog() {
		
        tripulantes.forEach { tripulante => tripulante.tomarGrog()};
	    
        }

        public  perderMasEbrioEn(unaCiudad) {
            
            tripulantes.remove(self.pirataMasEbrio());
		
            unaCiudad.sumarHabitante();
	    
        }

        public esTemible() {
		    
            mision.esRealizablePor(self);
	    
        }

        public bool tieneSuficienteTripulacion() {

		    return self.cantidadTripulantes() >= capacidad * 0.9;
	
         }

        public bool tiene(unItem) {
		
            return tripulantes.any { tripulante => tripulante.tiene(unItem)};
	    
        }

        public int cantidadTripulantesPasadosDeGrog() {

		    return self.tripulantesPasadosDeGrog().size();
	
        }

        public int cantidadItemsDistintosEntreTripulantesPasadosDeGrog() {
		
            return self.tripulantesPasadosDeGrog().flatMap { tripulante => tripulante.items() }.asSet().size();
	
        }

        public int cantidadInvitadosPor(unTripulante) {
		
            return tripulantes.count { tripulante => tripulante.fuisteInvitadoPor(unTripulante) };
	    
        }

        public todosTomanGrog() {

		    tripulantes.forEach { tripulante => tripulante.tomarGrog() };
	    
        }

}


/*/* Esto no tengo idea de como se declara, 
tampoco que tipo hay que poner de retorno si lo que se retorna es un objeto
 y es lo que falta declarar en cada clase.


class Barco {

	var mision
	const property tripulantes = []
	
	
	method pirataMasEbrio() {
		return tripulantes.max { tripulante => tripulante.nivelEbriedad() }
	}
	
	method tripulantesPasadosDeGrog() {
		return tripulantes.filter { tripulante => tripulante.pasadoDeGrog() }
	}

	method tripulantePasadoDeGrogConMasMonedas() {
		return self.tripulantesPasadosDeGrog().max { tripulante => tripulante.cantidadMonedas() }
	}

	method tripulanteMasInvitador() {
		return tripulantes.max { tripulante => tripulante.cantidadInvitadosPara(self) }
	}
	
	
}
*/