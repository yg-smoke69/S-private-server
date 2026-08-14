using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033A3")]
public class UIActivityContentAnnouncementView : UIBaseView
{
	[Token(Token = "0x4013B63")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture AD;

	[Token(Token = "0x4013B64")]
	[FieldOffset(Offset = "0x18")]
	public UITable ContentTable;

	[Token(Token = "0x4013B65")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton Facebook;

	[Token(Token = "0x4013B66")]
	[FieldOffset(Offset = "0x20")]
	public UIButton Official;

	[Token(Token = "0x4013B67")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Introduction;

	[Token(Token = "0x4013B68")]
	[FieldOffset(Offset = "0x28")]
	public UIButton Operation;

	[Token(Token = "0x4013B69")]
	[FieldOffset(Offset = "0x2C")]
	public Animation ButtonAnimation;

	[Token(Token = "0x6015E9F")]
	[Address(RVA = "0x2A0E058", Offset = "0x2A0E058", VA = "0x2A0E058")]
	public UIActivityContentAnnouncementView()
	{
	}

	[Token(Token = "0x6015EA0")]
	[Address(RVA = "0x2A0E060", Offset = "0x2A0E060", VA = "0x2A0E060", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EA1")]
	[Address(RVA = "0x2A0E448", Offset = "0x2A0E448", VA = "0x2A0E448")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
