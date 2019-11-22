class Barco {

	var mision
	const capacidad
	const property tripulantes = []
	
	method sosSaqueablePor(unPirata) {
		return unPirata.pasadoDeGrog()
	}

	method esVulnerableA(otroBarco) {
		return self.cantidadTripulantes() <= otroBarco.cantidadTripulantes() / 2
	}
	
	method cantidadTripulantes() {
		return tripulantes.size()
	}

	method todosPasadosDeGrog() {
		return tripulantes.all { tripulante => tripulante.pasadoDeGrog() }
	}

	method puedeUnirse(unPirata) {
		return self.hayLugar() && mision.esUtil(unPirata)
	}
	
	method hayLugar() {
		return self.cantidadTripulantes() < capacidad
	}

	method agregar(unTripulante) {
		if (self.puedeUnirse(unTripulante)) {
			tripulantes.add(unTripulante)
		}
	}
	
	method cambiarMision(unaMision) {
		tripulantes.removeAllSuchThat { tripulante => unaMision.esUtil(tripulante).negate() }
		mision = unaMision
	}
	
	method pirataMasEbrio() {
		return tripulantes.max { tripulante => tripulante.nivelEbriedad() }
	}
	
	method anclarEn(unaCiudad) {
		self.todosTomanGrog()
		self.perderMasEbrioEn(unaCiudad)
	}
	
	method todosTomanGrog() {
		tripulantes.forEach { tripulante => tripulante.tomarGrog() }
	}
	
	method perderMasEbrioEn(unaCiudad) {
		tripulantes.remove(self.pirataMasEbrio())
		unaCiudad.sumarHabitante()
	}
	
	method esTemible() {
		mision.esRealizablePor(self)
	}
	
	method tieneSuficienteTripulacion() {
		return self.cantidadTripulantes() >= capacidad * 0.9
	}
	
	method tiene(unItem) {
		return tripulantes.any { tripulante => tripulante.tiene(unItem) }
	}
	
	method cantidadTripulantesPasadosDeGrog() {
		return self.tripulantesPasadosDeGrog().size()
	}
	
	method cantidadItemsDistintosEntreTripulantesPasadosDeGrog() {
		return self.tripulantesPasadosDeGrog().flatMap { tripulante => tripulante.items() }.asSet().size()
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
	
	method cantidadInvitadosPor(unTripulante) {
		return tripulantes.count { tripulante => tripulante.fuisteInvitadoPor(unTripulante) }
	}
}
