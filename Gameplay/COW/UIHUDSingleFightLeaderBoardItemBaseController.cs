using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200284B")]
internal class UIHUDSingleFightLeaderBoardItemBaseController : UIBaseController
{
	[Token(Token = "0x400F894")]
	[FieldOffset(Offset = "0x28")]
	protected UIHudSingleFightLeaderBoardItemView m_View;

	[Token(Token = "0x400F895")]
	[FieldOffset(Offset = "0x2C")]
	protected Player m_Player;

	[Token(Token = "0x400F896")]
	[FieldOffset(Offset = "0x30")]
	private List<int> m_InfoTypeList;

	[Token(Token = "0x400F897")]
	[FieldOffset(Offset = "0x34")]
	private List<UILabel> m_InfoLabelList;

	[Token(Token = "0x400F898")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<int, LeaderBoardSortingData> m_SortingDataDict;

	[Token(Token = "0x400F899")]
	[FieldOffset(Offset = "0x3C")]
	private List<LeaderBoardSortingData> m_SortingDatas;

	[Token(Token = "0x400F89A")]
	[FieldOffset(Offset = "0x40")]
	private bool m_Reported;

	[Token(Token = "0x400F89B")]
	[FieldOffset(Offset = "0x44")]
	private uint m_Rank;

	[Token(Token = "0x170011F5")]
	public List<LeaderBoardSortingData> SortingDatas
	{
		[Token(Token = "0x600FBAD")]
		[Address(RVA = "0x2214E10", Offset = "0x2214E10", VA = "0x2214E10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600FBAC")]
	[Address(RVA = "0x2214CB4", Offset = "0x2214CB4", VA = "0x2214CB4")]
	public UIHUDSingleFightLeaderBoardItemBaseController()
	{
	}

	[Token(Token = "0x600FBAE")]
	[Address(RVA = "0x2214E68", Offset = "0x2214E68", VA = "0x2214E68")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FBAF")]
	[Address(RVA = "0x2214F10", Offset = "0x2214F10", VA = "0x2214F10", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FBB0")]
	[Address(RVA = "0x22150F8", Offset = "0x22150F8", VA = "0x22150F8")]
	public void InitData(List<int> list, Player player, bool isLocalSelf, List<LeaderBoardSortingData> sortingDatas)
	{
	}

	[Token(Token = "0x600FBB1")]
	[Address(RVA = "0x2215984", Offset = "0x2215984", VA = "0x2215984", Slot = "31")]
	protected virtual void SetInfoLabelList()
	{
	}

	[Token(Token = "0x600FBB2")]
	[Address(RVA = "0x2215B48", Offset = "0x2215B48", VA = "0x2215B48", Slot = "32")]
	public virtual void RefreshPlayerProfile(bool isLocalSelf)
	{
	}

	[Token(Token = "0x600FBB3")]
	[Address(RVA = "0x22164CC", Offset = "0x22164CC", VA = "0x22164CC", Slot = "33")]
	protected virtual void OnInitData(Player player)
	{
	}

	[Token(Token = "0x600FBB4")]
	[Address(RVA = "0x2216528", Offset = "0x2216528", VA = "0x2216528", Slot = "34")]
	protected virtual bool ShowDeadBg()
	{
		return default(bool);
	}

	[Token(Token = "0x600FBB5")]
	[Address(RVA = "0x2216580", Offset = "0x2216580", VA = "0x2216580", Slot = "35")]
	protected virtual bool ShowTop3Icon()
	{
		return default(bool);
	}

	[Token(Token = "0x600FBB6")]
	[Address(RVA = "0x22165D8", Offset = "0x22165D8", VA = "0x22165D8", Slot = "36")]
	public virtual void SetRank(uint rank)
	{
	}

	[Token(Token = "0x600FBB7")]
	[Address(RVA = "0x2216954", Offset = "0x2216954", VA = "0x2216954")]
	protected void OnReportBtnClick()
	{
	}

	[Token(Token = "0x600FBB8")]
	[Address(RVA = "0x2216D20", Offset = "0x2216D20", VA = "0x2216D20")]
	private void OnReportCheatSent(object[] param)
	{
	}

	[Token(Token = "0x600FBB9")]
	[Address(RVA = "0x2216E9C", Offset = "0x2216E9C", VA = "0x2216E9C")]
	private void OnPlayerAliveStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600FBBA")]
	[Address(RVA = "0x22158F4", Offset = "0x22158F4", VA = "0x22158F4")]
	public void ShowSelf(bool isShow)
	{
	}

	[Token(Token = "0x600FBBB")]
	[Address(RVA = "0x221708C", Offset = "0x221708C", VA = "0x221708C")]
	public IHAAMHPPLMG GetPlayerID()
	{
		return default(IHAAMHPPLMG);
	}

	[Token(Token = "0x600FBBC")]
	[Address(RVA = "0x2215200", Offset = "0x2215200", VA = "0x2215200")]
	private void SetPlayer(Player player)
	{
	}

	[Token(Token = "0x600FBBD")]
	[Address(RVA = "0x22171E8", Offset = "0x22171E8", VA = "0x22171E8")]
	public uint GetRank()
	{
		return default(uint);
	}

	[Token(Token = "0x600FBBE")]
	[Address(RVA = "0x2217240", Offset = "0x2217240", VA = "0x2217240")]
	public void ShowReportButton(bool show)
	{
	}

	[Token(Token = "0x600FBBF")]
	[Address(RVA = "0x2215260", Offset = "0x2215260", VA = "0x2215260")]
	private void SetInfoTypeList(List<int> list)
	{
	}

	[Token(Token = "0x600FBC0")]
	[Address(RVA = "0x22152C0", Offset = "0x22152C0", VA = "0x22152C0")]
	private void SetSortingDatas(List<LeaderBoardSortingData> sortingDatas)
	{
	}

	[Token(Token = "0x600FBC1")]
	[Address(RVA = "0x221627C", Offset = "0x221627C", VA = "0x221627C")]
	private void SetIsSelf(bool isSelf)
	{
	}

	[Token(Token = "0x600FBC2")]
	[Address(RVA = "0x2216314", Offset = "0x2216314", VA = "0x2216314")]
	private void SetDeadBG()
	{
	}

	[Token(Token = "0x600FBC3")]
	[Address(RVA = "0x2215588", Offset = "0x2215588", VA = "0x2215588")]
	public void RefreshPlayerStats()
	{
	}

	[Token(Token = "0x600FBC4")]
	[Address(RVA = "0x2217410", Offset = "0x2217410", VA = "0x2217410")]
	private void RefreshInfoLabels()
	{
	}

	[Token(Token = "0x600FBC5")]
	[Address(RVA = "0x22176C4", Offset = "0x22176C4", VA = "0x22176C4")]
	private void RefreshInfoLabel(int index)
	{
	}

	[Token(Token = "0x600FBC6")]
	[Address(RVA = "0x22155F0", Offset = "0x22155F0", VA = "0x22155F0")]
	private void InitInfoLabelByType()
	{
	}

	[Token(Token = "0x600FBC7")]
	[Address(RVA = "0x22174F0", Offset = "0x22174F0", VA = "0x22174F0")]
	public void RefreshSortingDatas()
	{
	}

	[Token(Token = "0x600FBC8")]
	[Address(RVA = "0x2217FDC", Offset = "0x2217FDC", VA = "0x2217FDC")]
	private void RefreshSortingData(LeaderBoardSortingData sortingData)
	{
	}

	[Token(Token = "0x600FBC9")]
	[Address(RVA = "0x221813C", Offset = "0x221813C", VA = "0x221813C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
