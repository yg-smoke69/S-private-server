using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000EAD")]
internal class GAKECMGLDMH : UDPClientMessageBase
{
	[Token(Token = "0x40077F4")]
	[FieldOffset(Offset = "0xC")]
	public string GDDCLMCOALC;

	[Token(Token = "0x6006890")]
	[Address(RVA = "0x363AFD8", Offset = "0x363AFD8", VA = "0x363AFD8")]
	public GAKECMGLDMH()
	{
	}

	[Token(Token = "0x6006891")]
	[Address(RVA = "0x363B05C", Offset = "0x363B05C", VA = "0x363B05C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006892")]
	[Address(RVA = "0x363B094", Offset = "0x363B094", VA = "0x363B094", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006893")]
	[Address(RVA = "0x363B0B0", Offset = "0x363B0B0", VA = "0x363B0B0", Slot = "9")]
	public override void Recycle()
	{
	}
}
