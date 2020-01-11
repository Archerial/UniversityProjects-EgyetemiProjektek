package dao;

import exceptions.CarNotFound;
import exceptions.EzAzAutoMarSzerepel;
import model.Car;

import java.util.Collection;

public interface ICarDAO {
    void addCar(Car car) throws EzAzAutoMarSzerepel;
    Car readCarByLicensePlate(String license_plate) throws CarNotFound;
    Collection<Car> readAllCar();
}
