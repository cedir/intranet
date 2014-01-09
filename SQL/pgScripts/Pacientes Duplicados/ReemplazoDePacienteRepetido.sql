-- Function: public.reemplazapac(smallint, smallint)

--DROP FUNcTION public.reemplazapac(smallint, smallint);

create FUNCTION public.reemplazapac("argUno" smallint, "argDos" smallint)
  RETURNS character varying AS
$BODY$update "cedirData"."tblEstudios" as p
set "idPaciente" = $1
where "idPaciente" = $2 ;
update "cedirData"."turnos_turnos" as tt
set "idPaciente" = $1
where "idPaciente" = $2 ; 
delete from "cedirData"."tblPacientes" 
where "id" = $2;
select p."nombres"
from "cedirData"."tblPacientes" as p
where p."id" = $1 ; $BODY$
  LANGUAGE sql VOLATILE
  COST 100;
ALTER FUNCTION public.reemplazapac(smallint, smallint)
  OWNER TO postgres;