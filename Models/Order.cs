using System;

namespace sysmed.Models
{
    /// <summary>
    /// Representa un pedido de medicamentos para la farmacia.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Nombre del medicamento solicitado.
        /// </summary>
        public string MedicineName { get; set; } = string.Empty;

        /// <summary>
        /// Tipo de medicamento.
        /// </summary>
        public MedicineType MedicineType { get; set; } = MedicineType.None;

        /// <summary>
        /// Cantidad solicitada (debe ser un número entero positivo).
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Distribuidor farmacéutico seleccionado.
        /// </summary>
        public Distributor Distributor { get; set; } = Distributor.None;

        /// <summary>
        /// Sucursales destino a las que llegará el pedido (soporta selección múltiple).
        /// </summary>
        public PharmacyBranch Branches { get; set; } = PharmacyBranch.None;
    }
}
