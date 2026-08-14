using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DBA")]
internal class ClanBadgeInfoDataManager : SingletonModule<ClanBadgeInfoDataManager>
{
	[Token(Token = "0x40118B2")]
	[FieldOffset(Offset = "0xC")]
	private List<ClanBadgeInfoData> m_ClanBadgeInfoList;

	[Token(Token = "0x601323D")]
	[Address(RVA = "0x1726E04", Offset = "0x1726E04", VA = "0x1726E04")]
	public ClanBadgeInfoDataManager()
	{
	}

	[Token(Token = "0x601323E")]
	[Address(RVA = "0x1726E94", Offset = "0x1726E94", VA = "0x1726E94", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x601323F")]
	[Address(RVA = "0x1726EF4", Offset = "0x1726EF4", VA = "0x1726EF4")]
	private void ProcessInfo()
	{
	}

	[Token(Token = "0x6013240")]
	[Address(RVA = "0x172711C", Offset = "0x172711C", VA = "0x172711C", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
