using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200252D")]
public class UIClanAvatarItemController : UIEasyListItemController
{
	[Token(Token = "0x400E675")]
	[FieldOffset(Offset = "0x38")]
	private UIClanAvatarItemView m_View;

	[Token(Token = "0x400E676")]
	[FieldOffset(Offset = "0x3C")]
	private HeadPicBaseInfo m_ClanAvatarInfo;

	[Token(Token = "0x600D839")]
	[Address(RVA = "0x2F224C4", Offset = "0x2F224C4", VA = "0x2F224C4")]
	public UIClanAvatarItemController()
	{
	}

	[Token(Token = "0x600D83A")]
	[Address(RVA = "0x2F224CC", Offset = "0x2F224CC", VA = "0x2F224CC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D83B")]
	[Address(RVA = "0x2F22574", Offset = "0x2F22574", VA = "0x2F22574", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D83C")]
	[Address(RVA = "0x2F226D0", Offset = "0x2F226D0", VA = "0x2F226D0", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D83D")]
	[Address(RVA = "0x2F22840", Offset = "0x2F22840", VA = "0x2F22840")]
	private void SelectAvatar()
	{
	}

	[Token(Token = "0x600D83E")]
	[Address(RVA = "0x2F229BC", Offset = "0x2F229BC", VA = "0x2F229BC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
