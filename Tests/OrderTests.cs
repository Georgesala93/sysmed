using System;
using sysmed.Models;
using sysmed.Business;

namespace sysmed.Tests
{
    /// <summary>
    /// Contiene un conjunto de pruebas unitarias automáticas para verificar que la lógica de negocio y las
    /// validaciones del formulario funcionan correctamente de acuerdo con la rúbrica del proyecto.
    /// </summary>
    public static class OrderTests
    {
        /// <summary>
        /// Ejecuta los diferentes casos de prueba y reporta el resultado en la consola.
        /// </summary>
        /// <returns>True si todas las pruebas pasaron con éxito; de lo contrario, False.</returns>
        public static bool RunTests()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=====================================================================");
            Console.WriteLine("INICIANDO SUITE DE PRUEBAS UNITARIAS DE LOGICA DE NEGOCIO (sysmed)");
            Console.WriteLine("=====================================================================");
            Console.ResetColor();

            int passedTests = 0;
            int totalTests = 0;

            // Caso 1: Pedido completamente válido
            totalTests++;
            var validOrder = new Order
            {
                MedicineName = "Amoxicilina 500mg",
                MedicineType = MedicineType.Antibiotico,
                Quantity = 10,
                Distributor = Distributor.Cofarma,
                Branches = PharmacyBranch.Principal
            };
            var result1 = OrderValidator.Validate(validOrder);
            if (result1.IsValid)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[PASS] Caso 1: Pedido totalmente válido.");
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[FAIL] Caso 1: Pedido totalmente válido falló inesperadamente.");
                foreach (var err in result1.Errors) Console.WriteLine("  - Error detectado: " + err);
            }
            Console.ResetColor();

            // Caso 2: Nombre de medicamento inválido (no alfanumérico)
            totalTests++;
            var invalidNameOrder = new Order
            {
                MedicineName = "Ibuprofeno!!!",
                MedicineType = MedicineType.Analgesico,
                Quantity = 5,
                Distributor = Distributor.Empsephar,
                Branches = PharmacyBranch.Principal
            };
            var result2 = OrderValidator.Validate(invalidNameOrder);
            if (!result2.IsValid && result2.Errors.Exists(e => e.Contains("caracteres alfanuméricos")))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[PASS] Caso 2: Validación de nombre alfanumérico funciona correctamente (caracteres prohibidos detectados).");
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[FAIL] Caso 2: Validación de nombre alfanumérico falló al no rechazar el nombre.");
            }
            Console.ResetColor();

            // Caso 3: Cantidad inválida (negativa o cero)
            totalTests++;
            var invalidQtyOrder = new Order
            {
                MedicineName = "Loratadina",
                MedicineType = MedicineType.Analgesico,
                Quantity = -5,
                Distributor = Distributor.Cemefar,
                Branches = PharmacyBranch.Secundaria
            };
            var result3 = OrderValidator.Validate(invalidQtyOrder);
            if (!result3.IsValid && result3.Errors.Exists(e => e.Contains("número entero positivo")))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[PASS] Caso 3: Validación de cantidad positiva funciona correctamente (cantidad negativa rechazada).");
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[FAIL] Caso 3: Validación de cantidad falló al no rechazar valor negativo.");
            }
            Console.ResetColor();

            // Caso 4: Sin distribuidor seleccionado
            totalTests++;
            var noDistOrder = new Order
            {
                MedicineName = "Paracetamol",
                MedicineType = MedicineType.Analgesico,
                Quantity = 10,
                Distributor = Distributor.None,
                Branches = PharmacyBranch.Principal
            };
            var result4 = OrderValidator.Validate(noDistOrder);
            if (!result4.IsValid && result4.Errors.Exists(e => e.Contains("Debe seleccionar un distribuidor")))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[PASS] Caso 4: Validación de distribuidor funciona (distribuidor ausente detectado).");
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[FAIL] Caso 4: Validación de distribuidor falló al no rechazar valor nulo/None.");
            }
            Console.ResetColor();

            // Caso 5: Sin sucursales seleccionadas
            totalTests++;
            var noBranchOrder = new Order
            {
                MedicineName = "Amoxicilina",
                MedicineType = MedicineType.Antibiotico,
                Quantity = 15,
                Distributor = Distributor.Cofarma,
                Branches = PharmacyBranch.None
            };
            var result5 = OrderValidator.Validate(noBranchOrder);
            if (!result5.IsValid && result5.Errors.Exists(e => e.Contains("Debe seleccionar al menos una sucursal")))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[PASS] Caso 5: Validación de sucursales funciona (pedido sin destino detectado).");
                passedTests++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[FAIL] Caso 5: Validación de sucursales falló al no rechazar selección vacía.");
            }
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=====================================================================");
            Console.WriteLine($"RESULTADO DE LA PRUEBA: {passedTests} de {totalTests} CASOS EXITOSOS");
            Console.WriteLine("=====================================================================");
            Console.ResetColor();

            return passedTests == totalTests;
        }
    }
}
