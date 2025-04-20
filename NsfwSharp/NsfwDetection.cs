public class NsfwDetection
{
    public string Name { get; private set; }
    public double Confidence { get; private set; }

    public NsfwDetection(string name, double confidence)
    {
        Name = name;
        Confidence = confidence;
    }
}