package dao;

import com.fasterxml.jackson.core.JsonGenerationException;
import com.fasterxml.jackson.core.JsonParseException;
import com.fasterxml.jackson.databind.JsonMappingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.datatype.jsr310.JavaTimeModule;
import exceptions.CarNotFound;
import exceptions.EzAzAutoMarSzerepel;
import model.Car;
import org.apache.log4j.Logger;
import com.fasterxml.jackson.core.JsonParseException;
import com.fasterxml.jackson.core.type.TypeReference;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Collection;

public class CarDAO implements ICarDAO{

    File jsonFile;
    ObjectMapper mapper = new ObjectMapper();
    TypeReference listReference;
    private Logger logger = Logger.getLogger(CarDAO.class);

    public CarDAO(String jsonFilePath) throws IOException {
        jsonFile = new File(jsonFilePath);
        if (!jsonFile.exists()) {
            try {
                jsonFile.createNewFile();
                FileWriter writer = new FileWriter(jsonFile);
                writer.write("()");
                writer.close();
            } catch (IOException e){
                e.printStackTrace();
            }
        }
        mapper = new ObjectMapper();
        mapper.registerModule(new JavaTimeModule());
        listReference = new com.fasterxml.jackson.core.type.TypeReference<ArrayList<Car>>(){};
        logger.debug("--DAO--");
        logger.info("--Logger info--");
    }

    @Override
    public void addCar(Car car) throws EzAzAutoMarSzerepel {
        try{
            readCarByLicensePlate(car.getLicense_plate());
            throw new EzAzAutoMarSzerepel(car);
        } catch (CarNotFound carNotFound) {
            Collection<Car> result = readAllCar();
            result.add(car);
            try{
                mapper.writeValue(jsonFile, result);
                logger.info(car + " hozzáadva, igy az autók száma: " + result.size());
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }

    @Override
    public Car readCarByLicensePlate(String license_plate) throws CarNotFound {
        Collection<Car> cars = new ArrayList<>();
        try{
            cars = mapper.readValue(jsonFile, listReference);
            for (Car c: cars){
                if (c.getLicense_plate().equalsIgnoreCase(license_plate)){
                    return  c;
                }
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
        throw new CarNotFound(license_plate);
    }

    @Override
    public Collection<Car> readAllCar() {
        Collection<Car> result = new ArrayList<>();
        try {
            result = mapper.readValue(jsonFile, listReference);
        } catch (JsonParseException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
        logger.info(result.size() + " autó van az adatbázisban ");
        return result;
    }
}
