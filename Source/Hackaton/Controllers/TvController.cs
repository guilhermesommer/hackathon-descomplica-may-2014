// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LiveController.cs" company="Descomplica">
//   Descomplica
// </copyright>
// <summary>
//   Defines the LiveController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Hackaton.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    /// The television controller.
    /// </summary>
    public class TvController : Controller
    {
        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Index()
        {
            return this.View();
        }

    }
}
