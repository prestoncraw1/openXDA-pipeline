//*********************************************************************************************************************
// IFaultResultsWriter.cs
//
//  Copyright © 2013, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the Eclipse Public License -v 1.0 (the "License"); you may
//  not use this file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://www.opensource.org/licenses/eclipse-1.0.php
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  --------------------------------------------------------------------------------------------------- 
//  Portions of this work are derived from "openFLE" which is an Electric Power Research Institute, Inc.
//  (EPRI) copyrighted open source software product released under the BSD license.  openFLE carries
//  the following copyright notice: Version 1.0 - Copyright 2012 ELECTRIC POWER RESEARCH INSTITUTE, INC.
//  All rights reserved.
//  ---------------------------------------------------------------------------------------------------
//
//  Code Modification History:
//  -------------------------------------------------------------------------------------------------------------------
//  03/06/2013 - Stephen C. Wills
//       Generated original version of source code.
//
//*********************************************************************************************************************

using System;
using System.Collections.Generic;
using GSF.Adapters;

namespace FaultAlgorithms
{
    /// <summary>
    /// Interface for writing the results of the fault analysis to an output source.
    /// </summary>
    public interface IFaultResultsWriter : IAdapter
    {
        /// <summary>
        /// Writes configuration information to the output source.
        /// </summary>
        /// <param name="deviceConfigurations">Configuration information to be written to the output source.</param>
        void WriteConfiguration(ICollection<Device> deviceConfigurations);

        /// <summary>
        /// Writes the results to the output source.
        /// </summary>
        /// <param name="disturbanceRecorder">The device that collected the disturbance data.</param>
        /// <param name="disturbanceFiles">Information about the data files collected during the disturbance.</param>
        /// <param name="lineDataSets">The data sets used for analysis to determine fault location.</param>
        void WriteResults(Device disturbanceRecorder, ICollection<DisturbanceFile> disturbanceFiles, ICollection<Tuple<Line, FaultLocationDataSet>> lineDataSets);
    }
}
