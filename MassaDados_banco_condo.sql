
use condo_biometry;

-- retorna todos usuarios cadastrados perfil morador
select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,data_cad as Cadastro,id_login as Operador from tbl_usuario where perfil = 'Morador' and status = '';

-- retorna todos usuarios cadastrados perfil entregador
select id_user as Codigo,Nome,Perfil,funcao,empresa,id_biometria as Biometria,data_cad as Cadastro,id_login as Operador from tbl_usuario where perfil != 'Morador';

-- retorna todos usuarios cadastrados por nome
select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,data_cad as Cadastro,id_login as Operador from tbl_usuario where(nome like '%Rom%') and status = '';

-- retorna todos usuarios cadastrados por bloco
select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,data_cad as Cadastro,id_login as Operador from tbl_usuario where(bloco like '%04%') and status = '';

-- retorna todos usuarios cadastrados por Apto // nao usada
select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,data_cad as Cadastro,id_login as Operador from tbl_usuario where(Apto like '%21%') and status = '';
 
-- retorna todos usuarios cadastrados por bloco e Apto
select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,data_cad as Cadastro,id_login as Operador from tbl_usuario where(bloco like '%02%')and (Apto like '%22%') and status = '';

-- retorna todos usuarios cadastrados por nome do entregador
select u.id_user as Codigo,u.Nome,u.Bloco,u.Apto,u.id_biometria as Biometria,u.data_cad as Cadastro,u.id_login as Operador
 from tbl_usuario u inner join tbl_login l where l.id_login = u.id_login and (l.nome like '%Ivone%') and status = '';

-- retorna todos usuarios cadastrados no ultimo mes
select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,data_cad as Cadastro,id_login as Operador from tbl_usuario 
where data_cad  BETWEEN CURDATE() - INTERVAL 1 month AND CURDATE();

-- retorna todos usuarios cadastrados no ultimo 3 mes
select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,data_cad as Cadastro,id_login as Operador from tbl_usuario 
where data_cad  BETWEEN CURDATE() - INTERVAL 3 month AND CURDATE();

-- retorna todos usuarios cadastrados no ultimo 6 mes
select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,data_cad as Cadastro,id_login as Operador from tbl_usuario 
where data_cad  BETWEEN CURDATE() - INTERVAL 6 month AND CURDATE();

-- retorna todos usuarios cadastrados no ultimo 12 mes
select id_user as Codigo,Nome,Bloco,Apto,id_biometria as Biometria,data_cad as Cadastro,id_login as Operador from tbl_usuario 
where data_cad  BETWEEN CURDATE() - INTERVAL 12 month AND CURDATE();

-- retorna a quantidade de moradores por bloco
SELECT COUNT(*) AS Morador,Bloco from tbl_usuario where perfil = 'Morador' and status = ''
GROUP BY Bloco ORDER BY Morador desc; 

-- retorna a quantidade de usuario na tabela usuario
select count(*) as Total_usuario from tbl_usuario;
 
##########################################################################################################################################

-- retorna encomenda por codigo 
select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,e.data_inclusao,e.status_retirada,e.nome_morador as Morador,
e.data_retirada as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login
and (Num_encomenda like '%RR%');

-- retorna encomendas entregue
select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,e.data_inclusao,e.status_retirada,e.nome_morador as Morador,
e.data_retirada as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login
and  processo = 'Concluido';

-- retorna encomendas nao entregue
select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,e.data_inclusao,e.status_retirada,e.nome_morador as Morador,
e.data_retirada as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login
and  processo = 'Aberto';

-- retorna encomenda por bloco e Apto nao entregue
select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,e.data_inclusao,e.status_retirada,e.nome_morador as Morador,
e.data_retirada as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login
and(e.bloco like '%02%')and (e.Apto like '%22%') and Processo = 'Aberto';

-- retorna encomenda por bloco e Apto entregue
select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,e.data_inclusao,e.status_retirada,e.nome_morador as Morador,
e.data_retirada as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login
and(e.bloco like '%02%')and (e.Apto like '%22%') and Processo = 'Concluido';

-- retorna encomenda data retirada em atraso
select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,e.data_inclusao,e.status_retirada,e.nome_morador as Morador,
e.data_retirada as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login
 and curdate() > data_retirada;

