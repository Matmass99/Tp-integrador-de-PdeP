class CiudadCostera {

	var property cantidadHabitantes = 0

	method sosSaqueablePor(unPirata) {
		return unPirata.nivelEbriedad() >= 50
	}

	method esVulnerableA(otroBarco) {
		return otroBarco.cantidadTripulantes() >= cantidadHabitantes * 0.4 || otroBarco.todosPasadosDeGrog() 
	}
	
	method sumarHabitante() {
		cantidadHabitantes++
	}
	
}