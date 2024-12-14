public class Reception : Event
{
    //attributes
    private string _email;
    //constructor
    public Reception()
    {
        
    }

    //methods
    public string GetEmail()
    {
        return _email;
    }
    public void SetEmail(string email)
    {
        _email = email;
    }
    public override string FullDetails()
    {
        string fullDetails= base.FullDetails();
        fullDetails += $"\nRSVP at this email: {_email}\n";
        return fullDetails;
    }
}