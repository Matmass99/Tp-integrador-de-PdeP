using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Theading.Tasks;

namespace yaar
{
    public class claseMision{

        public bool esRealizablePor(unBarco) {
		    
            return unBarco.tieneSuficienteTripulacion();
	    
        }
    }

    public class claseBusquedaDelTesoro : claseMision {

        public bool esUtil(unPirata) {
		
            return self.tieneAlgunItemObligatorio(unPirata) && unPirata.cantidadMonedas() <= 5;
	    
        }

        public bool tieneAlgunItemObligatorio(unPirata) {
		    
            return ['brújula', 'mapa', 'grogXD'].any { item =>  unPirata.tiene(item) };
	    
        }

        override public bool esRealizablePor(unBarco) {
		    
            return super(unBarco) && unBarco.tiene('llave de cofre');
	    
        }
    }

    public class claseConvertirseEnLeyenda : claseMision {

	    

	    public bool esUtil(unPirata) {

		    return unPirata.cantidadItems() >= 10 && unPirata.tiene(itemObligatorio);
	
        }

    }
    public class claseSaqueo : claseMision {

	    public bool esUtil(unPirata) {
		
            return unPirata.cantidadMonedas() < monedasParaSaquear.limite() && victima.sosSaqueablePor(unPirata);
	    
        }

	    override public bool esRealizablePor(unBarco) {
		    
            return super(unBarco) && victima.esVulnerableA(unBarco);
	    
        }

    }

}


/* Esto no tengo idea de como se declara un objeto, y es lo que falta declarar en cada clase. 

class ConvertirseEnLeyenda inherits Mision {

	const itemObligatorio

	

class Saqueo inherits Mision {

	const victima

	

object monedasParaSaquear {
	var property limite = 0
}
*/