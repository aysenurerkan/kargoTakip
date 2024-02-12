

CREATE TABLE subeler(

sid NUMBER GENERATED ALWAYS as IDENTITY(START WITH 1 INCREMENT by 1),
sisim VARCHAR2(20),
PRIMARY KEY (sid)

);


CREATE TABLE admin(

aid NUMBER GENERATED ALWAYS as IDENTITY(START WITH 1 INCREMENT by 1),
aisim VARCHAR2(20),
asoyisim VARCHAR2(20),
atcno NUMBER(11) UNIQUE NOT NULL,
adogumTarihi VARCHAR2(30),
amaas NUMBER(7),
asube VARCHAR2(20),
asifre VARCHAR2(20),
atel VARCHAR2(12),
PRIMARY KEY (aid)

);

drop table admin;

CREATE OR REPLACE PROCEDURE kullaniciEkle(isim IN VARCHAR2,soyisim IN VARCHAR2, tcno IN NUMBER, dob IN DATE, maas IN DECIMAL, sube IN VARCHAR2,
sifre IN VARCHAR2, tel IN NUMBER)AS
BEGIN
INSERT INTO admin(aisim,asoyisim,atcno,adogumTarihi,amaas,asube,asifre,atel) VALUES (isim,soyisim,tcno,dob,maas,sube,sifre,tel);
END;
/

CREATE OR REPLACE PROCEDURE kullaniciSil(id IN INT)AS
BEGIN
DELETE FROM admin WHERE aid=id ;
END;
/

EXECUTE kullaniciEkle('admin','admin',1,'08-05-1995',7000,'Ankara-Sincan','1',05444445566);
/
EXECUTE kullaniciEkle('ali','veli',3,'08-05-1995',7000,'Ankara-Sincan','3',05444445566);
/
execute kullaniciSil(4);
/

SELECT*FROM admin;

CREATE OR REPLACE PROCEDURE subeEkle(subeisim IN VARCHAR2)AS
BEGIN
INSERT INTO subeler(sisim) VALUES (subeisim);
END;
/

--EXECUTE subeEkle('Ankara-Merkez');

--EXECUTE subeEkle('Ýstanbul-Merkez');

--EXECUTE subeEkle('Ýzmir-Merkez');

--EXECUTE subeEkle('Ankara-Sincan');

EXECUTE subeEkle('Ankara-Mamak');
/

SELECT*FROM subeler;


CREATE TABLE musteri(

mid NUMBER GENERATED ALWAYS as IDENTITY(START WITH 1 INCREMENT by 1),
misim VARCHAR2(20),
msoyisim VARCHAR2(20),
mtcno NUMBER(11) UNIQUE NOT NULL,
mdogumTarihi VARCHAR2(25),
madres VARCHAR2(100),
milce VARCHAR2(20),
msehir VARCHAR2(20),
mtel VARCHAR2(11),
PRIMARY KEY (mid)

);
 
DROP TABLE musteri;

CREATE OR REPLACE PROCEDURE musteriEkle(isim IN VARCHAR2,soyisim IN VARCHAR2, tcno IN NUMBER, dob IN VARCHAR2, adres IN VARCHAR2, ilce IN VARCHAR2,
sehir IN VARCHAR2, tel IN VARCHAR2)AS
BEGIN
INSERT INTO musteri(misim,msoyisim,mtcno,mdogumTarihi,madres,milce,msehir,mtel) VALUES (isim,soyisim,tcno,dob,adres,ilce,sehir,tel);
END;
/

execute musteriEkle('ahmet','yýldýrým',12335,'08-05-1998','yýlmaz mah buðday sok 12 1','Sincan','Ankara','053234550');
/

SELECT*FROM musteri;

CREATE TABLE kargo(

kid NUMBER GENERATED ALWAYS as IDENTITY(START WITH 1 INCREMENT by 1),
kaliciisim VARCHAR2(20),
kalicisoyisim VARCHAR2(20),
kalicitcno NUMBER(11)  NOT NULL,
kgonderentcno NUMBER(11)  NOT NULL,
kgonderenBilgi VARCHAR2(140),
kaliciadres VARCHAR2(100),
kaliciilce VARCHAR2(20),
kalicisehir VARCHAR2(20),
kalicitel NUMBER(11),
kicerik VARCHAR2(50),
ktakipNo VARCHAR2(20),
ktarih VARCHAR2(20),
PRIMARY KEY (kid)

);

ALTER TABLE kargo ADD kgonderenSube VARCHAR(20);

ALTER TABLE kargo ADD kucret DECIMAL(6,2);

ALTER TABLE kargo ADD sms VARCHAR(6);
 
SELECT*FROM kargo;

CREATE TABLE kargoTakip(

ktid NUMBER GENERATED ALWAYS as IDENTITY(START WITH 1 INCREMENT by 1),
ktAraSubeler VARCHAR2(20),
ktAraSubelerTarih VARCHAR2(20),
ktTakipNo VARCHAR2(20),
ktTeslim CHAR(1),
 
PRIMARY KEY (ktid)

);


ALTER TABLE kargoTakip ADD alanKisi VARCHAR(30);
 


 
CREATE OR REPLACE trigger kargoTakibeEkle
BEFORE INSERT ON kargo
REFERENCING NEW AS NEW OLD AS OLD
FOR EACH ROW 
BEGIN
INSERT INTO  kargoTakip(ktAraSubeler,ktAraSubelerTarih,ktTakipNo,ktTeslim) VALUES (:NEW.kgonderenSube,:NEW.ktarih,:NEW.ktakipNo,'H');
END;
/

CREATE OR REPLACE trigger kargoTakiptenSil
BEFORE DELETE ON kargo
REFERENCING NEW AS NEW OLD AS OLD
FOR EACH ROW 
BEGIN
DELETE FROM  kargoTakip WHERE ktTakipNo=:OLD.ktakipNo;
END;
/




INSERT INTO kargo(kaliciisim,kalicisoyisim,kalicitcno,kgonderentcno,kgonderenBilgi,kaliciadres,kaliciilce,kalicisehir,kalicitel,kicerik,ktakipNo,ktarih,kgonderenSube) 
VALUES ('ayþenur','erkan','1111111111','2222222','Gönderen bilgileri gelecek','Alýcý adresi gelecek','Gölbaþý','Ankara','05334445566','bilgisayar','TKP0002','04-12-2021','Ankara-Gölbaþý');


 
SELECT*FROM kargoTakip;

SELECT*FROM kargo;

SELECT*FROM admin;

 