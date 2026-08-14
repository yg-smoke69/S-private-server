using COW.Gameplay.UGC.BlockEdit;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2000C1E")]
public class BEEnumData
{
	[Token(Token = "0x4006470")]
	[FieldOffset(Offset = "0x8")]
	public string LabelKey;

	[Token(Token = "0x4006471")]
	[FieldOffset(Offset = "0xC")]
	public IOGCEGJJHLK ValueType;

	[Token(Token = "0x4006472")]
	[FieldOffset(Offset = "0x10")]
	public string StringValue;

	[Token(Token = "0x4006473")]
	[FieldOffset(Offset = "0x14")]
	public int IntValue;

	[Token(Token = "0x4006474")]
	[FieldOffset(Offset = "0x18")]
	public bool BoolValue;

	[Token(Token = "0x6005CA1")]
	[Address(RVA = "0x2E4B5C8", Offset = "0x2E4B5C8", VA = "0x2E4B5C8")]
	public BEEnumData()
	{
	}

	[Token(Token = "0x6005CA2")]
	[Address(RVA = "0x2E4B5D0", Offset = "0x2E4B5D0", VA = "0x2E4B5D0")]
	public static IOGCEGJJHLK GetIntBoolStringType(IOGCEGJJHLK valueType)
	{
		return default(IOGCEGJJHLK);
	}

	[Token(Token = "0x6005CA3")]
	[Address(RVA = "0x2E4B67C", Offset = "0x2E4B67C", VA = "0x2E4B67C")]
	public bool IsEqual(ValueData valueData)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CA4")]
	[Address(RVA = "0x2E4B81C", Offset = "0x2E4B81C", VA = "0x2E4B81C", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CA5")]
	[Address(RVA = "0x2E4B9AC", Offset = "0x2E4B9AC", VA = "0x2E4B9AC")]
	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return default(bool);
	}
}
