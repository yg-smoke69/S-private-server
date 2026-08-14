using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D39")]
public class UISettingBloodToggle : MonoBehaviour
{
	[Token(Token = "0x40114A8")]
	[FieldOffset(Offset = "0xC")]
	public UIToggle redToggle;

	[Token(Token = "0x40114A9")]
	[FieldOffset(Offset = "0x10")]
	public UIToggle blackToggle;

	[Token(Token = "0x40114AA")]
	[FieldOffset(Offset = "0x14")]
	public UIToggle nullToggle;

	[Token(Token = "0x40114AB")]
	[FieldOffset(Offset = "0x18")]
	public UILabel redLabel;

	[Token(Token = "0x40114AC")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel blackLabel;

	[Token(Token = "0x40114AD")]
	[FieldOffset(Offset = "0x20")]
	public UILabel nullLabel;

	[Token(Token = "0x40114AE")]
	[FieldOffset(Offset = "0x24")]
	public Color OnColor;

	[Token(Token = "0x40114AF")]
	[FieldOffset(Offset = "0x34")]
	public Color OffColor;

	[Token(Token = "0x40114B0")]
	[FieldOffset(Offset = "0x44")]
	public UISprite BTN_BG;

	[Token(Token = "0x6012EC1")]
	[Address(RVA = "0x1A56480", Offset = "0x1A56480", VA = "0x1A56480")]
	public UISettingBloodToggle()
	{
	}

	[Token(Token = "0x6012EC2")]
	[Address(RVA = "0x1A56488", Offset = "0x1A56488", VA = "0x1A56488")]
	private void Awake()
	{
	}

	[Token(Token = "0x6012EC3")]
	[Address(RVA = "0x1A56588", Offset = "0x1A56588", VA = "0x1A56588")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6012EC4")]
	[Address(RVA = "0x1A56A24", Offset = "0x1A56A24", VA = "0x1A56A24")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6012EC5")]
	[Address(RVA = "0x1A56C04", Offset = "0x1A56C04", VA = "0x1A56C04")]
	private void OnValueChange()
	{
	}
}
