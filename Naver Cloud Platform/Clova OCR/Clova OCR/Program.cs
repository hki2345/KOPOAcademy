using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Configuration;

namespace Clova_OCR
{
    internal class Program
    {
        const string SECRET_KEY = "bGlsWUVvZUJGaVJVd0pTdUFkZ2dtRkhkT0NzaUZYRUI=";
        const string URL = "https://bc1zisswlo.apigw.ntruss.com/custom/v1/22607/9e326da3daa7d15e65ff373061beb73c12681e982d1c603c8d3133eb96afa2c4/general";

        static void Main(string[] args)
        {
            string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
            string imageFile = rootPath + "image.jpg";
            string resultFile = rootPath + "result.json";

            bool liveMode = false;
            ResponseData responseData = new ResponseData();

            if (liveMode)
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Headers.Add("X-OCR-SECRET", SECRET_KEY);
                httpWebRequest.Method = "POST";

                RequestData requestData = new RequestData()
                {
                    version = "V2",
                    lang = "ko",
                    requestId = "",
                    timestamp = 0,
                    images = new Image[]
                    {
                    new Image()
                    {
                        name = "온도계",
                        format = "jpg",
                        data = Convert.ToBase64String(File.ReadAllBytes(imageFile))
                    }
                    }
                };

                using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string requestFile = JsonConvert.SerializeObject(requestData);
                    streamWriter.Write(requestFile);
                }


                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    string responseJson = streamReader.ReadToEnd();
                    File.WriteAllText(resultFile, responseJson);
                    responseData = JsonConvert.DeserializeObject<ResponseData>(responseJson);
                }

            }
            else
            {
                string responseJson = File.ReadAllText(resultFile);
                responseData = JsonConvert.DeserializeObject<ResponseData>(responseJson);
            }

            double? temperature = null;
            int? wetness = null;

            double x, y, width, height;
            x = y = width = height = -1;

            Field[] fields = responseData.images[0].fields;

            for (int i = 0; i < fields.Length; i++)
            {
                Vertice[] vertices = fields[i].boundingPoly.vertices;
                if (fields[i].inferText == "온도")
                {
                    x = vertices[0].x;
                    y = vertices[0].y;
                    width = vertices[2].x - x;
                    height = vertices[2].y - y;

                    break;
                }
            }

            if (x != -1)
            {
                for (int i = 0; i <fields.Length; i++)
                {
                    Vertice[] vertices = fields[i].boundingPoly.vertices;

                    if (vertices[0].x > x + width + 0 &&
                        vertices[0].x < x + width * 2 &&
                        vertices[0].y > y - height / 2 &&
                        vertices[0].y < y + height / 2)
                    {
                        string temp = fields[i].inferText;
                        temp = temp.Substring(0, 4);
                        Debug.WriteLine(temp);
                        temperature = double.Parse(temp);
                    }
                }
            }


            fields = responseData.images[0].fields;
            for (int i = 0; i < fields.Length; i++)
            {
                Vertice[] vertices = fields[i].boundingPoly.vertices;
                if (fields[i].inferText == "습도")
                {
                    x = vertices[0].x;
                    y = vertices[0].y;
                    width = vertices[2].x - x;
                    height = vertices[2].y - y;

                    break;
                }
            }

            if (x != -1)
            {
                for (int i = 0; i < fields.Length; i++)
                {
                    Vertice[] vertices = fields[i].boundingPoly.vertices;

                    if (vertices[0].x > x + width + 0 &&
                        vertices[0].x < x + width * 2 &&
                        vertices[0].y > y - height / 2 &&
                        vertices[0].y < y + height / 2)
                    {
                        string temp = fields[i].inferText;
                        temp = temp.Substring(0, 2);
                        Debug.WriteLine(temp);
                        wetness = int.Parse(temp);
                    }
                }
            }

            Console.WriteLine(temperature);
            Console.WriteLine(wetness);
        }
    }

    class RequestData
    {
        public string version;
        public string requestId;
        public string resultType;
        public int timestamp;
        public string lang;
        public Image[] images;
    }

    class Image
    {
        public string format;
        public string data;
        public string name;
    }

    class ResponseData
    {
        public string version;
        public string requestId;
        public long timestamp;
        public RecongnitionResult[] images;
    }

    class RecongnitionResult
    {
        public string uid;
        public string name;
        public string inferResult;
        public string message;
        public Field[] fields;
        public ValidationResult validationResult;
    }

    class Field
    { 
        public string name;
        public string valueType;
        public string inferText;
        public double inferConfidence;
        public BoundingPoly boundingPoly;
        public string type;
    }

    class BoundingPoly
    {
        public Vertice[] vertices;
    }

    class Vertice
    {
        public double x;
        public double y;
    }

    class ValidationResult
    {
        public string result;
        public string message;
    }
}
