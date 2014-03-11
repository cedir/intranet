/* RESUMEN : Este script realiza un control de la cantidad de estudios realizados por año en el CEDIR 

Los estudios que se tienen en cuenta son los siguientes:

alto : esofago gastroduodeno video endoscopia id's:(1,18,87,140) idem con polipectomia, idem con toma de biopsia,idem coagulacion con argon plasma

bajo: colono video endoscopia id's:(2,19,86,92)

colangios id's: (34,13,49,48)

*/


select count(est."nroEstudio") as "altos", p.sexo
from "cedirData"."tblEstudios" as est  
inner join "cedirData"."AlmacenEstudios" as ale on  est."idEstudio" = ale."idEstudio" 
inner join "cedirData"."tblPacientes" as p on  est."idPaciente" = p."id"
where ale."idEstudio" IN (1,18,87,140)


and est."fechaEstudio" between '2005/06/01' and '2006/05/31' 
--and est."fechaEstudio" between '2006/06/01' and '2007/05/31' 
--and est."fechaEstudio" between '2007/06/01' and '2008/05/31' 
--and est."fechaEstudio" between '2008/06/01' and '2009/05/31' 
--and est."fechaEstudio" between '2009/06/01' and '2010/05/31' 
--and est."fechaEstudio" between '2010/06/01' and '2011/05/31' 
--and est."fechaEstudio" between '2011/06/01' and '2012/05/31' 
-- and est."fechaEstudio" between '2012/06/01' and '2013/05/31' 
--and est."fechaEstudio" between '2013/06/01' and '2014/05/31' 
-- and est."fechaEstudio" between '2014/06/01' and '2015/05/31' 
group by p.sexo


