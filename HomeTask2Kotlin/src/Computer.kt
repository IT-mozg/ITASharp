public abstract class Computer(var macAddress:String) {

    //    var macAddress: String = ""
//        set(value)
//        { field = value}
//
//    constructor(){}
//    constructor(macAddress: String) : this(){
//        this.macAddress = macAddress
//    }
    abstract fun turnOn();
    abstract fun turnOff();

    override fun toString(): String {
        return String.format("macAddress = ${macAddress} ")
    }
}