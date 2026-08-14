using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002008")]
public class UIChampionshipGameStatsController : UINavigationController, _Attribute
{
	[Token(Token = "0x2002009")]
	public class NavArgs
	{
		[Token(Token = "0x400C94A")]
		[FieldOffset(Offset = "0x8")]
		public ulong teamID;

		[Token(Token = "0x400C94B")]
		[FieldOffset(Offset = "0x10")]
		public TeamInfo teamInfo;

		[Token(Token = "0x400C94C")]
		[FieldOffset(Offset = "0x14")]
		public uint championshipType;

		[Token(Token = "0x600A1FD")]
		[Address(RVA = "0x282BD2C", Offset = "0x282BD2C", VA = "0x282BD2C")]
		public NavArgs()
		{
		}
	}

	[Token(Token = "0x400C943")]
	[FieldOffset(Offset = "0x68")]
	private UIChampionshipGameStatsView m_View;

	[Token(Token = "0x400C944")]
	[FieldOffset(Offset = "0x6C")]
	protected UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C945")]
	[FieldOffset(Offset = "0x70")]
	protected ChampionshipOpenInfoDesc m_ChampionshipOpenInfo;

	[Token(Token = "0x400C946")]
	[FieldOffset(Offset = "0x74")]
	private UIChampionshipTeamOverviewController m_TeamOverviewUI;

	[Token(Token = "0x400C947")]
	[FieldOffset(Offset = "0x78")]
	private ulong m_TeamID;

	[Token(Token = "0x400C948")]
	[FieldOffset(Offset = "0x80")]
	private TeamInfo m_TeamInfo;

	[Token(Token = "0x400C949")]
	[FieldOffset(Offset = "0x84")]
	private uint m_ChampionshipType;

	[Token(Token = "0x600A1E4")]
	[Address(RVA = "0x2829B68", Offset = "0x2829B68", VA = "0x2829B68")]
	public UIChampionshipGameStatsController()
	{
	}

	[Token(Token = "0x600A1E5")]
	[Address(RVA = "0x2829BEC", Offset = "0x2829BEC", VA = "0x2829BEC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A1E6")]
	[Address(RVA = "0x2829C94", Offset = "0x2829C94", VA = "0x2829C94")]
	protected object GetView()
	{
		return null;
	}

	[Token(Token = "0x600A1E7")]
	[Address(RVA = "0x2829CEC", Offset = "0x2829CEC", VA = "0x2829CEC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A1E8")]
	[Address(RVA = "0x282A054", Offset = "0x282A054", VA = "0x282A054", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600A1E9")]
	[Address(RVA = "0x282A6FC", Offset = "0x282A6FC", VA = "0x282A6FC", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600A1EA")]
	[Address(RVA = "0x282A760", Offset = "0x282A760", VA = "0x282A760", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A1EB")]
	[Address(RVA = "0x282A5D4", Offset = "0x282A5D4", VA = "0x282A5D4")]
	private void RequestData()
	{
	}

	[Token(Token = "0x600A1EC")]
	[Address(RVA = "0x282A7E8", Offset = "0x282A7E8", VA = "0x282A7E8")]
	private void UpdateTeamInfo()
	{
	}

	[Token(Token = "0x600A1ED")]
	[Address(RVA = "0x282A354", Offset = "0x282A354", VA = "0x282A354")]
	private void UpdateSeasonInfo()
	{
	}

	[Token(Token = "0x600A1EE")]
	[Address(RVA = "0x282A978", Offset = "0x282A978", VA = "0x282A978")]
	private void UpdateStatsInfo(CSTeamChampionshipSeasonStatsRes res)
	{
	}

	[Token(Token = "0x600A1EF")]
	[Address(RVA = "0x282B1B4", Offset = "0x282B1B4", VA = "0x282B1B4")]
	private string SecFormat(uint _sec)
	{
		return null;
	}

	[Token(Token = "0x600A1F0")]
	[Address(RVA = "0x282B2F0", Offset = "0x282B2F0", VA = "0x282B2F0")]
	private string uniFormat(uint n)
	{
		return null;
	}

	[Token(Token = "0x600A1F1")]
	[Address(RVA = "0x282B484", Offset = "0x282B484", VA = "0x282B484")]
	private void OnViewMatchHistoryBtnClick()
	{
	}

	[Token(Token = "0x600A1F2")]
	[Address(RVA = "0x282B6A4", Offset = "0x282B6A4", VA = "0x282B6A4")]
	protected void OnShareBtnClick()
	{
	}

	[Token(Token = "0x600A1F3")]
	[Address(RVA = "0x282B7FC", Offset = "0x282B7FC", VA = "0x282B7FC", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600A1F4")]
	[Address(RVA = "0x282B910", Offset = "0x282B910", VA = "0x282B910", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600A1F5")]
	[Address(RVA = "0x282BA60", Offset = "0x282BA60", VA = "0x282BA60", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A1F6")]
	[Address(RVA = "0x282BC64", Offset = "0x282BC64", VA = "0x282BC64", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A1F7")]
	[Address(RVA = "0x282BCFC", Offset = "0x282BCFC", VA = "0x282BCFC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A1F8")]
	[Address(RVA = "0x282BD04", Offset = "0x282BD04", VA = "0x282BD04")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600A1F9")]
	[Address(RVA = "0x282BD0C", Offset = "0x282BD0C", VA = "0x282BD0C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x600A1FA")]
	[Address(RVA = "0x282BD14", Offset = "0x282BD14", VA = "0x282BD14")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A1FB")]
	[Address(RVA = "0x282BD1C", Offset = "0x282BD1C", VA = "0x282BD1C")]
	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600A1FC")]
	[Address(RVA = "0x282BD24", Offset = "0x282BD24", VA = "0x282BD24")]
	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
