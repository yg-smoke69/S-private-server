using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002022")]
public class UIChampionshipTeamInviteItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400C9C9")]
	[FieldOffset(Offset = "0x38")]
	private UIChampionshipTeamInviteItemView m_View;

	[Token(Token = "0x400C9CA")]
	[FieldOffset(Offset = "0x3C")]
	private FriendAccountInfo m_FriendAccountInfo;

	[Token(Token = "0x400C9CB")]
	[FieldOffset(Offset = "0x40")]
	private UIBaseProfileInfoController m_BaseProfileUI;

	[Token(Token = "0x400C9CC")]
	[FieldOffset(Offset = "0x44")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C9CD")]
	[FieldOffset(Offset = "0x48")]
	private UIChampionshipTeamInviteController m_Parent;

	[Token(Token = "0x600A2D3")]
	[Address(RVA = "0x26139A4", Offset = "0x26139A4", VA = "0x26139A4")]
	public UIChampionshipTeamInviteItemController()
	{
	}

	[Token(Token = "0x600A2D4")]
	[Address(RVA = "0x26139AC", Offset = "0x26139AC", VA = "0x26139AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A2D5")]
	[Address(RVA = "0x2613A50", Offset = "0x2613A50", VA = "0x2613A50", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A2D6")]
	[Address(RVA = "0x2613FA0", Offset = "0x2613FA0", VA = "0x2613FA0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A2D7")]
	[Address(RVA = "0x2614228", Offset = "0x2614228", VA = "0x2614228", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A2D8")]
	[Address(RVA = "0x26142B0", Offset = "0x26142B0", VA = "0x26142B0")]
	private void Invite()
	{
	}

	[Token(Token = "0x600A2D9")]
	[Address(RVA = "0x2613BE8", Offset = "0x2613BE8", VA = "0x2613BE8")]
	private void UpdateInviteButtonView()
	{
	}

	[Token(Token = "0x600A2DA")]
	[Address(RVA = "0x26143F8", Offset = "0x26143F8", VA = "0x26143F8", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A2DB")]
	[Address(RVA = "0x261448C", Offset = "0x261448C", VA = "0x261448C", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A2DC")]
	[Address(RVA = "0x2614888", Offset = "0x2614888", VA = "0x2614888")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A2DD")]
	[Address(RVA = "0x2614890", Offset = "0x2614890", VA = "0x2614890")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
