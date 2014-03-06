﻿select count(est."nroEstudio") as "altos", p.sexo
from "cedirData"."tblEstudios" as est  
inner join "cedirData"."AlmacenEstudios" as ale on  est."idEstudio" = ale."idEstudio" 
inner join "cedirData"."tblPacientes" as p on  est."idPaciente" = p."id"
where ale."idEstudio" IN (34,13,49,48)


--and est."fechaEstudio" between '2010/06/01' and '2011/05/31' 
--and est."fechaEstudio" between '2011/06/01' and '2012/05/31' 
--and est."fechaEstudio" between '2012/06/01' and '2013/05/31' 
-- and est."fechaEstudio" between '2013/06/01' and '2014/05/31' 
-- and est."fechaEstudio" between '2014/06/01' and '2015/05/31' 
group by p.sexo

/*
alto : esofago gastroduodeno video endoscopia (1,18,87,140) idem con polipectomia, idem con toma de biopsia,idem coagulacion con argon plasma

bajo: colono video endoscopia (2,19,86,92)

colangios (34,13,49,48)

*/