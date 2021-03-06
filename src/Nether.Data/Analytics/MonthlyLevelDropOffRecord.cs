﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Nether.Data.Analytics
{
    public class MonthlyLevelDropOffRecord
    {
        public DateTime EventDate { get; set; }
        public int ReachedLevel { get; set; }
        public long TotalCount { get; set; }
    }
}

