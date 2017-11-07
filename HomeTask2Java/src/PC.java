public class PC extends Computer implements ISleep{
    public PC(){}
    public PC(String macAddress){
        super(macAddress);
    }

    @Override
    public void turnOn() {
        System.out.println("PC turn on!");
    }

    @Override
    public void turnOff() {
        System.out.println("PC turn off!");
    }

    @Override
    public void sleep() {
        System.out.println("PC in sleep mode!");
    }

    @Override
    public String toString(){
        return String.format("\t" + getClass() + "\n\tmacAddress = " + getMacAddress());
    }
}
