/*
 * APIMATICCalculatorTestcases.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 09/07/2016
 */
using System;
using APIMATICCalculatorTestcases.PCL.Controllers;
using APIMATICCalculatorTestcases.PCL.Http.Client;

namespace APIMATICCalculatorTestcases.PCL
{
    public partial class APIMATICCalculatorTestcasesClient
    {

        /// <summary>
        /// Singleton access to SimpleCalculator controller
        /// </summary>
        public SimpleCalculatorController SimpleCalculator
        {
            get
            {
                return APIMATICCalculatorTestcases.PCL.Controllers.SimpleCalculatorController.Instance;
            }
        }

        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public APIMATICCalculatorTestcasesClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public APIMATICCalculatorTestcasesClient(string basicAuthUserName, string basicAuthPassword)
        {
            Configuration.BasicAuthUserName = basicAuthUserName;
            Configuration.BasicAuthPassword = basicAuthPassword;
        }
    }
}