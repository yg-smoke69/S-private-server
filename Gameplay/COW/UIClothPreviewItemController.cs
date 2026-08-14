using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200256F")]
public class UIClothPreviewItemController : UIBaseController
{
	[Token(Token = "0x400E7B9")]
	[FieldOffset(Offset = "0x28")]
	private UIWidget m_ItemWidget;

	[Token(Token = "0x400E7BA")]
	[FieldOffset(Offset = "0x2C")]
	private UIClothPreviewItemView m_View;

	[Token(Token = "0x400E7BB")]
	[FieldOffset(Offset = "0x30")]
	public UIModelAvatarBase.EWardrobeType ewardrobetype;

	[Token(Token = "0x400E7BC")]
	[FieldOffset(Offset = "0x34")]
	private CSSharedItemData m_ClothItemData;

	[Token(Token = "0x600DAC8")]
	[Address(RVA = "0x2CD0C70", Offset = "0x2CD0C70", VA = "0x2CD0C70")]
	public UIClothPreviewItemController()
	{
	}

	[Token(Token = "0x600DAC9")]
	[Address(RVA = "0x2CD0CF4", Offset = "0x2CD0CF4", VA = "0x2CD0CF4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DACA")]
	[Address(RVA = "0x2CD0D98", Offset = "0x2CD0D98", VA = "0x2CD0D98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DACB")]
	[Address(RVA = "0x2CD0EF4", Offset = "0x2CD0EF4", VA = "0x2CD0EF4")]
	private void OnClothPreviewBtnClick()
	{
	}

	[Token(Token = "0x600DACC")]
	[Address(RVA = "0x2CD11D0", Offset = "0x2CD11D0", VA = "0x2CD11D0")]
	public void SetSelected(bool flag)
	{
	}

	[Token(Token = "0x600DACD")]
	[Address(RVA = "0x2CD1270", Offset = "0x2CD1270", VA = "0x2CD1270")]
	public void RefreshClothPreviewUI(CSSharedItemData itemdata)
	{
	}

	[Token(Token = "0x600DACE")]
	[Address(RVA = "0x2CD1420", Offset = "0x2CD1420", VA = "0x2CD1420")]
	public void ResetDefaultUI(UIModelAvatarBase.EWardrobeType type)
	{
	}

	[Token(Token = "0x600DACF")]
	[Address(RVA = "0x2CD176C", Offset = "0x2CD176C", VA = "0x2CD176C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
