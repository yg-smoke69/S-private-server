using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001EF6")]
internal class UIDigitaluniverseBStarMapAssistHistoryController : UIBaseController, _Attribute
{
	[Token(Token = "0x400C2EB")]
	[FieldOffset(Offset = "0x28")]
	private UIDigitaluniverseBStarMapAssistHistoryView m_View;

	[Token(Token = "0x400C2EC")]
	[FieldOffset(Offset = "0x2C")]
	public Action<bool> ShowOrHideAction;

	[Token(Token = "0x600974E")]
	[Address(RVA = "0x2F0DFCC", Offset = "0x2F0DFCC", VA = "0x2F0DFCC")]
	public UIDigitaluniverseBStarMapAssistHistoryController()
	{
	}

	[Token(Token = "0x600974F")]
	[Address(RVA = "0x2F0E050", Offset = "0x2F0E050", VA = "0x2F0E050")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009750")]
	[Address(RVA = "0x2F0E0F8", Offset = "0x2F0E0F8", VA = "0x2F0E0F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009751")]
	[Address(RVA = "0x2F0E288", Offset = "0x2F0E288", VA = "0x2F0E288")]
	public void SetViewData(List<CSDigitalUniverseBStarCraftInfoRes.AssistanceInfo> assistInfoList)
	{
	}

	[Token(Token = "0x6009752")]
	[Address(RVA = "0x2F0E418", Offset = "0x2F0E418", VA = "0x2F0E418", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x6009753")]
	[Address(RVA = "0x2F0E4DC", Offset = "0x2F0E4DC", VA = "0x2F0E4DC", Slot = "22")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6009754")]
	[Address(RVA = "0x2F0E5A0", Offset = "0x2F0E5A0", VA = "0x2F0E5A0", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6009755")]
	[Address(RVA = "0x2F0E698", Offset = "0x2F0E698", VA = "0x2F0E698", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6009756")]
	[Address(RVA = "0x2F0E714", Offset = "0x2F0E714", VA = "0x2F0E714")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009757")]
	[Address(RVA = "0x2F0E71C", Offset = "0x2F0E71C", VA = "0x2F0E71C")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	[Token(Token = "0x6009758")]
	[Address(RVA = "0x2F0E724", Offset = "0x2F0E724", VA = "0x2F0E724")]
	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
