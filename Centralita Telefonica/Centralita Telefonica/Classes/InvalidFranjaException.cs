[Serializable]
public class InvalidFranjaException : Exception{

    public string franja {get; set;}
    public InvalidFranjaException() {}
    public InvalidFranjaException(string message) : base(message) {}
    public InvalidFranjaException(string message, Exception inner) : base (message, inner) {}
    public InvalidFranjaException(string message, int franja) : this(message) {
        this.franja = franja.ToString();
    }
}