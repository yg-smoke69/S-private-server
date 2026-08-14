using System;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x20022F0")]
public class UIRushingPetsRoomSetting : MonoBehaviour
{
	[Token(Token = "0x400DA1A")]
	[FieldOffset(Offset = "0xC")]
	public UILabel Title;

	[Token(Token = "0x400DA1B")]
	[FieldOffset(Offset = "0x10")]
	public UIToggle Toggle;

	[Token(Token = "0x400DA1C")]
	[FieldOffset(Offset = "0x14")]
	private Action<DCNOOCAGCKC, uint> m_ToggeleCB;

	[Token(Token = "0x400DA1D")]
	[FieldOffset(Offset = "0x18")]
	private DCNOOCAGCKC paramType;

	[Token(Token = "0x600C0AE")]
	[Address(RVA = "0x143406C", Offset = "0x143406C", VA = "0x143406C")]
	public UIRushingPetsRoomSetting()
	{
	}

	[Token(Token = "0x600C0AF")]
	[Address(RVA = "0x142D1DC", Offset = "0x142D1DC", VA = "0x142D1DC")]
	public void Init()
	{
	}

	[Token(Token = "0x600C0B0")]
	[Address(RVA = "0x142D2FC", Offset = "0x142D2FC", VA = "0x142D2FC")]
	public void SetCallBack(Action<DCNOOCAGCKC, uint> toggleCB)
	{
	}

	[Token(Token = "0x600C0B1")]
	[Address(RVA = "0x1434074", Offset = "0x1434074", VA = "0x1434074")]
	private void OnToggleChanged()
	{
	}

	[Token(Token = "0x600C0B2")]
	[Address(RVA = "0x142D35C", Offset = "0x142D35C", VA = "0x142D35C")]
	public void InitInfo(DCNOOCAGCKC curType, string key, bool toggle)
	{
	}
}
