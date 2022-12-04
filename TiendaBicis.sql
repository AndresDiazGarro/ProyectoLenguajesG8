/* Nombre system
  Contraseña DBFide1 */

CREATE TABLE Tarjetas(
ID_tarjeta NUMBER (38) GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
Titular_tarjeta VARCHAR2 (100) NOT NULL,
Num_tarjeta NUMBER(20) NOT NULL,
CVC NUMBER(3) NOT NULL,
CONSTRAINT PK_Tarjetas PRIMARY KEY(ID_tarjeta)
);

INSERT INTO Tarjetas(Titular_tarjeta,Num_tarjeta,CVC)
VALUES ('Andres Diaz',123456789,123);

drop table Usuarios;
drop table Tarjetas;
CREATE TABLE Usuarios(
ID_Usuario NUMBER (38)GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
Nombre VARCHAR2 (30) NOT NULL,
Apellido VARCHAR2 (30) NOT NULL,
Nom_Usuario VARCHAR2 (30) NOT NULL,
Contrasena VARCHAR2(20) NOT NULL,
Rol VARCHAR2(20) NOT NULL,
ID_tarjeta NUMBER (38),
CONSTRAINT PK_Usuarios PRIMARY KEY(ID_Usuario),
CONSTRAINT FK_Tarjetas FOREIGN KEY (ID_tarjeta) REFERENCES Tarjetas(ID_tarjeta)
);


INSERT INTO USUARIOS(NOMBRE,APELLIDO,NOM_USUARIO,CONTRASENA,ID_TARJETA)
VALUES ('Andres','Diaz','andres1',123,1);

INSERT INTO USUARIOS(NOMBRE,APELLIDO,NOM_USUARIO,CONTRASENA,ID_TARJETA)
VALUES ('Danny','Rojas','danny1',123,1);

CREATE TABLE Marca(
ID_marca NUMBER (38)GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
Nombre_marca VARCHAR2 (30) NOT NULL,
CONSTRAINT PK_Marca PRIMARY KEY(ID_marca)
);

CREATE TABLE Material(
ID_material NUMBER (38)GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
Nombre_material VARCHAR2 (30) NOT NULL,
CONSTRAINT PK_Material PRIMARY KEY(ID_material)
);

CREATE TABLE Marco(
ID_Marco NUMBER (38)GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
ID_Material NUMBER (38) NOT NULL,
Nombre_marco VARCHAR2 (30) NOT NULL,
ID_Marca NUMBER (38) NOT NULL,
CONSTRAINT PK_Marco PRIMARY KEY(ID_Marco),
CONSTRAINT FK_Material FOREIGN KEY (ID_Material) REFERENCES Material(ID_Material),
CONSTRAINT FK_Marca FOREIGN KEY (ID_Marca) REFERENCES Marca(ID_Marca)
);

CREATE TABLE Ruedas(
ID_Ruedas NUMBER (38)GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
ID_Material NUMBER (38) NOT NULL,
ID_Marca NUMBER (38) NOT NULL,
Nombre_ruedas VARCHAR2 (30) NOT NULL,
CONSTRAINT PK_Ruedas PRIMARY KEY(ID_Ruedas),
CONSTRAINT FK_MaterialRueda FOREIGN KEY (ID_Material) REFERENCES Material(ID_Material),
CONSTRAINT FK_MarcaRueda FOREIGN KEY (ID_Marca) REFERENCES Marca(ID_Marca)
);

CREATE TABLE Suspension(
ID_Suspension NUMBER (38)GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
ID_Material NUMBER (38) NOT NULL,
ID_Marca NUMBER (38) NOT NULL,
Nombre_Susp VARCHAR2 (30) NOT NULL,
CONSTRAINT PK_Suspension PRIMARY KEY(ID_Suspension),
CONSTRAINT FK_MaterialSusp FOREIGN KEY (ID_Material) REFERENCES Material(ID_Material),
CONSTRAINT FK_MarcaSusp FOREIGN KEY (ID_Marca) REFERENCES Marca(ID_Marca)
);

