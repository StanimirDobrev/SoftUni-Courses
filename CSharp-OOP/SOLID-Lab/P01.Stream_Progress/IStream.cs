﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.Stream_Progress
{
    public interface IStream
    {
        int Length { get; set; }
        int BytesSent { get; set; }
    }
}
