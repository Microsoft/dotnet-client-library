/*
 * JSONResponse.cs
 *
 * Copyright (C) 2010-2014 by Revolution Analytics Inc.
 *
 * This program is licensed to you under the terms of Version 2.0 of the
 * Apache License. This program is distributed WITHOUT
 * ANY EXPRESS OR IMPLIED WARRANTY, INCLUDING THOSE OF NON-INFRINGEMENT,
 * MERCHANTABILITY OR FITNESS FOR A PARTICULAR PURPOSE. Please refer to the
 * Apache License 2.0 (http://www.apache.org/licenses/LICENSE-2.0) for more details.
 *
 */

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DeployR
{
/// <summary>
///A class that contains the JSON response generated by a HTTP POST/GET call.  This class uses the json.net 3rd party library.
/// </summary>
/// <remarks></remarks>
    public class JSONResponse : RResponse
    {

        private Boolean m_success = false;
        private String m_errormsg = "";
        private String m_console = "";
        private int m_errorcode = 0;
        private JObject m_jresponse;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <remarks></remarks>
        protected JSONResponse()
        {

        }

        internal JSONResponse(JObject jresponse, Boolean success, String errormsg, int errorcode)
        {
            m_success = success;
            m_errormsg = errormsg;
            m_errorcode = errorcode;
            m_jresponse = jresponse;
        }

        internal JSONResponse(JObject jresponse, Boolean success, String errormsg, String console, int errorcode)
        {
            m_success = success;
            m_errormsg = errormsg;
            m_console = console;
            m_errorcode = errorcode;
            m_jresponse = jresponse;
        }
        /// <summary>
        /// Get the json.net JOBject that represents the JSON markup
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public JObject JSONMarkup
        {
            get
            {
                return m_jresponse;
            }
        }
        /// <summary>
        /// Error Message generated by calling API
        /// </summary>
        /// <value></value>
        /// <returns>String containg error message</returns>
        /// <remarks></remarks>
        public int ErrorCode
        {
            get
            {
                return m_errorcode;
            }
        }
        /// <summary>
        /// Error Message generated by calling API
        /// </summary>
        /// <value></value>
        /// <returns>String containg error message</returns>
        /// <remarks></remarks>
        public String ErrorMsg
        {
            get
            {
                return m_errormsg;
            }
        }

        /// <summary>
        /// R Console text, if available
        /// </summary>
        /// <value></value>
        /// <returns>String containg console text</returns>
        /// <remarks></remarks>
        public String Console
        {
            get
            {
                return m_console;
            }
        }

        /// <summary>
        /// Indication if calling API succeeded
        /// </summary>
        /// <value></value>
        /// <returns>Boolean indicating if calling API succeeded.  True is success, False if failure</returns>
        /// <remarks></remarks>
        public Boolean Success
        {
            get
            {
                return m_success;
            }
        }
    }
}