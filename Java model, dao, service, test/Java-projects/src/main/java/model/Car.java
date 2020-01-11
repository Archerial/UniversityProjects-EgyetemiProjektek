package model;

import exceptions.InvalidDate;
import exceptions.TheCarIsTooOld;
import exceptions.TheCurrentKilometerCantBeNegative;
import org.apache.log4j.Logger;

import java.time.LocalDate;
import java.util.HashMap;
import java.util.Map;
import java.util.Objects;


public class Car {
    private Logger logger = Logger.getLogger(String.valueOf(Car.class));

    private String brand;
    private String type;
    private String license_plate;
    private int number_of_doors;
    private Fuel fuel;
    private LocalDate made;
    private double current_kilometer;

    public Car() {
    }

    public Car(String brand, String type, String license_plate, int number_of_doors, Fuel fuel, LocalDate made, double current_kilometer){
        this.brand = brand;
        this.type = type;
        this.license_plate = license_plate;
        this.number_of_doors = number_of_doors;
        this.fuel = fuel;
        this.made = made;
        this.current_kilometer = current_kilometer;
        logger.info("Uj autó!" + this);
    }

    public String getBrand() {
        return brand;
    }
    public void setBrand(String brand){
        this.brand = brand;
    }

    public String getType(){
        return type;
    }
    public void setType(String type){
        this.type = type;
    }

    public String getLicense_plate(){
        return license_plate;
    }
    public void setLicense_plate(String license_plate){
        this.license_plate = license_plate;
    }

    public int getNumber_of_doors(){
        return number_of_doors;
    }
    public void setNumber_of_doors(int number_of_doors) {
        this.number_of_doors = number_of_doors;
    }

    public Fuel getFuel() {
        return fuel;
    }
    public void setFuel(Fuel fuel){
        this.fuel = fuel;
    }

    public LocalDate getMade(){
        return made;
    }
    public void setMade(LocalDate made) throws InvalidDate, TheCarIsTooOld {
        if (made.isAfter(LocalDate.now())){
            throw new InvalidDate();
        }

        this.made = made;
    }

    public double getCurrent_kilometer(){
        return  current_kilometer;
    }
    public void setCurrent_kilometer(double current_kilometer) throws TheCurrentKilometerCantBeNegative {
        if (current_kilometer < 0) {
            throw new TheCurrentKilometerCantBeNegative();
        }
        this.current_kilometer = current_kilometer;
    }

    @Override
    public String toString(){
        return "Car{" +
                "Renddszám:'" + license_plate + '\'' +
                ", Márka:'" + brand + '\'' +
                ", Típus:" + type +
                ", Ajtók száma:" + number_of_doors +
                ", Üzemanyag:" + fuel +
                ", Gyártási dátum:" + made +
                ", Kilométer óra állása:" + current_kilometer +
                '}';
    }


    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Car car = (Car) o;
        return number_of_doors == car.number_of_doors &&
                Double.compare(car.current_kilometer, current_kilometer) == 0 &&
                Objects.equals(logger, car.logger) &&
                Objects.equals(brand, car.brand) &&
                Objects.equals(type, car.type) &&
                Objects.equals(license_plate, car.license_plate) &&
                fuel == car.fuel &&
                Objects.equals(made, car.made);
    }

    @Override
    public int hashCode() {
        return Objects.hash(logger, brand, type, license_plate, number_of_doors, fuel, made, current_kilometer);
    }
}
