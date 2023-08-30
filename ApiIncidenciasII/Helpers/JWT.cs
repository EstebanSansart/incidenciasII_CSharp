namespace ApiIncidenciasII.Helpers;
public class JWT
{
    public string HasKey { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public double DuratoinInMinutes { get; set; }
    public double DurationInMinutes { get; internal set; }
    public char[] Key { get; internal set; }
}