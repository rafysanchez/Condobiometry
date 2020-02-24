
//inicio do sistema
void inicio(){ 
  digitalWrite(led_red,HIGH);
  digitalWrite(led_blue,LOW);
  digitalWrite(led_green,LOW);
  if (finger.verifyPassword())
  {
    digitalWrite(fault_sensor, LOW);
  } 
  else 
  {        
    digitalWrite(fault_sensor, HIGH);
    delay(1000);
  }
  getEnrol = 0;
  // gera tom audível
  tone(audioPin, 1080, 100);
  delay(300);
  noTone(audioPin);
  tone(audioPin, 980, 100);
  delay(200);
  noTone(audioPin);
  tone(audioPin, 770, 100);
  delay(300);
  noTone(audioPin); 
}
//********** Aguardando acao usuario ******************************* 
void code_entry_init(){

  // gera sinal audível
  tone(audioPin, 1500, 100);
  delay(200);
  noTone(audioPin);
  tone(200, 1500, 100);
  delay(250);
  noTone(audioPin);
  tone(audioPin, 1500, 100);
  delay(200);
  noTone(audioPin);
  // somente LED azul aceso
  digitalWrite(led_red, LOW);
  digitalWrite(led_blue, HIGH);
  digitalWrite(led_green, LOW);
}
//********************FUNCAO PARA ABRIR TODOS COMPARTIMENTOS********************************************
void Abrir_Todos()
{
  for(int x = 0; x < 16; x++ ){
    digitalWrite(ebox[x],LOW);
    tone(audioPin, 1500, 100);
    delay(200);
    noTone(audioPin);    
    digitalWrite(ebox[x],HIGH);
      delay(200);
  }
}
//************** cadastros de novas biometrias *****************************
uint8_t getFingerprintEnroll() { 
   //verifica se leitor esta conectado ou nao 
  if (finger.verifyPassword()) {
    Serial.write("LEITOR BIOMETRICO FUNCIONANDO.");
  } 
  else {
    Serial.write("LEITOR BIOMETRICO NAO ESTA FUNCIONANDO.");  
    delay(1000);
    inicio();// inicializa 
  }
  //gera som audivel
  code_entry_init(); 

  delay(2000);
  //Serial.println("\n"); 
  Serial.write("CADASTRO DE BIOMETRIA"); 
  delay(2000);
  int p = -1;  
   // Serial.println("\n"); 
   Serial.write("PRESSIONE O DEDO NO SENSOR.");  
  while (p != FINGERPRINT_OK) {
    p = finger.getImage();
    switch (p) {
    case FINGERPRINT_OK:    
      Serial.println("\n"); 
      Serial.println("IMAGEM SALVA.");
      break;
    case FINGERPRINT_NOFINGER:
      break;
    case FINGERPRINT_PACKETRECIEVEERR:      
      Serial.println("\n"); 
      Serial.println("ERRO NA COMUNICAÇÃO COM ARDUINO.");
      digitalWrite(fault_sensor, HIGH);
      break;
      delay(2000);
      inicio();// inicializa 
    case FINGERPRINT_IMAGEFAIL:
      Serial.println("\n"); 
      Serial.println("ERRO NA CAPTURA DA IMAGEM.");
      break;            
      delay(2000);
      inicio();// inicializa 
    default:
      Serial.println("\n"); 
      Serial.println("ERRO NA COMUNICAÇÃO COM LEITOR BIOMETRICO.");  
      digitalWrite(fault_sensor, HIGH);    
      break;            
      delay(2000);
      inicio();// inicializa  
    }
  }
  // OK success!

  p = finger.image2Tz(1);
  switch (p) {
  case FINGERPRINT_OK:
    Serial.println("\n"); 
    Serial.println("IMAGEM SALVA.");
    break;
  case FINGERPRINT_IMAGEMESS:
    Serial.println("\n"); 
    Serial.println("IMAGEM CONFUSA.");
    inicio();// inicializa  
    return p;
  case FINGERPRINT_PACKETRECIEVEERR:
    Serial.println("\n"); 
    Serial.println("ERRO NA COMUNICAÇÃO COM LEITOR BIOMETRICO.");  
    digitalWrite(fault_sensor, HIGH); 
    delay(2000);
    inicio();// inicializa   
    return p;

  case FINGERPRINT_FEATUREFAIL:
    Serial.println("\n"); 
    Serial.println("ERRO DE BIOMETRIA.");
    delay(2000);
    inicio();// inicializa  
    return p;
  case FINGERPRINT_INVALIDIMAGE:
    Serial.println("\n"); 
    Serial.println("ERRO DE BIOMETRIA.");
    delay(2000);
    inicio();// inicializa  
    return p;
  default:
    Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");
    digitalWrite(fault_sensor, HIGH);
    delay(2000);
    inicio();// inicializa 
    return p; 
  }
  //Serial.println("\n"); 
  Serial.write("REMOVA O DEDO.");
  delay(2000);
  ////////////////////////////////////////
  p = 0;
  while (p != FINGERPRINT_NOFINGER) {
    p = finger.getImage();
  }
  p = -1;  
  //Serial.println("\n"); 
  Serial.write("COLOQUE O MESMO DEDO NOVAMENTE.");
  while (p != FINGERPRINT_OK) {
    p = finger.getImage();
    switch (p) {
    case FINGERPRINT_OK:
      Serial.println("\n"); 
      Serial.println("IMAGEM SALVA.");
      break;
    case FINGERPRINT_NOFINGER:
      break;
    case FINGERPRINT_PACKETRECIEVEERR:
      Serial.println("\n"); 
      Serial.println("ERRO NA COMUNICAÇÃO COM LEITOR BIOMETRICO.");    
      digitalWrite(fault_sensor, HIGH);
      break;            
      delay(2000);
      inicio();// inicializa 
    case FINGERPRINT_IMAGEFAIL:
      Serial.println("\n"); 
      Serial.println("ERRO DE BIOMETRIA.");
      break;            
      delay(2000);
      inicio();// inicializa 
    default:
      Serial.println("\n"); 
      Serial.println("ERRO DESCONHECIDO.");
      digitalWrite(fault_sensor, HIGH);
      break;            
      delay(2000);
      inicio();// inicializa 
    }
  }

  // OK success!

  p = finger.image2Tz(2);
  switch (p) {
  case FINGERPRINT_OK:
    Serial.println("\n"); 
    Serial.println("IMAGEM CONVERTIDA.");
    break;          
  case FINGERPRINT_IMAGEMESS:
    Serial.println("\n"); 
    Serial.println("IMAGEM CONFUSA.");
    return p;
  case FINGERPRINT_PACKETRECIEVEERR:
    Serial.println("\n"); 
    Serial.println("ERRO NA COMUNICAÇÃO COM LEITOR BIOMETRICO.");
    digitalWrite(fault_sensor, HIGH);
    delay(2000);
    inicio();// inicializa 
    return p;

  case FINGERPRINT_FEATUREFAIL:
    Serial.println("\n"); 
    Serial.println("ERRO DE BIOMETRIA.");
    delay(2000);
    inicio();// inicializa 
    return p;
  case FINGERPRINT_INVALIDIMAGE:   
    Serial.println("\n"); 
    Serial.println("ERRO DE BIOMETRIA.");  
    delay(2000);
    inicio();// inicializa 
    return p;
  default:
    Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");    
    digitalWrite(fault_sensor, HIGH);
    delay(2000);
    inicio();// inicializa 
    return p; 
  }
  // OK converted!
  p = finger.createModel();
  if (p == FINGERPRINT_OK) {
    Serial.println("\n"); 
    Serial.println("IMAGEM SALVA.");
  } 
  else if (p == FINGERPRINT_PACKETRECIEVEERR) {
    Serial.println("\n"); 
    Serial.println("ERRO NA COMUNICAÇÃO COM LEITOR BIOMETRICO.");       
    digitalWrite(fault_sensor, HIGH); 
    delay(2000);
    inicio();// inicializa 
    return p;
  } 
  else if (p == FINGERPRINT_ENROLLMISMATCH) {
    Serial.println("\n"); 
    Serial.println("DIGITAIS DIFERENTES.");
    delay(2000);
    inicio();// inicializa  
    return p;

  } 
  else {
    Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");  
    digitalWrite(fault_sensor, HIGH);
    delay(2000);
    inicio();// inicializa 
    return p;
  }   
  p = finger.storeModel(id);
  if (p == FINGERPRINT_OK) {
    //Serial.println("\n"); 
     Serial.write("USUARIO CADASTRADO COM SUCESSO.");
    //Serial.println("\n"); 
    delay(2000);
    Serial.print(id);
    Serial.println("#"); 
    delay(2000);

    //"""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
  } 
  else if (p == FINGERPRINT_PACKETRECIEVEERR) {
    Serial.println("\n"); 
    Serial.println("ERRO DE BIOMETRIA.");    
    delay(2000);
    inicio();// inicializa 
    return p;
  } 
  else if (p == FINGERPRINT_BADLOCATION) {
    Serial.println("\n"); 
    Serial.println("FALHA AO ARMAZENAR.");   
    delay(2000);
    inicio();// inicializa 
    return p;
  } 
  else if (p == FINGERPRINT_FLASHERR) {
    Serial.println("\n"); 
    Serial.println("FALHA AO ARMAZENAR.");   
    delay(2000);
    inicio();// inicializa 
    return p;
  } 
  else {
    Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");    
    digitalWrite(fault_sensor, HIGH);
    delay(2000);
    inicio();// inicializa 
    return p;
  }  
  inicio();// inicializa 
}//fecha funcao enrol

