using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002712")]
internal class UIHudControlLeaderboardItemController : UIBaseController
{
	[Token(Token = "0x400F119")]
	[FieldOffset(Offset = "0x28")]
	private UIHudControlLeaderboardItemView m_View;

	[Token(Token = "0x400F11A")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<int, UILabel> m_Type2Label;

	[Token(Token = "0x400F11B")]
	[FieldOffset(Offset = "0x30")]
	private LeaderboardData m_DataInfo;

	[Token(Token = "0x170011B4")]
	public LeaderboardData DataInfo
	{
		[Token(Token = "0x600ED6B")]
		[Address(RVA = "0x1361800", Offset = "0x1361800", VA = "0x1361800")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600ED6A")]
	[Address(RVA = "0x1361748", Offset = "0x1361748", VA = "0x1361748")]
	public UIHudControlLeaderboardItemController()
	{
	}

	[Token(Token = "0x600ED6C")]
	[Address(RVA = "0x1361858", Offset = "0x1361858", VA = "0x1361858")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ED6D")]
	[Address(RVA = "0x13618FC", Offset = "0x13618FC", VA = "0x13618FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ED6E")]
	[Address(RVA = "0x1361C54", Offset = "0x1361C54", VA = "0x1361C54")]
	public void SetTypes(EMatchResultPlayerInfoType type1, EMatchResultPlayerInfoType type2, EMatchResultPlayerInfoType type3)
	{
	}

	[Token(Token = "0x600ED6F")]
	[Address(RVA = "0x1361B3C", Offset = "0x1361B3C", VA = "0x1361B3C")]
	public void SetDetailData(EMatchResultPlayerInfoType type, string text)
	{
	}

	[Token(Token = "0x600ED70")]
	[Address(RVA = "0x1361DF4", Offset = "0x1361DF4", VA = "0x1361DF4")]
	public void SetRankInfo(int rankLevel)
	{
	}

	[Token(Token = "0x600ED71")]
	[Address(RVA = "0x1361FD0", Offset = "0x1361FD0", VA = "0x1361FD0")]
	public void SetDataInfo(LeaderboardData dataInfo)
	{
	}

	[Token(Token = "0x600ED72")]
	[Address(RVA = "0x1361A6C", Offset = "0x1361A6C", VA = "0x1361A6C")]
	private void SetBackground(bool isLocalPlayer)
	{
	}

	[Token(Token = "0x600ED73")]
	[Address(RVA = "0x13620E8", Offset = "0x13620E8", VA = "0x13620E8")]
	public void SetKillCount(int k)
	{
	}

	[Token(Token = "0x600ED74")]
	[Address(RVA = "0x136218C", Offset = "0x136218C", VA = "0x136218C")]
	public void SetDMG(int k)
	{
	}

	[Token(Token = "0x600ED75")]
	[Address(RVA = "0x1362230", Offset = "0x1362230", VA = "0x1362230")]
	public void SetBuffCount(int d)
	{
	}

	[Token(Token = "0x600ED76")]
	[Address(RVA = "0x13622BC", Offset = "0x13622BC", VA = "0x13622BC")]
	public void SetOnTimeZone(int a)
	{
	}

	[Token(Token = "0x600ED77")]
	[Address(RVA = "0x1362428", Offset = "0x1362428", VA = "0x1362428")]
	public void SetCapePointCount(int a)
	{
	}

	[Token(Token = "0x600ED78")]
	[Address(RVA = "0x13624CC", Offset = "0x13624CC", VA = "0x13624CC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
