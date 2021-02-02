const int LIGHT = 8;
const int HIGH_HI = 1;
const int LOW_LO = 0;

void setup() {
  // put your setup code here, to run once:
  pinMode(LIGHT, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(LIGHT, HIGH_HI);   // turn the LED on (HIGH is the voltage level)
  delay(300);                       // wait for a second
  digitalWrite(LIGHT, LOW_LO);    // turn the LED off by making the voltage LOW
  delay(300);                       // wait for a second
}
