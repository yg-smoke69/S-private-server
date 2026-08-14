using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001246")]
internal class EKBIOEEAMAK : UDPClientMessageBase
{
	[Token(Token = "0x40080DA")]
	[FieldOffset(Offset = "0x10")]
	public ulong MIJOCMKONAD;

	[Token(Token = "0x40080DB")]
	[FieldOffset(Offset = "0x18")]
	public uint IHAAMHPPLMG;

	[Token(Token = "0x40080DC")]
	[FieldOffset(Offset = "0x1C")]
	public string GCJBNAHBGMD;

	[Token(Token = "0x60076FE")]
	[Address(RVA = "0x362B3D0", Offset = "0x362B3D0", VA = "0x362B3D0")]
	public EKBIOEEAMAK()
	{
	}

	[Token(Token = "0x60076FF")]
	[Address(RVA = "0x362B454", Offset = "0x362B454", VA = "0x362B454", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007700")]
	[Address(RVA = "0x362B508", Offset = "0x362B508", VA = "0x362B508", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007701")]
	[Address(RVA = "0x362B550", Offset = "0x362B550", VA = "0x362B550", Slot = "9")]
	public override void Recycle()
	{
	}
}
