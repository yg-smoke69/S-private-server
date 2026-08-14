using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200200B")]
public class UIChampionshipLeaderBoardItem : UIEasyListItemController
{
	[Token(Token = "0x400C956")]
	[FieldOffset(Offset = "0x38")]
	private UIChampionshipLeaderBoardItemView m_View;

	[Token(Token = "0x400C957")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C958")]
	[FieldOffset(Offset = "0x40")]
	private UITeamBaseProfileController m_ProfileCtrl;

	[Token(Token = "0x400C959")]
	[FieldOffset(Offset = "0x44")]
	private TeamInfo m_TeamInfo;

	[Token(Token = "0x400C95A")]
	[FieldOffset(Offset = "0x48")]
	public uint m_ChampionshipType;

	[Token(Token = "0x400C95B")]
	[FieldOffset(Offset = "0x4C")]
	public bool m_IsSelf;

	[Token(Token = "0x400C95C")]
	[FieldOffset(Offset = "0x50")]
	private LeaderBoardInfo m_Info;

	[Token(Token = "0x600A20A")]
	[Address(RVA = "0x282E374", Offset = "0x282E374", VA = "0x282E374")]
	public UIChampionshipLeaderBoardItem()
	{
	}

	[Token(Token = "0x600A20B")]
	[Address(RVA = "0x282E37C", Offset = "0x282E37C", VA = "0x282E37C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A20C")]
	[Address(RVA = "0x282E424", Offset = "0x282E424", VA = "0x282E424", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A20D")]
	[Address(RVA = "0x282E6E0", Offset = "0x282E6E0", VA = "0x282E6E0", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A20E")]
	[Address(RVA = "0x282F094", Offset = "0x282F094", VA = "0x282F094")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600A20F")]
	[Address(RVA = "0x282F248", Offset = "0x282F248", VA = "0x282F248")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
