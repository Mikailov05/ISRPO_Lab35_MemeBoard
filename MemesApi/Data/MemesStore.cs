using System.Linq.Expressions;
using MemesApi.Models;
namespace MemesApi.data;

public static class MemesStore {
    public static int NextId() => _nextId++;
    private static int _nextId = 4;
    public static List<Meme> Memes { get; } = new() {

        new Meme {
            Id = 1,
            Title = "Когда код сработал с первого раза",
            Category = "Программирование ",
            Ratting = 5,
            AddedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
        },
        new Meme {
            Id = 2,
            Title = "Я и дедлайн в 23:59",
            Category = "Учеба ",
            Ratting = 4,
            AddedAt = new DateTime(2026, 1, 2, 0, 0, 0, DateTimeKind.Utc)
        },
        new Meme {
            Id = 1,
            Title = "Когда код сработал с первого раза",
            Category = "Программирование ",
            Ratting = 5,
            AddedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
        },

    new Meme {
            Id = 3,
            Title = "Пятница после пар",
            Category = "жизнь ",
            Ratting = 5,
            AddedAt = new DateTime(2026, 1, 3, 0, 0, 0, DateTimeKind.Utc)
        },


    };

}