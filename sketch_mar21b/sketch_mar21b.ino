#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include <ThreeWire.h>
#include <RtcDS1302.h>
#include <avr/wdt.h>
#define LEFT_IN 2
#define RIGHT_IN 12
LiquidCrystal_I2C lcd (0x27, 16, 2);
ThreeWire myWire(33, 31, 35);
RtcDS1302<ThreeWire> Rtc(myWire);
int left_count = 0, right_count = 0;
const int TIME_INTERVAL = 20, TIME_LIMIT = 10;;
bool left_prev = false, right_prev = false;
uint32_t endTime;
int32_t leftTime = TIME_LIMIT;
void setup() {
  Serial.begin(115200);
  pinMode(LEFT_IN, INPUT);
  pinMode(RIGHT_IN, INPUT);
  Rtc.Begin();
  lcd.init();
  lcd.backlight();
  lcd.clear();
  wait();
  showScore(0, 0);
  start(5);
  endTime = Rtc.GetDateTime().Epoch32Time() + 10;
}
void loop() {
  leftTime = endTime - Rtc.GetDateTime().Epoch32Time();
  if (leftTime > 0) {
    if (digitalRead(LEFT_IN) == HIGH && left_prev == false)
      left_count++;
    if (digitalRead(RIGHT_IN) == HIGH && right_prev == false)
      right_count++;
    left_prev = digitalRead(LEFT_IN);
    right_prev = digitalRead(RIGHT_IN);
    showScore(left_count, right_count);
  }
  else {
    Serial.println(String(F("P:3")));
    showScore(left_count, right_count);
    lcd.setCursor(6, 0);
    lcd.print("STOP");
    lcd.setCursor(6, 1);
    if (left_count > right_count) {
      lcd.print("<WIN");
      terminate(1);
    }
    else if (left_count < right_count) {
      lcd.print("WIN>");
      terminate(2);
    }
    else {
      lcd.print("DRAW");
      terminate(3);
    }
  }
  delay(TIME_INTERVAL);
}
void wait() {
  Serial.println(String(F("P:0")));
  lcd.setCursor(0, 0);
  lcd.print("LEFT");
  lcd.setCursor(11, 0);
  lcd.print("RIGHT");
  while (digitalRead(LEFT_IN) == LOW || digitalRead(RIGHT_IN) == LOW) {
    lcd.setCursor(0, 1);
    lcd.print(digitalRead(LEFT_IN) == HIGH ? "READY" : "WAIT ");
    lcd.setCursor(11, 1);
    lcd.print(digitalRead(RIGHT_IN) == HIGH ? "READY" : " WAIT");
    Serial.println(String(F("S:")) + (digitalRead(LEFT_IN) == HIGH ? "1" : "0") + (digitalRead(RIGHT_IN) == HIGH ? "1" : "0"));
  }
}
void start(int sec) {
  Serial.println(String(F("P:1C:")) + sec);
  lcd.clear();
  for (int i = 0; i < sec; i++) {
    Serial.println(String(F("P:1C:")) + (sec - i));
    lcd.setCursor(7, 0);
    lcd.print(sec - i);
    delay(1000);
  }
  lcd.setCursor(7, 0);
  Serial.println(String(F("P:2")));
  lcd.print("GO");
}
void showScore(int left, int right) {
  lcd.setCursor(0, 0);
  lcd.print("LEFT");
  lcd.setCursor(11, 0);
  lcd.print("RIGHT");
  lcd.setCursor(0, 1);
  lcd.print(left);
  lcd.setCursor(16 - String(right).length(), 1);
  lcd.print(right);
  lcd.setCursor(7 , 1);
  lcd.print((leftTime < 10 ? " " : "") + String(leftTime));
  Serial.println(String(F("T:")) + leftTime + String(F("L:")) + left + String(F("R:")) + right);
}
void terminate(int result)
{
  if (result == 1)
    Serial.println("W:1");
  else if (result == 2)
    Serial.println("W:2");
  else
    Serial.println("W:3");
  delay(10000);
  wdt_enable(WDTO_15MS);
  while(1);
}
