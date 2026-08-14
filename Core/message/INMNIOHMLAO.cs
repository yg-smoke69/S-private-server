using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x20010A1")]
internal class INMNIOHMLAO : UDPClientMessageBase
{
	[Token(Token = "0x4007D20")]
	[FieldOffset(Offset = "0xC")]
	public List<BJEEOEONJEB> NMAFMCKMKPP;

	[Token(Token = "0x6007069")]
	[Address(RVA = "0x361F7C0", Offset = "0x361F7C0", VA = "0x361F7C0")]
	public INMNIOHMLAO()
	{
	}

	[Token(Token = "0x600706A")]
	[Address(RVA = "0x361F844", Offset = "0x361F844", VA = "0x361F844", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x600706B")]
	[Address(RVA = "0x361FA34", Offset = "0x361FA34", VA = "0x361FA34", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x600706C")]
	[Address(RVA = "0x361FBF4", Offset = "0x361FBF4", VA = "0x361FBF4", Slot = "9")]
	public override void Recycle()
	{
	}
}
