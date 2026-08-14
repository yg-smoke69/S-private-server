using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002998")]
internal class UIMapDownloadSelectController : UIPopupWindowController
{
	[Token(Token = "0x4010004")]
	[FieldOffset(Offset = "0x48")]
	private UIMapDownloadSelectView m_View;

	[Token(Token = "0x4010005")]
	[FieldOffset(Offset = "0x4C")]
	public Action<int> DownloadAction;

	[Token(Token = "0x4010006")]
	[FieldOffset(Offset = "0x50")]
	private List<UIMapDownloadSelectItemController> m_ItemCtrlList;

	[Token(Token = "0x6010B4A")]
	[Address(RVA = "0x2800278", Offset = "0x2800278", VA = "0x2800278")]
	public UIMapDownloadSelectController()
	{
	}

	[Token(Token = "0x6010B4B")]
	[Address(RVA = "0x2800304", Offset = "0x2800304", VA = "0x2800304")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010B4C")]
	[Address(RVA = "0x28003AC", Offset = "0x28003AC", VA = "0x28003AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010B4D")]
	[Address(RVA = "0x280057C", Offset = "0x280057C", VA = "0x280057C")]
	public void SetUIData(List<MapModeData> mapDataList)
	{
	}

	[Token(Token = "0x6010B4E")]
	[Address(RVA = "0x2800CAC", Offset = "0x2800CAC", VA = "0x2800CAC")]
	private void OnBtnCancelClick()
	{
	}

	[Token(Token = "0x6010B4F")]
	[Address(RVA = "0x2800D10", Offset = "0x2800D10", VA = "0x2800D10")]
	private void OnBtnComfirmClick()
	{
	}

	[Token(Token = "0x6010B50")]
	[Address(RVA = "0x2801090", Offset = "0x2801090", VA = "0x2801090")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
