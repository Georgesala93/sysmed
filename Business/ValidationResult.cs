using System.Collections.Generic;

namespace sysmed.Business
{
    /// <summary>
    /// Representa el resultado de una operación de validación, acumulando los posibles mensajes de error.
    /// </summary>
    public class ValidationResult
    {
        /// <summary>
        /// Indica si el modelo validado es válido (no tiene errores).
        /// </summary>
        public bool IsValid => Errors.Count == 0;

        /// <summary>
        /// Lista de mensajes de error generados durante la validación.
        /// </summary>
        public List<string> Errors { get; } = new List<string>();

        /// <summary>
        /// Agrega un mensaje de error a la lista.
        /// </summary>
        /// <param name="errorMessage">Mensaje de error descriptivo.</param>
        public void AddError(string errorMessage)
        {
            Errors.Add(errorMessage);
        }
    }
}
