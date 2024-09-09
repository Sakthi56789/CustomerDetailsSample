using System.ComponentModel.DataAnnotations;

namespace CustomerDetailsSample.Domain
{
    public class CustomerDetails
    {
        [Key] 
        public Guid CustomerID { get; set; } = Guid.NewGuid();
        public string? CustomerCode { get; set; }
        [Required]
        public string? CustomerName { get; set; }
        public Enum? Status { get; set; }
        [Required]
        public string? CustomerType { get; set; }
        [Required]
        public string? ContactTitle { get; set; }
        public string?  ContactPerson { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage = "Accept Number only while typing (Maximum 10)")]
        public string? Phone { get; set;}
        [MaxLength(10,ErrorMessage = "Accept Number only while typing (Maximum 10)")]
        public string? MobileNumber { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Accept the @ value Only ")]
        public string? EmailAddress { get; set; }
        public string? Street {  get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? City {  get; set; }
        [Required]
        public string? State { get; set; }  
        public string? District { get; set; }
        public string? Landmark { get; set; }
        public string? Pincode { get; set; }
        public string? Country { get; set; }
        public JsonContent? BillingAddress { get; set; } = null;
        public JsonContent? ShippingAddress { get; set; } = null;
        public string? BusinessRegistrationNumber { get; set; }
        public string? TaxID { get; set; }
        public decimal CreditLimit { get; set; }
        public string? PaymentTerms {  get; set; }
        public int CreditDays {  get; set; }
        public int DueDays { get; set; }
        public decimal CashDisc { get; set; } 
        public decimal CreditDisc { get; set; }
        public int ChequePaymentDays { get; set; }
        public decimal OpeningBalDebt { get; set; }
        public Enum? GoodsTCSExempted {  get; set; }
        public Enum? GSTExempted { get; set; }
        public Enum? TDSApplicable { get; set; }
        public string? GSTNo { get; set; }
        public string? TINNo { get; set; }
        public string? PANNo { get; set; }
        public string? FSSAINo { get; set; }
        public string? ProfessionalTaxNo { get; set; }
        public string? BankName { get; set; }
        public string? BankAccountNumber { get; set; }
        public string? BankBranch { get; set; }
        public string? BankIFSCCode { get; set; }
        public string? HomeopathicLIC { get; set; }
        public string? DLNo1 {  get; set; }
        public string? DLNo2 { get; set; }
        public DateOnly DLExpDate { get; set; }
        public string? DoctorRegNo { get; set; }
        public string? OrderFrequency { get; set; }
        public Enum? AllowReturns { get; set; }
        public Enum? AllowBilling { get; set; }
        public string? SalesReturnAdjustedIn { get; set; }
        public DateOnly AllowSalesReturnUpto { get; set; }
        public int SalesRepID { get; set; }
        public decimal RepCom { get; set; }
        public decimal ExpiryDeductPercentage { get; set; }
        public string? PreferredCommunicationChannel { get; set; }
        public string? PreferredDeliveryTimes { get; set; }
        public string? SpecialInstructions { get; set; }
        public Enum? SaveasSingleLedger { get; set; }
        public string? Note { get; set; }
        public Enum? Allowtoenterfreeqty { get; set; }
        public DateOnly Birthday { get; set; }
        public DateOnly Anniversary { get; set; }
        public DateOnly LastOrderDate { get; set; }
        public Guid? CompanyID { get; set; } = null;
        public Guid? BranchID { get; set; } = null;
        public Guid? CreatedBy { get; set; } = null;
        public DateTime CreatedDate { get; set; }
        public Guid? LastUpdatedBy { get; set; } = null;
        public DateTime LastUpdatedDate { get; set; }
        public int TenantId { get; set; }

        }
}
