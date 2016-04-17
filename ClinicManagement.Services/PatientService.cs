using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManagement.Web.Models;
using Tortuga.Chain;

namespace ClinicManagement.Services
{
    /// <summary>
    /// PatientService class.
    /// </summary>
    public class PatientService
    {
        private readonly SqlServerDataSource m_DataSource;
        private const string PatientPersonView = "vPatientPerson";

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientService"/> class.
        /// </summary>
        /// <param name="dataSource">The data source.</param>
        public PatientService(SqlServerDataSource dataSource)
        {
            m_DataSource = dataSource;
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public Task<List<Patient>> GetAll()
        {
            return m_DataSource.From(PatientPersonView).ToCollection<Patient>().ExecuteAsync();
        }

        /// <summary>
        /// Gets the patient by identifier.
        /// </summary>
        /// <param name="patientId">The patient identifier.</param>
        /// <returns></returns>
        public Task<Patient> GetPatientById(int patientId)
        {
            return m_DataSource.From(PatientPersonView, new { PatientId = patientId })
                .ToObject<Patient>().ExecuteAsync();
        }
    }
}
