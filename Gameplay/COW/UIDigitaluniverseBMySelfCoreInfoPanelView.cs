using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034D7")]
public class UIDigitaluniverseBMySelfCoreInfoPanelView : UIBaseView
{
	[Token(Token = "0x4014BF1")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ThumbLabel;

	[Token(Token = "0x4014BF2")]
	[FieldOffset(Offset = "0x18")]
	public UISprite HeadIcon;

	[Token(Token = "0x4014BF3")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel PlayerName;

	[Token(Token = "0x4014BF4")]
	[FieldOffset(Offset = "0x20")]
	public UILabel AssistNum;

	[Token(Token = "0x4014BF5")]
	[FieldOffset(Offset = "0x24")]
	public UIInput InputSignWord;

	[Token(Token = "0x4014BF6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Content;

	[Token(Token = "0x4014BF7")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton MaskBtn;

	[Token(Token = "0x6016237")]
	[Address(RVA = "0x2F81708", Offset = "0x2F81708", VA = "0x2F81708")]
	public UIDigitaluniverseBMySelfCoreInfoPanelView()
	{
	}

	[Token(Token = "0x6016238")]
	[Address(RVA = "0x2F81710", Offset = "0x2F81710", VA = "0x2F81710", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016239")]
	[Address(RVA = "0x2F81AEC", Offset = "0x2F81AEC", VA = "0x2F81AEC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
