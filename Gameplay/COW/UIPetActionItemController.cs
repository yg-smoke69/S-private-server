using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A4D")]
public class UIPetActionItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x40103FE")]
	[FieldOffset(Offset = "0x38")]
	private UIPetActionItemView m_View;

	[Token(Token = "0x40103FF")]
	[FieldOffset(Offset = "0x3C")]
	private PetActionData action_info;

	[Token(Token = "0x4010400")]
	[FieldOffset(Offset = "0x40")]
	private CSSharedItemData inventoryItem;

	[Token(Token = "0x4010401")]
	[FieldOffset(Offset = "0x44")]
	private UIStandardItemMAXBController m_UIStandardItemMAXBController;

	[Token(Token = "0x4010402")]
	[FieldOffset(Offset = "0x48")]
	private bool isSelected;

	[Token(Token = "0x60112C3")]
	[Address(RVA = "0x23E5394", Offset = "0x23E5394", VA = "0x23E5394")]
	public UIPetActionItemController()
	{
	}

	[Token(Token = "0x60112C4")]
	[Address(RVA = "0x23E539C", Offset = "0x23E539C", VA = "0x23E539C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60112C5")]
	[Address(RVA = "0x23E5444", Offset = "0x23E5444", VA = "0x23E5444", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60112C6")]
	[Address(RVA = "0x23E54A0", Offset = "0x23E54A0", VA = "0x23E54A0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60112C7")]
	[Address(RVA = "0x23E5780", Offset = "0x23E5780", VA = "0x23E5780", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60112C8")]
	[Address(RVA = "0x23E58B0", Offset = "0x23E58B0", VA = "0x23E58B0", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60112C9")]
	[Address(RVA = "0x23E5944", Offset = "0x23E5944", VA = "0x23E5944", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60112CA")]
	[Address(RVA = "0x23E5B28", Offset = "0x23E5B28", VA = "0x23E5B28")]
	private void PlayAction()
	{
	}

	[Token(Token = "0x60112CB")]
	[Address(RVA = "0x23E5CEC", Offset = "0x23E5CEC", VA = "0x23E5CEC", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x60112CC")]
	[Address(RVA = "0x23E620C", Offset = "0x23E620C", VA = "0x23E620C", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x60112CD")]
	[Address(RVA = "0x23E6100", Offset = "0x23E6100", VA = "0x23E6100")]
	public void SetHighLightBGState(bool show)
	{
	}

	[Token(Token = "0x60112CE")]
	[Address(RVA = "0x23E627C", Offset = "0x23E627C", VA = "0x23E627C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60112CF")]
	[Address(RVA = "0x23E64E8", Offset = "0x23E64E8", VA = "0x23E64E8")]
	public void RefreshData()
	{
	}

	[Token(Token = "0x60112D0")]
	[Address(RVA = "0x23E6B08", Offset = "0x23E6B08", VA = "0x23E6B08")]
	private void RefreshPetDownloadInfo(object[] data)
	{
	}

	[Token(Token = "0x60112D1")]
	[Address(RVA = "0x23E6C30", Offset = "0x23E6C30", VA = "0x23E6C30")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60112D2")]
	[Address(RVA = "0x23E6C38", Offset = "0x23E6C38", VA = "0x23E6C38")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60112D3")]
	[Address(RVA = "0x23E6C40", Offset = "0x23E6C40", VA = "0x23E6C40")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60112D4")]
	[Address(RVA = "0x23E6C48", Offset = "0x23E6C48", VA = "0x23E6C48")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x60112D5")]
	[Address(RVA = "0x23E6C50", Offset = "0x23E6C50", VA = "0x23E6C50")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
