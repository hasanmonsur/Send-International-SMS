﻿namespace TwilioSmsService.Models
{
    public class SmsRequest
    {
        public string ToPhoneNumber { get; set; }
        public string Message { get; set; }
    }
}
