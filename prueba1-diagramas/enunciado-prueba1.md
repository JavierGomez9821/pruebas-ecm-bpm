# Prueba 1 – Historias de usuario y diagramas (ECM/BPM)

## Contexto general

Una entidad financiera quiere implementar, sobre una plataforma ECM/BPM (por ejemplo, OnBase o Alfresco),
un flujo para gestionar **solicitudes de los clientes**.  
Actualmente el proceso es muy manual y consta de estos pasos generales:

1. El cliente envía una solicitud (crédito, queja, reclamo, petición, etc.).
2. Un funcionario la recibe por correo o formulario web y la registra en el sistema.
3. Un coordinador asigna manualmente la solicitud a un analista.
4. El analista revisa la solicitud, realiza la gestión y responde al cliente.
5. El coordinador necesita llevar control del estado de las solicitudes.

Se desea modelar este flujo en una herramienta ECM/BPM, de forma que quede claro:

- Qué actividades se realizan.
- Qué actores participan.
- En qué estados puede estar una solicitud.
- Qué información se debe registrar.

---

## Historias de usuario

A continuación, se presentan historias de usuario que describen el comportamiento esperado del sistema.

### HU1 – Radicación de solicitudes

> **Como** cliente de la entidad financiera,  
> **quiero** poder enviar una solicitud desde un formulario digital,  
> **para que** el área de servicio al cliente la reciba y la gestione.

**Criterios de aceptación:**

- El formulario debe capturar como mínimo:
  - Nombre completo del cliente  
  - Número de identificación  
  - Tipo de solicitud (crédito, PQR, otro)  
  - Descripción de la solicitud  
  - Documentos anexos (opcional)
- Al guardar la solicitud, el sistema debe:
  - Registrar la información en el repositorio ECM.  
  - Generar un número de radicado automático.  
  - Guardar la fecha y hora de radicación.

---

### HU2 – Asignación automática de analista

> **Como** coordinador de servicio al cliente,  
> **quiero** que el sistema asigne automáticamente un analista disponible,  
> **para que** las solicitudes se gestionen sin intervención manual.

**Criterios de aceptación:**

- La asignación debe ser equilibrada entre los analistas (por ejemplo, round-robin).
- Si un analista está marcado como “no disponible” (vacaciones, incapacidad, etc.), no debe asignársele ninguna solicitud.
- Debe quedar trazabilidad de:
  - Fecha y hora de la asignación.
  - Analista asignado.
  - Usuario o sistema que realizó la asignación.

---

### HU3 – Gestión y cambio de estado de la solicitud

> **Como** analista de servicio,  
> **quiero** poder cambiar el estado de la solicitud conforme la vaya gestionando,  
> **para que** el coordinador y el cliente puedan conocer el avance.

**Criterios de aceptación:**

- Estados mínimos:
  - **En análisis**
  - **Resuelta**
  - **Cerrada / Notificada al cliente**
- Cada cambio de estado debe registrar:
  - Usuario que realizó el cambio.
  - Fecha y hora.
  - Comentario u observación (opcional, pero recomendable).
- No se debe poder cerrar una solicitud si no ha pasado por el estado “Resuelta”.

---

### HU4 – Consulta y seguimiento de solicitudes

> **Como** coordinador de servicio,  
> **quiero** consultar las solicitudes por estado, analista y rango de fechas,  
> **para** hacer seguimiento y reportes de carga de trabajo.

**Criterios de aceptación:**

- Filtros mínimos:
  - Rango de fechas de radicación.
  - Estado de la solicitud.
  - Analista asignado.
- El sistema debe mostrar:
  - Número de radicado.
  - Cliente.
  - Tipo de solicitud.
  - Estado actual.
  - Analista asignado.
  - Fecha de radicación.

---

## Actividades que debe realizar el candidato

1. **Identificar los procesos principales** a partir de las historias de usuario.  
   - Por ejemplo:  
     - Proceso de radicación  
     - Proceso de asignación  
     - Proceso de gestión y cierre  
   - El candidato puede agruparlos en un solo proceso o en varios subprocesos, justificando su decisión.

2. **Construir un diagrama BPMN** (o notación equivalente) del proceso principal, que incluya:
   - Inicio y fin del proceso.  
   - Actividades de los distintos roles (cliente, coordinador, analista, sistema).  
   - Puertas de decisión (excepciones o caminos alternos si aplica).  
   - Estados relevantes de la solicitud dentro del flujo.

3. **Construir un diagrama de clases** (o modelo de datos) mínimo con las entidades principales, por ejemplo:
   - `Solicitud`
   - `Cliente`
   - `Analista`
   - `Asignación`
   - `CambioEstado` (si lo considera necesario)
   
   Para cada clase, se esperan al menos:
   - Atributos principales (ej. `numeroRadicado`, `fechaRadicacion`, `estado`, etc.).  
   - Relaciones entre clases (asociaciones, composiciones, etc.).

4. **Listar suposiciones** realizadas para completar el modelo.  
   - Ejemplo: “Se asume que… el número de radicado es único a nivel de sistema”.

5. **Formular preguntas al cliente o al área de negocio** que considere necesarias para aclarar el alcance.  
   - Ejemplo: “¿Los clientes pueden adjuntar más de un documento?”  
   - “¿Existe SLA (tiempo máximo) para responder una solicitud?”

---

## Entregables

- Diagrama BPMN en formato:
  - Imagen (PNG/JPG) o
  - PDF
- Diagrama de clases o modelo de datos:
  - Imagen (PNG/JPG) o
  - PDF
- Documento breve (puede ser en el mismo archivo o en un archivo aparte) con:
  - Lista de suposiciones.
  - Lista de preguntas al cliente.

---

## Criterios de evaluación

- Claridad y coherencia del proceso modelado.
- Correcta identificación de actores y actividades.
- Calidad del diagrama BPMN (flujo lógico, decisiones, estados).
- Adecuada identificación de entidades y relaciones en el diagrama de clases.
- Capacidad de análisis reflejada en las suposiciones y preguntas.
- Presentación ordenada y entendible de los entregables.

---

## Nivel esperado según el perfil

- **Practicante ECM/BPM**  
  - Se espera un modelo razonablemente claro, aunque pueda ser sencillo.
  - Es aceptable que falten algunos detalles técnicos mientras el proceso esté bien entendido.

- **Ingeniero Junior ECM/BPM**  
  - Se espera un mayor nivel de detalle en el BPMN y el modelo de datos.
  - Se valoran preguntas más específicas de negocio y técnicas.
