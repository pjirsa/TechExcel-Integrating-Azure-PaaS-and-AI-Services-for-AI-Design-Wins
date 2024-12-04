using System.Text.Json.Serialization;

public class MaintenanceRequest
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
        [JsonPropertyName("hotel_id")]
        public int HotelId {get;set;}
        
        [JsonPropertyName("hotel")]
        public string Hotel { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("details")]
        public string Details { get; set; }
        
        [JsonPropertyName("room_number")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? RoomNumber { get; set; }

        [JsonPropertyName("room_numbers_checked")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RoomNumbersChecked { get; set; }
        
        [JsonPropertyName("meeting_room")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MeetingRoom { get; set; }
        
        [JsonPropertyName("location")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Location { get; set; }

        [JsonPropertyName("request_vector")]
        public float[]? RequestVector { get; set; }
    }