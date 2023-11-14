using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class JSONStorage : BaseClass
{
    private Dictionary<string, BaseClass> objects = new Dictionary<string, BaseClass>();

    public Dictionary<string, BaseClass> All()
    {
        return objects;
    }

    public void New(BaseClass obj)
    {
        objects[$"{obj.GetType().Name}.{obj.id}"] = obj;
    }

    public void Save()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        string jsonString = JsonSerializer.Serialize(objects, options);
        Directory.CreateDirectory("storage");
        File.WriteAllText(_filePath, jsonString);
    }

    public void Load()
    {
        if (File.Exists(_filePath))
        {
            string jsonString = File.ReadAllText(_filePath);
            objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(jsonString);
        }
    }
}