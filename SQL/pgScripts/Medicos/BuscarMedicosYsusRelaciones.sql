SELECT * FROM "cedirData"."tblMedicosAct" as ma
left join "cedirData"."tblDetalleEstudio"  AS de
on de."idMedicoActuante"= ma."idMedicoAct"
left JOIN  "cedirData"."tblPagosMedicos" as pm
ON de."idMedicoActuante"= pm."idMedico" 
left JOIN "cedirData"."turnos_turnos" as tt
ON tt."medico_id" = de."idMedicoActuante"
left JOIN "cedirData"."turnos_disponibilidad_medicos" as tdm
ON tdm."medico_id" = de."idMedicoActuante" 
where ma."idMedicoAct"= 218