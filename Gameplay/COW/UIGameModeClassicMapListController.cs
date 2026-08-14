using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026A4")]
internal class UIGameModeClassicMapListController : UIBaseController, _Attribute
{
	[Token(Token = "0x400EE55")]
	[FieldOffset(Offset = "0x28")]
	private UIGameModeClassicMapListView m_View;

	[Token(Token = "0x400EE56")]
	[FieldOffset(Offset = "0x2C")]
	private MapModeData m_SelectedMapData;

	[Token(Token = "0x400EE57")]
	[FieldOffset(Offset = "0x30")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x400EE58")]
	[FieldOffset(Offset = "0x34")]
	private List<MapModeData> m_MapModeList;

	[Token(Token = "0x400EE59")]
	[FieldOffset(Offset = "0x38")]
	private uint m_DelayCallAzore;

	[Token(Token = "0x400EE5A")]
	[FieldOffset(Offset = "0x3C")]
	protected List<ResourceID> m_NeedDownloadRes;

	[Token(Token = "0x400EE5B")]
	[FieldOffset(Offset = "0x40")]
	private UINewDownloadInfoController m_DownloaderCtrl;

	[Token(Token = "0x600E888")]
	[Address(RVA = "0x217AD90", Offset = "0x217AD90", VA = "0x217AD90")]
	public UIGameModeClassicMapListController()
	{
	}

	[Token(Token = "0x600E889")]
	[Address(RVA = "0x217AE7C", Offset = "0x217AE7C", VA = "0x217AE7C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E88A")]
	[Address(RVA = "0x217B28C", Offset = "0x217B28C", VA = "0x217B28C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600E88B")]
	[Address(RVA = "0x217B4F4", Offset = "0x217B4F4", VA = "0x217B4F4")]
	private void RefreshDownloader(object[] data)
	{
	}

	[Token(Token = "0x600E88C")]
	[Address(RVA = "0x217BB10", Offset = "0x217BB10", VA = "0x217BB10")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E88D")]
	[Address(RVA = "0x217BBB8", Offset = "0x217BBB8", VA = "0x217BBB8")]
	private void OnChooseMapSuccess(object[] data)
	{
	}

	[Token(Token = "0x600E88E")]
	[Address(RVA = "0x217BDA0", Offset = "0x217BDA0", VA = "0x217BDA0")]
	public void TweenAnimParaise()
	{
	}

	[Token(Token = "0x600E88F")]
	[Address(RVA = "0x217BDF4", Offset = "0x217BDF4", VA = "0x217BDF4")]
	public void TweenAnimAzore()
	{
	}

	[Token(Token = "0x600E890")]
	[Address(RVA = "0x2178AE0", Offset = "0x2178AE0", VA = "0x2178AE0")]
	public void SetUIData(List<MapModeData> dataList)
	{
	}

	[Token(Token = "0x600E891")]
	[Address(RVA = "0x217B8D0", Offset = "0x217B8D0", VA = "0x217B8D0")]
	private void updateDownloadList()
	{
	}

	[Token(Token = "0x600E892")]
	[Address(RVA = "0x217BE48", Offset = "0x217BE48", VA = "0x217BE48")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600E893")]
	[Address(RVA = "0x217BEA8", Offset = "0x217BEA8", VA = "0x217BEA8")]
	public void ResetTween()
	{
	}

	[Token(Token = "0x600E894")]
	[Address(RVA = "0x217BEFC", Offset = "0x217BEFC", VA = "0x217BEFC")]
	private void OnParadiseBtnClick()
	{
	}

	[Token(Token = "0x600E895")]
	[Address(RVA = "0x217C600", Offset = "0x217C600", VA = "0x217C600")]
	private void OnAzoreBtnClick()
	{
	}

	[Token(Token = "0x600E896")]
	[Address(RVA = "0x217C894", Offset = "0x217C894", VA = "0x217C894", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E897")]
	[Address(RVA = "0x217CA38", Offset = "0x217CA38", VA = "0x217CA38", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E898")]
	[Address(RVA = "0x217CACC", Offset = "0x217CACC", VA = "0x217CACC")]
	private void TryDownloadMapRes()
	{
	}

	[Token(Token = "0x600E899")]
	[Address(RVA = "0x217CC40", Offset = "0x217CC40", VA = "0x217CC40")]
	private void _003CRefreshDownloader_003Em__0()
	{
	}

	[Token(Token = "0x600E89A")]
	[Address(RVA = "0x217CD8C", Offset = "0x217CD8C", VA = "0x217CD8C")]
	private void _003CSetUIData_003Em__1()
	{
	}

	[Token(Token = "0x600E89B")]
	[Address(RVA = "0x217CED8", Offset = "0x217CED8", VA = "0x217CED8")]
	private void _003COnParadiseBtnClick_003Em__2()
	{
	}

	[Token(Token = "0x600E89C")]
	[Address(RVA = "0x217CFD8", Offset = "0x217CFD8", VA = "0x217CFD8")]
	private void _003COnAzoreBtnClick_003Em__3()
	{
	}

	[Token(Token = "0x600E89D")]
	[Address(RVA = "0x217D0D8", Offset = "0x217D0D8", VA = "0x217D0D8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E89E")]
	[Address(RVA = "0x217D0E0", Offset = "0x217D0E0", VA = "0x217D0E0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
