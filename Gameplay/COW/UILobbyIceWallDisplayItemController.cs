using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002137")]
public class UILobbyIceWallDisplayItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x2002138")]
	private sealed class _003CSetViewData_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D04F")]
		[FieldOffset(Offset = "0x8")]
		internal CSSharedItemData skinData;

		[Token(Token = "0x400D050")]
		[FieldOffset(Offset = "0xC")]
		internal UILobbyIceWallDisplayItemController _0024this;

		[Token(Token = "0x600AE67")]
		[Address(RVA = "0xDB8B84", Offset = "0xDB8B84", VA = "0xDB8B84")]
		public _003CSetViewData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600AE68")]
		[Address(RVA = "0xDB9A4C", Offset = "0xDB9A4C", VA = "0xDB9A4C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400D047")]
	[FieldOffset(Offset = "0x38")]
	private UILobbyIceWallDisplayItemView m_View;

	[Token(Token = "0x400D048")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelIceWallDisplay m_Model;

	[Token(Token = "0x400D049")]
	[FieldOffset(Offset = "0x40")]
	private List<ResourceID> m_NeedDownloadList;

	[Token(Token = "0x400D04A")]
	[FieldOffset(Offset = "0x44")]
	private UIModelOptionalDownload m_optionalDownloadModel;

	[Token(Token = "0x400D04B")]
	[FieldOffset(Offset = "0x48")]
	private WeaponItemData m_Info;

	[Token(Token = "0x400D04C")]
	[FieldOffset(Offset = "0x4C")]
	private UINewDownloadInfoController m_Downloader;

	[Token(Token = "0x400D04D")]
	[FieldOffset(Offset = "0x50")]
	private UICommonGuideController m_guideController;

	[Token(Token = "0x400D04E")]
	[FieldOffset(Offset = "0x54")]
	private string m_skinName;

	[Token(Token = "0x600AE52")]
	[Address(RVA = "0xDB7834", Offset = "0xDB7834", VA = "0xDB7834")]
	public UILobbyIceWallDisplayItemController()
	{
	}

	[Token(Token = "0x600AE53")]
	[Address(RVA = "0xDB78C0", Offset = "0xDB78C0", VA = "0xDB78C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AE54")]
	[Address(RVA = "0xDB7964", Offset = "0xDB7964", VA = "0xDB7964", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AE55")]
	[Address(RVA = "0xDB7D88", Offset = "0xDB7D88", VA = "0xDB7D88", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600AE56")]
	[Address(RVA = "0xDB5DA0", Offset = "0xDB5DA0", VA = "0xDB5DA0")]
	public void ShowGuide()
	{
	}

	[Token(Token = "0x600AE57")]
	[Address(RVA = "0xDB7F48", Offset = "0xDB7F48", VA = "0xDB7F48", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600AE58")]
	[Address(RVA = "0xDB8B8C", Offset = "0xDB8B8C", VA = "0xDB8B8C")]
	private void RefreshDownloadState(bool isAbready)
	{
	}

	[Token(Token = "0x600AE59")]
	[Address(RVA = "0xDB8CB0", Offset = "0xDB8CB0", VA = "0xDB8CB0", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600AE5A")]
	[Address(RVA = "0xDB8E08", Offset = "0xDB8E08", VA = "0xDB8E08", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600AE5B")]
	[Address(RVA = "0xDB8E9C", Offset = "0xDB8E9C", VA = "0xDB8E9C")]
	private void Update()
	{
	}

	[Token(Token = "0x600AE5C")]
	[Address(RVA = "0xDB8624", Offset = "0xDB8624", VA = "0xDB8624")]
	private void SetQualityBG(uint quality)
	{
	}

	[Token(Token = "0x600AE5D")]
	[Address(RVA = "0xDB8FFC", Offset = "0xDB8FFC", VA = "0xDB8FFC")]
	private void OnButtonClicked()
	{
	}

	[Token(Token = "0x600AE5E")]
	[Address(RVA = "0xDB91B4", Offset = "0xDB91B4", VA = "0xDB91B4", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600AE5F")]
	[Address(RVA = "0xDB9584", Offset = "0xDB9584", VA = "0xDB9584", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600AE60")]
	[Address(RVA = "0xDB9620", Offset = "0xDB9620", VA = "0xDB9620")]
	private void RemoveIceWall(object[] data)
	{
	}

	[Token(Token = "0x600AE61")]
	[Address(RVA = "0xDB9694", Offset = "0xDB9694", VA = "0xDB9694")]
	private void ChangeIceWall(object[] data)
	{
	}

	[Token(Token = "0x600AE62")]
	[Address(RVA = "0xDB9898", Offset = "0xDB9898", VA = "0xDB9898")]
	private void _003CChangeIceWall_003Em__0()
	{
	}

	[Token(Token = "0x600AE63")]
	[Address(RVA = "0xDB9A2C", Offset = "0xDB9A2C", VA = "0xDB9A2C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AE64")]
	[Address(RVA = "0xDB9A34", Offset = "0xDB9A34", VA = "0xDB9A34")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x600AE65")]
	[Address(RVA = "0xDB9A3C", Offset = "0xDB9A3C", VA = "0xDB9A3C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600AE66")]
	[Address(RVA = "0xDB9A44", Offset = "0xDB9A44", VA = "0xDB9A44")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
