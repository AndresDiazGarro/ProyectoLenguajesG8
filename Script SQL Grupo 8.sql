/* Nombre system
  Contrase�a DBFide1 */

CREATE TABLE Usuarios(
ID_Usuario NUMBER (38) GENERATED BY DEFAULT ON NULL AS IDENTITY NOT NULL,
Nombre VARCHAR2 (30) NOT NULL,
Apellido VARCHAR2 (30) NOT NULL,
Nom_Usuario VARCHAR2 (30) NOT NULL,
Contrasena VARCHAR2(20) NOT NULL,
Rol VARCHAR2(20) NOT NULL,
CONSTRAINT PK_Usuarios PRIMARY KEY(ID_Usuario)
);

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
ID_Factura VARCHAR2(30) NOT NULL,
NOMBRE VARCHAR2(20) NOT NULL,
APELLIDO VARCHAR2(20) NOT NULL,
USUARIO VARCHAR2 (30),
CEDULA NUMBER (38) NOT NULL,
TERMINOS VARCHAR2 (50) NOT NULL,
FECHA VARCHAR2 (10) NOT NULL
);


CREATE TABLE DetalleFactura(
DESCRIPCION VARCHAR2(50) NOT NULL,
CANTIDAD NUMBER(5) NOT NULL,
PRECIO NUMBER(7) NOT NULL,
MONTO NUMBER(10) NOT NULL,
ID_FACTURA VARCHAR2(30) NOT NULL
);

CREATE TABLE Coordenadas (
ID_SUCURSAL NUMBER (5) NOT NULL,
NOMBRE_SUCURSAL VARCHAR2 (50) NOT NULL,
LATITUD DECIMAL (20,10) NOT NULL,
LONGITUD DECIMAL (20,10) NOT NULL,
DIRECCION VARCHAR2 (150)
);

CREATE TABLE HISTORICO_FACTURA (
ID_FACTURA VARCHAR2(30) NOT NULL,
NOMBRE VARCHAR2(20) NOT NULL,
APELLIDO VARCHAR2(20) NOT NULL,
USUARIO VARCHAR2(30),
IDENTIFICACION NUMBER(38) NOT NULL,
TERMINOS VARCHAR2(50) NOT NULL,
FECHA VARCHAR2(10) NOT NULL
);

CREATE TABLE HISTORICO_DETALLE (
DESCRIPCION VARCHAR2(50) NOT NULL,
CANTIDAD  NUMBER(5) NOT NULL,
PRECIO NUMBER(7) NOT NULL,
MONTO NUMBER(10) NOT NULL,
ID_FACTURA VARCHAR2(30) NOT NULL
);

create table taller(
    ID_Bicicleta_Taller number(38) generated by default on null as identity,
    ID_BICICLETA number(38) not null,
    NOMBRE VARCHAR2(30) NOT NULL,
    NOMBRE_FRENOS VARCHAR2(30) NOT NULL,
    NOMBRE_TRANSMISION VARCHAR2(30),
    NOMBRE_SUSP VARCHAR2(30) NOT NULL,
    NOMBRE_RUEDAS VARCHAR2(30) NOT NULL,
    NOMBRE_MARCO VARCHAR2(30) NOT NULL,
    Nombre_MARCA VARCHAR2(30) NOT NULL,
    PROBLEMAS_REPORTADOS VARCHAR2(100) NOT NULL,
    OBSERVACIONES_MECANICO VARCHAR2(100) NOT NULL,
    MECANICO_REVISION VARCHAR2(30) NOT NULL,
    PRECIO_REVISION NUMBER(7) NOT NULL
);

--AUDITORIA DE TABLA TALLER

CREATE TABLE AUDITORIA_TALLER (
Id_Record NUMBER GENERATED ALWAYS AS IDENTITY,
Accion VARCHAR2(200),
Usuario VARCHAR2(20),
Fecha DATE,
PRIMARY KEY (Id_Record)
);

--AUDITORIA DE TABLA BICICLETAS
CREATE TABLE AUDITORIA_BICICLETAS (
Id_Record NUMBER GENERATED ALWAYS AS IDENTITY,
Accion VARCHAR2(200),
Usuario VARCHAR2(20),
Fecha DATE,
PRIMARY KEY (Id_Record)
);

