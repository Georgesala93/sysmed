using System;
using sysmed.Models;

namespace sysmed.Business
{
    /// <summary>
    /// Validador encargado de aplicar las reglas de negocio sobre un pedido (Order).
    /// </summary>
    public static class OrderValidator
    {
        /// <summary>
        /// Realiza la validación completa de un pedido de acuerdo a los requerimientos de la actividad.
        /// </summary>
        /// <param name="order">El objeto Order a validar.</param>
        /// <returns>Un ValidationResult indicando el estado final de la validación y los errores acumulados.</returns>
        public static ValidationResult Validate(Order order)
        {
            var result = new ValidationResult();

            if (order == null)
            {
                result.AddError("El pedido no puede ser nulo.");
                return result;
            }

            // 1. Validar Nombre del medicamento (Alfanumérico y no vacío)
            if (string.IsNullOrWhiteSpace(order.MedicineName))
            {
                result.AddError("El nombre del medicamento no puede estar vacío ni contener solo espacios.");
            }
            else
            {
                bool hasAlphanumeric = false;
                bool isAllAlphanumericOrSpace = true;

                foreach (char c in order.MedicineName)
                {
                    if (char.IsLetterOrDigit(c))
                    {
                        hasAlphanumeric = true;
                    }
                    else if (c != ' ' && c != '-') // Permitimos guiones como separador común
                    {
                        isAllAlphanumericOrSpace = false;
                    }
                }

                if (!hasAlphanumeric)
                {
                    result.AddError("El nombre del medicamento debe contener al menos un carácter alfanumérico.");
                }

                if (!isAllAlphanumericOrSpace)
                {
                    result.AddError("El nombre del medicamento sólo puede contener caracteres alfanuméricos, espacios o guiones.");
                }
            }

            // 2. Validar Tipo de medicamento seleccionado
            if (order.MedicineType == MedicineType.None)
            {
                result.AddError("Debe seleccionar un tipo de medicamento.");
            }

            // 3. Validar Cantidad (Número entero positivo)
            if (order.Quantity <= 0)
            {
                result.AddError("La cantidad requerida debe ser un número entero positivo (mayor que cero).");
            }

            // 4. Validar Distribuidor seleccionado
            if (order.Distributor == Distributor.None)
            {
                result.AddError("Debe seleccionar un distribuidor farmacéutico.");
            }

            // 5. Validar Sucursal seleccionada (Principal y/o Secundaria)
            if (order.Branches == PharmacyBranch.None)
            {
                result.AddError("Debe seleccionar al menos una sucursal destino (Principal, Secundaria o ambas).");
            }

            return result;
        }
    }
}
