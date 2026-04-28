using Microsoft.AspNetCore.SignalR;

namespace MemesApi.Models;

public class Meme {
    
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;

    public int Ratting { get; set; } = 1;

    public DateTime AddedAt { get; set; } = DateTime.UtcNow;
}


