using Il2CppDummyDll;
using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B88")]
public class CanvasData
{
	[Token(Token = "0x400619D")]
	[FieldOffset(Offset = "0x8")]
	public float positionX;

	[Token(Token = "0x400619E")]
	[FieldOffset(Offset = "0xC")]
	public float positionY;

	[Token(Token = "0x400619F")]
	[FieldOffset(Offset = "0x10")]
	public float scale;

	[Token(Token = "0x6005798")]
	[Address(RVA = "0x37BD6F4", Offset = "0x37BD6F4", VA = "0x37BD6F4")]
	public CanvasData()
	{
	}

	[Token(Token = "0x6005799")]
	[Address(RVA = "0x37BD704", Offset = "0x37BD704", VA = "0x37BD704")]
	public bool FromJsonData(JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x600579A")]
	[Address(RVA = "0x37BD85C", Offset = "0x37BD85C", VA = "0x37BD85C")]
	public bool ToJsonData(JsonWriter jsonWriter)
	{
		return default(bool);
	}

	[Token(Token = "0x600579B")]
	[Address(RVA = "0x37BDA3C", Offset = "0x37BDA3C", VA = "0x37BDA3C")]
	public CanvasData Clone()
	{
		return null;
	}
}
