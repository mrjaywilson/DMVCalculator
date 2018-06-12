// Import API
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Namespace Decparation
/// </summary>
namespace CST_117_Project_1
{
    /// <summary>
    /// Class Declaration
    /// </summary>
    class Calculate
    {
        /// <summary>
        /// Enum Declaration
        /// </summary>
        public enum FormulaType
        {
            /// <summary>
            /// Enum values for density, mass, and volume
            /// </summary>
            DENSITY,
            MASS,
            VOLUME
        }

        /// <summary>
        /// Store or Retrieve the currentFormula
        /// </summary>
        public FormulaType currentFormula { get; set; }
    }
}
