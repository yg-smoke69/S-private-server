using System;
using COW;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003AAD")]
public class UIManualWeaponItemView : MonoBehaviour
{
	[Token(Token = "0x4018F0E")]
	[FieldOffset(Offset = "0xC")]
	private UIButton m_Button;

	[Token(Token = "0x4018F0F")]
	[FieldOffset(Offset = "0x10")]
	private UISprite m_Shadow;

	[Token(Token = "0x4018F10")]
	[FieldOffset(Offset = "0x14")]
	private UISprite m_Icon;

	[Token(Token = "0x4018F11")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_SelectMark;

	[Token(Token = "0x4018F12")]
	[FieldOffset(Offset = "0x1C")]
	private GameObject m_Tag;

	[Token(Token = "0x4018F13")]
	[FieldOffset(Offset = "0x20")]
	public UIButton m_Badge0;

	[Token(Token = "0x4018F14")]
	[FieldOffset(Offset = "0x24")]
	public UISprite m_BadgeSprite0;

	[Token(Token = "0x4018F15")]
	[FieldOffset(Offset = "0x28")]
	private Action<ManualWeaponData> m_OnClickItem;

	[Token(Token = "0x4018F16")]
	[FieldOffset(Offset = "0x2C")]
	private ManualWeaponData m_Data;

	[Token(Token = "0x4018F17")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 m_OriginSize;

	[Token(Token = "0x60173D0")]
	[Address(RVA = "0x148AC9C", Offset = "0x148AC9C", VA = "0x148AC9C")]
	public UIManualWeaponItemView()
	{
	}

	[Token(Token = "0x60173D1")]
	[Address(RVA = "0x148ACA4", Offset = "0x148ACA4", VA = "0x148ACA4")]
	private void Start()
	{
	}

	[Token(Token = "0x60173D2")]
	[Address(RVA = "0x148ADDC", Offset = "0x148ADDC", VA = "0x148ADDC")]
	public void SetData(ManualWeaponData data, bool hasUnlock, bool isSelect, Action<ManualWeaponData> callback)
	{
	}

	[Token(Token = "0x60173D3")]
	[Address(RVA = "0x148B488", Offset = "0x148B488", VA = "0x148B488")]
	public void ClearData()
	{
	}

	[Token(Token = "0x60173D4")]
	[Address(RVA = "0x148B494", Offset = "0x148B494", VA = "0x148B494")]
	public void Show()
	{
	}

	[Token(Token = "0x60173D5")]
	[Address(RVA = "0x148B4CC", Offset = "0x148B4CC", VA = "0x148B4CC")]
	public void Hide()
	{
	}

	[Token(Token = "0x60173D6")]
	[Address(RVA = "0x148B504", Offset = "0x148B504", VA = "0x148B504")]
	public void OnClick()
	{
	}

	[Token(Token = "0x60173D7")]
	[Address(RVA = "0x148B628", Offset = "0x148B628", VA = "0x148B628")]
	public void OnClickBadge0()
	{
	}
}
