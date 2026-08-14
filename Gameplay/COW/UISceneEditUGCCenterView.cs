using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200399D")]
public class UISceneEditUGCCenterView : UIBaseView
{
	[Token(Token = "0x4018281")]
	[FieldOffset(Offset = "0x14")]
	public GameObject TransGo;

	[Token(Token = "0x4018282")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnSceneEdit;

	[Token(Token = "0x4018283")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LockSceneEdit;

	[Token(Token = "0x4018284")]
	[FieldOffset(Offset = "0x20")]
	public Transform TabsGo;

	[Token(Token = "0x4018285")]
	[FieldOffset(Offset = "0x24")]
	public UISprite CreateIcon;

	[Token(Token = "0x4018286")]
	[FieldOffset(Offset = "0x28")]
	public UISprite FrontProgress;

	[Token(Token = "0x4018287")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject InfoGo;

	[Token(Token = "0x4018288")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Selected;

	[Token(Token = "0x4018289")]
	[FieldOffset(Offset = "0x34")]
	public GameObject UnSelected;

	[Token(Token = "0x401828A")]
	[FieldOffset(Offset = "0x38")]
	public UIButton UnActiveSceneEdit;

	[Token(Token = "0x401828B")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel ExpLabel;

	[Token(Token = "0x401828C")]
	[FieldOffset(Offset = "0x40")]
	public UILabel UnSelectedLabel;

	[Token(Token = "0x401828D")]
	[FieldOffset(Offset = "0x44")]
	public Transform ProfileProgress;

	[Token(Token = "0x401828E")]
	[FieldOffset(Offset = "0x48")]
	public UIButton ProfileProgressBtn;

	[Token(Token = "0x401828F")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject UIFX_RiseEffect;

	[Token(Token = "0x601707E")]
	[Address(RVA = "0x2DBA408", Offset = "0x2DBA408", VA = "0x2DBA408")]
	public UISceneEditUGCCenterView()
	{
	}

	[Token(Token = "0x601707F")]
	[Address(RVA = "0x2DBA410", Offset = "0x2DBA410", VA = "0x2DBA410", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017080")]
	[Address(RVA = "0x2DBAA60", Offset = "0x2DBAA60", VA = "0x2DBAA60")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
