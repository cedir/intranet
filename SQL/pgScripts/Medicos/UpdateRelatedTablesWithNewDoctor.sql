DECLARE @resultado;
DECLARE @resultado1;
DECLARE @resultado2;
DECLARE @resultado3;
DECLARE @idMedicoAeliminar;
DECLARE @idMedicoReemplazante;

SET @idMedicoAeliminar = 12848;--ejemplo
SET @idMedicoReemplazante = 12786;--ejemplo


SET @resultado = update "cedirData"."tblDetalleEstudio" as p
set "idMedicoActuante" = @idMedicoReemplazante
where "idMedicoActuante" = @idMedicoAeliminar;



SET @resultado1 = update "cedirData"."tblPagosMedicos" 
set "idMedico" = @idMedicoReemplazante
where "idMedico" = @idMedicoAeliminar;


SET @resultado2 = update "cedirData"."turnos_turnos" as tt
set "medico_id" = @idMedicoReemplazante
where "medico_id" = @idMedicoAeliminar;


SET @resultado3 = update "cedirData"."turnos_disponibilidad_medicos" 
set "medico_id" = @idMedicoReemplazante
where "medico_id" = @idMedicoAeliminar;

SET @resultado4 = delete from "cedirData"."tblMedicosAct" 
where "id" = @idMedicoAeliminar;



--print resultados
