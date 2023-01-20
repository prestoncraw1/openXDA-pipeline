﻿//******************************************************************************************************
//  BreakerReportsSettings.cs - Gbtc
//
//  Copyright © 2019, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may not use this
//  file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  07/09/2019 - Billy Ernest
//       Generated original version of source code.
//
//******************************************************************************************************


using System.ComponentModel;
using System.Configuration;

namespace openXDA.Model
{
    public class BreakerReportsSettings
    {
        #region [ Members ]

        // Constants
        public const string CategoryName = "BreakerReports";

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Indicates whether operation is enabled.
        /// </summary>
        [Setting]
        [DefaultValue(false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Indicates whether operation is enabled.
        /// </summary>
        [Setting]
        [DefaultValue("0 0 2 * *")]  // Runs on second day of month to ensure all data is in
        public string Schedule { get; set; }

        /// <summary>
        /// Comma separated list of emails to send breaker reports to.
        /// </summary>
        [Setting]
        [DefaultValue("")]
        public string EmailList { get; set; }

        #endregion
    }
}
