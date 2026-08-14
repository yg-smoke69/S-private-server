using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022C6")]
public class UIPVEWeaponItemController : UIBaseController
{
	[Token(Token = "0x400D952")]
	[FieldOffset(Offset = "0x28")]
	private UIPVEWeaponItemView m_View;

	[Token(Token = "0x400D953")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x400D954")]
	[FieldOffset(Offset = "0x30")]
	private CSSharedItemDataManager.CollectionSubType m_CurrentCollectionType;

	[Token(Token = "0x400D955")]
	[FieldOffset(Offset = "0x34")]
	private uint m_ItemID;

	[Token(Token = "0x400D956")]
	[FieldOffset(Offset = "0x38")]
	private CSSharedItemData m_WeaponItemData;

	[Token(Token = "0x400D957")]
	[FieldOffset(Offset = "0x3C")]
	private WeaponSkinData m_WeaponSkinData;

	[Token(Token = "0x400D958")]
	[FieldOffset(Offset = "0x40")]
	private UIModelPVE m_ModelPVE;

	[Token(Token = "0x400D959")]
	[FieldOffset(Offset = "0x44")]
	private CSSharedAvatarData m_AvatarData;

	[Token(Token = "0x600BF76")]
	[Address(RVA = "0x15AAF88", Offset = "0x15AAF88", VA = "0x15AAF88")]
	public UIPVEWeaponItemController()
	{
	}

	[Token(Token = "0x600BF77")]
	[Address(RVA = "0x15AB00C", Offset = "0x15AB00C", VA = "0x15AB00C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BF78")]
	[Address(RVA = "0x15AB0B4", Offset = "0x15AB0B4", VA = "0x15AB0B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BF79")]
	[Address(RVA = "0x15AB4FC", Offset = "0x15AB4FC", VA = "0x15AB4FC")]
	public UIToggleButton GetToggleBtn()
	{
		return null;
	}

	[Token(Token = "0x600BF7A")]
	[Address(RVA = "0x15AB56C", Offset = "0x15AB56C", VA = "0x15AB56C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600BF7B")]
	[Address(RVA = "0x15AB5D0", Offset = "0x15AB5D0", VA = "0x15AB5D0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BF7C")]
	[Address(RVA = "0x15AB76C", Offset = "0x15AB76C", VA = "0x15AB76C")]
	public void SetUIData(uint itemid)
	{
	}

	[Token(Token = "0x600BF7D")]
	[Address(RVA = "0x15ABBF8", Offset = "0x15ABBF8", VA = "0x15ABBF8")]
	private void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600BF7E")]
	[Address(RVA = "0x15AC06C", Offset = "0x15AC06C", VA = "0x15AC06C")]
	private void GotoPurchase()
	{
	}

	[Token(Token = "0x600BF7F")]
	[Address(RVA = "0x15AC294", Offset = "0x15AC294", VA = "0x15AC294")]
	private void HighLightCurrent(object[] data)
	{
	}

	[Token(Token = "0x600BF80")]
	[Address(RVA = "0x15AC3F0", Offset = "0x15AC3F0", VA = "0x15AC3F0")]
	private void RefreshTips(object[] data)
	{
	}

	[Token(Token = "0x600BF81")]
	[Address(RVA = "0x15AC52C", Offset = "0x15AC52C", VA = "0x15AC52C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BF82")]
	[Address(RVA = "0x15AC534", Offset = "0x15AC534", VA = "0x15AC534")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600BF83")]
	[Address(RVA = "0x15AC53C", Offset = "0x15AC53C", VA = "0x15AC53C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
