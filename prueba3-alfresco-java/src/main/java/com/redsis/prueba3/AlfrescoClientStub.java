package com.redsis.prueba3;

import java.util.UUID;

public class AlfrescoClientStub {

    /**
     * Simula la subida de un documento a Alfresco.
     * En la prueba real, el candidato debería implementar aquí:
     *  - Llamado REST
     *  - Envío de metadatos
     *  - Manejo de errores, etc.
     */
    public String subirDocumento(DocumentoRequest req) {
        System.out.println("Simulando subida de documento a Alfresco...");
        System.out.println("Nombre archivo: " + req.nombreArchivo);
        System.out.println("Cliente: " + req.clienteNombre + " (" + req.clienteIdentificacion + ")");
        System.out.println("Tipo Documento: " + req.tipoDocumento);

        // Aquí solo devolvemos un NodeId ficticio
        return "NODE-" + UUID.randomUUID();
    }
}
