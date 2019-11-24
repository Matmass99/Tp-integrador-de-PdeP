using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Theading.Tasks;

namespace yaar
{
    public class claseCiudadCostera{
        
         public claseCiudadCostera(){
            
            int _cantidadHabitantes;
        
        }
        
        public int cantidadHabitantes { get; set;} //*este es el property de cantidad de habitantes*//
        
        public int CantidadHabitantes;

        public bool sosSaqueablePor(clasePirata unPirata) {
		    
            return unPirata.nivelEbriedad() >= 50;
	    
        }

        public bool esVulnerableA(claseBarco otroBarco) {
		    
            return otroBarco.cantidadTripulantes() >= cantidadHabitantes * 0.4 || otroBarco.todosPasadosDeGrog();
	
        }

        public sumarHabitante() {
		   
            cantidadHabitantes++;
	    
        }
    }
}



	