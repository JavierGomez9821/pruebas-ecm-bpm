package com.redsis.prueba3;

public class DocumentoRequest {

    public String nombreArchivo;
    public String clienteNombre;
    public String clienteIdentificacion;
    public String tipoDocumento;

    public DocumentoRequest(String nombreArchivo,
                            String clienteNombre,
                            String clienteIdentificacion,
                            String tipoDocumento) {

        this.nombreArchivo = nombreArchivo;
        this.clienteNombre = clienteNombre;
        this.clienteIdentificacion = clienteIdentificacion;
        this.tipoDocumento = tipoDocumento;
    }
}
