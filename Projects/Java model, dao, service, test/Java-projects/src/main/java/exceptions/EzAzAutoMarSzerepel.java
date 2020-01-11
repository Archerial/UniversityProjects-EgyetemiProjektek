package exceptions;

import model.Car;

public class EzAzAutoMarSzerepel extends Throwable {
    public EzAzAutoMarSzerepel(Car car){
        super(car.toString());
    }
}
