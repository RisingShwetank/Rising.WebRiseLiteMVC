using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;


namespace Rising.WebRise.Models
{  
    public class ImportFileInput
    {
       
        
        public string FilePath { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime TradeDate { get; set; }

        [Display(Name = "Import Basis")]
        public string ImportBasis { get; set; }

        public string FileType { get; set; }

        public string Exchange { get; set; }

        public string FileName { get; set; }

        public string Session { get; set; }

        public string Records { get; set; }

        [Display(Name = "Pro Code")]
        public string procode { get; set; }
        [Display(Name = "Broker Code")]
        public string brokercode { get; set; }

        [Display(Name = "Calculate Brokerage")]
        public bool calbrok { get; set; }

        [Display(Name = "User Id Wise Transfer")]
        public string useridwt { get; set; }

        public string Imported { get; set; }

        public string Rejected { get; set; }
        [Display(Name = "Member ID")]
        public string memberid { get; set; }

        public string File { get; set; }

        [Display(Name = "Session Id")]
        public string SessionId { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }

        [Display(Name = "Delete Only")]
        public bool DeleteOnly { get; set; }


    }
}
