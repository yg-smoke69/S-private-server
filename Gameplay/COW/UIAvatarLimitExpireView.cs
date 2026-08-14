using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033CB")]
public class UIAvatarLimitExpireView : UIBaseView
{
	[Token(Token = "0x4013CE8")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid List;

	[Token(Token = "0x4013CE9")]
	[FieldOffset(Offset = "0x18")]
	public UISprite AvatarHead;

	[Token(Token = "0x4013CEA")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ComfirmBtn;

	[Token(Token = "0x4013CEB")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BtnBG;

	[Token(Token = "0x6015F17")]
	[Address(RVA = "0x2A882D4", Offset = "0x2A882D4", VA = "0x2A882D4")]
	public UIAvatarLimitExpireView()
	{
	}

	[Token(Token = "0x6015F18")]
	[Address(RVA = "0x2A882DC", Offset = "0x2A882DC", VA = "0x2A882DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F19")]
	[Address(RVA = "0x2A885A4", Offset = "0x2A885A4", VA = "0x2A885A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