CREATE TABLE Transmision(
ID_Transmision NUMBER (38)GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
ID_Material NUMBER (38) NOT NULL,
ID_Marca NUMBER (38) NOT NULL,
Nombre_Transmision VARCHAR2 (30) NOT NULL,
CONSTRAINT PK_Transmision PRIMARY KEY(ID_Transmision),
CONSTRAINT FK_MaterialTrans FOREIGN KEY (ID_Material) REFERENCES Material(ID_Material),
CONSTRAINT FK_MarcaTrans FOREIGN KEY (ID_Marca) REFERENCES Marca(ID_Marca)
);

CREATE TABLE Frenos(
ID_Frenos NUMBER (38)GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
ID_Material NUMBER (38) NOT NULL,
ID_Marca NUMBER (38) NOT NULL,
Nombre_Frenos VARCHAR2 (30) NOT NULL,
CONSTRAINT PK_Frenos PRIMARY KEY(ID_Frenos),
CONSTRAINT FK_MaterialFrenos FOREIGN KEY (ID_Material) REFERENCES Material(ID_Material),
CONSTRAINT FK_MarcaFrenos FOREIGN KEY (ID_Marca) REFERENCES Marca(ID_Marca)
);

CREATE TABLE Bicicletas(
ID_Bicicleta NUMBER(38) GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
Nombre VARCHAR2 (30) NOT NULL,
Precio NUMBER (7) NOT NULL,
ID_Frenos NUMBER (38) NOT NULL,
ID_Transmision NUMBER (38) NOT NULL,
ID_Suspension NUMBER(38) NOT NULL,
ID_Ruedas NUMBER(38) NOT NULL,
ID_Marco NUMBER(38) NOT NULL,
ID_Marca NUMBER(38) NOT NULL,
CONSTRAINT PK_Bicicletas PRIMARY KEY(ID_Bicicleta),
CONSTRAINT FK_TransmisionBici FOREIGN KEY (ID_Transmision) REFERENCES Transmision(ID_Transmision),
CONSTRAINT FK_MarcaBici FOREIGN KEY (ID_Marca) REFERENCES Marca(ID_Marca),
CONSTRAINT FK_FrenosBici FOREIGN KEY (ID_Frenos) REFERENCES Frenos(ID_Frenos),
CONSTRAINT FK_MarcoBici FOREIGN KEY (ID_Marco) REFERENCES Marco(ID_Marco),
CONSTRAINT FK_SuspensionBici FOREIGN KEY (ID_Suspension) REFERENCES Suspension(ID_Suspension),
CONSTRAINT FK_RuedasBici FOREIGN KEY (ID_Ruedas) REFERENCES Ruedas(ID_Ruedas)
);

CREATE TABLE Factura(
ID_Factura NUMBER(38) GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
ID_Usuario NUMBER (38) NOT NULL,
TERMINOS VARCHAR2 (50) NOT NULL,
Fecha DATE NOT NULL,
CONSTRAINT PK_Factura PRIMARY KEY(ID_Factura),
CONSTRAINT FK_UsuarioFactura FOREIGN KEY (ID_Usuario) REFERENCES Usuarios(ID_Usuario)
);

CREATE TABLE DetalleFactura(
DESCRIPCION VARCHAR2(50) NOT NULL,
CANTIDAD NUMBER(5) NOT NULL,
PRECIO NUMBER(7) NOT NULL,
MONTO NUMBER(10) NOT NULL
);

select * from Usuarios;



--------------------------------INSERTS DE DATOS-------------------------------------
--Marca Inserts
INSERT ALL 
INTO MARCA (ID_marca, Nombre_marca) VALUES (1,'Specialized')
INTO MARCA (ID_marca, Nombre_marca) VALUES (2,'Scott')
INTO MARCA (ID_marca, Nombre_marca) VALUES (3,'Trek')
INTO MARCA (ID_marca, Nombre_marca) VALUES (4,'Giant')
INTO MARCA (ID_marca, Nombre_marca) VALUES (5,'Pinarello')
INTO MARCA (ID_marca, Nombre_marca) VALUES (6,'Cannondale')
INTO MARCA (ID_marca, Nombre_marca) VALUES (7,'Fairlight')
INTO MARCA (ID_marca, Nombre_marca) VALUES (8,'Fearless')
INTO MARCA (ID_marca, Nombre_marca) VALUES (9,'Argon')
INTO MARCA (ID_marca, Nombre_marca) VALUES (10,'Zipp')
INTO MARCA (ID_marca, Nombre_marca) VALUES (11,'Hunt')
INTO MARCA (ID_marca, Nombre_marca) VALUES (12,'RockShox')
INTO MARCA (ID_marca, Nombre_marca) VALUES (13,'Fox')
INTO MARCA (ID_marca, Nombre_marca) VALUES (14,'Shimano')
INTO MARCA (ID_marca, Nombre_marca) VALUES (15,'Campagnolo')
SELECT * FROM dual;