--AUDITORIA DE TABLA USUARIOS
CREATE TABLE AUDITORIA_USUARIOS (
Id_Record NUMBER GENERATED ALWAYS AS IDENTITY,
Accion VARCHAR2(200),
Usuario VARCHAR2(20),
Fecha DATE,
PRIMARY KEY (Id_Record)
);

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

--Coordenadas Inserts
INSERT INTO COORDENADAS (ID_SUCURSAL, NOMBRE_SUCURSAL, LATITUD, LONGITUD, DIRECCION) VALUES (01, 'San Jose', 9.9363147, -84.0790631,'Avenida 4ta, de Correos de Costa Rica, 100mts Sur y 125 Oeste.');
INSERT INTO COORDENADAS (ID_SUCURSAL, NOMBRE_SUCURSAL, LATITUD, LONGITUD, DIRECCION) VALUES (02, 'Alajuela', 9.989498, -84.2874799, 'Centro Alajuela, de KFC 150mts Norte y 75 Este.');
INSERT INTO COORDENADAS (ID_SUCURSAL, NOMBRE_SUCURSAL, LATITUD, LONGITUD, DIRECCION) VALUES (03, 'Cartago', 9.8667534, -84.0633935,'Tejar, del Mas x Menos 75mts al Sur y 25 al Oeste.');
INSERT INTO COORDENADAS (ID_SUCURSAL, NOMBRE_SUCURSAL, LATITUD, LONGITUD, DIRECCION) VALUES (04, 'Heredia', 9.9971108, -84.1892609, 'Centro Comercial Paseo de las Flores, Local # 33.');
INSERT INTO COORDENADAS (ID_SUCURSAL, NOMBRE_SUCURSAL, LATITUD, LONGITUD, DIRECCION) VALUES (05, 'Limon', 10.3251669, -83.7215197, 'Del Chino los Aces, 25mts al Sur.');

--taller insert de prueba
insert into taller (ID_BICICLETA,NOMBRE,NOMBRE_FRENOS,NOMBRE_TRANSMISION,NOMBRE_SUSP,NOMBRE_RUEDAS,NOMBRE_MARCO,NOMBRE_MARCA,PROBLEMAS_REPORTADOS,OBSERVACIONES_MECANICO,MECANICO_REVISION,PRECIO_REVISION)values
(303, 'SCOTT SCALE 925 BIKE', 'SHIMANO DISC BRAKES', 'Shimano XT-SLX 12', 'Creek Helm','Syncros X-25 TR Rims',
'FOX 32 Float Rhythm 100mm Fork','SCOTT','Me hace brr cuando subo cuestas','Cadena esta oxidada',
'Juan','25000');

-----------------------PROCEDIMIENTOS ALMACENADOS DE USUARIOS---------------------

/* Creaci�n Usuario (CREATE) */
CREATE OR REPLACE PACKAGE CREACION_CUENTA
IS
    PROCEDURE CREAR_USUARIO(nom VARCHAR2, apell VARCHAR2, usua VARCHAR2,
    cont VARCHAR2, rol VARCHAR2);
    PROCEDURE VERIFICAR_REPETIDO(usua VARCHAR2);
END;
/
CREATE OR REPLACE PACKAGE BODY CREACION_CUENTA
IS
    PROCEDURE CREAR_USUARIO(nom VARCHAR2, apell VARCHAR2, usua VARCHAR2,
    cont VARCHAR2, rol VARCHAR2)
     IS
       BEGIN
        INSERT INTO USUARIOS (nombre, apellido, Nom_usuario, contrasena, rol)
        VALUES (nom, apell, usua, cont, rol);
       END;
       
       PROCEDURE VERIFICAR_REPETIDO(usua VARCHAR2)
        IS
         usuario USUARIOS.NOM_USUARIO%TYPE;
         BEGIN
          SELECT NOM_USUARIO INTO usuario FROM USUARIOS
          WHERE NOM_USUARIO = usua;
         END;
END;

/* Inicio de sesion*/

CREATE OR REPLACE PACKAGE INICIO_SESION
IS
    PROCEDURE VERIFICAR_USUARIO(usua VARCHAR2, cont VARCHAR2);
    PROCEDURE VERIFICAR_ROL(usua VARCHAR2, rol_cursor OUT SYS_REFCURSOR);