-- retorna todos encomendas registradas no ultimo mes
select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,e.data_inclusao,e.status_retirada,e.nome_morador as Morador,
e.data_retirada as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login
and e.data_inclusao  BETWEEN CURDATE() - INTERVAL 1 month AND CURDATE();

-- retorna todos encomendas registradas no ultimo 3 mes
select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,e.data_inclusao,e.status_retirada,e.nome_morador as Morador,
e.data_retirada as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login
and e.data_inclusao  BETWEEN CURDATE() - INTERVAL 3 month AND CURDATE();

-- retorna todos encomendas registradas no ultimo 6 mes
select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,e.data_inclusao,e.status_retirada,e.nome_morador as Morador,
e.data_retirada as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login
and e.data_inclusao  BETWEEN CURDATE() - INTERVAL 6 month AND CURDATE();

-- retorna todos encomendas registradas no ultimo 12 mes
select e.num_encomenda as Codigo,e.id_ebox as Compartimento,e.Bloco,e.Apto,e.data_inclusao,e.status_retirada,e.nome_morador as Morador,
e.data_retirada as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login
and e.data_inclusao  BETWEEN CURDATE() - INTERVAL 12 month AND CURDATE();

-- retorna a quantidade encomendas por bloco
SELECT COUNT(*) AS Encomendas,bloco from tbl_entrega 
GROUP BY Bloco ORDER BY Encomendas desc; 

-- retorna a quantidade encomendas por entregador
SELECT COUNT(*) AS Encomendas,id_login from tbl_entrega 
GROUP BY id_login ORDER BY Encomendas desc; 

#####################################################################################################################################

-- retorna a lista de compartimentos e seus status
select id_ebox as Codigo, num_ebox as Compartimento,Tamanho, data_cad as Cadastro from tbl_ebox;

-- retorna a lista de compartimentos e seus status livre
select id_ebox as Codigo, num_ebox as Compartimento,Tamanho, data_cad as Cadastro from tbl_ebox where status_ebox = 'Livre';

-- retorna a lista de compartimentos e seus status Ocupado
select id_ebox as Codigo, num_ebox as Compartimento,Tamanho, data_cad as Cadastro from tbl_ebox where status_ebox = 'Ocupado';

-- retorna a lista de compartimentos e seus status Interditado
select id_ebox as Codigo, num_ebox as Compartimento,Tamanho, data_cad as Cadastro from tbl_ebox where status_ebox = 'Interditado';

-- retorna a lista de compartimentos e seus status ocupado atraso
select c.id_ebox as Codigo, c.num_ebox as Compartimento,c.Tamanho, c.data_cad as Cadastro from tbl_ebox c
inner join tbl_entrega e  where c.id_ebox = e.id_ebox and curdate() > e.data_retirada and e.processo = 'Aberto';

-- retorna cmparimentos mais utilizados
SELECT COUNT(*) AS Qtde,id_ebox from tbl_entrega 
GROUP BY id_ebox ORDER BY Qtde desc; 

-- retorna cmparimentos mais interditado
SELECT COUNT(*) AS Qtde,id_ebox from tbl_servico 
GROUP BY id_ebox ORDER BY Qtde desc; 

##########################################################################################################################################################

-- retorna  servicos em aberto
select id_servico as Codigo,resp_abertura as Responsavel,id_ebox as Compartimento,Motivo,data_ocorrencia,
resp_conclusao as Concluinte,observacao,data_conclusao,status_os from tbl_ servico where status_os = 'Aberto';

-- retorna  servicos fechado
select id_servico as Codigo,resp_abertura as Responsavel,id_ebox as Compartimento,Motivo,data_ocorrencia,
resp_conclusao as Concluinte,observacao,data_conclusao,status_os from tbl_ servico where status_os = 'Finalizado';

-- retorna  servicos por responsavel
select id_servico as Codigo,resp_abertura as Responsavel,id_ebox as Compartimento,Motivo,data_ocorrencia,
resp_conclusao as Concluinte,observacao,data_conclusao,status_os from tbl_servico where (resp_abertura like '% Nome%');

-- retorna  servicos por periodo
select id_servico as Codigo,resp_abertura as Responsavel,id_ebox as Compartimento,Motivo,data_ocorrencia,
resp_conclusao as Concluinte,observacao,data_conclusao,status_os from tbl_ servico where
data_ocorrencia  BETWEEN CURDATE() - INTERVAL 6 month AND CURDATE();

