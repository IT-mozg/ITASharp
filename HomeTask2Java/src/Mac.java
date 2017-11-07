public class Mac extends Computer implements ISleep{
    public Mac(){}
    public Mac(String macAddress){
        super(macAddress);
    }

    @Override
    public void turnOn() {
        System.out.println("Mac turn on!");
    }

    @Override
    public void turnOff() {
        System.out.println("Mac turn off!");
    }

    @Override
    public void sleep() {
        System.out.println("Mac in sleep mode!");
    }

    @Override
    public String toString(){
        return String.format("\t" + getClass() + "\n\tmacAddress = " + getMacAddress());
    }
}
