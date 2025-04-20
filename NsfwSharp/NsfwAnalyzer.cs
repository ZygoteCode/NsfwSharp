using YoloDotNet;
using YoloDotNet.Enums;
using YoloDotNet.Models;
using SkiaSharp;
using YoloDotNet.Extensions;

namespace NsfwSharp
{
    public class NsfwAnalyzer
    {
        private Yolo _yolo;

        public NsfwAnalyzer(string modelPath)
        {
            _yolo = new Yolo(new YoloOptions
            {
                OnnxModel = modelPath,
                ModelType = ModelType.ObjectDetection,
                Cuda = false,
                GpuId = 0,
                PrimeGpu = false,
            });
        }

        public NsfwAnalysis GetNsfwAnalysis(string imagePath)
        {
            return GetNsfwAnalysis(SKImage.FromEncodedData(imagePath));
        }

        public NsfwAnalysis GetNsfwAnalysis(byte[] imageData)
        {
            return GetNsfwAnalysis(SKImage.FromEncodedData(imageData));
        }

        public NsfwAnalysis GetNsfwAnalysis(SKImage image)
        {
            List<ObjectDetection>? results = _yolo.RunObjectDetection(image, confidence: 0.25, iou: 0.7);
            List<NsfwDetection> detections = new List<NsfwDetection>();

            foreach (ObjectDetection objectDetection in results)
            {
                detections.Add(new NsfwDetection(objectDetection.Label.Name.Substring(0, 1).ToUpper() + objectDetection.Label.Name.Substring(1).ToLower(), objectDetection.Confidence));
            }

            SKImage detectionsImage = image.Draw(results);
            return new NsfwAnalysis(detections.Count > 0, detections.ToArray(), image, detectionsImage);
        }
    }
}