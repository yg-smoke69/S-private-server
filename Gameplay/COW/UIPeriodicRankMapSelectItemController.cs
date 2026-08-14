using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A4C")]
public class UIPeriodicRankMapSelectItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x40103F8")]
	[FieldOffset(Offset = "0x38")]
	private UIRankMapSelectItemView m_View;

	[Token(Token = "0x40103F9")]
	[FieldOffset(Offset = "0x3C")]
	private MapOpeningInfo m_Data;

	[Token(Token = "0x40103FA")]
	[FieldOffset(Offset = "0x40")]
	private UINewDownloadInfoController m_Downloader;

	[Token(Token = "0x40103FB")]
	[FieldOffset(Offset = "0x44")]
	protected List<ResourceID> m_NeedDownloadRes;

	[Token(Token = "0x40103FC")]
	[FieldOffset(Offset = "0x48")]
	private UIModelOptionalDownload m_ModelDownload;

	[Token(Token = "0x40103FD")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x60112B4")]
	[Address(RVA = "0x23E27D4", Offset = "0x23E27D4", VA = "0x23E27D4")]
	public UIPeriodicRankMapSelectItemController()
	{
	}

	[Token(Token = "0x60112B5")]
	[Address(RVA = "0x23E2860", Offset = "0x23E2860", VA = "0x23E2860")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60112B6")]
	[Address(RVA = "0x23E2908", Offset = "0x23E2908", VA = "0x23E2908", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60112B7")]
	[Address(RVA = "0x23E2C44", Offset = "0x23E2C44", VA = "0x23E2C44", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60112B8")]
	[Address(RVA = "0x23E2E08", Offset = "0x23E2E08", VA = "0x23E2E08", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60112B9")]
	[Address(RVA = "0x23E3860", Offset = "0x23E3860", VA = "0x23E3860", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60112BA")]
	[Address(RVA = "0x23E3CF4", Offset = "0x23E3CF4", VA = "0x23E3CF4", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60112BB")]
	[Address(RVA = "0x23E3D88", Offset = "0x23E3D88", VA = "0x23E3D88")]
	private void OnSelectedButtonClick()
	{
	}

	[Token(Token = "0x60112BC")]
	[Address(RVA = "0x23E4008", Offset = "0x23E4008", VA = "0x23E4008")]
	private void OnItemButtonClick()
	{
	}

	[Token(Token = "0x60112BD")]
	[Address(RVA = "0x23E3654", Offset = "0x23E3654", VA = "0x23E3654")]
	private void UpdateDownloadList()
	{
	}

	[Token(Token = "0x60112BE")]
	[Address(RVA = "0x23E3AF8", Offset = "0x23E3AF8", VA = "0x23E3AF8")]
	private void RefreshDownloader(object[] data)
	{
	}

	[Token(Token = "0x60112BF")]
	[Address(RVA = "0x23E44A4", Offset = "0x23E44A4", VA = "0x23E44A4")]
	private void MapPanelVisibilityChanged(object[] data)
	{
	}

	[Token(Token = "0x60112C0")]
	[Address(RVA = "0x23E464C", Offset = "0x23E464C", VA = "0x23E464C")]
	private void _003CSetViewData_003Em__0()
	{
	}

	[Token(Token = "0x60112C1")]
	[Address(RVA = "0x23E4AB0", Offset = "0x23E4AB0", VA = "0x23E4AB0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60112C2")]
	[Address(RVA = "0x23E4AB8", Offset = "0x23E4AB8", VA = "0x23E4AB8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
