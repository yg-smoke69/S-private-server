using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200294D")]
public class UILobbyWeaponRackItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400FE8E")]
	[FieldOffset(Offset = "0x38")]
	private UILobbyWeaponRackItemView m_View;

	[Token(Token = "0x400FE8F")]
	[FieldOffset(Offset = "0x3C")]
	private WeaponItemData m_Itemdata;

	[Token(Token = "0x400FE90")]
	[FieldOffset(Offset = "0x40")]
	private bool m_ABReady;

	[Token(Token = "0x400FE91")]
	[FieldOffset(Offset = "0x44")]
	private List<ResourceID> m_NeedDownloadList;

	[Token(Token = "0x400FE92")]
	[FieldOffset(Offset = "0x48")]
	private UINewDownloadInfoController m_Downloader;

	[Token(Token = "0x6010803")]
	[Address(RVA = "0x21E1A60", Offset = "0x21E1A60", VA = "0x21E1A60")]
	public UILobbyWeaponRackItemController()
	{
	}

	[Token(Token = "0x6010804")]
	[Address(RVA = "0x21E1AEC", Offset = "0x21E1AEC", VA = "0x21E1AEC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010805")]
	[Address(RVA = "0x21E1B90", Offset = "0x21E1B90", VA = "0x21E1B90", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010806")]
	[Address(RVA = "0x21E1FA4", Offset = "0x21E1FA4", VA = "0x21E1FA4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010807")]
	[Address(RVA = "0x21E2194", Offset = "0x21E2194", VA = "0x21E2194", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6010808")]
	[Address(RVA = "0x21E326C", Offset = "0x21E326C", VA = "0x21E326C")]
	private void RefreshDownloadState(bool isAbReady)
	{
	}

	[Token(Token = "0x6010809")]
	[Address(RVA = "0x21E2D0C", Offset = "0x21E2D0C", VA = "0x21E2D0C")]
	private void SetQualityBG(uint Quality)
	{
	}

	[Token(Token = "0x601080A")]
	[Address(RVA = "0x21E3390", Offset = "0x21E3390", VA = "0x21E3390")]
	private void OnDragOverTrigger(object[] data)
	{
	}

	[Token(Token = "0x601080B")]
	[Address(RVA = "0x21E3424", Offset = "0x21E3424", VA = "0x21E3424")]
	private void OnButtonClicked()
	{
	}

	[Token(Token = "0x601080C")]
	[Address(RVA = "0x21E3768", Offset = "0x21E3768", VA = "0x21E3768", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x601080D")]
	[Address(RVA = "0x21E3804", Offset = "0x21E3804", VA = "0x21E3804", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x601080E")]
	[Address(RVA = "0x21E38A0", Offset = "0x21E38A0", VA = "0x21E38A0", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601080F")]
	[Address(RVA = "0x21E3CE4", Offset = "0x21E3CE4", VA = "0x21E3CE4", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010810")]
	[Address(RVA = "0x21E3D9C", Offset = "0x21E3D9C", VA = "0x21E3D9C")]
	private void _003CSetViewData_003Em__0()
	{
	}

	[Token(Token = "0x6010811")]
	[Address(RVA = "0x21E3F54", Offset = "0x21E3F54", VA = "0x21E3F54")]
	private void _003CSetViewData_003Em__1()
	{
	}

	[Token(Token = "0x6010812")]
	[Address(RVA = "0x21E40AC", Offset = "0x21E40AC", VA = "0x21E40AC")]
	private bool _003CSetViewData_003Em__2(uint x)
	{
		return default(bool);
	}

	[Token(Token = "0x6010813")]
	[Address(RVA = "0x21E4108", Offset = "0x21E4108", VA = "0x21E4108")]
	private bool _003COnDataChanged_003Em__3(uint x)
	{
		return default(bool);
	}

	[Token(Token = "0x6010814")]
	[Address(RVA = "0x21E4164", Offset = "0x21E4164", VA = "0x21E4164")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010815")]
	[Address(RVA = "0x21E416C", Offset = "0x21E416C", VA = "0x21E416C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x6010816")]
	[Address(RVA = "0x21E4174", Offset = "0x21E4174", VA = "0x21E4174")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6010817")]
	[Address(RVA = "0x21E417C", Offset = "0x21E417C", VA = "0x21E417C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
