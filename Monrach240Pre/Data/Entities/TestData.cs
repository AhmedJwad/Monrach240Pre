using System.ComponentModel.DataAnnotations;

namespace Monrach240Pre.Data.Entities
{
    public class TestData
    {
        public decimal ID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        public DateTime TIMESTAMP { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        public DateTime DATE_TIME_STAMP { get; set; }

        [StringLength(64)]
        public string DATA_SOURCE_NAME { get; set; }

        [StringLength(128)]
        public string DEVICE_ID { get; set; }

        [StringLength(32)]
        public string PATIENT_SEQ_NUM { get; set; }

        [StringLength(32)]
        public string PATIENT_ID { get; set; }

        [StringLength(128)]
        public string PATIENT_NAME { get; set; }

        [StringLength(128)]
        public string PATIENT_NAME_LAST { get; set; }

        [StringLength(128)]
        public string PATIENT_NAME_MIDDLE { get; set; }

        [StringLength(128)]
        public string PATIENT_NAME_FIRST { get; set; }

        [StringLength(12)]
        public string PATIENT_NAME_SEX { get; set; }

        [StringLength(128)]
        public string PATIENT_ADDRESS { get; set; }

        [StringLength(128)]
        public string PATIENT_PHONE { get; set; }

        [StringLength(32)]
        public string PATIENT_RACE { get; set; }

        [StringLength(12)]
        public string RESULT_SEQ_NUM { get; set; }

        [StringLength(32)]
        public string RESULT_TEST_ID { get; set; }

        [StringLength(32)]
        public string RESULT_TEST_ID1 { get; set; }

        [StringLength(32)]
        public string RESULT_TEST_ID2 { get; set; }

        [StringLength(32)]
        public string RESULT_TEST_ID3 { get; set; }

        [StringLength(32)]
        public string RESULT_TEST_ID4 { get; set; }

        [StringLength(32)]
        public string RESULT_VALUE { get; set; }

        [StringLength(32)]
        public string RESULT_UNIT { get; set; }

        [StringLength(32)]
        public string RESULT_ABNORMAL { get; set; }

        [StringLength(32)]
        public string RESULT_STATUS { get; set; }

        [StringLength(32)]
        public string RESULT_OPERATOR_ID { get; set; }
    }
}
