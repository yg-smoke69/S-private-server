using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026E1")]
internal class UIHudBanknoteLeaderboardItemController : UIBaseController
{
	[Token(Token = "0x400F030")]
	[FieldOffset(Offset = "0x28")]
	private UIHudControlLeaderboardItemView m_View;

	[Token(Token = "0x400F031")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<int, UILabel> m_Type2Label;

	[Token(Token = "0x400F032")]
	[FieldOffset(Offset = "0x30")]
	private LeaderboardData m_DataInfo;

	[Token(Token = "0x170011AA")]
	public LeaderboardData DataInfo
	{
		[Token(Token = "0x600EB81")]
		[Address(RVA = "0x1718104", Offset = "0x1718104", VA = "0x1718104")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600EB80")]
	[Address(RVA = "0x171804C", Offset = "0x171804C", VA = "0x171804C")]
	public UIHudBanknoteLeaderboardItemController()
	{
	}

	[Token(Token = "0x600EB82")]
	[Address(RVA = "0x171815C", Offset = "0x171815C", VA = "0x171815C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EB83")]
	[Address(RVA = "0x1718200", Offset = "0x1718200", VA = "0x1718200", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EB84")]
	[Address(RVA = "0x1717248", Offset = "0x1717248", VA = "0x1717248")]
	public void SetTypes(EMatchResultPlayerInfoType type1, EMatchResultPlayerInfoType type2, EMatchResultPlayerInfoType type3)
	{
	}

	[Token(Token = "0x600EB85")]
	[Address(RVA = "0x1718440", Offset = "0x1718440", VA = "0x1718440")]
	public void SetDetailData(EMatchResultPlayerInfoType type, string text)
	{
	}

	[Token(Token = "0x600EB86")]
	[Address(RVA = "0x17173E8", Offset = "0x17173E8", VA = "0x17173E8")]
	public void SetRankInfo(int rankLevel)
	{
	}

	[Token(Token = "0x600EB87")]
	[Address(RVA = "0x1717130", Offset = "0x1717130", VA = "0x1717130")]
	public void SetDataInfo(LeaderboardData dataInfo)
	{
	}

	[Token(Token = "0x600EB88")]
	[Address(RVA = "0x1718370", Offset = "0x1718370", VA = "0x1718370")]
	private void SetBackground(bool isLocalPlayer)
	{
	}

	[Token(Token = "0x600EB89")]
	[Address(RVA = "0x1717764", Offset = "0x1717764", VA = "0x1717764")]
	public void SetKillCount(int k)
	{
	}

	[Token(Token = "0x600EB8A")]
	[Address(RVA = "0x17179A8", Offset = "0x17179A8", VA = "0x17179A8")]
	public void SetDMG(int k)
	{
	}

	[Token(Token = "0x600EB8B")]
	[Address(RVA = "0x1718558", Offset = "0x1718558", VA = "0x1718558")]
	public void SetBuffCount(int d)
	{
	}

	[Token(Token = "0x600EB8C")]
	[Address(RVA = "0x17185E4", Offset = "0x17185E4", VA = "0x17185E4")]
	public void SetOnTimeZone(int a)
	{
	}

	[Token(Token = "0x600EB8D")]
	[Address(RVA = "0x1717D0C", Offset = "0x1717D0C", VA = "0x1717D0C")]
	public void SetCapePointCount(int a)
	{
	}

	[Token(Token = "0x600EB8E")]
	[Address(RVA = "0x1718750", Offset = "0x1718750", VA = "0x1718750")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
