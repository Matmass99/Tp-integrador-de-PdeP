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
            int _capacidad;
            claseMision _mision;
            List <clasePirata> tripulante = new List <clasePirata>();
        }

        public claseMision mision ;
        
        public int Capacidad { get; set; }
        
        public List <clasePirata> tripulante;
        
        public List <clasePirata> tripulante {get {return tripulante;} set {tripulante = value;}}


        public bool sosSaqueablePor(clasePirata unPirata) {
		
            return unPirata.pasadoDeGrog();
	    
        }
        
        public bool esVulnerableA(claseBarco otroBarco){
           
            return self.cantidadTripulantes() <= otroBarco.cantidadTripulantes() / 2;
        
        }
        
        public int cantidadTripulantes() {
		
            return tripulante.size();
	    
        }

        public bool todosPasadosDeGrog() {
		
            return tripulantes.all ((clasePirata tripulante) => tripulante.pasadoDeGrog());
	    
        }

        public bool  puedeUnirse(clasePirata unPirata) {
		
            return self.hayLugar() && mision.esUtil(unPirata);
	    
        }
        
        public bool hayLugar() {
		    
            return self.cantidadTripulantes() < capacidad;
	    
        }

        public void agregar(clasePirata unTripulante) {
		    
            if (self.puedeUnirse(unTripulante)) {
			
                tripulantes.add(unTripulante);
		    
            }

	    }

        public void cambiarMision(claseMision unaMision) {
		   
            tripulantes.removeAllSuchThat ((clasePirata tripulante) => unaMision.esUtil(tripulante).negate());
		   
            mision = unaMision;
	    
        }

        public void anclarEn(claseCiudadCostera unaCiudad) {
		    
            self.todosTomanGrog();
		    
            self.perderMasEbrioEn(unaCiudad);
	   
        }

        public void todosTomanGrog() {
		
        tripulantes.forEach ((clasePirata tripulante) => tripulante.tomarGrog());
	    
        }

        public void perderMasEbrioEn(claseCiudadCostera unaCiudad) {
            
            tripulantes.remove(self.pirataMasEbrio());
		
            unaCiudad.sumarHabitante();
	    
        }

        public void esTemible() {
		    
            mision.esRealizablePor(self);
	    
        }

        public bool tieneSuficienteTripulacion() {

		    return self.cantidadTripulantes() >= capacidad * 0.9;
	
         }

        public bool tiene(String unItem) {
		
            return tripulantes.any ((clasePirata tripulante) => tripulante.tiene(unItem));
	    
        }

        public int cantidadTripulantesPasadosDeGrog() {

		    return self.tripulantesPasadosDeGrog().size();
	
        }

        public int cantidadItemsDistintosEntreTripulantesPasadosDeGrog() {
		
            return self.tripulantesPasadosDeGrog().flatMap ((clasePirata tripulante) => tripulante.items()).asSet().size();
	
        }

        public int cantidadInvitadosPor(clasePirata unTripulante) {
		
            return tripulantes.count ((clasePirata tripulante) => tripulante.fuisteInvitadoPor(unTripulante));
	    
        }

        public todosTomanGrog() {

		    tripulantes.forEach ((clasePirata tripulante) => tripulante.tomarGrog());
	    
        }

}
}


/*/* Esto no tengo idea de como se declara, 
tampoco que tipo hay que poner de retorno si lo que se retorna es un objeto
 y es lo que falta declarar en cada clase.

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
	
	

*/