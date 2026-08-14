using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200352E")]
public class UIFastSendGiftFriendItemView : UIBaseView
{
	[Token(Token = "0x401500D")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x401500E")]
	[FieldOffset(Offset = "0x18")]
	public UIToggleButton SelectBtn;

	[Token(Token = "0x401500F")]
	[FieldOffset(Offset = "0x1C")]
	public UIEffectSprite bg;

	[Token(Token = "0x4015010")]
	[FieldOffset(Offset = "0x20")]
	public GameObject fakeBg;

	[Token(Token = "0x4015011")]
	[FieldOffset(Offset = "0x24")]
	public UINetworkTexture HeadIcon;

	[Token(Token = "0x4015012")]
	[FieldOffset(Offset = "0x28")]
	public UIEffectSprite HeadSprite;

	[Token(Token = "0x4015013")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject FakeSprite;

	[Token(Token = "0x4015014")]
	[FieldOffset(Offset = "0x30")]
	public UILabel nickname;

	[Token(Token = "0x4015015")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Available;

	[Token(Token = "0x4015016")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Mask;

	[Token(Token = "0x601633A")]
	[Address(RVA = "0x1DBA110", Offset = "0x1DBA110", VA = "0x1DBA110")]
	public UIFastSendGiftFriendItemView()
	{
	}

	[Token(Token = "0x601633B")]
	[Address(RVA = "0x1DBA118", Offset = "0x1DBA118", VA = "0x1DBA118", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601633C")]
	[Address(RVA = "0x1DBA5F0", Offset = "0x1DBA5F0", VA = "0x1DBA5F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
