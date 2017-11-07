

public class Main {
    public static void main(String[] args) {
        Computer[] comps = {
                new Mac("1".hashCode()+""),
                new Mac("2".hashCode()+""),
                new PC("3".hashCode()+"")
        };

        for(int i = 0; i < comps.length; i++){
            System.out.println(comps[i]);
            comps[i].turnOn();
            comps[i].turnOff();
            System.out.println();
        }
        System.out.println();

        ISleep[] icomps = {
                new Mac("1".hashCode()+""),
                new Mac("2".hashCode()+""),
                new PC("3".hashCode()+"")
        };

        for ( ISleep c : icomps) {
            System.out.println(c);
            c.sleep();
        }

    }
}
