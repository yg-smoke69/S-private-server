using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x200110D")]
internal class EIECFAACIMN : UDPClientMessageBase
{
	[Token(Token = "0x4007E14")]
	[FieldOffset(Offset = "0xC")]
	public uint IHAAMHPPLMG;

	[Token(Token = "0x4007E15")]
	[FieldOffset(Offset = "0x10")]
	public int AJENCIHMPBE;

	[Token(Token = "0x4007E16")]
	[FieldOffset(Offset = "0x14")]
	public int HMBPELFIEAC;

	[Token(Token = "0x600721A")]
	[Address(RVA = "0x362AD40", Offset = "0x362AD40", VA = "0x362AD40")]
	public EIECFAACIMN()
	{
	}

	[Token(Token = "0x600721B")]
	[Address(RVA = "0x362ADC4", Offset = "0x362ADC4", VA = "0x362ADC4", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600721C")]
	[Address(RVA = "0x362AE7C", Offset = "0x362AE7C", VA = "0x362AE7C", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x600721D")]
	[Address(RVA = "0x362AEC4", Offset = "0x362AEC4", VA = "0x362AEC4", Slot = "9")]
	public override void Recycle()
	{
	}
}
