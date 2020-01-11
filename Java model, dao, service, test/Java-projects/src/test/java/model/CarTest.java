package model;

import com.fasterxml.jackson.databind.ObjectMapper;
import org.junit.Before;
import org.junit.Ignore;
import org.junit.Test;
import model.Fuel;
import model.Car;

import java.io.File;
import java.io.IOException;
import java.time.LocalDate;
import java.util.*;

public class CarTest {

    @Before
    @Test
    public void testEmptyContructor(){
        Car newCar = new Car();
        System.out.println(newCar);
    }

    @Test
    public void testFullConstructor(){
        Car newCar = new Car("Opel",
                "Astra",
                "ABC-123",
                4,
                Fuel.PETROL,
                LocalDate.of(2012,11,01),
                55.56);
        System.out.println(newCar);
    }

}
