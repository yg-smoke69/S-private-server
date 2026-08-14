using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002633")]
public class UIGachaContentViewSetting : MonoBehaviour
{
	[Token(Token = "0x400EBD8")]
	[FieldOffset(Offset = "0xC")]
	public Transform DownloadCtrlPos;

	[Token(Token = "0x400EBD9")]
	[FieldOffset(Offset = "0x10")]
	public UIButton AnimationPlayBtn;

	[Token(Token = "0x400EBDA")]
	[FieldOffset(Offset = "0x14")]
	public UISprite AnimationPlayBtnSprite;

	[Token(Token = "0x400EBDB")]
	[FieldOffset(Offset = "0x18")]
	public UIButton CDNChangeBtn;

	[Token(Token = "0x400EBDC")]
	[FieldOffset(Offset = "0x1C")]
	public bool UseCutomizedPrivewUI;

	[Token(Token = "0x400EBDD")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget LeftWidget;

	[Token(Token = "0x400EBDE")]
	[FieldOffset(Offset = "0x24")]
	public UIWidget RightWidget;

	[Token(Token = "0x400EBDF")]
	[FieldOffset(Offset = "0x28")]
	public bool UseCutomizedProperty;

	[Token(Token = "0x600E31F")]
	[Address(RVA = "0x26723B4", Offset = "0x26723B4", VA = "0x26723B4")]
	public UIGachaContentViewSetting()
	{
	}

	[Token(Token = "0x600E320")]
	[Address(RVA = "0x266E850", Offset = "0x266E850", VA = "0x266E850")]
	public void OnInit()
	{
	}

	[Token(Token = "0x600E321")]
	[Address(RVA = "0x26723BC", Offset = "0x26723BC", VA = "0x26723BC")]
	private void OnAnimPlayBtnClick()
	{
	}

	[Token(Token = "0x600E322")]
	[Address(RVA = "0x26724C8", Offset = "0x26724C8", VA = "0x26724C8")]
	private void OnCDNChangeBtnClick()
	{
	}
}
