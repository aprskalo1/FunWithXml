using System.Runtime.Serialization;
using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;
using FunWithXml_API.Models;
using CsvHelper;
using System.Globalization;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Xml.XPath;

namespace FunWithXml_API.Services
{
    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract]
        public void CsvToXmlFile(string csvData);

        public BodyMeasurement SearchXmlFile(int age);
    }

    public class SoapService : ISoapService
    {
        private readonly string _xmlFilePath;

        public SoapService()
        {
            _xmlFilePath = "XmlFiles/BodyMeasurements.xml";
        }

        public void CsvToXmlFile(string csvData)
        {
            var bodyMeasurements = csvData.Split("\n").Select(line =>
            {
                var values = line.Split(",").Select(float.Parse).ToArray();
                return new BodyMeasurement
                {
                    bia_di = values[0],
                    bii_di = values[1],
                    bit_di = values[2],
                    che_de = values[3],
                    che_di = values[4],
                    elb_di = values[5],
                    wri_di = values[6],
                    kne_di = values[7],
                    ank_di = values[8],
                    sho_gi = values[9],
                    che_gi = values[10],
                    wai_gi = values[11],
                    nav_gi = values[12],
                    hip_gi = values[13],
                    thi_gi = values[14],
                    bic_gi = values[15],
                    for_gi = values[16],
                    kne_gi = values[17],
                    cal_gi = values[18],
                    ank_gi = values[19],
                    wri_gi = values[20],
                    age = (int)values[21],
                    wgt = values[22],
                    hgt = values[23]
                };
            }).ToList();

            var serializer = new XmlSerializer(typeof(List<BodyMeasurement>));
            using (var writer = XmlWriter.Create(_xmlFilePath))
            {
                serializer.Serialize(writer, bodyMeasurements);
            }

        }

        public BodyMeasurement SearchXmlFile(int age)
        {
            var xml = new XmlDocument();
            xml.Load(_xmlFilePath);

            XPathNavigator navigator = xml.CreateNavigator()!;

            XPathExpression expression = navigator.Compile($"//BodyMeasurement[age={age}]");

            XPathNodeIterator iterator = navigator.Select(expression);

            if (iterator.MoveNext())
            {
                XPathNavigator node = iterator.Current!;

                BodyMeasurement bodyMeasurement = new BodyMeasurement
                {
                    bia_di = float.Parse(node.SelectSingleNode("bia_di")!.Value),
                    bii_di = float.Parse(node.SelectSingleNode("bii_di")!.Value),
                    bit_di = float.Parse(node.SelectSingleNode("bit_di")!.Value),
                    che_de = float.Parse(node.SelectSingleNode("che_de")!.Value),
                    che_di = float.Parse(node.SelectSingleNode("che_di")!.Value),
                    elb_di = float.Parse(node.SelectSingleNode("elb_di")!.Value),
                    wri_di = float.Parse(node.SelectSingleNode("wri_di")!.Value),
                    kne_di = float.Parse(node.SelectSingleNode("kne_di")!.Value),
                    ank_di = float.Parse(node.SelectSingleNode("ank_di")!.Value),
                    sho_gi = float.Parse(node.SelectSingleNode("sho_gi")!.Value),
                    che_gi = float.Parse(node.SelectSingleNode("che_gi")!.Value),
                    wai_gi = float.Parse(node.SelectSingleNode("wai_gi")!.Value),
                    nav_gi = float.Parse(node.SelectSingleNode("nav_gi")!.Value),
                    hip_gi = float.Parse(node.SelectSingleNode("hip_gi")!.Value),
                    thi_gi = float.Parse(node.SelectSingleNode("thi_gi")!.Value),
                    bic_gi = float.Parse(node.SelectSingleNode("bic_gi")!.Value),
                    for_gi = float.Parse(node.SelectSingleNode("for_gi")!.Value),
                    kne_gi = float.Parse(node.SelectSingleNode("kne_gi")!.Value),
                    cal_gi = float.Parse(node.SelectSingleNode("cal_gi")!.Value),
                    ank_gi = float.Parse(node.SelectSingleNode("ank_gi")!.Value),
                    wri_gi = float.Parse(node.SelectSingleNode("wri_gi")!.Value),
                    age = int.Parse(node.SelectSingleNode("age")!.Value),
                    wgt = float.Parse(node.SelectSingleNode("wgt")!.Value),
                    hgt = float.Parse(node.SelectSingleNode("hgt")!.Value),
                    sex = int.Parse(node.SelectSingleNode("sex")!.Value)
                };

                return bodyMeasurement;
            }
            else
            {
                throw new Exception("Body Measurement not found");
            }
        }
    }
}
