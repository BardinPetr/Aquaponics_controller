#define USER 0
#define PROG 1
#define SEND_FORMAT PROG

#include <OneWire.h>
#include <DallasTemperature.h>
#include <SoftwareSerial.h>

#include "WaterControll.h"

SoftwareSerial softser(4, 5);
WaterControll sens(softser, 6, 7, 8, true);

OneWire oneWire(2);
DallasTemperature sensors(&oneWire);

String inputString = "";
boolean stringComplete = false;

int pins[4] = {9, 10, 11, 12};

bool pins_run[4] = {false, false, false, false};
unsigned long pins_tmr[4] = {0, 0, 0, 0};
int ttime = 300; //time of pums work

bool timeButtons = true;

void setup() {
  Serial.begin(9600);

  sens.Add(sens.PH, "pH", true);
  sens.Add(sens.OPR, "OPR", false);
  sens.Add(sens.DO, "Oxygen", false);
  sens.Add(sens.COND, "Conductivity", false);

  sens.set_finishHandler(finish);

  sensors.begin();

  inputString.reserve(5);

  for (int i = 0; i < 4; i++) pinMode(pins[i], OUTPUT);
  for (int i = 0; i < 4; i++) digitalWrite(pins[i], 0);
}

void finish(float* in) {
  if (SEND_FORMAT == 0) {
    Serial.println("\n\n***************\nData from sensors recieved!");
    for (int i = 0; i < sens.sensors_count; i++) {
      Serial.println(sens.sensors_name[i] + ":\t\t\t\t" + String(in[i]));
    }
    Serial.println("***************\n");
  }
  else {
    Serial.print("<");
    for (int i = 0; i < sens.sensors_count; i++) {
      Serial.print(String(in[i]) + "#");
    }
    sensors.requestTemperatures(); 
    Serial.print(String(String(sensors.getTempCByIndex(0)) + "#"));
    Serial.println(">");
  }
}

void serialEvent() {
  while (Serial.available()) {
    char inChar = (char)Serial.read();
    inputString += inChar;
    if (inChar == '>') {
      stringComplete = true;
    }
  }
}

void loop() {
  sens.readAll_nw();

  for (int i = 0; i < 4; i++) {
    if ((millis() - pins_tmr[i]) > ttime && pins_run[i] && timeButtons) {
      digitalWrite(pins[i], 0);
      pins_run[i] = false;
    }
  }

  if (stringComplete) {
    if (inputString.startsWith("!")) {
      inputString = inputString.substring(1);
      timeButtons = String(inputString[0]).toInt();
    }
    else {
      inputString = inputString.substring(1, inputString.length() - 1);

      int state = String(inputString[0]).toInt();
      int id = String(inputString[1]).toInt();

      digitalWrite(pins[id], state);
      pins_run[id] = state;
      pins_tmr[id] = millis();

      inputString = "";
      stringComplete = false;
    }
  }
}

