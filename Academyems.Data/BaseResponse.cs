﻿namespace Academyems.Data
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public string? Error { get; set; }
        public string? Message { get; set; }
    }
}
