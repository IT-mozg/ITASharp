class Mac(macAddress: String) : Computer(macAddress), ISleep {

    override fun sleep() {
        println("Mac in sleep mode!")
    }

    override fun turnOff() {
        println("Mac turn off!")
    }

    override fun turnOn() {
        println("Mac turn on!")
    }
}