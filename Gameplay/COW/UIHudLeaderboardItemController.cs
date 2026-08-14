using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002053")]
internal class UIHudLeaderboardItemController : UIBaseController
{
	[Token(Token = "0x400CAA3")]
	[FieldOffset(Offset = "0x28")]
	private UIHudLeaderboardItemView m_View;

	[Token(Token = "0x400CAA4")]
	[FieldOffset(Offset = "0x2C")]
	private LeaderboardData m_DataInfo;

	[Token(Token = "0x17000FDA")]
	public LeaderboardData DataInfo
	{
		[Token(Token = "0x600A4F0")]
		[Address(RVA = "0xFEBCA8", Offset = "0xFEBCA8", VA = "0xFEBCA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A4EF")]
	[Address(RVA = "0xFEBD18", Offset = "0xFEBD18", VA = "0xFEBD18")]
	public UIHudLeaderboardItemController()
	{
	}

	[Token(Token = "0x600A4F1")]
	[Address(RVA = "0xFEBD9C", Offset = "0xFEBD9C", VA = "0xFEBD9C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A4F2")]
	[Address(RVA = "0xFEBE40", Offset = "0xFEBE40", VA = "0xFEBE40", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A4F3")]
	[Address(RVA = "0xFEA7DC", Offset = "0xFEA7DC", VA = "0xFEA7DC")]
	public void SetRankInfo(int rankLevel, int peakRankPos)
	{
	}

	[Token(Token = "0x600A4F4")]
	[Address(RVA = "0xFEA9F0", Offset = "0xFEA9F0", VA = "0xFEA9F0")]
	public void SetRole(uint role)
	{
	}

	[Token(Token = "0x600A4F5")]
	[Address(RVA = "0xFEC068", Offset = "0xFEC068", VA = "0xFEC068")]
	private void UpdateHeadIcon()
	{
	}

	[Token(Token = "0x600A4F6")]
	[Address(RVA = "0xFEA6C4", Offset = "0xFEA6C4", VA = "0xFEA6C4")]
	public void SetDataInfo(LeaderboardData dataInfo)
	{
	}

	[Token(Token = "0x600A4F7")]
	[Address(RVA = "0xFEBF98", Offset = "0xFEBF98", VA = "0xFEBF98")]
	private void SetBackground(bool isLocalPlayer)
	{
	}

	[Token(Token = "0x600A4F8")]
	[Address(RVA = "0xFEAEF0", Offset = "0xFEAEF0", VA = "0xFEAEF0")]
	public void SetKillCount(int k)
	{
	}

	[Token(Token = "0x600A4F9")]
	[Address(RVA = "0xFEB170", Offset = "0xFEB170", VA = "0xFEB170")]
	public void SetDeadCount(int d)
	{
	}

	[Token(Token = "0x600A4FA")]
	[Address(RVA = "0xFEB3F0", Offset = "0xFEB3F0", VA = "0xFEB3F0")]
	public void SetAssistCount(int a)
	{
	}

	[Token(Token = "0x600A4FB")]
	[Address(RVA = "0xFEB670", Offset = "0xFEB670", VA = "0xFEB670")]
	public void SetTotalDamage(int dmg)
	{
	}

	[Token(Token = "0x600A4FC")]
	[Address(RVA = "0xFEC230", Offset = "0xFEC230", VA = "0xFEC230")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
