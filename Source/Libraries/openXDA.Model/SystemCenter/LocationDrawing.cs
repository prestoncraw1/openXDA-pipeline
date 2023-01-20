﻿//******************************************************************************************************
//  LocationDrawing.cs - Gbtc
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
//  06/17/2021 - Billy Ernest
//       Generated original version of source code.
//
//******************************************************************************************************

using GSF.Data.Model;
using System.ComponentModel.DataAnnotations;

namespace SystemCenter.Model
{
    [PatchRoles("Administrator,Transmission SME")]
    [PostRoles("Administrator,Transmission SME")]
    [DeleteRoles("Administrator,Transmission SME")]
    [AllowSearch]
    public class LocationDrawing
    {
        [PrimaryKey(true)]
        public int ID { get; set; }
        [Required]
        public int LocationID { get; set; }
        [Required]
        [DefaultSortOrder]
        public string Name { get; set; }
        [Required]
        public string Link { get; set; }
        public string Description { get; set; }
    }
}