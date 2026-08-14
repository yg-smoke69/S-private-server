using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000EC4")]
internal class HDEAGPDGKIH : UDPClientMessageBase
{
	[Token(Token = "0x400785C")]
	[FieldOffset(Offset = "0xC")]
	public List<AADOBBJPEMN> HJPPMGNANLC;

	[Token(Token = "0x60068EC")]
	[Address(RVA = "0x360C784", Offset = "0x360C784", VA = "0x360C784")]
	public HDEAGPDGKIH()
	{
	}

	[Token(Token = "0x60068ED")]
	[Address(RVA = "0x360C808", Offset = "0x360C808", VA = "0x360C808", Slot = "6")]
	public override void Serialize(FastBinaryWriter NNPGNFBKEMM)
	{
	}

	[Token(Token = "0x60068EE")]
	[Address(RVA = "0x360C9F8", Offset = "0x360C9F8", VA = "0x360C9F8", Slot = "7")]
	public override void UnSerialize(FastBinaryReader JBJHPGPCKFA)
	{
	}

	[Token(Token = "0x60068EF")]
	[Address(RVA = "0x360CBB8", Offset = "0x360CBB8", VA = "0x360CBB8", Slot = "9")]
	public override void Recycle()
	{
	}
}
