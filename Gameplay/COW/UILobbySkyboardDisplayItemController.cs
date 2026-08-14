using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200213B")]
public class UILobbySkyboardDisplayItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400D05E")]
	[FieldOffset(Offset = "0x38")]
	private UILobbySkyboardDisplayItemView m_View;

	[Token(Token = "0x400D05F")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelSkyboardDisplay m_Model;

	[Token(Token = "0x400D060")]
	[FieldOffset(Offset = "0x40")]
	private UIModelOptionalDownload m_OptionalDownloadModel;

	[Token(Token = "0x400D061")]
	[FieldOffset(Offset = "0x44")]
	private SkyboardBaseInfo m_skyboardInfo;

	[Token(Token = "0x400D062")]
	[FieldOffset(Offset = "0x48")]
	private UINewDownloadInfoController m_Downloader;

	[Token(Token = "0x400D063")]
	[FieldOffset(Offset = "0x4C")]
	private List<ResourceID> m_NeedDownloadList;

	[Token(Token = "0x600AE81")]
	[Address(RVA = "0x1CB7DD4", Offset = "0x1CB7DD4", VA = "0x1CB7DD4")]
	public UILobbySkyboardDisplayItemController()
	{
	}

	[Token(Token = "0x600AE82")]
	[Address(RVA = "0x1CB7E60", Offset = "0x1CB7E60", VA = "0x1CB7E60")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AE83")]
	[Address(RVA = "0x1CB7F04", Offset = "0x1CB7F04", VA = "0x1CB7F04", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AE84")]
	[Address(RVA = "0x1CB8328", Offset = "0x1CB8328", VA = "0x1CB8328", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600AE85")]
	[Address(RVA = "0x1CB84E8", Offset = "0x1CB84E8", VA = "0x1CB84E8", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600AE86")]
	[Address(RVA = "0x1CB9064", Offset = "0x1CB9064", VA = "0x1CB9064")]
	private void RefreshDownloadState(bool isAbReady)
	{
	}

	[Token(Token = "0x600AE87")]
	[Address(RVA = "0x1CB9188", Offset = "0x1CB9188", VA = "0x1CB9188", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600AE88")]
	[Address(RVA = "0x1CB92CC", Offset = "0x1CB92CC", VA = "0x1CB92CC", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600AE89")]
	[Address(RVA = "0x1CB8B04", Offset = "0x1CB8B04", VA = "0x1CB8B04")]
	private void SetQualityBG(uint quality)
	{
	}

	[Token(Token = "0x600AE8A")]
	[Address(RVA = "0x1CB9360", Offset = "0x1CB9360", VA = "0x1CB9360")]
	private void RemoveSkyboard(object[] data)
	{
	}

	[Token(Token = "0x600AE8B")]
	[Address(RVA = "0x1CB93D4", Offset = "0x1CB93D4", VA = "0x1CB93D4")]
	private void ChangeSkyboard(object[] data)
	{
	}

	[Token(Token = "0x600AE8C")]
	[Address(RVA = "0x1CB95D8", Offset = "0x1CB95D8", VA = "0x1CB95D8")]
	private void OnButtonItemClicked()
	{
	}

	[Token(Token = "0x600AE8D")]
	[Address(RVA = "0x1CB97D8", Offset = "0x1CB97D8", VA = "0x1CB97D8", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600AE8E")]
	[Address(RVA = "0x1CB9B40", Offset = "0x1CB9B40", VA = "0x1CB9B40", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600AE8F")]
	[Address(RVA = "0x1CB9BDC", Offset = "0x1CB9BDC", VA = "0x1CB9BDC")]
	private void _003CSetViewData_003Em__0()
	{
	}

	[Token(Token = "0x600AE90")]
	[Address(RVA = "0x1CB9D80", Offset = "0x1CB9D80", VA = "0x1CB9D80")]
	private void _003CChangeSkyboard_003Em__1()
	{
	}

	[Token(Token = "0x600AE91")]
	[Address(RVA = "0x1CB9F14", Offset = "0x1CB9F14", VA = "0x1CB9F14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AE92")]
	[Address(RVA = "0x1CB9F1C", Offset = "0x1CB9F1C", VA = "0x1CB9F1C")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x600AE93")]
	[Address(RVA = "0x1CB9F24", Offset = "0x1CB9F24", VA = "0x1CB9F24")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600AE94")]
	[Address(RVA = "0x1CB9F2C", Offset = "0x1CB9F2C", VA = "0x1CB9F2C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
