using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033B9")]
public class UIActivityStandardView : UIBaseView
{
	[Token(Token = "0x4013C14")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4013C15")]
	[FieldOffset(Offset = "0x18")]
	public Transform LeftTabContainer;

	[Token(Token = "0x4013C16")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Pivot;

	[Token(Token = "0x4013C17")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ThirdTogglesRoot;

	[Token(Token = "0x4013C18")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButtonGroup ThirdTogglesGroup;

	[Token(Token = "0x4013C19")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButton ThirdTogglePrefab;

	[Token(Token = "0x4013C1A")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject IntroPanelAnimationObj;

	[Token(Token = "0x4013C1B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject IntroBG;

	[Token(Token = "0x4013C1C")]
	[FieldOffset(Offset = "0x34")]
	public UITable IntroRoot;

	[Token(Token = "0x4013C1D")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Introduction;

	[Token(Token = "0x4013C1E")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Time;

	[Token(Token = "0x4013C1F")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Progress;

	[Token(Token = "0x4013C20")]
	[FieldOffset(Offset = "0x44")]
	public UILabel ProgressNum;

	[Token(Token = "0x4013C21")]
	[FieldOffset(Offset = "0x48")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x4013C22")]
	[FieldOffset(Offset = "0x4C")]
	public Transform StandardItemCenter;

	[Token(Token = "0x4013C23")]
	[FieldOffset(Offset = "0x50")]
	public Transform EventGroupRoot;

	[Token(Token = "0x4013C24")]
	[FieldOffset(Offset = "0x54")]
	public UINetworkTexture ADMini;

	[Token(Token = "0x4013C25")]
	[FieldOffset(Offset = "0x58")]
	public GameObject Content;

	[Token(Token = "0x6015EE1")]
	[Address(RVA = "0x1F2877C", Offset = "0x1F2877C", VA = "0x1F2877C")]
	public UIActivityStandardView()
	{
	}

	[Token(Token = "0x6015EE2")]
	[Address(RVA = "0x1F28784", Offset = "0x1F28784", VA = "0x1F28784", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EE3")]
	[Address(RVA = "0x1F28ECC", Offset = "0x1F28ECC", VA = "0x1F28ECC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
