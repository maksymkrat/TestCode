using System.Text.Json.Serialization;

namespace SerializeDeserialize;

public class ReceiptModel
{
    //[JsonPropertyName("items")]
    public IList<ReceiptItemModel> items { get; set; }
    //[JsonPropertyName("discount")]
    public int Discount { get; set;}
    //[JsonPropertyName("amount")]
    public float Amount { get; set;}
}