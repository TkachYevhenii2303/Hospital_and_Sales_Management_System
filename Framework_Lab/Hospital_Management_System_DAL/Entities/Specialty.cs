using System.Text.Json.Serialization;

namespace Labs_EF.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Specialty
    {
        Base_Surgery = 0,

        Anesthesiology = 1,

        Dermatology = 2,
        
        Neurosurgery = 3,
        
        Urology = 4,
        
        Thoracic_Surgery = 5,
    }
}
