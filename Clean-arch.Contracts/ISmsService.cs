namespace Clean_arch.Contracts;

public interface ISmsService
{
    void SendSms(SmsBody body);
}

public class SmsBody
{
    public string PhoneNumber { get; set; }
    public string Message { get; set; }
}