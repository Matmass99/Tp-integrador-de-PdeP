using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Theading.Tasks;

namespace yaar
{
    public class claseMision{

        
        public bool esRealizablePor(claseBarco unBarco) {
		    
            return unBarco.tieneSuficienteTripulacion();
	    
        }
    }

    public class claseBusquedaDelTesoro : claseMision {

        public bool esUtil(clasePirata unPirata) {
		
            return self.tieneAlgunItemObligatorio(unPirata) && unPirata.cantidadMonedas() <= 5;
	    
        }

        public bool tieneAlgunItemObligatorio(clasePirata unPirata){ 
            
            var objetos = new List<String>{"brújula", "mapa", "grogXD"};

            return objetos.any((string item) => unPirata.tiene(item));
        
        }
	    
        

        override public bool esRealizablePor(claseBarco unBarco) {
		    
            return super(unBarco) && unBarco.tiene("llave de cofre");
	    
        }
    }

    public class claseConvertirseEnLeyenda : claseMision {

	    
        public claseconvertirseEnLeyenda(){

            string _itemObligatorio;
        }

        public string itemObligatorio;

	    public bool esUtil(clasePirata unPirata) {

		    return unPirata.cantidadItems() >= 10 && unPirata.tiene(itemObligatorio);
	
        }

    }
    public class claseSaqueo : claseMision {

         public claseSaqueo(){

            clasePirata _victima ;
        }

        public clasePirata victima;


	    public bool esUtil(clasePirata unPirata) {
		
            return unPirata.cantidadMonedas() < monedasParaSaquear.Instance().limite() && victima.sosSaqueablePor(unPirata);
	    
        }

	    override public bool esRealizablePor(claseBarco unBarco) {
		    
            return super(unBarco) && victima.esVulnerableA(unBarco);
	    
        }

    }

    public class monedasParaSaquear{/*esto es para crear el objeto monedaParaSaquear*/
    
        public int limite = 0;
        
        
        private static readonly Lazy<monedasParaSaquear> instance = new Lazy<monedasParaSaquear>(() => new monedasParaSaquear());
    
        private monedasParaSaquear(){
        
        }
    
        public static monedasParaSaquear Instance{
            
            get{
            
                return instance.Value;
            
            }
        }
    }
    

} 
