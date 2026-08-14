using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028FD")]
public class UILegendClothVaultColorController : UIBaseController
{
	[Token(Token = "0x400FC4E")]
	[FieldOffset(Offset = "0x28")]
	private UILegendClothVaultColorView m_View;

	[Token(Token = "0x400FC4F")]
	[FieldOffset(Offset = "0x2C")]
	private int m_LegendLevel;

	[Token(Token = "0x400FC50")]
	[FieldOffset(Offset = "0x30")]
	private Color m_Color;

	[Token(Token = "0x400FC51")]
	[FieldOffset(Offset = "0x40")]
	private bool m_Unlock;

	[Token(Token = "0x400FC52")]
	[FieldOffset(Offset = "0x41")]
	private bool m_Armed;

	[Token(Token = "0x400FC53")]
	[FieldOffset(Offset = "0x42")]
	private bool m_IsInInvotory;

	[Token(Token = "0x400FC54")]
	[FieldOffset(Offset = "0x43")]
	private bool m_IsTypeBig;

	[Token(Token = "0x6010390")]
	[Address(RVA = "0x1AA3EAC", Offset = "0x1AA3EAC", VA = "0x1AA3EAC")]
	public UILegendClothVaultColorController()
	{
	}

	[Token(Token = "0x6010391")]
	[Address(RVA = "0x1AA3F30", Offset = "0x1AA3F30", VA = "0x1AA3F30")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010392")]
	[Address(RVA = "0x1AA3FD4", Offset = "0x1AA3FD4", VA = "0x1AA3FD4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010393")]
	[Address(RVA = "0x1AA4508", Offset = "0x1AA4508", VA = "0x1AA4508", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010394")]
	[Address(RVA = "0x1AA470C", Offset = "0x1AA470C", VA = "0x1AA470C")]
	public void SetData(LegendClothData data, bool isInInvotory, bool unLock)
	{
	}

	[Token(Token = "0x6010395")]
	[Address(RVA = "0x1AA4B9C", Offset = "0x1AA4B9C", VA = "0x1AA4B9C")]
	private void SetUnlock(bool canClick)
	{
	}

	[Token(Token = "0x6010396")]
	[Address(RVA = "0x1AA4E14", Offset = "0x1AA4E14", VA = "0x1AA4E14")]
	private void OnClickBtnPick()
	{
	}

	[Token(Token = "0x6010397")]
	[Address(RVA = "0x1AA4CF4", Offset = "0x1AA4CF4", VA = "0x1AA4CF4")]
	private void OnColorPick(object[] data)
	{
	}

	[Token(Token = "0x6010398")]
	[Address(RVA = "0x1AA552C", Offset = "0x1AA552C", VA = "0x1AA552C")]
	private void OnSlotPick(object[] data)
	{
	}

	[Token(Token = "0x6010399")]
	[Address(RVA = "0x1AA53D0", Offset = "0x1AA53D0", VA = "0x1AA53D0")]
	private void RefreshSelectType(int level)
	{
	}

	[Token(Token = "0x601039A")]
	[Address(RVA = "0x1AA43C0", Offset = "0x1AA43C0", VA = "0x1AA43C0")]
	private void ChangeSlotArmState(object[] data)
	{
	}

	[Token(Token = "0x601039B")]
	[Address(RVA = "0x1AA5604", Offset = "0x1AA5604", VA = "0x1AA5604")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601039C")]
	[Address(RVA = "0x1AA560C", Offset = "0x1AA560C", VA = "0x1AA560C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
