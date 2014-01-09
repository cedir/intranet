-- Function: sp_comprobanteslineainsertar(character varying, character varying, character varying, character varying)

--DROP FUNCTION sp_comprobanteslineainsertar(character varying, character varying, character varying, character varying);

CREATE OR REPLACE FUNCTION sp_comprobanteslineainsertar(concepto character varying, subtotal character varying, "idComprobante" character varying)
  RETURNS void AS
$BODY$insert into "cedirData"."tblComprobanteLineas"("concepto","subtotal","idComprobante")
values($1,to_number($2,'99999d99'),to_number($3,'99') )$BODY$
  LANGUAGE 'sql' VOLATILE
  COST 100;
ALTER FUNCTION sp_comprobanteslineainsertar(character varying, character varying, bigint) OWNER TO postgres;
GRANT EXECUTE ON FUNCTION sp_comprobanteslineainsertar(character varying, character varying, bigint) TO postgres;
