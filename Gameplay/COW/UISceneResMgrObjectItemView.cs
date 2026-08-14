using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039A2")]
public class UISceneResMgrObjectItemView : UIBaseView
{
	[Token(Token = "0x40182B7")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Name;

	[Token(Token = "0x40182B8")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ItemBtn;

	[Token(Token = "0x40182B9")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject HighLight;

	[Token(Token = "0x40182BA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ScriptedIcon;

	[Token(Token = "0x601708D")]
	[Address(RVA = "0x1A422E0", Offset = "0x1A422E0", VA = "0x1A422E0")]
	public UISceneResMgrObjectItemView()
	{
	}

	[Token(Token = "0x601708E")]
	[Address(RVA = "0x1A422E8", Offset = "0x1A422E8", VA = "0x1A422E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601708F")]
	[Address(RVA = "0x1A42598", Offset = "0x1A42598", VA = "0x1A42598")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
