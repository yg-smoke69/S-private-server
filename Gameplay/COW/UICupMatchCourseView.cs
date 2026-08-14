using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003495")]
public class UICupMatchCourseView : UIBaseView
{
	[Token(Token = "0x401480B")]
	[FieldOffset(Offset = "0x14")]
	public Animator UICupMatchCourse;

	[Token(Token = "0x401480C")]
	[FieldOffset(Offset = "0x18")]
	public Transform Course1;

	[Token(Token = "0x401480D")]
	[FieldOffset(Offset = "0x1C")]
	public Transform Course2;

	[Token(Token = "0x401480E")]
	[FieldOffset(Offset = "0x20")]
	public Transform Course3;

	[Token(Token = "0x401480F")]
	[FieldOffset(Offset = "0x24")]
	public Transform Course4;

	[Token(Token = "0x4014810")]
	[FieldOffset(Offset = "0x28")]
	public Transform Course5;

	[Token(Token = "0x4014811")]
	[FieldOffset(Offset = "0x2C")]
	public Transform Course6;

	[Token(Token = "0x4014812")]
	[FieldOffset(Offset = "0x30")]
	public Transform Course7;

	[Token(Token = "0x4014813")]
	[FieldOffset(Offset = "0x34")]
	public Transform Course8;

	[Token(Token = "0x4014814")]
	[FieldOffset(Offset = "0x38")]
	public Transform Course9;

	[Token(Token = "0x4014815")]
	[FieldOffset(Offset = "0x3C")]
	public Transform Course10;

	[Token(Token = "0x4014816")]
	[FieldOffset(Offset = "0x40")]
	public Transform Course11;

	[Token(Token = "0x4014817")]
	[FieldOffset(Offset = "0x44")]
	public Transform Course12;

	[Token(Token = "0x4014818")]
	[FieldOffset(Offset = "0x48")]
	public Transform Course13;

	[Token(Token = "0x4014819")]
	[FieldOffset(Offset = "0x4C")]
	public Transform Course14;

	[Token(Token = "0x401481A")]
	[FieldOffset(Offset = "0x50")]
	public Transform Course15;

	[Token(Token = "0x401481B")]
	[FieldOffset(Offset = "0x54")]
	public UISprite ChampionTeamIcon;

	[Token(Token = "0x401481C")]
	[FieldOffset(Offset = "0x58")]
	public UILabel ChampionTeamName;

	[Token(Token = "0x401481D")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject ChampionInfo;

	[Token(Token = "0x401481E")]
	[FieldOffset(Offset = "0x60")]
	public CupMatchCourseItem CourseTemplete;

	[Token(Token = "0x401481F")]
	[FieldOffset(Offset = "0x64")]
	public UINetworkTexture CupMatchIcon;

	[Token(Token = "0x4014820")]
	[FieldOffset(Offset = "0x68")]
	public GameObject DefaultIcon;

	[Token(Token = "0x4014821")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject Line1;

	[Token(Token = "0x4014822")]
	[FieldOffset(Offset = "0x70")]
	public GameObject Line2;

	[Token(Token = "0x4014823")]
	[FieldOffset(Offset = "0x74")]
	public GameObject Line3;

	[Token(Token = "0x4014824")]
	[FieldOffset(Offset = "0x78")]
	public GameObject VFX_once;

	[Token(Token = "0x6016173")]
	[Address(RVA = "0x274D8B4", Offset = "0x274D8B4", VA = "0x274D8B4")]
	public UICupMatchCourseView()
	{
	}

	[Token(Token = "0x6016174")]
	[Address(RVA = "0x274D8BC", Offset = "0x274D8BC", VA = "0x274D8BC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016175")]
	[Address(RVA = "0x274E124", Offset = "0x274E124", VA = "0x274E124")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
