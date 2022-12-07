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
 VALUES (ADD_ID_FACTURA,ADD_NOMBRE,ADD_APELLIDO,ADD_USUARIO,ADD_IDENTIFICACION,ADD_TERMINOS,ADD_FECHA);
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
      INSERT INTO HISTORICO_FACTURA (ID_FACTURA, NOMBRE,APELLIDO,USUARIO,IDENTIFICACION,TERMINOS,FECHA)
      VALUES (:NEW.ID_FACTURA, :NEW.NOMBRE,:NEW.APELLIDO,:NEW.USUARIO,:NEW.CEDULA,:NEW.TERMINOS,:NEW.FECHA);
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
WHERE HISTORICO_FACTURA.ID_FACTURA=HISTORICO_DETALLE.ID_FACTURA AND HISTORICO_FACTURA.ID_FACTURA LIKE '699510';

SELECT * FROM CONSULTA_FACTURAS;


