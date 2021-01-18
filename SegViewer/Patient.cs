using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace SegViewer
{

    class Patient
    {
        static void CalculatorContour()
        {
            Mat mat = new Mat(@"..\..\Images\ocv02.jpg", ImreadModes.Unchanged);
            for (var y = 0; y < mat.Height; y++)
            {
                for (var x = 0; x < mat.Width; x++)
                {
                    Vec3b color = mat.Get<Vec3b>(y, x);
                    var temp = color.Item0;
                    color.Item0 = color.Item2; 
                    color.Item2 = temp;        
                    mat.Set(y, x, color);
                }
            }
        }
    }

}