END;
/
CREATE OR REPLACE PACKAGE BODY INICIO_SESION
IS 
    PROCEDURE VERIFICAR_USUARIO(usua VARCHAR2, cont VARCHAR2)
     IS
       V_USUARIO USUARIOS.NOM_USUARIO%TYPE;
       V_CONTRASENA USUARIOS.CONTRASENA%TYPE;
       BEGIN
        SELECT CONTRASENA INTO V_CONTRASENA FROM USUARIOS
        WHERE NOM_USUARIO = usua AND CONTRASENA = cont;
       END;
       
       PROCEDURE VERIFICAR_ROL(usua VARCHAR2, rol_cursor OUT SYS_REFCURSOR)
       IS
       BEGIN
        OPEN rol_cursor FOR SELECT ROL FROM USUARIOS WHERE NOM_USUARIO = usua;
       END;
END;

CREATE OR REPLACE PACKAGE PERFIL
IS
 PROCEDURE MOSTRAR_DATOS_USUARIO(usua_act VARCHAR2, datos_usuario OUT SYS_REFCURSOR);
 PROCEDURE ACTUALIZAR_USUARIO(usua_act VARCHAR2,  nom VARCHAR2, apell VARCHAR2, usua VARCHAR2, cont VARCHAR2, rol_nuevo VARCHAR2);
 PROCEDURE ELIMINAR_USUARIO(usua_act VARCHAR2);
END;
/
CREATE OR REPLACE PACKAGE BODY PERFIL
IS 
 PROCEDURE MOSTRAR_DATOS_USUARIO(usua_act VARCHAR2, datos_usuario OUT SYS_REFCURSOR)
 IS
  BEGIN
   OPEN datos_usuario FOR SELECT * FROM USUARIOS WHERE NOM_USUARIO = usua_act;
  END;
    
    PROCEDURE ACTUALIZAR_USUARIO(usua_act VARCHAR2, nom VARCHAR2, apell VARCHAR2, usua VARCHAR2, cont VARCHAR2, rol_nuevo VARCHAR2)
    IS
     BEGIN
      UPDATE Usuarios SET NOMBRE = nom,
      APELLIDO = apell,
      NOM_USUARIO = usua,
      CONTRASENA = cont,
      ROL = rol_nuevo
      WHERE NOM_USUARIO = usua_act;
     END;
     
     PROCEDURE ELIMINAR_USUARIO(usua_act VARCHAR2)
     IS
      BEGIN
       DELETE FROM Usuarios WHERE NOM_USUARIO = usua_act;
      END;
  
END;

-----------------------PROCEDIMIENTO ALMACENADO DE BICICLETAS CONSULTA---------------------

CREATE OR REPLACE PROCEDURE seleccionarBicicletas(bicis out sys_refcursor)
AS

 BEGIN
  OPEN bicis FOR SELECT ID_BICICLETA, NOMBRE, PRECIO, NOMBRE_FRENOS, NOMBRE_TRANSMISION, NOMBRE_SUSP, NOMBRE_RUEDAS, NOMBRE_MARCO, Nombre_MARCA
 FROM BICICLETAS INNER JOIN FRENOS ON
  bicicletas.ID_FRENOS = frenos.ID_FRENOS
   INNER JOIN TRANSMISION ON
    bicicletas.ID_TRANSMISION = transmision.ID_TRANSMISION
     INNER JOIN SUSPENSION ON
      bicicletas.ID_SUSPENSION = SUSPENSION.ID_SUSPENSION
       INNER JOIN RUEDAS ON
        bicicletas.ID_RUEDAS = RUEDAS.ID_RUEDAS
         INNER JOIN MARCO ON 
          bicicletas.ID_MARCO = MARCO.ID_MARCO
           INNER JOIN MARCA ON
            bicicletas.ID_MARCA = MARCA.ID_MARCA
  Order by ID_BICICLETA ASC;
END;


