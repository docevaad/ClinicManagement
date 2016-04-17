using ClinicManagement.Services;
using ClinicManagement.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace ClinicManagement.Web.Controllers
{
    /// <summary>
    /// PatientController class
    /// </summary>
    [RoutePrefix("api/patient")]
    public class PatientController : ApiController
    {
        public readonly PatientService m_PatientService;

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientController"/> class.
        /// </summary>
        /// <param name="patientService">The patient service.</param>
        public PatientController(PatientService patientService)
        {
            m_PatientService = patientService;
        }

        /// <summary>
        /// Gets a list of <see cref="Patient"/>
        /// </summary>
        /// <returns></returns>
        public Task<List<Patient>> Get()
        {
            return m_PatientService.GetAll();
        }

        /// <summary>
        /// Gets the specified patient identifier.
        /// </summary>
        /// <param name="patientId">The patient identifier.</param>
        /// <returns></returns>
        [Route("{patientId:int}")]
        public Task<Patient> Get(int patientId)
        {
            return m_PatientService.GetPatientById(patientId);
        }
    }
}