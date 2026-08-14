using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002370")]
public class SettingTipsCompoment : MonoBehaviour
{
	[Token(Token = "0x400DC9C")]
	[FieldOffset(Offset = "0xC")]
	public UIButton TipsBtn;

	[Token(Token = "0x400DC9D")]
	[FieldOffset(Offset = "0x10")]
	public TIPS_SHOWTYPE TipsType;

	[Token(Token = "0x400DC9E")]
	[FieldOffset(Offset = "0x14")]
	public string WebUrl;

	[Token(Token = "0x400DC9F")]
	[FieldOffset(Offset = "0x18")]
	public string WindowTitle;

	[Token(Token = "0x400DCA0")]
	[FieldOffset(Offset = "0x1C")]
	public string TipsKey;

	[Token(Token = "0x600C614")]
	[Address(RVA = "0x20E27F0", Offset = "0x20E27F0", VA = "0x20E27F0")]
	public SettingTipsCompoment()
	{
	}

	[Token(Token = "0x600C615")]
	[Address(RVA = "0x20E27F8", Offset = "0x20E27F8", VA = "0x20E27F8")]
	public void Awake()
	{
	}

	[Token(Token = "0x600C616")]
	[Address(RVA = "0x20E29C0", Offset = "0x20E29C0", VA = "0x20E29C0")]
	private void OnSettingTipsClick()
	{
	}

	[Token(Token = "0x600C617")]
	[Address(RVA = "0x20E2C3C", Offset = "0x20E2C3C", VA = "0x20E2C3C")]
	private void ShowTips()
	{
	}

	[Token(Token = "0x600C618")]
	[Address(RVA = "0x20E2B08", Offset = "0x20E2B08", VA = "0x20E2B08")]
	private void ShowCDNWindow()
	{
	}
}
