using System.Collections.Generic;

namespace RotaDasTapas.Models
{
    public class TapasResponse
    {
        /// <summary>
        ///     List of Tapas
        /// </summary>
        public IEnumerable<Tapa> Tapas { get; set; }
    }
}