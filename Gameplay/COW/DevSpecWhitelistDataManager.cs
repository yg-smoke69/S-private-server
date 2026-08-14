using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001DD9")]
public class DevSpecWhitelistDataManager : SingletonModule<DevSpecWhitelistDataManager>
{
	[Token(Token = "0x400BD0B")]
	[FieldOffset(Offset = "0xC")]
	private DevSpecWhitelistData m_matchingDevSpecWhitelistData;

	[Token(Token = "0x400BD0C")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<DevSpecWhitelistData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17000F0B")]
	public DevSpecWhitelistData MatchingDevSpecWhitelistData
	{
		[Token(Token = "0x6008E96")]
		[Address(RVA = "0x1C90B4C", Offset = "0x1C90B4C", VA = "0x1C90B4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008E95")]
	[Address(RVA = "0x1C90ABC", Offset = "0x1C90ABC", VA = "0x1C90ABC")]
	public DevSpecWhitelistDataManager()
	{
	}

	[Token(Token = "0x6008E97")]
	[Address(RVA = "0x1C90BA4", Offset = "0x1C90BA4", VA = "0x1C90BA4", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6008E98")]
	[Address(RVA = "0x1C91C24", Offset = "0x1C91C24", VA = "0x1C91C24", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6008E99")]
	[Address(RVA = "0x1C91C80", Offset = "0x1C91C80", VA = "0x1C91C80")]
	private static int _003COnInit_003Em__0(DevSpecWhitelistData a, DevSpecWhitelistData b)
	{
		return default(int);
	}
}
