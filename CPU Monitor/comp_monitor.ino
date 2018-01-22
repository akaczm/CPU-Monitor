#include <Wire.h>
#include <LiquidCrystal_PCF8574.h>

LiquidCrystal_PCF8574 lcd(0x3F);
String inData;
String sensorType = "U";

void setup()
{
	Serial.begin(9600);
	lcd.begin(16, 2);
	lcd.setBacklight(255);
	lcd.setCursor(1, 0);
	lcd.print("#NOT CONNECTED#");
  /* add setup code here */

}

void loop()
{
	while (Serial.available() > 0)
	{
	  char recieved = Serial.read();
	  inData += recieved;
    if (recieved == '*')
    {
      inData.remove(inData.length() - 1,1);

      if (inData == "ID1")
      {
        lcd.clear();
        lcd.setCursor(0,0);
      }

      else if (inData == "ID2")
      {
        lcd.setCursor(0,1);
      }

      else if (inData == "Temperature")
      {
        sensorType = "T";
      }

      else if (inData == "Fan")
      {
        sensorType = "F";
      }

      else if (inData == "Load")
      {
        sensorType = "L";
      }

      else if (inData == "Clock")
      {
        sensorType = "C";
      }

      else if (inData == "CPU")
      {
        lcd.print("CPU");
      }

      else if (inData == "GPU")
      {
        lcd.print("GPU");
      }

      else if (inData == "DIS")
      {
        lcd.clear();
        lcd.setCursor(1, 0);
        lcd.print("#NOT CONNECTED#");
      }

      else
      {
        if (sensorType == "T")
        {
          lcd.print(" Temp: " + inData + char(223)+"C ");
        }
        else if (sensorType == "L")
        {
          lcd.print(" Load: " + inData + "%");
        }
        else if (sensorType == "F")
        {
          lcd.print(" Fan: " + inData + " RPM");
        }
        else if (sensorType == "C")
        {
          lcd.print(" Cl: " + inData + "MHz");
        }
        else
        {
          lcd.print(" Sensor: " + inData);
        }
        
      }
      
      inData = "";
    }
	}
  /* add main program code here */

}