------------------------------------------------------------------------------------------------------------------
--PROCEDIMIENTO ALMACENADO PARA AGREGAR BICIS
create or replace PROCEDURE AGREGAR_BICI(
          ADD_ID_BICICLETA IN BICICLETAS.ID_BICICLETA%TYPE,
          ADD_NOMBRE IN BICICLETAS.NOMBRE%TYPE,
          ADD_PRECIO IN BICICLETAS.PRECIO%TYPE,
          ADD_ID_FRENOS IN BICICLETAS.ID_FRENOS%TYPE,
          ADD_ID_TRANSMISION IN BICICLETAS.ID_TRANSMISION%TYPE,
          ADD_ID_SUSPENSION IN BICICLETAS.ID_SUSPENSION%TYPE,
          ADD_ID_RUEDAS IN BICICLETAS.ID_RUEDAS%TYPE,
          ADD_ID_MARCO IN BICICLETAS.ID_MARCO%TYPE,
          ADD_ID_MARCA IN BICICLETAS.ID_MARCA%TYPE)
AS
BEGIN
 INSERT INTO BICICLETAS (ID_BICICLETA, NOMBRE, PRECIO, ID_FRENOS, ID_TRANSMISION,ID_SUSPENSION,ID_RUEDAS,ID_MARCO,ID_MARCA) 
 VALUES (ADD_ID_BICICLETA,ADD_NOMBRE,ADD_PRECIO,ADD_ID_FRENOS,ADD_ID_TRANSMISION,ADD_ID_SUSPENSION,ADD_ID_RUEDAS,ADD_ID_MARCO,ADD_ID_MARCA);
END;

--PROCEDIMIENTO ALMACENADO PARA AGREGAR DATOS A LA FACTURA Detalle
create or replace PROCEDURE DETALLE_FACTURA(
          ADD_DESCRIPCION IN DetalleFactura.DESCRIPCION%TYPE,
          ADD_CANTIDAD IN DetalleFactura.CANTIDAD%TYPE,
          ADD_PRECIO IN DetalleFactura.PRECIO%TYPE,
          ADD_MONTO IN DetalleFactura.MONTO%TYPE,
          ADD_ID_FACTURA IN DetalleFactura.ID_FACTURA%TYPE)
AS
BEGIN
 INSERT INTO DetalleFactura (DESCRIPCION, CANTIDAD, PRECIO,MONTO,ID_FACTURA) 
 VALUES (ADD_DESCRIPCION,ADD_CANTIDAD,ADD_PRECIO,ADD_MONTO,ADD_ID_FACTURA);
END;

-----------------------PROCEDIMIENTO ALMACENADO DE Factura Detalle CONSULTA---------------------

CREATE OR REPLACE PROCEDURE seleccionarDetalle(detalle out sys_refcursor)
AS
 BEGIN
  OPEN detalle FOR SELECT *
 FROM DetalleFactura;
END;


--PROCEDIMIENTO ALMACENADO PARA AGREGAR DATOS A LA FACTURA
create or replace PROCEDURE FACTURACION(
          ADD_ID_FACTURA IN FACTURA.ID_FACTURA%TYPE,
          ADD_NOMBRE IN FACTURA.NOMBRE%TYPE,
          ADD_APELLIDO IN FACTURA.APELLIDO%TYPE,
          ADD_USUARIO IN FACTURA.USUARIO%TYPE,
          ADD_IDENTIFICACION IN FACTURA.CEDULA%TYPE,
          ADD_TERMINOS IN FACTURA.TERMINOS%TYPE,
          ADD_FECHA IN FACTURA.FECHA%TYPE)
AS
BEGIN
 INSERT INTO FACTURA (ID_FACTURA,NOMBRE, APELLIDO, USUARIO, CEDULA,TERMINOS,FECHA) 
 VALUES (ADD_ID_FACTURA,ADD_NOMBRE,ADD_APELLIDO,ADD_USUARIO,ADD_IDENTIFICACION,
 ADD_TERMINOS,ADD_FECHA);
END;

----------------------------------------------------------------------------------------------------
--PROCEDIMIENTO ALMACENADO PARA ELIMINAR BICIS
create or replace PROCEDURE ELIMINAR_BICI(DEL_BICICLETA IN BICICLETAS.ID_BICICLETA%TYPE)
AS
BEGIN
 DELETE FROM BICICLETAS 
 WHERE ID_BICICLETA = DEL_BICICLETA;
END;

