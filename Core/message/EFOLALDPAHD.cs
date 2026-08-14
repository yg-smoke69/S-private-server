using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000ED5")]
internal class EFOLALDPAHD : UDPClientMessageBase
{
	[Token(Token = "0x400787F")]
	[FieldOffset(Offset = "0xC")]
	public List<KCNKCFAMFGO> MNMDNLOIPCF;

	[Token(Token = "0x4007880")]
	[FieldOffset(Offset = "0x10")]
	public bool CIILMLJIDBJ;

	[Token(Token = "0x4007881")]
	[FieldOffset(Offset = "0x14")]
	public uint CEDJCPLOLNE;

	[Token(Token = "0x6006933")]
	[Address(RVA = "0x3628A18", Offset = "0x3628A18", VA = "0x3628A18")]
	public EFOLALDPAHD()
	{
	}

	[Token(Token = "0x6006934")]
	[Address(RVA = "0x3628A9C", Offset = "0x3628A9C", VA = "0x3628A9C", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6006935")]
	[Address(RVA = "0x3628CF8", Offset = "0x3628CF8", VA = "0x3628CF8", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6006936")]
	[Address(RVA = "0x3628EE4", Offset = "0x3628EE4", VA = "0x3628EE4", Slot = "9")]
	public override void Recycle()
	{
	}

	[Token(Token = "0x6006937")]
	[Address(RVA = "0x362902C", Offset = "0x362902C", VA = "0x362902C", Slot = "8")]
	public override bool CanCache()
	{
		return default(bool);
	}
}
