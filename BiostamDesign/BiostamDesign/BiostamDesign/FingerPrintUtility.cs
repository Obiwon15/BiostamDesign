using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DPFP;
using DPFP.Capture;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.IO;

namespace BiostamDesign
{
    class FingerPrintUtility
    {

        public static DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback CaptureFeedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref CaptureFeedback, ref features);


            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;

        }

        public static Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);

            return bitmap;

        }


    }
}
