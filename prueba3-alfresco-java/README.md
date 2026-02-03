# Prueba 3 – Programación Java (Simulación de integración con Alfresco)

Esta prueba consiste en implementar un componente Java que simule la carga de documentos
a un repositorio Alfresco utilizando un cliente REST o un stub provisto.

No necesitas un entorno Alfresco real: el proyecto incluye clases base para simular la lógica.

---

## 🎯 Objetivo

Implementar la lógica necesaria para:

1. Recibir los datos del documento y sus metadatos.
2. Simular o implementar la llamada REST.
3. Retornar un identificador de documento (`nodeId`).
4. Mostrar en consola información del proceso.

---

## 🗂 Estructura del proyecto

```
prueba3-alfresco-java/
│
├─ pom.xml
└─ src/
   └─ main/java/com/redsis/prueba3/
       ├─ Application.java
       ├─ DocumentoRequest.java
       └─ AlfrescoClientStub.java
```

---

## 📝 Entrega

Puedes entregar:

- El proyecto con tus cambios
- Un repositorio con la solución
- Los archivos implementados/modificados
