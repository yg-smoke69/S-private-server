using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002014")]
public class UIChampionshipOtherFormController : UINavigationController
{
	[Token(Token = "0x2002015")]
	public class NavArgs
	{
		[Token(Token = "0x400C984")]
		[FieldOffset(Offset = "0x8")]
		public uint cpType;

		[Token(Token = "0x400C985")]
		[FieldOffset(Offset = "0xC")]
		public uint teamID;

		[Token(Token = "0x400C986")]
		[FieldOffset(Offset = "0x10")]
		public bool self;

		[Token(Token = "0x400C987")]
		[FieldOffset(Offset = "0x14")]
		public uint scaleType;

		[Token(Token = "0x600A264")]
		[Address(RVA = "0x28364D4", Offset = "0x28364D4", VA = "0x28364D4")]
		public NavArgs()
		{
		}
	}

	[Token(Token = "0x2002016")]
	private enum EPage
	{
		[Token(Token = "0x400C989")]
		Team
	}

	[Token(Token = "0x2002017")]
	private enum ETeamSubPage
	{
		[Token(Token = "0x400C98B")]
		Info,
		[Token(Token = "0x400C98C")]
		Record
	}

	[Token(Token = "0x400C97E")]
	[FieldOffset(Offset = "0x68")]
	private uint m_ChampionshipType;

	[Token(Token = "0x400C97F")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_TeamID;

	[Token(Token = "0x400C980")]
	[FieldOffset(Offset = "0x70")]
	private UIChampionshipOtherFormView m_View;

	[Token(Token = "0x400C981")]
	[FieldOffset(Offset = "0x74")]
	private UIChampionshipTeamProfileOtherController m_TeamCtrl;

	[Token(Token = "0x400C982")]
	[FieldOffset(Offset = "0x78")]
	private UIStandardDrawerTabController m_DrawerTabCtrl;

	[Token(Token = "0x400C983")]
	[FieldOffset(Offset = "0x7C")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x600A25B")]
	[Address(RVA = "0x2835788", Offset = "0x2835788", VA = "0x2835788")]
	public UIChampionshipOtherFormController()
	{
	}

	[Token(Token = "0x600A25C")]
	[Address(RVA = "0x283580C", Offset = "0x283580C", VA = "0x283580C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A25D")]
	[Address(RVA = "0x28358B0", Offset = "0x28358B0", VA = "0x28358B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A25E")]
	[Address(RVA = "0x2835A24", Offset = "0x2835A24", VA = "0x2835A24", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600A25F")]
	[Address(RVA = "0x2835DB8", Offset = "0x2835DB8", VA = "0x2835DB8")]
	public void CreateTab()
	{
	}

	[Token(Token = "0x600A260")]
	[Address(RVA = "0x2835C14", Offset = "0x2835C14", VA = "0x2835C14")]
	public void CreateTeamPage()
	{
	}

	[Token(Token = "0x600A261")]
	[Address(RVA = "0x2836414", Offset = "0x2836414", VA = "0x2836414")]
	private void OnBtnTeamPageClick()
	{
	}

	[Token(Token = "0x600A262")]
	[Address(RVA = "0x28364C4", Offset = "0x28364C4", VA = "0x28364C4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A263")]
	[Address(RVA = "0x28364CC", Offset = "0x28364CC", VA = "0x28364CC")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