//************ Verificacao de biometrias *******************************

uint8_t getFingerprintID() {

  //gera som audivel
  code_entry_init(); 

  uint8_t p = finger.getImage();
  switch (p) {
  case FINGERPRINT_OK:
    Serial.println("\n"); 
    Serial.println("IMAGEM DETECTADA.");
    break;
  case FINGERPRINT_NOFINGER:
    Serial.println("\n"); 
    Serial.println("BIOMETRIA AUTENTICADA.");
    return p;
  case FINGERPRINT_PACKETRECIEVEERR:
    Serial.println("\n"); 
    Serial.println("ERRO NA COMUNICAÇÃO COM LEITOR BIOMETRICO.");   
    digitalWrite(fault_sensor, HIGH);   
    delay(2000);
    inicio();// inicializa 
    return p;
  case FINGERPRINT_IMAGEFAIL:
    Serial.println("\n"); 
    Serial.println("ERRO DE IMAGEM.");    
    delay(2000);
    inicio();// inicializa 
    return p;
  default:
    Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");
    digitalWrite(fault_sensor, HIGH);
    delay(2000);
    inicio();// inicializa 
    return p;
  }

  // OK success!

  p = finger.image2Tz();
  switch (p) {
  case FINGERPRINT_OK:
    Serial.println("\n"); 
    Serial.println("IMAGEM CONVERTIDO.");
    break;
  case FINGERPRINT_IMAGEMESS:
    Serial.println("\n"); 
    Serial.println("IMAGEM CONFUSA.");
    return p;
  case FINGERPRINT_PACKETRECIEVEERR:
    Serial.println("\n"); 
    Serial.println("ERRO DE COMUNICAÇÃO COM LEITOR BIOMETRICO.");   
    digitalWrite(fault_sensor, HIGH);    
    delay(2000);
    inicio();// inicializa 
    return p;
  case FINGERPRINT_FEATUREFAIL:
    Serial.println("\n"); 
    Serial.println("FALHA NA BIOMETRIA.");  
    delay(2000);
    inicio();// inicializa 
    return p;
  case FINGERPRINT_INVALIDIMAGE:
    Serial.println("\n"); 
    Serial.println("FALHA NA BIOMETRIA.");   
    delay(2000);
    inicio();// inicializa 
    return p;
  default:
    Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");   
    digitalWrite(fault_sensor, HIGH); 
    delay(2000);
    inicio();// inicializa 
    return p; 
  }

  // OK converted!
  p = finger.fingerFastSearch();
  if (p == FINGERPRINT_OK) {
    Serial.println("\n"); 
    Serial.println("BIOMETRIA ENCONTRADA.");
  } 
  else if (p == FINGERPRINT_PACKETRECIEVEERR) {
    Serial.println("\n"); 
    Serial.println("ERRO NA COMUNICAÇÃO COM LEITOR BIOMETRICO");
    digitalWrite(fault_sensor, HIGH);
    delay(2000);
    inicio();// inicializa 
    return p; 
  } 
  else if (p == FINGERPRINT_NOTFOUND) {
    Serial.println("\n"); 
    Serial.println("ACESSO NEGADO!");
    tone(audioPin, 1000, 100);
    delay(200);
    noTone(audioPin);
    //*******************************************************************
    for(int i = 0; i<4; i++)
    {

    }    
    delay(1000);
    return p;
  } 
  else {
    Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");   
    digitalWrite(fault_sensor, HIGH);
    delay(2000);
    inicio();// inicializa 
    return p;
  }   

  // found a match!
  Serial.println("\n"); 
  Serial.println("ID ENCONTRADO.");
  Serial.println(finger.confidence); 
}

