//Projeto: bioCabinets CTB-01 Controle de travas por biometria. 2WS
//Desenvolvido no ano de 2016
//Autor: Romario dos Santos
//Formação: Tecnico em Eletrônica e Tecnico em Informatica.
//Todos direitos reservados

#include <Adafruit_Fingerprint.h>
#include <EEPROM.h>
#include <SoftwareSerial.h>
// declarção de variáveis para leitor biometrico
int getFingerprintIDez();
uint8_t getFingerprintEnroll(uint8_t id);
uint8_t getFingerprintEnroll(int id);

// pin 52 fio verde do sensor - 53 fio branco 
SoftwareSerial mySerial(52,53); 
Adafruit_Fingerprint finger = Adafruit_Fingerprint(&mySerial);

int ebox[16] = {
  22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37 };
int sensor_ebox[16]={
  A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,A11,A12,A13,A14,A15
};
int led_cabinets[16] = {
  2, 3, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51
};
char enrolid[3]={
  '0','0','0'};//variavelpara guadar o id do usuario
  
const int fault_sensor = 10; 
const int audioPin = 8; 
const int led_green = 9;  
const int led_blue = 12;   
const int led_red = 13;  
const int maxx = 16;        // aqui define a qtde de armarios

int id;
int count = 0;         
int getEnrol = 0;
String getFinger = "";
int num_ebox = -1;
boolean fechado = false;
boolean aberto = false;
boolean alarm = false;

void setup()
{ 
  Serial.begin(9600); //incia serial 
  finger.begin(57600); //taxa de comunicacao do leitor
  pinMode(fault_sensor,OUTPUT);
  pinMode(audioPin,OUTPUT);   
  pinMode(led_blue,OUTPUT);
  pinMode(led_green,OUTPUT);
  pinMode(led_red,OUTPUT);

  for(int i = 0; i< maxx; i++){
    delay(300);
    pinMode(ebox[i],OUTPUT);   
    digitalWrite(ebox[i],HIGH); 
    pinMode(sensor_ebox[i],INPUT); 
    digitalWrite(sensor_ebox[i],LOW); 
  }  
  //verifica se leitor esta conectado ou nao 
  if (finger.verifyPassword()) {
    Serial.write("LEITOR BIOMETRICO FUNCIONANDO.");
    digitalWrite(fault_sensor, LOW);
  } 
  else {
    Serial.write("LEITOR BIOMETRICO NAO ESTA FUNCIONANDO.");
    digitalWrite(fault_sensor, HIGH);
    delay(1000);
    // while (1)    inicio();
    //asm volatile ("  jmp 0");//reinicia automaticamente
  } 
}