-----------------------------------------------------------------------------------------------------
--PROCEDIMIENTO ALMACENADO PARA ACTUALIZAR BICICLETAS
create or replace PROCEDURE ACTUALIZAR_BICI(
          UPD_ID_BICICLETA IN BICICLETAS.ID_BICICLETA%TYPE,
          UPD_NOMBRE IN BICICLETAS.NOMBRE%TYPE,
          UPD_PRECIO IN BICICLETAS.PRECIO%TYPE,
          UPD_ID_FRENOS IN BICICLETAS.ID_FRENOS%TYPE,
          UPD_ID_TRANSMISION IN BICICLETAS.ID_TRANSMISION%TYPE,
          UPD_ID_SUSPENSION IN BICICLETAS.ID_SUSPENSION%TYPE,
          UPD_ID_RUEDAS IN BICICLETAS.ID_RUEDAS%TYPE,
          UPD_ID_MARCO IN BICICLETAS.ID_MARCO%TYPE,
          UPD_ID_MARCA IN BICICLETAS.ID_MARCA%TYPE)
AS
VID BICICLETAS.ID_BICICLETA%TYPE;
BEGIN
 SELECT ID_BICICLETA INTO VID FROM BICICLETAS WHERE ID_BICICLETA = UPD_ID_BICICLETA;
  UPDATE BICICLETAS
   SET 
    NOMBRE = UPD_NOMBRE,
    PRECIO = UPD_PRECIO,
    ID_FRENOS = UPD_ID_FRENOS,
    ID_TRANSMISION = UPD_ID_TRANSMISION,
    ID_SUSPENSION = UPD_ID_SUSPENSION,
    ID_RUEDAS = UPD_ID_RUEDAS,
    ID_MARCO = UPD_ID_MARCO,
    ID_MARCA = UPD_ID_MARCA
   WHERE 
    ID_BICICLETA = UPD_ID_BICICLETA;
END;

----------------------------------------------------------------------------------------
--AUDITORIAS DE TABLAS

--PISTA DE AUDITORIA 
CREATE OR REPLACE TRIGGER PISTA_AUDITORIA_BICICLETAS
AFTER INSERT OR DELETE OR UPDATE ON BICICLETAS
DECLARE
  VUSUARIO VARCHAR2(20);
  VACCION VARCHAR2(200);
  VFECHA DATE;
BEGIN
  SELECT USER, SYSDATE INTO VUSUARIO, VFECHA FROM DUAL;
    IF INSERTING THEN
      VACCION := 'SE AGREGÓ UNA BICICLETA NUEVA';
    ELSIF UPDATING THEN
      VACCION := 'SE ACTUALIZÓ UNA BICICLETA';
    ELSIF DELETING THEN
      VACCION := 'SE ELIMINÓ UNA BICICLETA';
    END IF;
      INSERT INTO AUDITORIA_BICICLETAS (USUARIO, ACCION,FECHA) VALUES (VUSUARIO, VACCION, VFECHA);
END;

--PISTA DE TALLER 
CREATE OR REPLACE TRIGGER PISTA_AUDITORIA_TALLER
AFTER INSERT OR DELETE OR UPDATE ON TALLER
DECLARE
  VUSUARIO VARCHAR2(20);
  VACCION VARCHAR2(200);
  VFECHA DATE;
BEGIN
  SELECT USER, SYSDATE INTO VUSUARIO, VFECHA FROM DUAL;
    IF INSERTING THEN
      VACCION := 'SE AGREG� UNA BICICLETA NUEVA AL TALLER';
    ELSIF UPDATING THEN
      VACCION := 'SE ACTUALIZ� UNA BICICLETA DEL TALLER';
    ELSIF DELETING THEN
      VACCION := 'SE ELIMIN� UNA BICICLETA DEL TALLER';
    END IF;
      INSERT INTO AUDITORIA_TALLER (USUARIO, ACCION,FECHA) VALUES (VUSUARIO, VACCION, VFECHA);
END;

--Usuarios 
CREATE OR REPLACE TRIGGER PISTA_AUDITORIA_USUARIOS
AFTER INSERT OR DELETE OR UPDATE ON USUARIOS
DECLARE
  VUSUARIO VARCHAR2(20);
  VACCION VARCHAR2(200);
  VFECHA DATE;
BEGIN
  SELECT USER, SYSDATE INTO VUSUARIO, VFECHA FROM DUAL;
    IF INSERTING THEN
      VACCION := 'SE AGREG� UN USUARIO NUEVO';
    ELSIF UPDATING THEN
      VACCION := 'SE ACTUALIZ� UN USUARIO';
    ELSIF DELETING THEN
      VACCION := 'SE ELIMIN� UN USUARIO';
    END IF;
      INSERT INTO AUDITORIA_USUARIOS (USUARIO, ACCION,FECHA) VALUES (VUSUARIO, VACCION, VFECHA);
