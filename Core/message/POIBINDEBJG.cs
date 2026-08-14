using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000F84")]
internal class POIBINDEBJG : UDPClientMessageBase
{
	[Token(Token = "0x4007A67")]
	[FieldOffset(Offset = "0xC")]
	public uint PIAAFCGBIAA;

	[Token(Token = "0x4007A68")]
	[FieldOffset(Offset = "0x10")]
	public uint GAPBDHBOCBE;

	[Token(Token = "0x4007A69")]
	[FieldOffset(Offset = "0x14")]
	public uint BNMIJIJLBLD;

	[Token(Token = "0x6006BF4")]
	[Address(RVA = "0x3178D38", Offset = "0x3178D38", VA = "0x3178D38")]
	public POIBINDEBJG()
	{
	}

	[Token(Token = "0x6006BF5")]
	[Address(RVA = "0x3178DBC", Offset = "0x3178DBC", VA = "0x3178DBC", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006BF6")]
	[Address(RVA = "0x3178E74", Offset = "0x3178E74", VA = "0x3178E74", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006BF7")]
	[Address(RVA = "0x3178EBC", Offset = "0x3178EBC", VA = "0x3178EBC", Slot = "9")]
	public override void Recycle()
	{
	}
}
