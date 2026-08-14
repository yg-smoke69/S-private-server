using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A5F")]
public class UIPetSkinItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x4010459")]
	[FieldOffset(Offset = "0x38")]
	private UIPetSkinItemView m_View;

	[Token(Token = "0x401045A")]
	[FieldOffset(Offset = "0x3C")]
	private PetSkinData skin_info;

	[Token(Token = "0x401045B")]
	[FieldOffset(Offset = "0x40")]
	private CSSharedItemData inventoryItem;

	[Token(Token = "0x401045C")]
	[FieldOffset(Offset = "0x44")]
	private UIStandardItemMAXBController m_UIStandardItemMAXBController;

	[Token(Token = "0x401045D")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsSelected;

	[Token(Token = "0x401045E")]
	[FieldOffset(Offset = "0x4C")]
	private UIPetInfoController m_UIPetInfoController;

	[Token(Token = "0x60113B9")]
	[Address(RVA = "0x2C4F234", Offset = "0x2C4F234", VA = "0x2C4F234")]
	public UIPetSkinItemController()
	{
	}

	[Token(Token = "0x60113BA")]
	[Address(RVA = "0x2C4F23C", Offset = "0x2C4F23C", VA = "0x2C4F23C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60113BB")]
	[Address(RVA = "0x2C4F2E4", Offset = "0x2C4F2E4", VA = "0x2C4F2E4", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60113BC")]
	[Address(RVA = "0x2C4F340", Offset = "0x2C4F340", VA = "0x2C4F340", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60113BD")]
	[Address(RVA = "0x2C4F6A0", Offset = "0x2C4F6A0", VA = "0x2C4F6A0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60113BE")]
	[Address(RVA = "0x2C4F864", Offset = "0x2C4F864", VA = "0x2C4F864", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60113BF")]
	[Address(RVA = "0x2C4FD08", Offset = "0x2C4FD08", VA = "0x2C4FD08")]
	private void SelectSkin()
	{
	}

	[Token(Token = "0x60113C0")]
	[Address(RVA = "0x2C4FE78", Offset = "0x2C4FE78", VA = "0x2C4FE78", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x60113C1")]
	[Address(RVA = "0x2C50414", Offset = "0x2C50414", VA = "0x2C50414", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x60113C2")]
	[Address(RVA = "0x2C4FBFC", Offset = "0x2C4FBFC", VA = "0x2C4FBFC")]
	public void SetHighLightBGState(bool show)
	{
	}

	[Token(Token = "0x60113C3")]
	[Address(RVA = "0x2C50484", Offset = "0x2C50484", VA = "0x2C50484")]
	private void RefreshPetDownloadInfo(object[] data)
	{
	}

	[Token(Token = "0x60113C4")]
	[Address(RVA = "0x2C505AC", Offset = "0x2C505AC", VA = "0x2C505AC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60113C5")]
	[Address(RVA = "0x2C50818", Offset = "0x2C50818", VA = "0x2C50818")]
	public void RefreshData()
	{
	}

	[Token(Token = "0x60113C6")]
	[Address(RVA = "0x2C50F84", Offset = "0x2C50F84", VA = "0x2C50F84", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60113C7")]
	[Address(RVA = "0x2C498D0", Offset = "0x2C498D0", VA = "0x2C498D0")]
	public void SetPetInfoController(UIPetInfoController ctrl)
	{
	}

	[Token(Token = "0x60113C8")]
	[Address(RVA = "0x2C51018", Offset = "0x2C51018", VA = "0x2C51018")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60113C9")]
	[Address(RVA = "0x2C51020", Offset = "0x2C51020", VA = "0x2C51020")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60113CA")]
	[Address(RVA = "0x2C51028", Offset = "0x2C51028", VA = "0x2C51028")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60113CB")]
	[Address(RVA = "0x2C51030", Offset = "0x2C51030", VA = "0x2C51030")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x60113CC")]
	[Address(RVA = "0x2C51038", Offset = "0x2C51038", VA = "0x2C51038")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
