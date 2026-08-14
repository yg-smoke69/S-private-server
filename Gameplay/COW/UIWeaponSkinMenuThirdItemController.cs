using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C08")]
public class UIWeaponSkinMenuThirdItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x4010D04")]
	[FieldOffset(Offset = "0x38")]
	private UIWeaponSkinMenuThirdItemView m_View;

	[Token(Token = "0x4010D05")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x4010D06")]
	[FieldOffset(Offset = "0x40")]
	private object m_Data;

	[Token(Token = "0x4010D07")]
	[FieldOffset(Offset = "0x44")]
	private bool m_IsABReady;

	[Token(Token = "0x4010D08")]
	[FieldOffset(Offset = "0x48")]
	private uint m_ItemIconGrey;

	[Token(Token = "0x1700131D")]
	private CollectionBaseInfo m_DataAsCollectionBaseInfo
	{
		[Token(Token = "0x60124AF")]
		[Address(RVA = "0x2EE1494", Offset = "0x2EE1494", VA = "0x2EE1494")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700131E")]
	private WeaponSkinBaseInfo m_DataAsWeaponSkinBaseInfo
	{
		[Token(Token = "0x60124B0")]
		[Address(RVA = "0x2EE1578", Offset = "0x2EE1578", VA = "0x2EE1578")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60124AE")]
	[Address(RVA = "0x2EE1480", Offset = "0x2EE1480", VA = "0x2EE1480")]
	public UIWeaponSkinMenuThirdItemController()
	{
	}

	[Token(Token = "0x60124B1")]
	[Address(RVA = "0x2EE165C", Offset = "0x2EE165C", VA = "0x2EE165C")]
	public void RefreshMutliSelectEquipState()
	{
	}

	[Token(Token = "0x60124B2")]
	[Address(RVA = "0x2EE18E8", Offset = "0x2EE18E8", VA = "0x2EE18E8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60124B3")]
	[Address(RVA = "0x2EE1990", Offset = "0x2EE1990", VA = "0x2EE1990", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60124B4")]
	[Address(RVA = "0x2EE19EC", Offset = "0x2EE19EC", VA = "0x2EE19EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60124B5")]
	[Address(RVA = "0x2EE1FCC", Offset = "0x2EE1FCC", VA = "0x2EE1FCC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60124B6")]
	[Address(RVA = "0x2EE21F8", Offset = "0x2EE21F8", VA = "0x2EE21F8")]
	private void RefreshRedTips(bool flag)
	{
	}

	[Token(Token = "0x60124B7")]
	[Address(RVA = "0x2EE2290", Offset = "0x2EE2290", VA = "0x2EE2290", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60124B8")]
	[Address(RVA = "0x2EE3AF4", Offset = "0x2EE3AF4", VA = "0x2EE3AF4")]
	private void OnItemDownloadUpdate(object[] param)
	{
	}

	[Token(Token = "0x60124B9")]
	[Address(RVA = "0x2EE3D90", Offset = "0x2EE3D90", VA = "0x2EE3D90")]
	private void OnItemUpdate(object[] param)
	{
	}

	[Token(Token = "0x60124BA")]
	[Address(RVA = "0x2EE4000", Offset = "0x2EE4000", VA = "0x2EE4000", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x60124BB")]
	[Address(RVA = "0x2EE458C", Offset = "0x2EE458C", VA = "0x2EE458C", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x60124BC")]
	[Address(RVA = "0x2EE4628", Offset = "0x2EE4628", VA = "0x2EE4628", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60124BD")]
	[Address(RVA = "0x2EE4744", Offset = "0x2EE4744", VA = "0x2EE4744", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60124BE")]
	[Address(RVA = "0x2EE47D8", Offset = "0x2EE47D8", VA = "0x2EE47D8")]
	private void OnClickGoToMallWeapon()
	{
	}

	[Token(Token = "0x60124BF")]
	[Address(RVA = "0x2EE3710", Offset = "0x2EE3710", VA = "0x2EE3710")]
	public void ShowNotReadyLabel(uint id)
	{
	}

	[Token(Token = "0x60124C0")]
	[Address(RVA = "0x2EE4A8C", Offset = "0x2EE4A8C", VA = "0x2EE4A8C")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60124C1")]
	[Address(RVA = "0x2EE4A94", Offset = "0x2EE4A94", VA = "0x2EE4A94")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60124C2")]
	[Address(RVA = "0x2EE4A9C", Offset = "0x2EE4A9C", VA = "0x2EE4A9C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60124C3")]
	[Address(RVA = "0x2EE4AA4", Offset = "0x2EE4AA4", VA = "0x2EE4AA4")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x60124C4")]
	[Address(RVA = "0x2EE4AAC", Offset = "0x2EE4AAC", VA = "0x2EE4AAC")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
