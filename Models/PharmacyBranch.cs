using System;

namespace sysmed.Models
{
    /// <summary>
    /// Representa las sucursales de la farmacia que pueden recibir el pedido.
    /// Soporta selección múltiple usando flags.
    /// </summary>
    [Flags]
    public enum PharmacyBranch
    {
        None = 0,
        Principal = 1,
        Secundaria = 2
    }

    public static class PharmacyBranchExtensions
    {
        /// <summary>
        /// Devuelve la dirección física correspondiente a la sucursal de la farmacia.
        /// </summary>
        public static string GetAddress(this PharmacyBranch branch)
        {
            return branch switch
            {
                PharmacyBranch.Principal => "Calle de la Rosa n. 28",
                PharmacyBranch.Secundaria => "Calle Alcazabilla n. 3",
                _ => string.Empty
            };
        }
    }
}
