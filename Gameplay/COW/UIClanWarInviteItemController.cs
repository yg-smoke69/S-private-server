using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002558")]
public class UIClanWarInviteItemController : UIEasyListItemController
{
	[Token(Token = "0x400E74C")]
	[FieldOffset(Offset = "0x38")]
	private UIBaseProfileInfoController m_BaseProfileInfo;

	[Token(Token = "0x400E74D")]
	[FieldOffset(Offset = "0x3C")]
	private UIClanWarInviteItemView m_View;

	[Token(Token = "0x400E74E")]
	[FieldOffset(Offset = "0x40")]
	private ClanMember m_MemberInfo;

	[Token(Token = "0x400E74F")]
	[FieldOffset(Offset = "0x44")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x600D9CA")]
	[Address(RVA = "0x2B4F818", Offset = "0x2B4F818", VA = "0x2B4F818")]
	public UIClanWarInviteItemController()
	{
	}

	[Token(Token = "0x600D9CB")]
	[Address(RVA = "0x2B4F820", Offset = "0x2B4F820", VA = "0x2B4F820")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D9CC")]
	[Address(RVA = "0x2B4F8C4", Offset = "0x2B4F8C4", VA = "0x2B4F8C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D9CD")]
	[Address(RVA = "0x2B4FA90", Offset = "0x2B4FA90", VA = "0x2B4FA90")]
	private void OnInviteClick()
	{
	}

	[Token(Token = "0x600D9CE")]
	[Address(RVA = "0x2B501C0", Offset = "0x2B501C0", VA = "0x2B501C0", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D9CF")]
	[Address(RVA = "0x2B50940", Offset = "0x2B50940", VA = "0x2B50940")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