--Material Inserts
INSERT ALL 
INTO MATERIAL (ID_MATERIAL, Nombre_MATERIAL) VALUES (51,'Acero')
INTO MATERIAL (ID_MATERIAL, Nombre_MATERIAL) VALUES (52,'Aluminio')
INTO MATERIAL (ID_MATERIAL, Nombre_MATERIAL) VALUES (53,'Fibra de Carbono')
INTO MATERIAL (ID_MATERIAL, Nombre_MATERIAL) VALUES (54,'Titanio')
SELECT * FROM dual;

--Marco Inserts
INSERT ALL 
INTO MARCO (ID_MARCO, ID_MATERIAL, NOMBRE_MARCO, ID_MARCA) VALUES (71,52,'Strael 3.0', 7)
INTO MARCO (ID_MARCO, ID_MATERIAL, NOMBRE_MARCO, ID_MARCA) VALUES (72,53,'Fearless', 8)
INTO MARCO (ID_MARCO, ID_MATERIAL, NOMBRE_MARCO, ID_MARCA) VALUES (73,54,'Krypton Pro', 9)
SELECT * FROM dual;

--Ruedas Inserts
INSERT ALL 
INTO RUEDAS (ID_RUEDAS, ID_MATERIAL, ID_MARCA, NOMBRE_RUEDAS) VALUES (91,53,10,'Carbon Aero')
INTO RUEDAS (ID_RUEDAS, ID_MATERIAL, ID_MARCA, NOMBRE_RUEDAS) VALUES (92,53,11,'Razing Zero')
INTO RUEDAS (ID_RUEDAS, ID_MATERIAL, ID_MARCA, NOMBRE_RUEDAS) VALUES (93,52,10,'Firecrest Carbon')
SELECT * FROM dual;

--Suspension Inserts
INSERT ALL 
INTO SUSPENSION (ID_SUSPENSION, ID_MATERIAL, ID_MARCA, NOMBRE_SUSP) VALUES (101,52,12,'Float Factory')
INTO SUSPENSION (ID_SUSPENSION, ID_MATERIAL, ID_MARCA, NOMBRE_SUSP) VALUES (102,53,12,'SID Ultimate')
INTO SUSPENSION (ID_SUSPENSION, ID_MATERIAL, ID_MARCA, NOMBRE_SUSP) VALUES (103,52,13,'Creek Helm')
SELECT * FROM dual;

--Transmision Inserts
INSERT ALL 
INTO TRANSMISION (ID_TRANSMISION, ID_MATERIAL, ID_MARCA, NOMBRE_TRANSMISION) VALUES (131,51,15,'Rohloffus')
INTO TRANSMISION (ID_TRANSMISION, ID_MATERIAL, ID_MARCA, NOMBRE_TRANSMISION) VALUES (132,53,14,'Rocketer')
SELECT * FROM dual;

--Frenos Inserts
INSERT ALL 
INTO FRENOS (ID_FRENOS, ID_MATERIAL, ID_MARCA, NOMBRE_FRENOS) VALUES (151,53,14,'XTR')
INTO FRENOS (ID_FRENOS, ID_MATERIAL, ID_MARCA, NOMBRE_FRENOS) VALUES (152,53,14,'Deore XT')
SELECT * FROM dual;

--Bicicletas Inserts
INSERT ALL 
INTO BICICLETAS (ID_BICICLETA, NOMBRE, PRECIO, ID_FRENOS, ID_TRANSMISION,ID_SUSPENSION,ID_RUEDAS,ID_MARCO,ID_MARCA) VALUES (301,'Sierra MTB',4000,151,132,101,92,72,1)
INTO BICICLETAS (ID_BICICLETA, NOMBRE, PRECIO, ID_FRENOS, ID_TRANSMISION,ID_SUSPENSION,ID_RUEDAS,ID_MARCO,ID_MARCA) VALUES (302,'RoadTreader Z',5685,152,131,103,93,71,3)
SELECT * FROM dual;

