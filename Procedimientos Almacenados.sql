CREATE OR REPLACE PROCEDURE LOGIN (REGISTROS OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN REGISTROS FOR SELECT NOM_USUARIO, CONTRASENA FROM USUARIOS;
END;

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



CREATE OR REPLACE PACKAGE INICIO_SESION
IS
    PROCEDURE VERIFICAR_USUARIO(usua VARCHAR2, cont VARCHAR2);
    FUNCTION VERIFICAR_ROL(usua VARCHAR2) return number;
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
       
       FUNCTION VERIFICAR_ROL(usua VARCHAR2) RETURN NUMBER
       IS
       V_ROL USUARIOS.ROL%TYPE;
       BEGIN
        SELECT ROL INTO V_ROL FROM USUARIOS WHERE NOM_USUARIO = usua;
        IF V_ROL = 'Cliente' THEN
            return 0;
        ELSE
            return 1;
        END IF;
    END;
END;

select * from usuarios;


CREATE OR REPLACE PROCEDURE MOSTRAR_DATOS_USUARIO(usua_act IN VARCHAR2, nom OUT VARCHAR2,
apell OUT VARCHAR2, usua OUT VARCHAR2, cont OUT VARCHAR2)
AS
BEGIN
 SELECT NOMBRE INTO nom FROM USUARIOS
 WHERE NOM_USUARIO = usua_act;
 SELECT APELLIDO INTO apell FROM USUARIOS
 WHERE NOM_USUARIO = usua_act;
 SELECT NOM_USUARIO INTO usua FROM USUARIOS
 WHERE NOM_USUARIO = usua_act;
 SELECT Contrasena INTO cont FROM USUARIOS
 WHERE NOM_USUARIO = usua_act;
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
            bicicletas.ID_MARCA = MARCA.ID_MARCA;
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

/* ESTO ES NUEVOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO*/
--PROCEDIMIENTO ALMACENADO PARA AGREGAR DATOS A LA FACTURA
create or replace PROCEDURE DETALLE_FACTURA(
          ADD_DESCRIPCION IN DetalleFactura.DESCRIPCION%TYPE,
          ADD_CANTIDAD IN DetalleFactura.CANTIDAD%TYPE,
          ADD_PRECIO IN DetalleFactura.PRECIO%TYPE,
          ADD_MONTO IN DetalleFactura.MONTO%TYPE)
AS
BEGIN
 INSERT INTO DetalleFactura (DESCRIPCION, CANTIDAD, PRECIO, MONTO) 
 VALUES (ADD_DESCRIPCION,ADD_CANTIDAD,ADD_PRECIO,ADD_MONTO);
END;

-----------------------PROCEDIMIENTO ALMACENADO DE Factura Detalle CONSULTA---------------------

CREATE OR REPLACE PROCEDURE seleccionarDetalle(detalle out sys_refcursor)
AS
 BEGIN
  OPEN detalle FOR SELECT *
 FROM DetalleFactura;
END;
