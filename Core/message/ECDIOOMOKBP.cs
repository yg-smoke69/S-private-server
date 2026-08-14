using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001222")]
internal class ECDIOOMOKBP : UDPClientMessageBase
{
	[Token(Token = "0x4008089")]
	[FieldOffset(Offset = "0xC")]
	public List<BLOOMOKPODI> MMPMOEFEKHO;

	[Token(Token = "0x400808A")]
	[FieldOffset(Offset = "0x10")]
	public List<string> AHNAPOIIPPM;

	[Token(Token = "0x600766E")]
	[Address(RVA = "0x3625428", Offset = "0x3625428", VA = "0x3625428")]
	public ECDIOOMOKBP()
	{
	}

	[Token(Token = "0x600766F")]
	[Address(RVA = "0x36254AC", Offset = "0x36254AC", VA = "0x36254AC", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007670")]
	[Address(RVA = "0x36257FC", Offset = "0x36257FC", VA = "0x36257FC", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007671")]
	[Address(RVA = "0x3625A70", Offset = "0x3625A70", VA = "0x3625A70", Slot = "9")]
	public override void Recycle()
	{
	}
}
