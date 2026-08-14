using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2002E8A")]
public class ActivityClientInfo
{
	[Token(Token = "0x4011C3A")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x4011C3B")]
	[FieldOffset(Offset = "0xC")]
	public uint data;

	[Token(Token = "0x4011C3C")]
	[FieldOffset(Offset = "0x10")]
	public proto.EActivity.State state;

	[Token(Token = "0x60136BE")]
	[Address(RVA = "0x14BE31C", Offset = "0x14BE31C", VA = "0x14BE31C")]
	public ActivityClientInfo()
	{
	}

	[Token(Token = "0x60136BF")]
	[Address(RVA = "0x14BE324", Offset = "0x14BE324", VA = "0x14BE324")]
	public static implicit operator ActivityClientInfo(ActivityInfo activity)
	{
		return null;
	}

	[Token(Token = "0x60136C0")]
	[Address(RVA = "0x14BE440", Offset = "0x14BE440", VA = "0x14BE440")]
	public static implicit operator ActivityClientInfo(ActivityUpdateInfo activityUpdate)
	{
		return null;
	}
}
