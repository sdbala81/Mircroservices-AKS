﻿using System;

namespace GlobalTickets.Integration.Messages
{
    public class IntegrationBaseMessage
    {
        public Guid Id { get; set; }
        public DateTime CreationDateTime { get; set; }
    }
}