void loop()
{  
  if(getEnrol == 1){
    getFingerprintIDez();
  }
//  for(int i =0; i <8;i++)
//  {
//    int val = digitalRead(sensor_ebox[i]);
//    Serial.print("Entrada - ");
//    Serial.print(i);
//    Serial.print(" Valor - ");
//    Serial.print(val);
//    Serial.println("\n");
//    delay(1000);
//  }
//
//  delay(3000);

  if((num_ebox > -1)&&(digitalRead(sensor_ebox[num_ebox]) == 0))fechado = true;

  if(Serial.available() > 0){
    // Enquanto receber algo pela serial
    while(Serial.available() > 0) {
      // Lê byte da serial
      char recebido = Serial.read();
      switch(recebido){

      case 'A':     
        delay(200); 
        digitalWrite(ebox[0], LOW);
        aberto = true;
        num_ebox = 0;
        // Serial.println(" recebi E1");
        break;
      case 'B':   
        delay(200);     
        digitalWrite(ebox[1], LOW);
        aberto = true;
        num_ebox = 1;
        //Serial.println(" recebi E2");
        break;

      case 'C':
        delay(200); 
        digitalWrite(ebox[2], LOW);
        aberto = true;
        num_ebox = 2;
        //Serial.println(" recebi E3");
        break;

      case 'D':
        delay(200); 
        digitalWrite(ebox[3], LOW);
        aberto = true;
        num_ebox = 3;
        //Serial.println(" recebi E4");
        break;

      case 'E':
        delay(200); 
        digitalWrite(ebox[4], LOW);
        aberto = true;
        num_ebox = 4;
        // Serial.println(" recebi E5");
        break; 

      case 'F':
        delay(200); 
        digitalWrite(ebox[5], LOW);
        aberto = true;
        num_ebox = 5;
        // Serial.println(" recebi E6");
        break;

      case 'G':
        delay(200); 
        digitalWrite(ebox[6], LOW);
        aberto = true;
        num_ebox = 6;
        //Serial.println(" recebi E7");
        break;

      case 'H':
        delay(200); 
        digitalWrite(ebox[7], LOW);
        aberto = true;
        num_ebox = 7;
        //Serial.println(" recebi E8");
        break;

      case 'I':
        delay(200); 
        digitalWrite(ebox[8], LOW);
        aberto = true;
        num_ebox = 8;
        // Serial.println(" recebi E9");
        break;

      case 'J':
        delay(200); 
        digitalWrite(ebox[9], LOW);
        aberto = true;
        num_ebox = 9;
        //Serial.println(" recebi E10");
        break;

      case 'K':
        delay(200); 
        digitalWrite(ebox[10], LOW);
        aberto = true;
        num_ebox = 10;
        //Serial.println(" recebi E11");
        break;

      case 'L':
        delay(200); 
        digitalWrite(ebox[11], LOW);
        aberto = true;
        num_ebox = 11;
        // Serial.println(" recebi E12");
        break;

      case 'M':
        delay(200); 
        digitalWrite(ebox[12], LOW);
        aberto = true;
        num_ebox = 12;
        //Serial.println(" recebi E13");
        break;

      case 'N':
        delay(200); 
        digitalWrite(ebox[13], LOW);
        aberto = true;
        num_ebox = 13;
        //Serial.println(" recebi E14");
        break;

      case 'O':
        delay(200); 
        digitalWrite(ebox[14], LOW);
        aberto = true;
        num_ebox = 14;
        // Serial.println(" recebi E15");
        break;

      case 'P':
        delay(200); 
        digitalWrite(ebox[15], LOW);
        aberto = true;
        num_ebox = 15;
        // Serial.println(" recebi E16");
        break;
        
        case 'Q':
        //
         break;
        case 'R':
         //
        break;
         case 'S':
        //
        break;
         case 'T':
        //
        break;
        case 'U':
        //
        break;
         case 'V':
        //
        break;
         case 'Y':
        //
        break;
         case 'X':
        //
        break;
         case 'Z':
        //
        break;//TOTAL 25 EBOX        
        
      case 'a':    
        delay(200);    
        fechado = true;
        break;
      case 'b':   
        delay(200);     
        Abrir_Todos();
        break;
      case 'c':
          delay(200); 
        getEnrol = 1;
        break;
        case 'd':       
       getEnrol = 0;
        break;
      case 'e':
       Delete_biometria();
        break;
       case 'f':
       Serial.println("\n");
       Serial.println(getFinger);
        break;
      default:
        enrolid[count] = recebido;
        count +=1;
        if(count == 3){                  
          count = 0;         
          // conversão pela tabela ASCI
           int digito_1 = (int)enrolid[0]-48;
           int digito_2 = (int)enrolid[1]-48;
           int digito_3 = (int)enrolid[2]-48;
           id = digito_1*100 + digito_2*10  + digito_3; 
           getFingerprintEnroll();
        }
        break;
      }
    }
    delay(30); 
  }
  //---------------------------------------------------- 

  if(aberto){
    delay(1500); 
    int val = digitalRead(sensor_ebox[num_ebox]);
    if(val == 1)
    {            
     // Serial.println("ABERTA");
      Serial.println("1#");
      digitalWrite(led_green,HIGH);
      digitalWrite(led_red,LOW);      
      aberto = false;
      delay(1000);
      digitalWrite(ebox[num_ebox],HIGH);
      getEnrol = 0;
    }
    else
    {  
      delay(500);       
     // Serial.println("ERROR");       
      Serial.println("3#");
      digitalWrite(ebox[num_ebox],HIGH);
      aberto = false;
      num_ebox = -1;
    } 
  }

  if(fechado){
    delay(1500); 
    int val = digitalRead(sensor_ebox[num_ebox]);
    if(val == 0){     
      //Serial.println("FECHADA");      
      Serial.println("2#");
      digitalWrite(led_green,LOW);
      digitalWrite(led_red,HIGH);
      fechado = false;
      num_ebox = -1;
    }
    else
    {
      delay(500);  
      //Serial.println("ERROR");       
      Serial.println("3#");
      digitalWrite(ebox[num_ebox],HIGH);
      fechado = false;
    }
  }  
  if (finger.verifyPassword()) {
   getFinger = "LEITOR BIOMETRICO FUNCIONANDO.";
  } 
  else {
   getFinger = "LEITOR BIOMETRICO NAO ESTA FUNCIONANDO.";
    delay(1000);
  }
}//loop