END;

---------------------------------------------------------------------------------
--Seleccionar Auditoria de taller para consultar
CREATE OR REPLACE PROCEDURE seleccionarTallerAudits(audit_taller out sys_refcursor)
AS
 BEGIN
  OPEN audit_taller FOR SELECT Id_Record, Accion, Usuario, Fecha
   FROM AUDITORIA_TALLER
    Order by Id_Record ASC;
END;
---------------------------------------------------------------------------------
--Seleccionar Auditoria de bicicletas para consultar
CREATE OR REPLACE PROCEDURE seleccionarBikeAudits(audit_bicis out sys_refcursor)
AS
 BEGIN
  OPEN audit_bicis FOR SELECT Id_Record, Accion, Usuario, Fecha
   FROM AUDITORIA_BICICLETAS
    Order by Id_Record ASC;
END;

--Seleccionar Auditoria de usuarios para consultar
CREATE OR REPLACE PROCEDURE seleccionarUsuariosAudits(audit_usuarios out sys_refcursor)
AS
 BEGIN
  OPEN audit_usuarios FOR SELECT Id_Record, Accion, Usuario, Fecha
   FROM AUDITORIA_USUARIOS
    Order by Id_Record ASC;
END;


--PROCEDIMIENTO PARA EJECUTAR EL DELETE A LAS TABLAS FACTURA Y DETALLE FACTURA

Create or replace PROCEDURE LIMPIA_FACTURA
AS
BEGIN
 DELETE FROM FACTURA;
 DELETE FROM DETALLEFACTURA;
END;

--Trigger para guardar datos en HISTORICO factura

CREATE OR REPLACE TRIGGER GUARDA_FACTURA
AFTER INSERT ON FACTURA FOR EACH ROW
BEGIN
      INSERT INTO HISTORICO_FACTURA (ID_FACTURA, NOMBRE,APELLIDO,USUARIO,
      IDENTIFICACION,TERMINOS,FECHA)
      VALUES (:NEW.ID_FACTURA, :NEW.NOMBRE,:NEW.APELLIDO,:NEW.USUARIO,:NEW.CEDULA,
      :NEW.TERMINOS,:NEW.FECHA);
END GUARDA_FACTURA;

--TRIGGER PARA GUARDAR DATOS EN HISTORICO FACTURA

CREATE OR REPLACE TRIGGER GUARDA_DETALLE
AFTER INSERT ON DETALLEFACTURA FOR EACH ROW
BEGIN
      INSERT INTO HISTORICO_DETALLE (DESCRIPCION, CANTIDAD,PRECIO,MONTO,ID_FACTURA)
      VALUES (:NEW.DESCRIPCION, :NEW.CANTIDAD,:NEW.PRECIO,:NEW.MONTO,:NEW.ID_FACTURA);
END GUARDA_DETALLE;

---------------------------------------------------------------------------------
--Query Select Coordenadas
SELECT ID_SUCURSAL, NOMBRE_SUCURSAL, LATITUD, LONGITUD, DIRECCION
    FROM COORDENADAS;
    
    
--Procedimiento almacenado para consulta de Coordenadas
CREATE OR REPLACE PROCEDURE seleccionarCoordenadas(filas_coordenadas out sys_refcursor)
AS
    BEGIN
        OPEN filas_coordenadas FOR SELECT ID_SUCURSAL, NOMBRE_SUCURSAL, LATITUD, LONGITUD, DIRECCION
    FROM COORDENADAS;
END;

---  Stored procedure en taller consultar

create or replace procedure consultaTaller(bicis out sys_refcursor)
as
    begin
    open bicis for SELECT * from taller;
end;

