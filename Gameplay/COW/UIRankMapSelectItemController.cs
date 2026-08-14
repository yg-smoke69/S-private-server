using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AB8")]
public class UIRankMapSelectItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x4010695")]
	[FieldOffset(Offset = "0x38")]
	private UIRankMapSelectItemView m_View;

	[Token(Token = "0x4010696")]
	[FieldOffset(Offset = "0x3C")]
	private MapOpeningInfo m_Data;

	[Token(Token = "0x4010697")]
	[FieldOffset(Offset = "0x40")]
	private UINewDownloadInfoController m_Downloader;

	[Token(Token = "0x4010698")]
	[FieldOffset(Offset = "0x44")]
	protected List<ResourceID> m_NeedDownloadRes;

	[Token(Token = "0x4010699")]
	[FieldOffset(Offset = "0x48")]
	private UIModelOptionalDownload m_ModelDownload;

	[Token(Token = "0x401069A")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelMapOpeningInfo m_ModelMap;

	[Token(Token = "0x60117C0")]
	[Address(RVA = "0x1ACCD38", Offset = "0x1ACCD38", VA = "0x1ACCD38")]
	public UIRankMapSelectItemController()
	{
	}

	[Token(Token = "0x60117C1")]
	[Address(RVA = "0x1ACCDC4", Offset = "0x1ACCDC4", VA = "0x1ACCDC4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60117C2")]
	[Address(RVA = "0x1ACCE6C", Offset = "0x1ACCE6C", VA = "0x1ACCE6C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60117C3")]
	[Address(RVA = "0x1ACD1A8", Offset = "0x1ACD1A8", VA = "0x1ACD1A8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60117C4")]
	[Address(RVA = "0x1ACD36C", Offset = "0x1ACD36C", VA = "0x1ACD36C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60117C5")]
	[Address(RVA = "0x1ACDDC4", Offset = "0x1ACDDC4", VA = "0x1ACDDC4", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60117C6")]
	[Address(RVA = "0x1ACE38C", Offset = "0x1ACE38C", VA = "0x1ACE38C", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60117C7")]
	[Address(RVA = "0x1ACE420", Offset = "0x1ACE420", VA = "0x1ACE420")]
	private void OnSelectedButtonClick()
	{
	}

	[Token(Token = "0x60117C8")]
	[Address(RVA = "0x1ACE6A0", Offset = "0x1ACE6A0", VA = "0x1ACE6A0")]
	private void OnItemButtonClick()
	{
	}

	[Token(Token = "0x60117C9")]
	[Address(RVA = "0x1ACDBB8", Offset = "0x1ACDBB8", VA = "0x1ACDBB8")]
	private void UpdateDownloadList()
	{
	}

	[Token(Token = "0x60117CA")]
	[Address(RVA = "0x1ACE190", Offset = "0x1ACE190", VA = "0x1ACE190")]
	private void RefreshDownloader(object[] data)
	{
	}

	[Token(Token = "0x60117CB")]
	[Address(RVA = "0x1ACEB3C", Offset = "0x1ACEB3C", VA = "0x1ACEB3C")]
	private void MapPanelVisibilityChanged(object[] data)
	{
	}

	[Token(Token = "0x60117CC")]
	[Address(RVA = "0x1ACECE4", Offset = "0x1ACECE4", VA = "0x1ACECE4")]
	private void _003CSetViewData_003Em__0()
	{
	}

	[Token(Token = "0x60117CD")]
	[Address(RVA = "0x1ACF148", Offset = "0x1ACF148", VA = "0x1ACF148")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60117CE")]
	[Address(RVA = "0x1ACF150", Offset = "0x1ACF150", VA = "0x1ACF150")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
