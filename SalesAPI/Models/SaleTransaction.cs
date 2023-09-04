namespace SalesAPI.Models
{
    public class SaleTransaction
    {
        public int Id { get; set; }
        public string AccountId { get; set; }
        public string TransactionId { get; set; }
        public int TransactionAmountUsd { get; set; }
        public string TransactionCurrencyCode { get; set; }
        public int LocalHour { get; set; }
        public string TransactionScenario { get; set; }
        public string TransactionType { get; set; }
        public int TransactionIpAddress { get; set; }
        public string IpState { get; set; }
        public string IpPostalCode { get; set; }
        public string IpCountry { get; set; }
        public int IsProxyIp { get; set; }
        public string BrowserLanguage { get; set; }
        public string PaymentInstrumentType { get; set; }
        public string CardType { get; set; }
        public string PaymentBillingPostalCode { get; set; }
        public string PaymentBillingState { get; set; }
        public string PaymentBillingCountryCode { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingState { get; set; }
        public string ShippingCountry { get; set; }
        public string CvvVerifyResult { get; set; }
        public int DigitalItemCount { get; set; }
        public int PhysicalItemCount { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
