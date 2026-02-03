# Prueba 2 – Programación en C# (Simulación de OnBase)

Esta prueba evalúa tus habilidades en programación orientada a objetos, lógica aplicada a procesos
ECM/BPM y buenas prácticas en C#, utilizando un entorno simulado de Hyland OnBase.

⚠️ No necesitas el SDK real de OnBase ni conexión a ningún servidor.  
Todas las clases necesarias están incluidas en **OnBaseSdkStubs.cs**.

---

## 🎯 Objetivo General

Implementar un servicio en C# que genere y asigne un **Número de Radicado** a documentos simulados
dentro de un modelo liviano de OnBase.

Formato obligatorio del radicado:

```
RAD-AAAAMMDD-SSS
```

- `AAAA` = año  
- `MM` = mes  
- `DD` = día  
- `SSS` = secuencia incremental por día (001, 002, 003…)

---

## 🧠 Lo que debes implementar

Crear una clase llamada, por ejemplo, **RadicadoService**, que cumpla con lo siguiente:

### ✔ 1. Constructor

Recibe una instancia de `IOnBaseApplication`.

### ✔ 2. Método principal

Implementar:

```
void AsignarNumeroRadicado(int documentId);
```

### ✔ 3. El método debe:

1. Obtener el documento.
2. Verificar si ya existe el keyword **"Número de Radicado"**.  
3. Generar el número de radicado.
4. Agregar el keyword al documento.
5. Registrar logs de inicio, éxito o error.

---

## 🗂 Estructura esperada del proyecto

```
prueba2-onbase-csharp/
│
├─ OnBaseRadicado.sln
└─ OnBaseRadicado/
   ├─ OnBaseRadicado.csproj
   ├─ Program.cs
   ├─ OnBaseSdkStubs.cs
   └─ RadicadoService.cs   ← Debes crearlo
```

### Ejecución

```
cd prueba2-onbase-csharp
dotnet build
dotnet run --project OnBaseRadicado/OnBaseRadicado.csproj

