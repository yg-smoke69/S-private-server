using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D16")]
public class UIHudRouletteItem : MonoBehaviour
{
	[Token(Token = "0x401134B")]
	[FieldOffset(Offset = "0xC")]
	public UISprite ItemNormalBG;

	[Token(Token = "0x401134C")]
	[FieldOffset(Offset = "0x10")]
	public UISprite ItemSelectBG;

	[Token(Token = "0x401134D")]
	[FieldOffset(Offset = "0x14")]
	public UISprite ItemTxtBG;

	[Token(Token = "0x401134E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ItemTxt;

	[Token(Token = "0x401134F")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BG;

	[Token(Token = "0x4011350")]
	[FieldOffset(Offset = "0x20")]
	public float StartAngle1;

	[Token(Token = "0x4011351")]
	[FieldOffset(Offset = "0x24")]
	public float EndAngle1;

	[Token(Token = "0x4011352")]
	[FieldOffset(Offset = "0x28")]
	public float StartAngle2;

	[Token(Token = "0x4011353")]
	[FieldOffset(Offset = "0x2C")]
	public float EndAngle2;

	[Token(Token = "0x4011354")]
	[FieldOffset(Offset = "0x30")]
	private Color m_SelectedColor;

	[Token(Token = "0x4011355")]
	[FieldOffset(Offset = "0x40")]
	private IngameQuickChatData m_ConfigData;

	[Token(Token = "0x4011356")]
	[FieldOffset(Offset = "0x44")]
	private bool m_IsSelect;

	[Token(Token = "0x6012D9C")]
	[Address(RVA = "0x1C3EF0C", Offset = "0x1C3EF0C", VA = "0x1C3EF0C")]
	public UIHudRouletteItem()
	{
	}

	[Token(Token = "0x6012D9D")]
	[Address(RVA = "0x1C3EF1C", Offset = "0x1C3EF1C", VA = "0x1C3EF1C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6012D9E")]
	[Address(RVA = "0x1C3C798", Offset = "0x1C3C798", VA = "0x1C3C798")]
	public void SetConfigData(IngameQuickChatData configData)
	{
	}

	[Token(Token = "0x6012D9F")]
	[Address(RVA = "0x1C3C5B8", Offset = "0x1C3C5B8", VA = "0x1C3C5B8")]
	public void SetState(bool isSelect)
	{
	}

	[Token(Token = "0x6012DA0")]
	[Address(RVA = "0x1C3D020", Offset = "0x1C3D020", VA = "0x1C3D020")]
	public void SendChatRequest()
	{
	}
}
