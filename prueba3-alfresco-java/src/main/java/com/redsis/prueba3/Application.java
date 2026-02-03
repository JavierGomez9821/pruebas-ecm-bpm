package com.redsis.prueba3;

public class Application {
    public static void main(String[] args) {
        System.out.println("=== Simulacion Prueba 3 Java + Alfresco ===");

        AlfrescoClientStub client = new AlfrescoClientStub();

        DocumentoRequest request = new DocumentoRequest(
                "archivo.pdf",
                "Juan Perez",
                "100200300",
                "Solicitud"
        );

        // TODO: el candidato debe implementar la lógica real dentro de AlfrescoClientStub
        String nodeId = client.subirDocumento(request);

        System.out.println("Resultado: NodeId generado -> " + nodeId);
    }
}
