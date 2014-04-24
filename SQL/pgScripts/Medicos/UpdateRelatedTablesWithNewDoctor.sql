DECLARE @resultado;
DECLARE @resultado1;
DECLARE @resultado2;
DECLARE @resultado3;
DECLARE @resultado4;
DECLARE @resultado5;
DECLARE @resultado6;
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


SET @resultado4 = update "cedirData"."tblCajaMovimientos" 
set "medico_id" = @idMedicoReemplazante
where "medico_id" = @idMedicoAeliminar;

SET @resultado5 = update "cedirData"."tblDetalleEstudio"
set "idMedicoSolicitante" = @idMedicoReemplazante
where "idMedicoSolicitante" = @idMedicoAeliminar;


SET @resultado6 = delete from "cedirData"."tblMedicoSol" 
where "idMedicoSol" = @idMedicoAeliminar;

SET @resultado7 = delete from "cedirData"."tblMedicosAct" 
where "idMedicoAct" = @idMedicoAeliminar;



--print resultados
