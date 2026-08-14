using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;

namespace COW;

[Token(Token = "0x2002329")]
public class UIHudSceneEditConfirmWndController : UIPopupWindowController
{
	[Token(Token = "0x400DB21")]
	[FieldOffset(Offset = "0x48")]
	private UIHudSceneEditConfirmWndView m_View;

	[Token(Token = "0x400DB22")]
	[FieldOffset(Offset = "0x4C")]
	private Action fnApplyCallback;

	[Token(Token = "0x400DB23")]
	[FieldOffset(Offset = "0x50")]
	private Action fnCancelCallback;

	[Token(Token = "0x400DB24")]
	[FieldOffset(Offset = "0x54")]
	private JPPGAJBAAKK m_CurrentGame;

	[Token(Token = "0x400DB25")]
	[FieldOffset(Offset = "0x58")]
	private ESceneEditConfrmWndType m_WndType;

	[Token(Token = "0x400DB26")]
	[FieldOffset(Offset = "0x5C")]
	private UIModelSceneEdit m_ModelSceneEdit;

	[Token(Token = "0x400DB27")]
	[FieldOffset(Offset = "0x60")]
	private EWorkshop.UnlockSlotCostType m_CostType;

	[Token(Token = "0x400DB28")]
	[FieldOffset(Offset = "0x64")]
	private uint m_CostCnt;

	[Token(Token = "0x400DB29")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsShareGen;

	[Token(Token = "0x400DB2A")]
	[FieldOffset(Offset = "0x6C")]
	private EWorkshop.SlotType m_SlotType;

	[Token(Token = "0x400DB2B")]
	[FieldOffset(Offset = "0x70")]
	private uint m_SlotId;

	[Token(Token = "0x400DB2C")]
	[FieldOffset(Offset = "0x74")]
	private JOKABEAPNPP m_GameMode;

	[Token(Token = "0x400DB2D")]
	[FieldOffset(Offset = "0x78")]
	private DJMFJEMEKHM m_EntityAttributeItem;

	[Token(Token = "0x400DB2E")]
	[FieldOffset(Offset = "0x7C")]
	private int m_EntityAttributeItemIndex;

	[Token(Token = "0x600C2EF")]
	[Address(RVA = "0x1C57160", Offset = "0x1C57160", VA = "0x1C57160")]
	public UIHudSceneEditConfirmWndController()
	{
	}

	[Token(Token = "0x600C2F0")]
	[Address(RVA = "0x1C57168", Offset = "0x1C57168", VA = "0x1C57168")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C2F1")]
	[Address(RVA = "0x1C5720C", Offset = "0x1C5720C", VA = "0x1C5720C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C2F2")]
	[Address(RVA = "0x1C57558", Offset = "0x1C57558", VA = "0x1C57558")]
	public void SetWndType(ESceneEditConfrmWndType type, object[] args)
	{
	}

	[Token(Token = "0x600C2F3")]
	[Address(RVA = "0x1C583BC", Offset = "0x1C583BC", VA = "0x1C583BC")]
	private void UpdateLocText(string titleKey, string mainKey, string warnKey, string btnConfirmKey, string btnCancelKey)
	{
	}

	[Token(Token = "0x600C2F4")]
	[Address(RVA = "0x1C5883C", Offset = "0x1C5883C", VA = "0x1C5883C")]
	private void ProcessOnUnlockSlot()
	{
	}

	[Token(Token = "0x600C2F5")]
	[Address(RVA = "0x1C58FFC", Offset = "0x1C58FFC", VA = "0x1C58FFC")]
	private void OnClickCancelBtn()
	{
	}

	[Token(Token = "0x600C2F6")]
	[Address(RVA = "0x1C5920C", Offset = "0x1C5920C", VA = "0x1C5920C")]
	private void OnClickApplyBtn()
	{
	}

	[Token(Token = "0x600C2F7")]
	[Address(RVA = "0x1C59280", Offset = "0x1C59280", VA = "0x1C59280")]
	private void OnConfirmObjectGroup()
	{
	}

	[Token(Token = "0x600C2F8")]
	[Address(RVA = "0x1C5931C", Offset = "0x1C5931C", VA = "0x1C5931C")]
	private void OnConfirmDelAttribute()
	{
	}

	[Token(Token = "0x600C2F9")]
	[Address(RVA = "0x1C59514", Offset = "0x1C59514", VA = "0x1C59514")]
	private void OnCancelObjectGroup()
	{
	}

	[Token(Token = "0x600C2FA")]
	[Address(RVA = "0x1C59588", Offset = "0x1C59588", VA = "0x1C59588")]
	private void OnConfirmObjectGroupChangeLook()
	{
	}

	[Token(Token = "0x600C2FB")]
	[Address(RVA = "0x1C59628", Offset = "0x1C59628", VA = "0x1C59628")]
	private void OnCancelObjectGroupChangeLook()
	{
	}

	[Token(Token = "0x600C2FC")]
	[Address(RVA = "0x1C596A0", Offset = "0x1C596A0", VA = "0x1C596A0")]
	private void OnConfirmSave()
	{
	}

	[Token(Token = "0x600C2FD")]
	[Address(RVA = "0x1C59AA4", Offset = "0x1C59AA4", VA = "0x1C59AA4")]
	private void OnConfirmNotSave()
	{
	}

	[Token(Token = "0x600C2FE")]
	[Address(RVA = "0x1C59D90", Offset = "0x1C59D90", VA = "0x1C59D90")]
	private void OnConfirmApply()
	{
	}

	[Token(Token = "0x600C2FF")]
	[Address(RVA = "0x1C59EF8", Offset = "0x1C59EF8", VA = "0x1C59EF8")]
	private void OnConfirmUpload()
	{
	}

	[Token(Token = "0x600C300")]
	[Address(RVA = "0x1C5A060", Offset = "0x1C5A060", VA = "0x1C5A060")]
	private void OnConfirmUnlockSlot()
	{
	}

	[Token(Token = "0x600C301")]
	[Address(RVA = "0x1C5A66C", Offset = "0x1C5A66C", VA = "0x1C5A66C")]
	private void OnConfirmShare()
	{
	}

	[Token(Token = "0x600C302")]
	[Address(RVA = "0x1C5A7D4", Offset = "0x1C5A7D4", VA = "0x1C5A7D4")]
	private void OnConfirmDel()
	{
	}

	[Token(Token = "0x600C303")]
	[Address(RVA = "0x1C5A93C", Offset = "0x1C5A93C", VA = "0x1C5A93C")]
	private void OnConfirmCleanScene()
	{
	}

	[Token(Token = "0x600C304")]
	[Address(RVA = "0x1C59070", Offset = "0x1C59070", VA = "0x1C59070")]
	private void OnCloseWnd()
	{
	}

	[Token(Token = "0x600C305")]
	[Address(RVA = "0x1C5AAD4", Offset = "0x1C5AAD4", VA = "0x1C5AAD4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
