﻿/*
 * Author: Gbb Software 2002
 */

using System.Text;

namespace TestKSeF;

public class Configuration
{

    public List<ConfigurationLine> Lines= new();


    public void SaveToXML(System.Xml.XmlWriter x)
    {
        x.WriteStartElement("Config");
        foreach (var itm in Lines)
            itm.SaveToXML(x);
        x.WriteEndElement();
    }

    public void SaveConfig(string FileName)
    {
        var par = new System.Xml.XmlWriterSettings
        {
            Indent = true
        };
        using var x = System.Xml.XmlWriter.Create(FileName, par);
        x.WriteStartDocument();
        SaveToXML(x);
        x.WriteEndDocument();
        x.Close();
    }

    public static Configuration LoadFromXML(System.Xml.XmlReader x)
    {
        var ret = new Configuration();

        if (x.IsEmptyElement) return ret;

        x.ReadStartElement();
        while (x.NodeType != System.Xml.XmlNodeType.EndElement)
        {
            if (x.NodeType == System.Xml.XmlNodeType.Element)
                switch (x.Name)
                {
                    case "Line":
                        ret.Lines.Add(ConfigurationLine.LoadFromXML(x));
                        break;
                }

            x.Skip();
        }
        x.ReadEndElement();


        return ret;
    }

    public static Configuration LoadConfig(string FileName)
    {
        Configuration ret;

        if (File.Exists(FileName))
        {
            using var x = System.Xml.XmlReader.Create(FileName);
            x.MoveToContent();
            ret = LoadFromXML(x);
            x.Close();
        }
        else
            ret = new Configuration();
        return ret;
    }


}

public class ConfigurationLine
{
    public string Name { get; set; } = "";
    public string URL { get; set; } = "";
    public string Token { get; set; } = "";
    public string NIP { get; set; } = "";
    public string PublicKey { get; set; } = "";

    public string OurFullName { get { return ToString(); } }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(Name);
        sb.Append(": ");
        sb.Append(NIP);
        sb.Append(" ");
        sb.Append(URL);
        //sb.Append(" - ");
        //sb.Append(Token);
        return sb.ToString();
    }


    public void SaveToXML(System.Xml.XmlWriter x)
    {
        x.WriteStartElement("Line");
        {
            x.WriteAttributeString("Name", Name);
            if (!string.IsNullOrEmpty(URL)) x.WriteAttributeString("URL", URL);
            if (!string.IsNullOrEmpty(Token)) x.WriteAttributeString("Token", Token);
            if (!string.IsNullOrEmpty(NIP)) x.WriteAttributeString("NIP", NIP);
            if (!string.IsNullOrEmpty(PublicKey)) x.WriteAttributeString("PublicKey", PublicKey);
        }
        x.WriteEndElement();
    }

    public static ConfigurationLine LoadFromXML(System.Xml.XmlReader x)
    {
        var ret = new ConfigurationLine
        {
            Name = x.GetAttribute("Name") ?? "",
            URL = x.GetAttribute("URL") ?? "",
            Token = x.GetAttribute("Token") ?? "",
            NIP = x.GetAttribute("NIP") ?? "",
            PublicKey = x.GetAttribute("PublicKey") ?? ""
        };

        return ret;
    }
}