using System;

namespace sysmed.Models
{
    /// <summary>
    /// Representa los tipos de medicamentos disponibles en el sistema.
    /// </summary>
    public enum MedicineType
    {
        None = 0,
        Analgesico,
        Analeptico,
        Anestesico,
        Antiacido,
        Antidepresivo,
        Antibiotico
    }

    public static class MedicineTypeExtensions
    {
        /// <summary>
        /// Devuelve la representación textual legible y acentuada del tipo de medicamento.
        /// </summary>
        public static string ToFriendlyString(this MedicineType type)
        {
            return type switch
            {
                MedicineType.Analgesico => "analgésico",
                MedicineType.Analeptico => "analéptico",
                MedicineType.Anestesico => "anestésico",
                MedicineType.Antiacido => "antiácido",
                MedicineType.Antidepresivo => "antidepresivo",
                MedicineType.Antibiotico => "antibiótico",
                _ => "desconocido"
            };
        }
    }
}
