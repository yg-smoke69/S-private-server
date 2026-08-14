using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035A8")]
public class UIGameModeMapPickItemView : UIBaseView
{
	[Token(Token = "0x40156CA")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnPick;

	[Token(Token = "0x40156CB")]
	[FieldOffset(Offset = "0x18")]
	public Object SpriteBg;

	[Token(Token = "0x40156CC")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelName;

	[Token(Token = "0x40156CD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GoPick;

	[Token(Token = "0x40156CE")]
	[FieldOffset(Offset = "0x24")]
	public Transform RootDownloader;

	[Token(Token = "0x40156CF")]
	[FieldOffset(Offset = "0x28")]
	public GameObject GoTimeLimit;

	[Token(Token = "0x40156D0")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LabelTimeLimitTop;

	[Token(Token = "0x40156D1")]
	[FieldOffset(Offset = "0x30")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x40156D2")]
	[FieldOffset(Offset = "0x34")]
	public GameObject GoLock;

	[Token(Token = "0x60164A6")]
	[Address(RVA = "0x2189794", Offset = "0x2189794", VA = "0x2189794")]
	public UIGameModeMapPickItemView()
	{
	}

	[Token(Token = "0x60164A7")]
	[Address(RVA = "0x218979C", Offset = "0x218979C", VA = "0x218979C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164A8")]
	[Address(RVA = "0x2189BF8", Offset = "0x2189BF8", VA = "0x2189BF8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
