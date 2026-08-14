using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022CA")]
internal class UIPVEWeaponSkinItemController : UIEasyListItemController
{
	[Token(Token = "0x400D96A")]
	[FieldOffset(Offset = "0x38")]
	private UIPVEWeaponSkinItemView m_View;

	[Token(Token = "0x400D96B")]
	[FieldOffset(Offset = "0x3C")]
	private WeaponSkinBaseInfo m_WeaponSkinInfo;

	[Token(Token = "0x400D96C")]
	[FieldOffset(Offset = "0x40")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x400D96D")]
	[FieldOffset(Offset = "0x44")]
	private CSSharedItemDataManager.CollectionSubType m_CurrentCollectionType;

	[Token(Token = "0x400D96E")]
	[FieldOffset(Offset = "0x48")]
	private uint m_DefaultWeaponSkinId;

	[Token(Token = "0x400D96F")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_ItemIconGrey;

	[Token(Token = "0x600BF9D")]
	[Address(RVA = "0x15AFD2C", Offset = "0x15AFD2C", VA = "0x15AFD2C")]
	public UIPVEWeaponSkinItemController()
	{
	}

	[Token(Token = "0x600BF9E")]
	[Address(RVA = "0x15AFD40", Offset = "0x15AFD40", VA = "0x15AFD40")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BF9F")]
	[Address(RVA = "0x15AFDE8", Offset = "0x15AFDE8", VA = "0x15AFDE8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BFA0")]
	[Address(RVA = "0x15B010C", Offset = "0x15B010C", VA = "0x15B010C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BFA1")]
	[Address(RVA = "0x15B0170", Offset = "0x15B0170", VA = "0x15B0170", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600BFA2")]
	[Address(RVA = "0x15B0484", Offset = "0x15B0484", VA = "0x15B0484", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600BFA3")]
	[Address(RVA = "0x15B0520", Offset = "0x15B0520", VA = "0x15B0520", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600BFA4")]
	[Address(RVA = "0x15B0E90", Offset = "0x15B0E90", VA = "0x15B0E90")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BFA5")]
	[Address(RVA = "0x15B0E98", Offset = "0x15B0E98", VA = "0x15B0E98")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600BFA6")]
	[Address(RVA = "0x15B0EA0", Offset = "0x15B0EA0", VA = "0x15B0EA0")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600BFA7")]
	[Address(RVA = "0x15B0EA8", Offset = "0x15B0EA8", VA = "0x15B0EA8")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
