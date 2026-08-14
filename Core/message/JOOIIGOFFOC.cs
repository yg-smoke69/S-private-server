using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000ED0")]
internal class JOOIIGOFFOC : UDPClientMessageBase
{
	[Token(Token = "0x4007874")]
	[FieldOffset(Offset = "0xA")]
	public ushort ELLLMKJCGCD;

	[Token(Token = "0x600691D")]
	[Address(RVA = "0x36839D8", Offset = "0x36839D8", VA = "0x36839D8")]
	public JOOIIGOFFOC()
	{
	}

	[Token(Token = "0x600691E")]
	[Address(RVA = "0x3683A5C", Offset = "0x3683A5C", VA = "0x3683A5C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600691F")]
	[Address(RVA = "0x3683AB8", Offset = "0x3683AB8", VA = "0x3683AB8", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006920")]
	[Address(RVA = "0x3683AD4", Offset = "0x3683AD4", VA = "0x3683AD4", Slot = "9")]
	public override void Recycle()
	{
	}

	[Token(Token = "0x6006921")]
	[Address(RVA = "0x3683AD8", Offset = "0x3683AD8", VA = "0x3683AD8", Slot = "8")]
	public override bool CanCache()
	{
		return default(bool);
	}
}
