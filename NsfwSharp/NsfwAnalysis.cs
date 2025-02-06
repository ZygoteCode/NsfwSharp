using SkiaSharp;

namespace NsfwSharp
{
    public class NsfwAnalysis
    {
        public bool IsNsfw { get; private set; }
        public NsfwDetection[] Detections { get; private set; }
        public SKImage OriginalImage { get; private set; }
        public SKImage DetectionsImage { get; private set; }

        public NsfwAnalysis(bool isNsfw, NsfwDetection[] detections, SKImage originalImage, SKImage detectionsImage)
        {
            IsNsfw = isNsfw;
            Detections = detections;
            OriginalImage = originalImage;
            DetectionsImage = detectionsImage;
        }
    }
}