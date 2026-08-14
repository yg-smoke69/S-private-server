using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002025")]
public class UIChampionshipTeamJoinItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400C9D9")]
	[FieldOffset(Offset = "0x38")]
	private UIChampionshipTeamJoinItemView m_View;

	[Token(Token = "0x400C9DA")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C9DB")]
	[FieldOffset(Offset = "0x40")]
	private FriendAccountInfo m_AccountInfo;

	[Token(Token = "0x400C9DC")]
	[FieldOffset(Offset = "0x44")]
	private UIChampionshipTeamJoinController m_Parent;

	[Token(Token = "0x400C9DD")]
	[FieldOffset(Offset = "0x48")]
	private uint m_ChampionshipType;

	[Token(Token = "0x600A2F0")]
	[Address(RVA = "0x2616404", Offset = "0x2616404", VA = "0x2616404")]
	public UIChampionshipTeamJoinItemController()
	{
	}

	[Token(Token = "0x600A2F1")]
	[Address(RVA = "0x261640C", Offset = "0x261640C", VA = "0x261640C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A2F2")]
	[Address(RVA = "0x26164B0", Offset = "0x26164B0", VA = "0x26164B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A2F3")]
	[Address(RVA = "0x2616714", Offset = "0x2616714", VA = "0x2616714", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A2F4")]
	[Address(RVA = "0x26153F4", Offset = "0x26153F4", VA = "0x26153F4")]
	public void SetChampionshipType(uint championshipType)
	{
	}

	[Token(Token = "0x600A2F5")]
	[Address(RVA = "0x261679C", Offset = "0x261679C", VA = "0x261679C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A2F6")]
	[Address(RVA = "0x2617224", Offset = "0x2617224", VA = "0x2617224")]
	private void LookOver()
	{
	}

	[Token(Token = "0x600A2F7")]
	[Address(RVA = "0x2617364", Offset = "0x2617364", VA = "0x2617364")]
	private void ApplyFor()
	{
	}

	[Token(Token = "0x600A2F8")]
	[Address(RVA = "0x2616DA4", Offset = "0x2616DA4", VA = "0x2616DA4")]
	private void UpdateApplyButtonView()
	{
	}

	[Token(Token = "0x600A2F9")]
	[Address(RVA = "0x2617474", Offset = "0x2617474", VA = "0x2617474", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A2FA")]
	[Address(RVA = "0x261769C", Offset = "0x261769C", VA = "0x261769C", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A2FB")]
	[Address(RVA = "0x2617730", Offset = "0x2617730", VA = "0x2617730")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A2FC")]
	[Address(RVA = "0x2617738", Offset = "0x2617738", VA = "0x2617738")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
