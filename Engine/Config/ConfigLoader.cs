// File: Engine/Config/ConfigLoader.cs
using System;
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

public class ConfigLoader
{
    public static List<Entity> LoadEntities(string path)
    {
        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();

        var yaml = File.ReadAllText(path);
        var config = deserializer.Deserialize<Config>(yaml);

        var entities = new List<Entity>();
        foreach (var prototypePath in config.Entities)
        {
            var prototypeYaml = File.ReadAllText(prototypePath.Prototype);
            var entity = deserializer.Deserialize<Entity>(prototypeYaml);
            entities.Add(entity);
        }

        return entities;
    }
}

public class Config
{
    public List<EntityPrototype> Entities { get; set; }
}

public class EntityPrototype
{
    public string Prototype { get; set; }
}