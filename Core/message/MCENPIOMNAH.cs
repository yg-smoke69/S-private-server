using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001264")]
internal class MCENPIOMNAH : UDPClientMessageBase
{
	[Token(Token = "0x4008114")]
	[FieldOffset(Offset = "0xC")]
	public List<JBNPOIBIONB> HCEBGIMEOFA;

	[Token(Token = "0x6007776")]
	[Address(RVA = "0x343F7C0", Offset = "0x343F7C0", VA = "0x343F7C0")]
	public MCENPIOMNAH()
	{
	}

	[Token(Token = "0x6007777")]
	[Address(RVA = "0x343F844", Offset = "0x343F844", VA = "0x343F844", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x6007778")]
	[Address(RVA = "0x343FA34", Offset = "0x343FA34", VA = "0x343FA34", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x6007779")]
	[Address(RVA = "0x343FBF4", Offset = "0x343FBF4", VA = "0x343FBF4", Slot = "9")]
	public override void Recycle()
	{
	}
}
