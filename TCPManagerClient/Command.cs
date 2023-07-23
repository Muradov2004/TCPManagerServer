namespace TCPManagerClient;

public class Command
{
    public const string ProcessList = "PROCLIST";
    public const string Kill = "KILL";
    public const string Run = "RUN";

    public string? Text { get; set; }
    public string? Param { get; set; }

}
