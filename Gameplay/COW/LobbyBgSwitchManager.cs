using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000183")]
public class LobbyBgSwitchManager : SingletonModule<LobbyBgSwitchManager>
{
	[Token(Token = "0x2000184")]
	private sealed class _003CGetLobbyBgByRegion_003Ec__AnonStorey0
	{
		[Token(Token = "0x4000990")]
		[FieldOffset(Offset = "0x8")]
		internal string region;

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xECFE7C", Offset = "0xECFE7C", VA = "0xECFE7C")]
		public _003CGetLobbyBgByRegion_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xECFE84", Offset = "0xECFE84", VA = "0xECFE84")]
		internal bool _003C_003Em__0(LobbyBgSwitchData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400098E")]
	[FieldOffset(Offset = "0xC")]
	private List<LobbyBgSwitchData> m_Data;

	[Token(Token = "0x400098F")]
	[FieldOffset(Offset = "0x10")]
	private LobbyBgSwitchData m_DefaultData;

	[Token(Token = "0x60008B4")]
	[Address(RVA = "0xECF844", Offset = "0xECF844", VA = "0xECF844")]
	public LobbyBgSwitchManager()
	{
	}

	[Token(Token = "0x60008B5")]
	[Address(RVA = "0xECF908", Offset = "0xECF908", VA = "0xECF908", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60008B6")]
	[Address(RVA = "0xECFBE8", Offset = "0xECFBE8", VA = "0xECFBE8", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60008B7")]
	[Address(RVA = "0xECFCA8", Offset = "0xECFCA8", VA = "0xECFCA8")]
	public ResourceID GetLobbyBgByRegion(string region)
	{
		return default(ResourceID);
	}
}
