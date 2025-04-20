# NsfwSharp

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![C# .NET 9.0](https://img.shields.io/badge/C%23-.NET%209.0-blue)](https://dotnet.microsoft.com/download/dotnet/9.0)
[![YOLOv11](https://img.shields.io/badge/YOLOv11-ONNX%20Model-blueviolet)](#)

> **So far, the best C#.NET 9.0 open-source library that uses YOLOv11 with YoloDotNet (Microsoft.ML.OnnxRuntime) powered by a heavily trained ONNX model on a vast NSFW images dataset!**

NsfwSharp is the world's **first implementation** of an ONNX model with YOLOv11 for object detection in C# .NET 9.0, meticulously engineered to detect nudity, inappropriate, and NSFW content with unmatched precision.

---

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [Reporting Issues](#reporting-issues)
- [License](#license)
- [Acknowledgements](#acknowledgements)
- [Contact](#contact)

---

## Features

- **Cutting-Edge Detection:** Utilizes YOLOv11 for robust NSFW content detection.
- **ONNX Integration:** Powered by Microsoft.ML.OnnxRuntime for high performance.
- **Modern C# Development:** Built exclusively for C# .NET 9.0.
- **Extensive Dataset:** Trained on an enormous dataset to ensure superior accuracy.

---

## Installation

Integrate NsfwSharp into your project by following these simple steps:

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/yourusername/NsfwSharp.git
   cd NsfwSharp
   ```

2. **Install Dependencies:**

   Ensure you have the [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) installed. Then, restore NuGet packages:

   ```bash
   dotnet restore
   ```

3. **Install YoloDotNet:**

   NsfwSharp requires **YoloDotNet** for YOLOv11 integration. Install it via NuGet:

   ```bash
   dotnet add package YoloDotNet
   ```

4. **Build the Project:**

   ```bash
   dotnet build
   ```

---

## Usage

After installation, integrate NSFW detection into your application with ease. Here’s a quick example:

```csharp
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
```

For more detailed examples and documentation, please refer to the [Usage Guide](./docs/USAGE.md).

---

## Contributing

We welcome contributions from developers and enthusiasts alike! Follow these steps to contribute:

1. **Fork the Repository:**

   Click the **Fork** button at the top-right of this repository.

2. **Create a New Branch:**

   ```bash
   git checkout -b feature/your-feature-name
   ```

3. **Make Your Changes:**

   Commit your modifications with clear and concise commit messages:

   ```bash
   git commit -m "Add: [description of your changes]"
   ```

4. **Push to Your Fork:**

   ```bash
   git push origin feature/your-feature-name
   ```

5. **Create a Pull Request:**

   - Navigate to your fork on GitHub.
   - Click the **Compare & pull request** button.
   - Fill in the PR template with details about your changes.
   - Submit your pull request.

Your contributions are greatly appreciated and help improve NsfwSharp for everyone!

---

## Reporting Issues

Encountered a bug or have a feature request? I’d love to hear from you! Please follow these steps:

1. **Navigate to the Issues Tab:**

   Click on the **Issues** tab in the repository.

2. **Create a New Issue:**

   Click the **New Issue** button.

3. **Fill Out the Issue Template:**

   Provide a clear title and a detailed description including steps to reproduce the issue.

4. **Submit the Issue:**

   Once submitted, I’ll review and address it as soon as possible.

---

## License

NsfwSharp is open-sourced under the [MIT License](LICENSE). This permissive license allows you to use, modify, and distribute the library with confidence.

---

## Acknowledgements

A heartfelt thank you goes out to the original author of the pre-trained model. For more details, check out the model on [HuggingFace](https://huggingface.co/erax-ai/EraX-NSFW-V1.0?not-for-all-audiences=true).

---

## Contact

For any questions, suggestions, or feedback, please feel free to reach out via [GitHub Issues](https://github.com/ZygoteCode/NsfwSharp/issues) or contact the repository maintainer directly.

---

Happy coding! 🚀
