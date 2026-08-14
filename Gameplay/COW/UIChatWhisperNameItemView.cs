using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003438")]
public class UIChatWhisperNameItemView : UIBaseView
{
	[Token(Token = "0x4014384")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Btn;

	[Token(Token = "0x4014385")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Delate;

	[Token(Token = "0x4014386")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Highlight;

	[Token(Token = "0x4014387")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HeadPic;

	[Token(Token = "0x4014388")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Name;

	[Token(Token = "0x4014389")]
	[FieldOffset(Offset = "0x28")]
	public UISprite LadderIcon;

	[Token(Token = "0x401438A")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Status;

	[Token(Token = "0x401438B")]
	[FieldOffset(Offset = "0x30")]
	public UINetworkTexture HeadNetPic;

	[Token(Token = "0x401438C")]
	[FieldOffset(Offset = "0x34")]
	public GameObject UnreadTip;

	[Token(Token = "0x401438D")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Icon_Celebrity;

	[Token(Token = "0x601605C")]
	[Address(RVA = "0x20870DC", Offset = "0x20870DC", VA = "0x20870DC")]
	public UIChatWhisperNameItemView()
	{
	}

	[Token(Token = "0x601605D")]
	[Address(RVA = "0x20870E4", Offset = "0x20870E4", VA = "0x20870E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601605E")]
	[Address(RVA = "0x20875C8", Offset = "0x20875C8", VA = "0x20875C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
