package dao;

import exceptions.EzAzAutoMarSzerepel;
import exceptions.InvalidDate;
import exceptions.TheCarIsTooOld;
import exceptions.TheCurrentKilometerCantBeNegative;
import org.junit.*;
import model.Car;
import model.Fuel;

import java.io.File;
import java.io.IOException;
import java.time.LocalDate;


public class CarDAOTest {
    ICarDAO dao;
    static String file ="Logolas.json";

    @BeforeClass
    public static void setUp(){
        File jsonFile = new File(file);
        if (jsonFile.exists()){
            jsonFile.delete();
        }
    }

    @Before
    public void setTest() throws InvalidDate, IOException, TheCurrentKilometerCantBeNegative, EzAzAutoMarSzerepel, TheCarIsTooOld {
        dao = new CarDAO(file);
        Car car = new Car();
        car.setLicense_plate("AAA-000");
        car.setBrand("Ford");
        car.setType("Focus");
        car.setNumber_of_doors(5);
        car.setFuel(Fuel.DISEL);
        car.setMade(LocalDate.of(2013,04,21));
        car.setCurrent_kilometer(54000.34);
        dao.addCar(car);
        Car car2 = new Car();
        car2.setLicense_plate("BBB-111");
        car2.setBrand("AlfaRomeo");
        car2.setType("XCv1");
        car2.setNumber_of_doors(3);
        car2.setFuel(Fuel.PETROL);
        car2.setMade(LocalDate.of(1988,03,20));
        car2.setCurrent_kilometer(540.4);
        dao.addCar(car2);
        Car car3 = new Car();
        car3.setLicense_plate("CCC-444");
        car3.setBrand("Tesla");
        car3.setType("Roadster");
        car3.setNumber_of_doors(3);
        car3.setFuel(Fuel.ELECTRCONIC);
        car3.setMade(LocalDate.of(2010,11,04));
        car3.setCurrent_kilometer(543.43);
        dao.addCar(car3);

    }

    @Test(expected = EzAzAutoMarSzerepel.class)
    public void testEzAzAutoMarSzerepel() throws TheCurrentKilometerCantBeNegative, InvalidDate, EzAzAutoMarSzerepel, TheCarIsTooOld {
        Car car4 = new Car();
        car4.setLicense_plate("AAA-000");
        car4.setBrand("Ford");
        car4.setType("Focus");
        car4.setNumber_of_doors(5);
        car4.setFuel(Fuel.DISEL);
        car4.setMade(LocalDate.of(2013,04,21));
        car4.setCurrent_kilometer(54000.34);
        System.out.println(car4);
        dao.addCar(car4);
    }

    @Test(expected = InvalidDate.class)
    public void testInvalidDate() throws InvalidDate, TheCurrentKilometerCantBeNegative, TheCarIsTooOld {
        Car car5 = new Car();
        car5.setLicense_plate("ABC-123");
        car5.setBrand("Reanult");
        car5.setType("Megan");
        car5.setNumber_of_doors(5);
        car5.setFuel(Fuel.DISEL);
        car5.setMade(LocalDate.of(2100,03,04));
        car5.setCurrent_kilometer(150000.6);
    }

    @Test(expected = TheCurrentKilometerCantBeNegative.class)
    public void testInvalidKilometer() throws TheCurrentKilometerCantBeNegative, InvalidDate, TheCarIsTooOld {
        Car car = new Car();
        car.setLicense_plate("AAA-000");
        car.setBrand("Ford");
        car.setType("Focus");
        car.setNumber_of_doors(5);
        car.setFuel(Fuel.DISEL);
        car.setMade(LocalDate.of(2013,04,21));
        car.setCurrent_kilometer(-1234.43);
    }

    @After
    public void fileDelete(){
        File jsonfile = new File(file);
        if (jsonfile.exists()){
            jsonfile.delete();
        }
    }


    }