// returns -1 if failed, otherwise returns ID #
//retorna -1 se falhar, caso contrÃ¡rio retorna ID
int getFingerprintIDez() {
  uint8_t p = finger.getImage();
  if (p != FINGERPRINT_OK) return -1;

  p = finger.image2Tz();
  if (p != FINGERPRINT_OK){  
    Serial.println("\n"); 
    Serial.println("ERRO DE LEITURA.");
    inicio();// inicializa 
    return -1;
  }

  p = finger.fingerFastSearch();
  if (p != FINGERPRINT_OK){
    Serial.println("\n"); 
    Serial.println("ACESSO NEGADO!");
    tone(audioPin, 1000, 100);
    delay(200);
    noTone(audioPin);
    //*******************************************************************
    for(int i = 0; i<4; i++)
    {     
      //
    } 
    delay(1000);   
    inicio();// inicializa 
    return -1;
  }
  // found a match!
  //""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""

  // Serial.println("ACESSO PERMITIDO.");  
  int id_user = finger.fingerID;
  tone(audioPin, 3000, 1000);
  delay(200);
  noTone(audioPin);
  delay(300);
  tone(audioPin, 3000, 1500);
  delay(200);
  noTone(audioPin); 
  Serial.print(id_user);
  Serial.println("@");
  delay(1000);
  inicio();// inicializa 
}

