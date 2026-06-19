/// <summary>
/// DTO для элемента заказа.
/// </summary>
public class OrderItemDto
{
    /// <summary>Идентификатор блюда.</summary>
    public int dishId { get; set; }
    /// <summary>Количество порций.</summary>
    public int count { get; set; }
}

/// <summary>
/// DTO для создания заказа.
/// </summary>
public class CreateOrderDto
{
    /// <summary>Адрес доставки.</summary>
    public string address { get; set; }
    /// <summary>Дата и время доставки.</summary>
    public string date { get; set; }
    /// <summary>Список заказываемых блюд.</summary>
    public List<OrderItemDto> dishes { get; set; }
}