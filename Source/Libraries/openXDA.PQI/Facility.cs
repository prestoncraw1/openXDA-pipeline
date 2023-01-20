﻿//******************************************************************************************************
//  Facility.cs - Gbtc
//
//  Copyright © 2021, Grid Protection Alliance.  All Rights Reserved.
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
//  07/18/2022 - C. Lackner
//       Generated original version of source code.
//
//******************************************************************************************************

namespace openXDA.PQI
{
    /// <summary>
    /// Summary of the <see cref="Facility"/>. For more detailed information use <see cref="FacilityInfo"/>
    /// </summary>
    public class Facility
    {
        /// <summary>
        /// Name of the facility
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Voltage at the facility
        /// </summary>
        public string Voltage { get; set; }

        /// <summary>
        /// Utility voltage supplied to the facility
        /// </summary>
        public string UtilitySupplyVoltage { get; set; }

        /// <summary>
        /// Path to query this Facility 
        /// </summary>
        public string Path { get; set; }


    }
}