---- Stored Procedure Insertar Taller
create or replace procedure insertarTaller(idBici in number, nombre in varchar2, frenos in varchar2, transmision in varchar2, susp in varchar2, ruedas in varchar2, marco in varchar2, marca in varchar2, problemas in varchar2, observaciones varchar2, mecanico in varchar2, precioRevision in number)
as 
    begin
    insert into taller (ID_BICICLETA,NOMBRE,NOMBRE_FRENOS,NOMBRE_TRANSMISION,NOMBRE_SUSP,NOMBRE_RUEDAS,NOMBRE_MARCO,NOMBRE_MARCA,PROBLEMAS_REPORTADOS,OBSERVACIONES_MECANICO,MECANICO_REVISION,PRECIO_REVISION)values(idBici , nombre , frenos , transmision , susp , ruedas , marco , marca , problemas , observaciones , mecanico , precioRevision );
end;

---- para probar
---execute insertarTaller(303, 'SCOTT SCALE 925 BIKE', 'SHIMANO DISC BRAKES', 'Shimano XT-SLX 12', 'Creek Helm','Syncros X-25 TR Rims','FOX 32 Float Rhythm 100mm Fork','SCOTT','Me hace brr cuando subo cuestas','Cadena esta oxidada','Juan','25000');

---- Stored Procedure taller Update
create or replace procedure updateTaller(idBici in number, nombre in varchar2, frenos in varchar2, transmision in varchar2, susp in varchar2, ruedas in varchar2, marco in varchar2, marca in varchar2, problemas in varchar2, observaciones varchar2, mecanico in varchar2, precioRevision in number)
as

    IDBICIX number := idBici; 
    NOMBREX VARCHAR2(30) := nombre;
    NOMBRE_FRENOSX VARCHAR2(30) := frenos;
    NOMBRE_TRANSMISIONX VARCHAR2(30) := transmision;
    NOMBRE_SUSPX VARCHAR2(30) := susp;
    NOMBRE_RUEDASX VARCHAR2(30) := ruedas;
    NOMBRE_MARCOX VARCHAR2(30) := marco;
    Nombre_MARCAX VARCHAR2(30) := marca;
    PROBLEMAS_REPORTADOSX VARCHAR2(100) := problemas;
    OBSERVACIONES_MECANICOX VARCHAR2(100) := observaciones;
    MECANICO_REVISIONX VARCHAR2(30) := mecanico;
    PRECIO_REVISIONX NUMBER(7) := precioRevision;

begin
    update taller set NOMBRE=NOMBREX,NOMBRE_FRENOS=NOMBRE_FRENOSX,NOMBRE_TRANSMISION=NOMBRE_TRANSMISIONX,NOMBRE_SUSP=NOMBRE_SUSPX,NOMBRE_RUEDAS=NOMBRE_RUEDASX,NOMBRE_MARCO=NOMBRE_MARCOX,NOMBRE_MARCA=Nombre_MARCAX,
    PROBLEMAS_REPORTADOS=PROBLEMAS_REPORTADOSX,OBSERVACIONES_MECANICO=OBSERVACIONES_MECANICOX,
    MECANICO_REVISION=MECANICO_REVISIONX,PRECIO_REVISION=PRECIO_REVISIONX where ID_BICICLETA=IDBICIX;
exception
    when NO_DATA_FOUND then
    null;
    when others then
    raise;
end updateTaller;

--- stored procedure para eliminar en taller
create or replace procedure eliminarTaller(idBiciTaller in number)
as
    idBiciTallerX number := idBiciTaller;
begin
    delete from taller where ID_Bicicleta_Taller=idBiciTallerX;
end;

/* Vista para buscar un cliente en espec�fico*/
CREATE OR REPLACE VIEW CONSULTA_FACTURAS AS
SELECT HISTORICO_FACTURA.ID_FACTURA,HISTORICO_FACTURA.NOMBRE, 
HISTORICO_FACTURA.APELLIDO,HISTORICO_FACTURA.USUARIO,HISTORICO_FACTURA.IDENTIFICACION,
HISTORICO_FACTURA.TERMINOS,HISTORICO_DETALLE.DESCRIPCION,HISTORICO_DETALLE.CANTIDAD,
HISTORICO_DETALLE.PRECIO,HISTORICO_DETALLE.MONTO,HISTORICO_FACTURA.FECHA
FROM HISTORICO_FACTURA,HISTORICO_DETALLE
WHERE HISTORICO_FACTURA.ID_FACTURA=HISTORICO_DETALLE.ID_FACTURA 
AND HISTORICO_FACTURA.ID_FACTURA LIKE '699510';

SELECT * FROM CONSULTA_FACTURAS;