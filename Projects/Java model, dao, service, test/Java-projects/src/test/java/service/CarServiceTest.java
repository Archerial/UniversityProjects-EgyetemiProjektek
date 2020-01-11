package service;

import exceptions.CarNotFound;
import exceptions.EzAzAutoMarSzerepel;
import org.junit.AfterClass;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.mockito.Mock;
import org.mockito.Mockito;
import dao.ICarDAO;
import model.Car;
import model.Fuel;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.Collection;
import static org.junit.Assert.*;

public class CarServiceTest {
    static CarService service;

    @Before
    @Test
    public void setUp() throws CarNotFound, EzAzAutoMarSzerepel {
        ICarDAO mock = Mockito.mock(ICarDAO.class);
        service = new CarService(mock);
        Car car = new Car("Audi","A4","GLF-109",5,Fuel.DISEL,LocalDate.of(2015,11,04),12500.5);
        Car car2 = new Car("Jaguar","Qx7","RAP-503",3,Fuel.DISEL,LocalDate.of(2017,01,12),1500);
        Collection<Car> cars = new ArrayList<>();
        cars.add(car);
        cars.add(car2);
        Mockito.when(mock.readAllCar()).thenReturn(cars);
        Mockito.when(mock.readCarByLicensePlate("GLF-109")).thenReturn(car);
        Mockito.when(mock.readCarByLicensePlate("GLF")).thenThrow(CarNotFound.class);
        Mockito.doThrow(EzAzAutoMarSzerepel.class).when(mock).addCar(car);
    }

    @Test
    public void testMockObject(){
        System.out.println(service.readAllCar());
    }

    @Test
    public void testReadCarByLicensePlate() throws CarNotFound {
        System.out.println(service.readCarByLicensePlate("GLF-109"));
    }

    @Test(expected = CarNotFound.class)
    public void testCarNotFound() throws CarNotFound {
        service.readCarByLicensePlate("GLF");
    }


    @Test(expected = EzAzAutoMarSzerepel.class)
    public void testDuplicate() throws EzAzAutoMarSzerepel {
        Car car = new Car("Audi","A4","GLF-109",5,Fuel.DISEL,LocalDate.of(2015,11,04),12500.5);
        try {
            service.addCar(car);
        } catch (EzAzAutoMarSzerepel ezAzAutoMarSzerepel) {
            throw ezAzAutoMarSzerepel;
        }
    }




}
