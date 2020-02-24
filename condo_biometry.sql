
create database condo_biometry;

use condo_biometry;

create table if not exists tbl_login(
id_login int not null auto_increment,
nome varchar(45) not null,
perfil varchar(20) not null,
funcao varchar(40) not null,
empresa varchar(45) not null,
senha char(8),
id_biometria int not null default 0,
data_cad date,
constraint pk1 primary key(id_login)
);

insert into tbl_login(nome,perfil,funcao,empresa,senha,id_biometria,data_cad)
values
('Romario dos Santos','Administrador','Desenvolvedor','Devenlophers',11111111,1,current_date);

create table if not exists tbl_condominio(
id_condo int not null auto_increment,
id_login int not null,
nome varchar(30) not null,
rua varchar(30) not null,
numero varchar(5) not null,
cidade varchar(45) not null,
estado varchar(45) not null,
port_conection varchar(6) not null,
data_cad date,
constraint pk_condo primary key(id_condo),
constraint fk1 foreign key(id_login) references tbl_login(id_login)
);

create table if not exists tbl_usuario(
id_user int not null auto_increment,
id_login int not null,
perfil varchar(20)not null,
nome varchar(30) not null,
apto varchar(20) not null,
bloco varchar(20) not  null,
funcao varchar(40) not null,
empresa varchar(45) not null,
senha char(8) not null,
id_biometria int,
status varchar(1) default '', 
data_cad date,
constraint  pk primary key(id_user),
constraint userfk foreign key(id_login) references tbl_login(id_login)
);

create table if not exists tbl_ebox(
id_ebox int not null auto_increment,
id_login int not null,
num_ebox char(10) not null,
tamanho varchar(10) not null,
status_ebox varchar(20) not null,
data_cad date not null,
constraint  pk_ebox primary key(id_ebox),
constraint eboxfk1 foreign key(id_login) references tbl_login(id_login)

);

create table if not exists tbl_entrega(
id_entrega int not null auto_increment,
id_login int not null,
id_ebox int not null,
num_encomenda varchar(20) not null,
apto varchar(20) not null,
bloco varchar(20) not null,
data_inclusao date,
data_retirada date not null,
id_morador int not null,
nome_morador varchar(45),
status_retirada varchar(20) not null default 'Nao retirado',
processo varchar(20) not null default 'Aberto',
constraint  pk1 primary key(id_entrega),
constraint entregaafk1 foreign key(id_login) references tbl_login(id_login),
constraint entregafk2 foreign key(id_ebox) references tbl_ebox(id_ebox)
);

create table if not exists tbl_servico(
id_servico int not null auto_increment,
id_login int not null,
resp_abertura varchar(45),
id_ebox int not null,
motivo varchar(100) not null,
data_ocorrencia date,
data_conclusao date,
resp_conclusao varchar(45),
observacao varchar(100),
status_os varchar(10) default 'Aberto',
CONSTRAINT spk PRIMARY KEY(id_servico),
constraint sfk1 foreign key(id_login) references tbl_login(id_login),
constraint sfk2 foreign key(id_ebox) references tbl_ebox(id_ebox)
);


create table if not exists tbl_log_conexao(
id_log int not null auto_increment,
port_conection varchar(6) not null,
log_acao varchar(10) not null,
data_log date,
hora_log time,
constraint lpk primary key (id_log)
);

create table if not exists tbl_log_abertura(
id_log_abertura int not null auto_increment,
id_login int not null,
ebox varchar(20) not null,
motivo varchar(100) not null,
data_log date,
hora_log time,
constraint pk primary key (id_log_abertura),
constraint logfk1 foreign key(id_login) references tbl_login(id_login)
);

create table if not exists tbl_backup_restore(
id_backup int not null auto_increment,
id_login int not null ,
local_bd varchar(200) not null,
freq_backup varchar(100)not null,
local_backup varchar(200) not null,
local_restore varchar(200) not null,
data_cad date,
hora Time,
execucao varchar(45)not null default 'Backup',
constraint  pk_id_backup primary key(id_backup),
constraint brfk1 foreign key(id_login) references tbl_login(id_login)
);

## TRIGER PARA ATUALIZAR EBOX APOS INCLUSAO ENCOMENDA

delimiter $
create trigger trg_update_ebox after insert on tbl_entrega 
for each row
begin
update tbl_ebox set status_ebox = 'Ocupado' where id_ebox = 
(select id_ebox from tbl_entrega where id_entrega = (select max(id_entrega)from tbl_entrega));
end
$

delimiter $
create trigger trg_status_ebox after insert on tbl_servico 
for each row
begin
update tbl_ebox set status_ebox = 'Interditado' where id_ebox = 
(select id_ebox from tbl_servico where id_servico = (select max(id_servico)from tbl_servico));
end
$
