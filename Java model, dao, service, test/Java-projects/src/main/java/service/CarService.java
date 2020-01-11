package service;

import exceptions.CarNotFound;
import exceptions.EzAzAutoMarSzerepel;
import dao.ICarDAO;
import model.Car;

import java.util.ArrayList;
import java.util.Collection;

public class CarService {
    ICarDAO carDAO;

    public CarService(ICarDAO carDAO)
    {
        this.carDAO = carDAO;
    }

    public void addCar(Car car) throws EzAzAutoMarSzerepel {
        carDAO.addCar(car);
    }

    public Car readCarByLicensePlate(String license_plate) throws CarNotFound{
        return carDAO.readCarByLicensePlate(license_plate);
    }

    public Collection<Car> readAllCar() {
        return carDAO.readAllCar();
    }

}
