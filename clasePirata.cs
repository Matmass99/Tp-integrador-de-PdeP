using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Theading.Tasks;

namespace yaar
{
    public class clasePirata{

        public clasePirata(){
            int _nivelEbriedad;
            int _cantidadMonedas;
            List <string> items = new List <string>();
            clasePirata _invitante;
        }

        public List <string> items;

        public List <string> items {get {return items;} set {items = value;}} //*esto es el property de los items*//

        public int nivelEbriedad { get;  }

        public int nivelEbriedad;

        public int cantidadMonedas { get; }
        
        public int cantidadMonedas;

        public clasePirata invitante;

        public bool tiene(string unItem) {
		   
            return items.contains(unItem);
	    
        }

        public int cantidadItems() {
		   
            return items.size();
	
        }

        public bool pasadoDeGrog() {
		    
            return nivelEbriedad >= 90;
	    
        }

        public  tomarGrog() {
		
            nivelEbriedad += 5;

		    self.gastarMoneda();
	    
        }

        public  gastarMoneda() {
		    
            self.validarGastarMonedas();
		    
            cantidadMonedas--;
	
        }

        public validarGastarMonedas() {
		    if (cantidadMonedas == 0) {
			    throw new TripulanteException(message = "Cantidad de monedas insuficientes... insert coin!");
		    }
	    }
    
        public bool podesSaquear(clasePirata unaVictima) {
		
            return unaVictima.sosSaqueablePor(self);
	
        }

        public int cantidadInvitadosPara(claseBarco unBarco) {
		    
            return unBarco.cantidadInvitadosPor(self);
	    
        }

        public bool fuisteInvitadoPor(clasePirata unTripulante) { 
		    
            return invitante.equals(unTripulante);
	
        }
    }

    public class PirataEspiaDeLaCorona : Pirata {
	    
        override public bool pasadoDeGrog() {
		    
            return false;

	}

	    override public bool podesSaquear(clasePirata unaVictima) {
		    
            return super(unaVictima) && self.tiene("permiso de la corona");
	
    }	
}
    public class TripulanteException : Exception {}
}
