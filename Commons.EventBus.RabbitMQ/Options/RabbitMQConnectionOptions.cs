﻿namespace Commons.EventBus.RabbitMQ
{
    public class RabbitMQConnectionOptions
    {
        public string? HostName { get; set; }

        public int Port { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public TimeSpan RetryDelay { get; set; }
    }
}
