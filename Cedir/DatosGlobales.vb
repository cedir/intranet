Module DatosGlobales
    Public hayUnaFacturacionInstanciada As Boolean = False
    'Public idObraSocialDeFacturacion As Integer

    Public nroEstudioParaFacturacion As Integer
    Public nroConsultaParaFacturacion As Integer
    Public nroEstudioParaCargarMedicacion As Integer
    Public posibleErrorEnMedicacion As Boolean = False
    'posibleErrorEnMedicacion sirve para avisar a facturacion que hay un error en medicacion
    'Basicamente, si se se modifican la med. de 2 estudios desde fuera de la facturacion (por ej desde buscar estudios)
    'el nro de estudio del segundo va a reemplazar el del primero, dentro de la variable
    'nroEstudioParaCargarMedicacion, y eso va a hacer que fact. carge la medicacion de solo
    'el segundo estudio e ignore el primero.


    'Si esta abierta la vista de listado de facturaciones, la va a refrescar
    Public actualizarListadoFacturaciones As Boolean
End Module
