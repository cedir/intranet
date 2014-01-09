SELECT COUNT(*), "nombreMedicoAct" , "apellidoMedicoAct"
 FROM "cedirData"."tblMedicosAct"
  
Group by "nombreMedicoAct" , "apellidoMedicoAct"
having count(*) > 1