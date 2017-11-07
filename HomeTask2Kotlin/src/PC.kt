class PC(macAddress: String) : Computer(macAddress), ISleep {

    override fun sleep() {
        println("PC in sleep mode!")
    }

    override fun turnOff() {
        println("PC turn off!")
    }

    override fun turnOn() {
        println("PC turn on!")
    }
}