#################################################################################################################################

-- retorna historico de abertura
select a.id_log_abertura as Codigo, l.Nome as Responsavel,a.Ebox,a.Motivo,a.data_log as Data_abertura,a.hora_log as Hora
from tbl_log_abertura a inner join tbl_login l where a.id_login = l.id_login;

-- retorna historico por responsavel
select a.id_log_abertura as Codigo, l.Nome as Responsavel,a.Ebox,a.Motivo,a.data_log as Data_abertura,a.hora_log as Hora
from tbl_log_abertura a inner join tbl_login l where a.id_login = l.id_login and (l.nnome like '% Nome%');

-- retorna historico por motivo
select a.id_log_abertura as Codigo, l.Nome as Responsavel,a.Ebox,a.Motivo,a.data_log as Data_abertura,a.hora_log as Hora
from tbl_log_abertura a inner join tbl_login l where a.id_login = l.id_login and (a.motivo like '% Nome%');

-- retorna historico por periodo 1 mes
select a.id_log_abertura as Codigo, l.Nome as Responsavel,a.Ebox,a.Motivo,a.data_log as Data_abertura,a.hora_log as Hora
from tbl_log_abertura a inner join tbl_login l where a.id_login = l.id_login and data_log BETWEEN CURDATE() - INTERVAL 1 month AND CURDATE();

-- retorna historico por periodo 3 mes
select a.id_log_abertura as Codigo, l.Nome as Responsavel,a.Ebox,a.Motivo,a.data_log as Data_abertura,a.hora_log as Hora
from tbl_log_abertura a inner join tbl_login l where a.id_login = l.id_login and data_log BETWEEN CURDATE() - INTERVAL 3 month AND CURDATE();


select e.num_encomenda as Codigo,e.id_ebox as Ebox,e.Bloco,e.Apto,DATE_FORMAT(e.Data_inclusao,'%d/%m/%Y') as Data_inclusao,e.Status_retirada,e.Nome_morador as Morador,
DATE_FORMAT(e.data_retirada,'%d/%m/%Y') as Prazo_retirada,l.nome as Entregador from tbl_entrega e inner join tbl_login l where e.id_login = l.id_login and (Num_encomenda like '%RR%');


use condo_biometry;
-- ------------------------------------------------
insert into tbl_condominio(id_login,nome,rua,numero,cidade,estado,port_conection,data_cad)
values(1,'Conjunto Habitacional Embu B1','Rua sao Benedito','220','Embu das Artes','Sao Paulo','COM4',current_date);


insert into tbl_login(nome,perfil,funcao,empresa,senha,id_biometria,data_cad)
values
('Romario dos Santos','Administrador','Desenvolvedor','Condo Biometry',11111111,1,current_date),
('Jose Marinho','Administrador','Sindico','Condo Biometry',11111112,2,current_date),
('Ivone Costa','Entregador','Sindico','Port Blink',11111113,3,current_date),
('Edimison Oliveira','Entregador','Porteiro','Port Blink',11111114,4,current_date),
('Maria Lucia Aparecida','Administrador','Porteiro','Port Blink',11111115,5,current_date);


insert into tbl_usuario (id_login,nome,perfil,bloco,apto,funcao,empresa,senha,id_biometria,data_cad)
 values
