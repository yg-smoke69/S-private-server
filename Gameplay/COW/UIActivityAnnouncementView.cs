using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033A0")]
public class UIActivityAnnouncementView : UIBaseView
{
	[Token(Token = "0x4013B34")]
	[FieldOffset(Offset = "0x14")]
	public Transform LeftTabContainer;

	[Token(Token = "0x4013B35")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Content;

	[Token(Token = "0x4013B36")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture AD;

	[Token(Token = "0x4013B37")]
	[FieldOffset(Offset = "0x20")]
	public UITable ContentTable;

	[Token(Token = "0x4013B38")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Facebook;

	[Token(Token = "0x4013B39")]
	[FieldOffset(Offset = "0x28")]
	public UIButton Official;

	[Token(Token = "0x4013B3A")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton Ins;

	[Token(Token = "0x4013B3B")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Introduction;

	[Token(Token = "0x4013B3C")]
	[FieldOffset(Offset = "0x34")]
	public UIButton Operation;

	[Token(Token = "0x6015E96")]
	[Address(RVA = "0x2A0637C", Offset = "0x2A0637C", VA = "0x2A0637C")]
	public UIActivityAnnouncementView()
	{
	}

	[Token(Token = "0x6015E97")]
	[Address(RVA = "0x2A06384", Offset = "0x2A06384", VA = "0x2A06384", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E98")]
	[Address(RVA = "0x2A067F8", Offset = "0x2A067F8", VA = "0x2A067F8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
