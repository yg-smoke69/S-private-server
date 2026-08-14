using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200311F")]
public class AdItemInfo
{
	[Token(Token = "0x4012AC6")]
	[FieldOffset(Offset = "0x8")]
	public AdvertDesc Desc;

	[Token(Token = "0x6014987")]
	[Address(RVA = "0x14C22A0", Offset = "0x14C22A0", VA = "0x14C22A0")]
	public AdItemInfo()
	{
	}

	[Token(Token = "0x6014988")]
	[Address(RVA = "0x14C231C", Offset = "0x14C231C", VA = "0x14C231C")]
	public AdItemInfo(AdvertDesc desc)
	{
	}
}