(1,'Jose Marinho','Administrador','Entregador','Entregador','Sindico','Condo Biometry',11111112,2,current_date),
(1,'Ivone Costa','Entregador','Entregador','Entregador','Sindico','Port Blink',11111113,3,current_date),
(1,'Edimison Oliveira','Entregador','Entregador','Entregador','Porteiro','Port Blink',11111114,4,current_date),
(1,'Maria Lucia Aparecida','Administrador','Entregador','Entregador','Porteiro','Port Blink',11111115,5,current_date),
(1,'Elieds Jesus','Morador','01','01','Morador','Morador',11111116,6,current_date),
(1,'Manoel Oliveira','Morador','01','11','Morador','Morador',11111117,7,current_date),
(1,'Alexandre Costa','Morador','01','21','Morador','Morador',11111118,8,current_date),
(2,'Rodrigo Rocha','Morador','01','31','Morador','Morador',11111119,9,current_date),
(2,'Francisco Chargas','Morador','01','41','Morador','Morador',22222220,10,current_date),
(2,'Gabriela nascimento','Morador','02','02','Morador','Morador',22222221,11,current_date),
(1,'Andreia Amorin','Morador','02','12','Morador','Morador',22222222,12,current_date),
(3,'Cristina Counti','Morador','02','22','Morador','Morador',22222223,13,current_date),
(3,'Jaqueline Oliveira','Morador','02','32','Morador','Morador',22222224,14,current_date),
(3,'Joice Ribeiro','Morador','02','42','Morador','Morador',22222225,15,current_date),
(3,'Leandro de Jesus','Morador','03','03','Morador','Morador',22222226,16,current_date),
(4,'Maria Edilene Barros','Morador','03','13','Morador','Morador',22222227,17,current_date),
(4,'Manoel Rocha','Morador','03','23','Morador','Morador',22222228,18,current_date),
(1,'Michael Sageior','Morador','03','33','Morador','Morador',22222229,19,current_date),
(2,'Cicero Marques','Morador','03','43','Morador','Morador',33333330,20,current_date),
(2,'Nonato Novais','Morador','04','04','Morador','Morador',33333331,21,current_date),
(1,'Julia Santos','Morador','04','14','Morador','Morador',33333332,22,current_date),
(3,'Romario Oliveira','Morador','04','24','Morador','Morador',33333333,23,current_date),
(3,'Mariza Oiveira','Morador','04','34','Morador','Morador',33333334,24,current_date),
(3,'Marina Silva','Morador','04','44','Morador','Morador',33333335,25,current_date),
(4,'jardilene Pinto','Morador','05','05','Morador','Morador',33333336,26,current_date),
(4,'Josimar Costa','Morador','05','15','Morador','Morador',33333337,27,current_date),
(4,'Andre Goltino','Morador','05','25','Morador','Morador',33333338,28,current_date),
(1,'Marcelo Resende','Morador','05','35','Morador','Morador',33333339,29,current_date),
(4,'Ronad Barros','Morador','05','45','Morador','Morador',44444440,30,current_date),
(1,'Marilia Medonça','Morador','05','11','Morador','Morador',44444441,31,current_date);

insert into tbl_ebox(id_login,num_ebox,tamanho,status_ebox,data_cad)
values
(1,'EBXP01','Pequeno','Livre',current_date),
(1,'EBXP02','Pequeno','Livre',current_date),
(1,'EBXP03','Pequeno','Livre',current_date),
(1,'EBXP04','Medio','Livre',current_date),
(1,'EBXP05','Medio','Livre',current_date),
(1,'EBXP06','Medio','Livre',current_date),
(1,'EBXP07','Grande','Livre',current_date),
(1,'EBXP08','Grande','Livre',current_date),
(1,'EBXP09','Grande','Livre',current_date),
(1,'EBXP10','Pequeno','Livre',current_date),
(1,'EBXM01','Medio','Livre',current_date),
(1,'EBXM02','Grande','Livre',current_date),
(1,'EBXM03','Pequeno','Livre',current_date),
(1,'EBXM04','Medio','Livre',current_date),
(1,'EBXM05','Grande','Livre',current_date),
(1,'EBXM06','Medio','Livre',current_date);

insert into tbl_entrega(id_login,id_ebox,num_encomenda,bloco,apto,data_inclusao,data_retirada,id_morador,nome_morador)
values
(1,1,'DXB70935BR' , '01','11',current_date,current_date,0,'null'), 
(3,3,'OAB72938BR' , '02','22',current_date,current_date,0,'null'),
(5,10,'RRB88935BR', '03','33',current_date,current_date,0,'null'),
(2,11,'OAB72225BR', '04','04',current_date,current_date,0,'null'),
(4,5,'pAB71111BR' , '05','15',current_date,current_date,0,'null'),
(3,13,'OAB77897BR', '03','13',current_date,current_date,0,'null'),
(5,7,'DAB32655BR' , '05','25',current_date,current_date,0,'null'),
(1,4,'OAB76905BR' , '04','14', current_date,current_date,0,'null'),
(2,9,'ODB12765BR' , '01','31',current_date,current_date,0,'null'),
(3,14,'OPB70935BR', '02','01',current_date,current_date,0,'null');