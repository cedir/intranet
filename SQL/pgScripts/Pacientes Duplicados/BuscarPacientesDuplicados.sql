SELECT COUNT(*), nombres, apellido
FROM "cedirData"."tblPacientes"
Group by nombres, apellido
having count(*) > 1