# sysmed - Sistema de Simulación de Pedidos de Medicamentos

Este es un proyecto desarrollado en **C#** y **.NET 10.0** utilizando **Windows Forms** para simular el sistema de pedidos de medicamentos de una farmacia a un distribuidor farmacéutico.

La aplicación permite el ingreso de datos, su validación síncrona mediante un motor de reglas de negocio y la visualización de un resumen estructurado del pedido antes de proceder con el envío simulado.

---

## 🚀 Arquitectura del Proyecto

El sistema ha sido estructurado siguiendo principios de **diseño desacoplado y orientado al dominio** para garantizar la separación de responsabilidades y permitir la ejecución de pruebas sobre la lógica de negocio sin depender de la interfaz gráfica de usuario (UI).

```text
sysmed/
├── Models/              # Modelos de dominio y enums fuertemente tipados
│   ├── MedicineType.cs  # Enum: analgésico, antibiótico, etc. (con nombres legibles)
│   ├── Distributor.cs   # Enum: Cofarma, Empsephar, Cemefar
│   ├── PharmacyBranch.cs# Flags: Principal, Secundaria (con direcciones físicas)
│   └── Order.cs         # Estructura que modela el pedido
├── Business/            # Lógica y motor de reglas de negocio
│   ├── ValidationResult.cs# Estructura acumuladora de errores de validación
│   └── OrderValidator.cs  # Motor centralizado de validación de pedidos
├── UI/                  # Capa de presentación (Formularios Windows Forms)
│   ├── MainForm.cs      # Ventana principal de captura de datos y validación
│   └── SummaryForm.cs   # Ventana secundaria con el resumen formateado de pedido
├── Tests/               # Pruebas unitarias automáticas
│   └── OrderTests.cs    # Suite interna de simulación de validaciones
├── sysmed.csproj        # Archivo de configuración del proyecto .NET 10.0
└── Program.cs           # Punto de entrada de la aplicación
```

---

## 🛠️ Reglas de Validación de Negocio

Cuando el usuario presiona **Confirmar**, se genera un objeto de dominio `Order` que es evaluado por el motor de reglas en `OrderValidator`. Las condiciones para que un pedido sea válido son:

1. **Nombre del medicamento:** Debe contener caracteres alfanuméricos y no puede estar vacío ni formado únicamente por espacios.
2. **Tipo de medicamento:** Debe seleccionarse un tipo válido de la lista desplegable.
3. **Cantidad:** Debe ser un número entero estrictamente positivo ($> 0$).
4. **Distribuidor:** Debe seleccionarse un distribuidor de los tres disponibles (*Cofarma, Empsephar o Cemefar*).
5. **Sucursal:** Debe seleccionarse al menos una sucursal destino (*Principal y/o Secundaria*).

Si hay algún error, se consolida una lista completa en un único cuadro de alerta. Si todo es correcto, se abre de forma modal la ventana de resumen.

---

## ⚙️ Instrucciones de Ejecución

Asegúrate de estar ubicado en la carpeta del proyecto `sysmed/` en tu terminal.

### 1. Iniciar la Interfaz Gráfica (GUI)
Para ejecutar la aplicación interactiva de Windows Forms:
```cmd
"C:\Program Files\dotnet\dotnet.exe" run
```
*(Nota: Si usas PowerShell, recuerda anteponer el operador de llamada `&`: `& "C:\Program Files\dotnet\dotnet.exe" run`)*

### 2. Ejecutar la Suite de Pruebas Unitarias (CLI)
Para correr la simulación automática de casos de validación por consola sin interfaz de usuario:
```cmd
"C:\Program Files\dotnet\dotnet.exe" run -- --test
```
