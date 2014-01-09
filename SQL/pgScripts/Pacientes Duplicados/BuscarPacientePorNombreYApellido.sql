SELECT dni, nombres, apellido, edad, direccion, tel, sexo, "nroAfiliado", 
       id, "fechaNacimiento"
  FROM "cedirData"."tblPacientes"
  where nombres like'%ADA%'
  and apellido like'%PAOLETTI%'