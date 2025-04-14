namespace Vitals
{
    // Interface for vital checks
    interface IVital
    {
        bool IsOk();
        string GetAlertMessage();
    }
}
