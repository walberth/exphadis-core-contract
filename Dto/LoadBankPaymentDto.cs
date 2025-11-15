namespace Exphadis.Core.Contract.Dto;

public class LoadBankPaymentDto
{
    public int Id { get; set; }

    public int BankPaymentLoadedId { get; set; }

    public string BankIdentifier { get; set; }

    public int Service { get; set; }

    public string Document { get; set; }

    public int NroReceive { get; set; }

    public string StudentName { get; set; }

    public decimal FirstPayment { get; set; }

    public decimal SecondPayment { get; set; }

    public decimal ThirdPayment { get; set; }

    public decimal FourPayment { get; set; }

    public decimal FivePayment { get; set; }

    public decimal SixPayment { get; set; }

    public DateTime ExpirationTime { get; set; }

    public DateTime PaymentTime { get; set; }

    public int IdTypePayment { get; set; }

    public string TypePayment { get; set; }

    public int IdMethodPayment { get; set; }

    public string MethodPayment { get; set; }

    public string NroOperation { get; set; }

    public string Level { get; set; }

    public string Grade { get; set; }

    public string Month { get; set; }

    public string HourPayment { get; set; }

    public DateTime RealPaymentTime { get; set; }

    public string Channel { get; set; }

    public string ChannelName { get; set; }

    public string UserRegister { get; set; }
}
