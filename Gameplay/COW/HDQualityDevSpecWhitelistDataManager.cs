using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200014F")]
public class HDQualityDevSpecWhitelistDataManager : SingletonModule<HDQualityDevSpecWhitelistDataManager>
{
	[Token(Token = "0x4000873")]
	[FieldOffset(Offset = "0xC")]
	private HDQualityDevSpecWhitelistData m_matchingDevSpecWhitelistData;

	[Token(Token = "0x4000874")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<HDQualityDevSpecWhitelistData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17000129")]
	public HDQualityDevSpecWhitelistData MatchingDevSpecWhitelistData
	{
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x1211E6C", Offset = "0x1211E6C", VA = "0x1211E6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x1211DDC", Offset = "0x1211DDC", VA = "0x1211DDC")]
	public HDQualityDevSpecWhitelistDataManager()
	{
	}

	[Token(Token = "0x60007DB")]
	[Address(RVA = "0x1211EC4", Offset = "0x1211EC4", VA = "0x1211EC4", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60007DC")]
	[Address(RVA = "0x1212BC0", Offset = "0x1212BC0", VA = "0x1212BC0", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60007DD")]
	[Address(RVA = "0x1212C1C", Offset = "0x1212C1C", VA = "0x1212C1C")]
	private static int _003COnInit_003Em__0(HDQualityDevSpecWhitelistData a, HDQualityDevSpecWhitelistData b)
	{
		return default(int);
	}
}
