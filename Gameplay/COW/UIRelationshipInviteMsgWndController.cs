using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002AC7")]
internal class UIRelationshipInviteMsgWndController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x40106D7")]
	[FieldOffset(Offset = "0x48")]
	private UIRelationshipInviteMsgWndView m_View;

	[Token(Token = "0x6011865")]
	[Address(RVA = "0x1E4BA6C", Offset = "0x1E4BA6C", VA = "0x1E4BA6C")]
	public UIRelationshipInviteMsgWndController()
	{
	}

	[Token(Token = "0x6011866")]
	[Address(RVA = "0x1E4BA74", Offset = "0x1E4BA74", VA = "0x1E4BA74", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011867")]
	[Address(RVA = "0x1E4BBFC", Offset = "0x1E4BBFC", VA = "0x1E4BBFC", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6011868")]
	[Address(RVA = "0x1E4BD2C", Offset = "0x1E4BD2C", VA = "0x1E4BD2C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011869")]
	[Address(RVA = "0x1E4BDD0", Offset = "0x1E4BDD0", VA = "0x1E4BDD0")]
	public void SetUIData(List<RelationshipMessageInfo> msgInfos)
	{
	}

	[Token(Token = "0x601186A")]
	[Address(RVA = "0x1E4C0AC", Offset = "0x1E4C0AC", VA = "0x1E4C0AC", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x601186B")]
	[Address(RVA = "0x1E4C1A4", Offset = "0x1E4C1A4", VA = "0x1E4C1A4", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x601186C")]
	[Address(RVA = "0x1E4C220", Offset = "0x1E4C220", VA = "0x1E4C220", Slot = "48")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601186D")]
	[Address(RVA = "0x1E4C4A8", Offset = "0x1E4C4A8", VA = "0x1E4C4A8", Slot = "49")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601186E")]
	[Address(RVA = "0x1E4C53C", Offset = "0x1E4C53C", VA = "0x1E4C53C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601186F")]
	[Address(RVA = "0x1E4C544", Offset = "0x1E4C544", VA = "0x1E4C544")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
