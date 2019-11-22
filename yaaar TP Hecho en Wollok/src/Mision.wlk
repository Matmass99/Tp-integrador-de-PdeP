class Mision {
	method esRealizablePor(unBarco) {
		return unBarco.tieneSuficienteTripulacion()
	}
}

class BusquedaDelTesoro inherits Mision {

	method esUtil(unPirata) {
		return self.tieneAlgunItemObligatorio(unPirata) && unPirata.cantidadMonedas() <= 5
	}

	method tieneAlgunItemObligatorio(unPirata) {
		return ['brújula', 'mapa', 'grogXD'].any { item =>  unPirata.tiene(item) }
	}
	
	override method esRealizablePor(unBarco) {
		return super(unBarco) && unBarco.tiene('llave de cofre')
	}

}

class ConvertirseEnLeyenda inherits Mision {

	const itemObligatorio

	method esUtil(unPirata) {
		return unPirata.cantidadItems() >= 10 && unPirata.tiene(itemObligatorio)
	}

}

class Saqueo inherits Mision {

	const victima

	method esUtil(unPirata) {
		return unPirata.cantidadMonedas() < monedasParaSaquear.limite() && victima.sosSaqueablePor(unPirata)
	}

	override method esRealizablePor(unBarco) {
		return super(unBarco) && victima.esVulnerableA(unBarco)
	}

}

object monedasParaSaquear {
	var property limite = 0
}