//""""""""""" funcao para deletar biometrias""""""""""""""""""""""""""""""""""""""""""""""""""""""
uint8_t deleteFingerprint() {  

  int id ;//= enrolid;
  uint8_t p = -1;

  p = finger.deleteModel(id);

  if (p == FINGERPRINT_OK) {
    Serial.println("\n"); 
    Serial.println("EXCLUSÃO DE USUARIO.");
    Serial.println(id);  
    delay(1000);
  } 
  else if (p == FINGERPRINT_PACKETRECIEVEERR) {
    Serial.println("\n"); 
    Serial.println("ERRO DE COMUNICAÇÃO COM LEITOR BIOMETRICO."); 
    digitalWrite(fault_sensor, HIGH);
    return p;
    delay(2000);
    inicio();// inicializa 
  } 
  else if (p == FINGERPRINT_BADLOCATION) {
    Serial.println("\n"); 
    Serial.println("FALHA AO EXCLUIR.");
    return p;
    delay(2000);
    inicio();// inicializa 
  } 
  else if (p == FINGERPRINT_FLASHERR) {
    Serial.println("\n"); 
    Serial.println("ERRO DE FLASH.");
    return p;
    delay(2000);
    inicio();// inicializa 
  } 
  else {
    Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");
    digitalWrite(fault_sensor, HIGH);
    return p;
    delay(2000);
    inicio();// inicializa 
  }  

  inicio();// inicializa 
}//fecha funcao dele


//""""""""""" funcao para deletar biometrias""""""""""""""""""""""""""""""""""""""""""""""""""""""
void Delete_biometria()
{
  for(int i=0; i<16; i++){
    deleteFingerprintID(i);
  }
}
uint8_t deleteFingerprintID(int user) { 
  code_entry_init(); 
  int id = user;
  uint8_t p = -1;
  p = finger.deleteModel(id);
  if (p == FINGERPRINT_OK) {
    Serial.println("\n"); 
    Serial.println("EXCLUIR USUARIO PELO ID.");
    Serial.println(id);  
    Serial.println("@");
    Serial.println("\n"); 
    Serial.println("POR FAVOR AGUARDE...");
    Serial.print(id);
    Serial.println("@");
    return 2;//retorna valor para o lcaço
  } 
  else if (p == FINGERPRINT_PACKETRECIEVEERR) {
    Serial.println("\n"); 
    Serial.println("ERRO NA COMUNICAÇÃO COM LEITOR BIOMETRICO.");
    digitalWrite(fault_sensor, HIGH);
    delay(2000);
    return p;

  } 
  else if (p == FINGERPRINT_BADLOCATION) {
    Serial.println("\n"); 
    Serial.println("FALHA AO EXCLUIR.");
    delay(2000);
    return p;
  } 
  else if (p == FINGERPRINT_FLASHERR) {
    Serial.println("\n"); 
    Serial.println("ERRO DE FLASH.");
    delay(2000);
    return p;
  } 
  else {
    Serial.println("\n"); 
    Serial.println("ERRO DESCONHECIDO.");
    digitalWrite(fault_sensor, HIGH);
    delay(2000);
    return p;
  }  
}  //fecha funcao deleT


