using NsfwSharp;
using SkiaSharp;
using YoloDotNet.Extensions;

public class Program
{
    public static void Main()
    {
        NsfwAnalyzer nsfwAnalyzer = new NsfwAnalyzer(@"yolo_11m_nsfw.onnx");
        NsfwAnalysis nsfwAnalysis = nsfwAnalyzer.GetNsfwAnalysis(@"test.jpg");
        Console.WriteLine(nsfwAnalysis.Detections[0].Name);
        Console.WriteLine(nsfwAnalysis.Detections[0].Confidence);
        nsfwAnalysis.DetectionsImage.Save("result.jpg", SKEncodedImageFormat.Jpeg, 100);
    }
}