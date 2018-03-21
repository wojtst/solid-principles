namespace SolidPrinciples.Srp.Employee.Good
{
    public interface INotificationSender
    {
        void SendNotification(Employee employee, Message message);
    }
}
