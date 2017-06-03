﻿using System.Xml.Serialization;

namespace GarantiVP
{
    [XmlType(AnonymousType = true)]
    public class GVPSRequestTransaction
    {
        /// <summary>
        /// Transaction type
        /// <para>Size 32 Byte alfanumeric</para>
        /// <para lang="tr">İşlem tipi</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPSTransactionType Type { get; set; }

        /// <summary>
        /// Number of installments. If it is sent empty, no installment will be made.
        /// <para lang="tr">Taksit Sayısı. Eğer boş gönderilirse, taksit yapılamaz.</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InstallmentCnt { get; set; }

        /// <summary>
        /// Amount
        /// <para>Size 19 Byte numeric</para> 
        /// <para>WARNING : Do not send more than 2 digits after the decimal slash. Example 1234.567 -> 123456</para>
        /// <para lang="tr">Tutar</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ulong Amount { get; set; }

        /// <summary>
        /// Currency code
        /// <para>Size 3 Byte</para>
        /// <para lang="tr">Para birimi kodu</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPSCurrencyCodeEnum CurrencyCode { get; set; }

        /// <summary>
        /// Cancel - the first generated number for the call
        /// <para>Size 12 Byte numeric</para>
        /// <para lang="tr">İptal - arama için ilk üretilen numara</para> 
        /// </summary>
        [XmlElement]
        public string OriginalRetrefNum { get; set; }

        /// <summary>
        /// Number of days shifted
        /// <para>Size 2 Byte numeric</para>
        /// <para lang="tr">Ötelenmiş gün sayısı</para> 
        /// </summary>
        [XmlElement]
        public string DelayDayCount { get; set; }

        /// <summary>
        /// Down payment rate
        /// <para>Size 2 Byte numeric</para>
        /// <para lang="tr">Peşinat payı / oranı</para> 
        /// </summary>
        [XmlElement]
        public string DownPaymentRate { get; set; }


        /// <summary>
        /// For normal operations value is 0. For 3D secure operations value is 13.
        /// <para>Size 2 Byte numeric</para> 
        /// <para lang="tr">Normal işlemler için değer 0'dır. 3D güvenli işlemler için değer 13'tür.</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPSCardholderPresentCodeEnum CardholderPresentCode { get; set; }

        /// <summary>
        /// For ECommerce operations value is N. For Moto operations value is Y.
        /// <para>Size 1 Byte alfanumeric</para>
        /// <para lang="tr">E-ticaret operasyonları için değer N'dir. Moto işlemleri için değer Y'dir.</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPSMotoIndEnum MotoInd { get; set; }

        /// <summary>
        /// Trading card transaction information
        /// As much as the installment number, it should be installment information.
        /// <para lang="tr">Ortak kart işlemleri bilgisi</para> 
        /// <para lang="tr">Taksit sayısı kadar vade bilgisi olmalıdır.</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPSRequestCommercialCardExtendedCredit CommercialCardExtendedCredit { get; set; }

        /// <summary>
        /// Corporate payment inquiry
        /// <para lang="tr">Kurum ödeme sorgulaması</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPSRequestUtilityPaymentInq UtilityPaymentInq { get; set; }

        /// <summary>
        /// Corporate payment cancellation inquiry
        /// <para lang="tr">Kurumsal ödeme iptali sorgusu</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPSRequestUtilityPaymentVoidInq UtilityPaymentVoidInq { get; set; }

        /// <summary>
        /// GSM money uploading, query processing parameters
        /// <para lang="tr">GSM para yükleme, sorgulama işlemi parametreleri</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPSRequestGSMUnitInq GSMUnitInq { get; set; }

        /// <summary>
        /// Information required for invoice payment transactions
        /// <para lang="tr">Fatura ödeme işlemleri için gerekli bilgiler</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPSRequestUtilityPayment UtilityPayment { get; set; }

        /// <summary>
        /// GSM money uploading, query processing parameters
        /// <para lang="tr">GSM para yükleme, sorgulama işlemi parametreleri</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPSRequestGSMUnitSales GSMUnitSales { get; set; }

        /// <summary>
        /// For CepBank operation information
        /// <para lang="tr">CepBank işlem bilgileri için</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPSRequestCepBank CepBank { get; set; }

        /// <summary>
        /// For CepBank reward inquiry
        /// <para lang="tr">CepBank bonus / ödül sorgulama için</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPSRequestCepBankIng CepBankInq { get; set; }

        /// <summary>
        /// Information required for 3D secure operations.
        /// <para>The PayerAuthcode field should be 13 for 3D operations.</para>
        /// <para lang="tr">3D secure işlemleri için gerekli bilgiler.</para> 
        /// <para lang="tr">PayerAuthcode alanı 3D işlemler için 13 değerinde olmalıdır.</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPSRequestSecure3D Secure3D { get; set; }

        /// <summary>
        /// Reward information
        /// <para lang="tr">Bonus / Ödül bilgisi</para> 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPSRequestRewardList RewardList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPSRequestChequeList ChequeList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GVPSRequestMoneyCard MoneyCard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public GVPSRequestVerification Verification { get; set; }


        //#region For response fields

        ///// <summary>
        ///// The field where the generated transaction number is returned
        ///// </summary>
        //[XmlElement]
        //public string RetrefNum { get; set; }


        ///// <summary>
        ///// The field where the confirmation code is returned.
        ///// </summary>
        //[XmlElement]
        //public string AuthCode { get; set; }


        ///// <summary>
        ///// The field where the transaction sequence number is returned.
        ///// </summary>
        //[XmlElement]
        //public string SequenceNum { get; set; }


        ///// <summary>
        ///// The area where the provision date is rotated.
        ///// </summary>
        //[XmlElement]
        //public string ProvDate { get; set; }

        //#endregion
    }
}