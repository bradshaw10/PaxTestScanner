using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace PaxTestScanner.Models
{
    public partial class TransactionSale
    {
        class _failedMemberConversionMarker1
        {
        }
        //#error Cannot convert IncompleteMemberSyntax - see comment for details
        /* Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '<JsonObject("SaleTransactio...' at character 239


        Input:

 

        '

        '   This Model is a Sale Transactiom, with Header Details and then a List of SaleLines

        '   There will be Another Model for TransactionHeld with similar properties, and some extra ones

        '  

        '

        <JsonObject("SaleTransaction")>

         */


        public string RegCode { get; set; } = "";
        public string CustCode { get; set; } = "";
        public string HeldRef { get; set; } = "";
        public DateTime HeldDate { get; set; }
        public string HeldType { get; set; } = "";
        public DateTime ReportDate { get; set; }                  // May be Different to Actual Date



        // 

        // Not Sure if these Should be Part of Lines or not

        // 

        public string Nationality { get; set; } = "";
        public string EventCode { get; set; } = "";
        public DateTime EventDate { get; set; }
        public List<TransactionSaleLine> TransLines { get; set; } = new List<TransactionSaleLine>();
        public List<TransactionPaymentLine> PaymentLines { get; set; } = new List<TransactionPaymentLine>();
    }

    public partial class TransactionSaleLine
    {
        public int LineNo { get; set; }
        public string Assistant { get; set; } = "";            // Could be different for Each Line, .ie Who Served the Customer
        public string BranchExStock { get; set; } = "";        // Could be different for Each Line, .ie Branch Where Item is to Reduce Stock From
        public TransactionItem Item { get; set; }             // A Copy of the Product that was scanned
        public string ItemCode { get; set; } = "";
        public decimal QtySold { get; set; } = 0m;
        public decimal PriceRRP { get; set; } = 0m;
        public decimal PriceRetail { get; set; } = 0m;
        public decimal PriceBase { get; set; } = 0m;
        public decimal PriceActual { get; set; } = 0m;
        public decimal DiscountMarkdown { get; set; } = 0m;
        public decimal DiscountPromo { get; set; } = 0m;
        public decimal DiscountRounding { get; set; } = 0m;
        public decimal CostAvg { get; set; } = 0m;
        public string VatCode { get; set; } = "";
        public decimal VatRate { get; set; } = 0m;
        public decimal VatAmt { get; set; } = 0m;
        public decimal CommissionSale { get; set; } = 0m;
        public decimal CommissionAssistant { get; set; } = 0m;
        public string SerialNo { get; set; } = "";
        public string DiscountMarkCode { get; set; } = "";
        public string ReturnedCode { get; set; } = "";
        public string ReturnedRef { get; set; } = "";
        public string OfferCodes { get; set; } = "";
        public string AuthorisedBy { get; set; } = "";
    }



    // 

    // A Transaction Payment is Used by the Sale Transaction and the Holds Transaction

    // the Fields Date, ReportDate, Branch and RegCode are set into Tender from the Same Fields within either the Sale/Held Portion of the Parent Class

    // 

    public partial class TransactionPaymentLine
    {
        public string PaymentMethod { get; set; } = "";          // PN_TYPE, 01 -> 15 and 98 for Depositused
        public string RecordTypeCode { get; set; } = "";           // PN_RECTYPE  01, 02, 03 , 21,22,23 ect
        public string LineNo { get; set; } = "";
        public string Assistant { get; set; } = "";
        public string Cashier { get; set; } = "";
        public decimal PaymentCurrency { get; set; } = 0m;
        public decimal PaymentLocal { get; set; } = 0m;
        public string CurrencyCode { get; set; } = "";
        public string CustCode { get; set; } = "";



        // Branch/RegCode as per the Top Part of the Class



        public string ExternalRef { get; set; } = "";
        public string AuthCode { get; set; } = "";



        // Date and ReportDate as per the Top Part of the Class

    }
}