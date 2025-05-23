using System.Text.Json.Serialization;
namespace DeskToys.Core.Models;

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(string))]
[JsonSerializable(typeof(bool))]
[JsonSerializable(typeof(ushort[]))]
public partial class JsonContext : JsonSerializerContext
{
}