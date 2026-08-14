using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003429")]
public class UIChannelItemView : UIBaseView
{
	[Token(Token = "0x40142C7")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ClickButton;

	[Token(Token = "0x40142C8")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Tips;

	[Token(Token = "0x40142C9")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Selected;

	[Token(Token = "0x40142CA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ChannelName;

	[Token(Token = "0x40142CB")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Title;

	[Token(Token = "0x40142CC")]
	[FieldOffset(Offset = "0x28")]
	public GameObject WhisperName;

	[Token(Token = "0x40142CD")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Head;

	[Token(Token = "0x40142CE")]
	[FieldOffset(Offset = "0x30")]
	public UILabel UserName;

	[Token(Token = "0x40142CF")]
	[FieldOffset(Offset = "0x34")]
	public GameObject OnlineHint;

	[Token(Token = "0x40142D0")]
	[FieldOffset(Offset = "0x38")]
	public GameObject IngameHint;

	[Token(Token = "0x40142D1")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject OfflineHint;

	[Token(Token = "0x601602F")]
	[Address(RVA = "0x262AEC4", Offset = "0x262AEC4", VA = "0x262AEC4")]
	public UIChannelItemView()
	{
	}

	[Token(Token = "0x6016030")]
	[Address(RVA = "0x262AECC", Offset = "0x262AECC", VA = "0x262AECC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016031")]
	[Address(RVA = "0x262B3E0", Offset = "0x262B3E0", VA = "0x262B3E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
