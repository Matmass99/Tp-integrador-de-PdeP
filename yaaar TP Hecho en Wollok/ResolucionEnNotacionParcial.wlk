/** Punto 1 **/

BusquedaDelTesoro >> esUtil(unPirata) {
  return self.tieneAlgunItemObligatorio(unPirata) && unPirata.cantidadMonedas() <= 5
}

BusquedaDelTesoro >> tieneAlgunItemObligatorio(unPirata) {
  return ['brújula', 'mapa', 'grogXD'].any { item =>  unPirata.tiene(item) }
}

Pirata >> tiene(unItem) {
  return items.contains(unItem)
}

ConvertirseEnLeyenda >> esUtil(unPirata) {
  return unPirata.cantidadItems() >= 10 && unPirata.tiene(itemObligatorio)
}

Pirata >> cantidadItems() {
  return items.size()
}

Saqueo >> esUtil(unPirata) {
  return unPirata.cantidadMonedas() < monedasParaSaquear.limite() && unPirata.podesSaquear(victima)
}

Pirata >> podesSaquear(unaVictima) {
  return unaVictima.sosSaqueablePor(self)
}

Barco >> sosSaqueablePor(unPirata) {
  return unPirata.pasadoDeGrog()
}

Pirata >> pasadoDeGrog() {
  return nivelEbriedad >= 90
}

CiudadCostera >> sosSaqueablePor(unPirata) {
  return unPirata.nivelEbriedad() >= 50
}


/** Punto 2a **/

Barco >> puedeUnirse(unPirata) {
  return self.hayLugar() && mision.esUtil(unPirata)
}

Barco >> hayLugar() {
  return self.cantidadTripulantes() < capacidad
}


/** Punto 2b **/

Barco >> agregar(unTripulante) {
  if (self.puedeUnirse(unTripulante)) {
    tripulantes.add(unTripulante)
  }
}


/** Punto 2c **/

Barco >> cambiarMision(unaMision) {
  tripulantes.removeAllSuchThat { tripulante => unaMision.esUtil(tripulante).negate() }
  mision = unaMision
}


/** Punto 3a **/

Barco >> pirataMasEbrio() {
  return tripulantes.max { tripulante => tripulante.nivelEbriedad() }
}


/** Punto 3b **/

Barco >> anclarEn(unaCiudad) {
  self.todosTomanGrog()
  self.perderMasEbrioEn(unaCiudad)
}

Barco >> todosTomanGrog() {
  tripulantes.forEach { tripulante => tripulante.tomarGrog() }
}

Barco >> perderMasEbrioEn(unaCiudad) {
  tripulantes.remove(self.pirataMasEbrio())
  unaCiudad.sumarHabitante()
}

Pirata >> tomarGrog() {
  nivelEbriedad += 5
  self.gastarMoneda()
}

Pirata >> gastarMoneda() {
  self.validarGastarMonedas()
  cantidadMonedas--
}

Pirata >> validarGastarMonedas() {
  if (cantidadMonedas == 0) {
    throw new TripulanteException(message = 'Cantidad de monedas insuficientes... insert coin!')
  }
}

CiudadCostera >> sumarHabitante() {
  cantidadHabitantes++
}


/** Punto 4a **/

Barco >> esTemible() {
  mision.esRealizablePor(self)
}

Mision >> esRealizablePor(unBarco) {
  return unBarco.tieneSuficienteTripulacion()
}

Barco >> tieneSuficienteTripulacion() {
  return self.cantidadTripulantes() >= capacidad * 0.9
}

Barco >> cantidadTripulantes() {
  return tripulantes.size()
}

BusquedaDelTesoro >> esRealizablePor(unBarco) {
  return super(unBarco) && unBarco.tiene('llave de cofre')
}

Barco >> tiene(unItem) {
  return tripulantes.any { tripulante => tripulante.tiene(unItem) }
}

Saqueo >> esRealizablePor(unBarco) {
  return super(unBarco) && victima.esVulnerableA(unBarco)
}

Barco >> esVulnerableA(otroBarco) {
  return self.cantidadTripulantes() <= otroBarco.cantidadTripulantes() / 2
}

CiudadCostera >> esVulnerableA(otroBarco) {
  return otroBarco.cantidadTripulantes() >= cantidadHabitantes * 0.4 || otroBarco.todosPasadosDeGrog()
}

Barco >> todosPasadosDeGrog() {
  return tripulantes.all { tripulante => tripulante.pasadoDeGrog() }
}


/** Punto 4b **/

PirataEspiaDeLaCorona >> pasadoDeGrog() {
  return false
}

PirataEspiaDeLaCorona >> podesSaquear(unaVictima) {
  return super(unaVictima) && self.tiene('permiso de la corona')
}


/** Punto 5a **/

Barco >> cantidadTripulantesPasadosDeGrog() {
  return self.tripulantesPasadosDeGrog().size()
}

Barco >> tripulantesPasadosDeGrog() {
  return tripulantes.filter { tripulante => tripulante.pasadoDeGrog() }
}

/** Punto 5b **/

Barco >> cantidadItemsDistintosEntreTripulantesPasadosDeGrog() {
  return self.tripulantesPasadosDeGrog().flatMap { tripulante => tripulante.items() }.asSet().size()
}


/** Punto 5c **/

Barco >> tripulantePasadoDeGrogConMasMonedas() {
  return self.tripulantesPasadosDeGrog().max { tripulante => tripulante.cantidadMonedas() }
}


/** Punto 6 **/

Barco >> tripulanteMasInvitador() {
  return tripulantes.max { tripulante => tripulante.cantidadInvitadosPara(self) }
}

Pirata >> cantidadInvitadosPara(unBarco) {
  return unBarco.cantidadInvitadosPor(self)
}

Barco >> cantidadInvitadosPor(unTripulante) {
  return tripulantes.count { tripulante => tripulante.fuisteInvitadoPor(unTripulante) }
}

Pirata >> fuisteInvitadoPor(unTripulante) {
  return invitante.equals(unTripulante)
}
