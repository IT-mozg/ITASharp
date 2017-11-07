public abstract class Computer {
    private String macAddress;

    public void setMacAddress(String macAddress){
        this.macAddress = macAddress;
    }

    public String getMacAddress(){
        return macAddress;
    }

    public Computer(String macAddress){
        setMacAddress(macAddress);
    }
    public Computer(){}

    public abstract void turnOn();
    public abstract void turnOff();
}
