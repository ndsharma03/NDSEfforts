namespace RateLimitterTEst
{
    internal class MyRateLimitOptions
    {
      public  const string  MyRateLimit= "MyRateLimit";
        public int PermitLimit { get; set; }
        public int Window { get; set; }
        public int QueueLimit { get; set; }
     
    }
}