namespace Program;

// Модель данных, представляющая заказ.
public record Order(int Id, int ClientId, string Description, decimal Amount, DateOnly DueDate);