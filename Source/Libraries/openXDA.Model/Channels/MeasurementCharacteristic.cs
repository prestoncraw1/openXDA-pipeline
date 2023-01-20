﻿//******************************************************************************************************
//  MeasurementCharacteristic.cs - Gbtc
//
//  Copyright © 2017, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may
//  not use this file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  08/29/2017 - Billy Ernest
//       Generated original version of source code.
//
//******************************************************************************************************

using System;
using System.ComponentModel.DataAnnotations;
using GSF.Data.Model;

namespace openXDA.Model
{
    [PostRoles("Administrator, Transmission SME")]
    [DeleteRoles("Administrator, Transmission SME")]
    [PatchRoles("Administrator, Transmission SME")]
    [SettingsCategory("systemSettings")]
    public class MeasurementCharacteristic
    {
        [PrimaryKey(true)]
        public int ID { get; set; }

        [StringLength(200)]
        [DefaultSortOrder]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool Display { get; set; }
    }

    public static partial class TableOperationsExtensions
    {
        public static MeasurementCharacteristic GetOrAdd(this TableOperations<MeasurementCharacteristic> measurementCharacteristicTable, string name, string description = null)
        {
            MeasurementCharacteristic measurementCharacteristic = measurementCharacteristicTable.QueryRecordWhere("Name = {0}", name);

            if ((object)measurementCharacteristic == null)
            {
                measurementCharacteristic = new MeasurementCharacteristic();
                measurementCharacteristic.Name = name;
                measurementCharacteristic.Description = description ?? name;

                try
                {
                    measurementCharacteristicTable.AddNewRecord(measurementCharacteristic);
                }
                catch (Exception ex)
                {
                    // Ignore errors regarding unique key constraints
                    // which can occur as a result of a race condition
                    bool isUniqueViolation = ExceptionHandler.IsUniqueViolation(ex);

                    if (!isUniqueViolation)
                        throw;

                    return measurementCharacteristicTable.QueryRecordWhere("Name = {0}", name);
                }

                measurementCharacteristic.ID = measurementCharacteristicTable.Connection.ExecuteScalar<int>("SELECT @@IDENTITY");
            }

            return measurementCharacteristic;
        }
    }
}
