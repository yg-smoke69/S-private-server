using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200378A")]
public class UIHudTutorialTargetGuideView : UIBaseView
{
	[Token(Token = "0x401680D")]
	[FieldOffset(Offset = "0x14")]
	public UISprite TargetBG;

	[Token(Token = "0x401680E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TargetLabel;

	[Token(Token = "0x401680F")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel DistanceLabel;

	[Token(Token = "0x4016810")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GoMark;

	[Token(Token = "0x4016811")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GoArrow;

	[Token(Token = "0x4016812")]
	[FieldOffset(Offset = "0x28")]
	public GameObject GoMarkPos;

	[Token(Token = "0x4016813")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Target;

	[Token(Token = "0x4016814")]
	[FieldOffset(Offset = "0x30")]
	public UILabel EnemyLabel;

	[Token(Token = "0x4016815")]
	[FieldOffset(Offset = "0x34")]
	public UISprite EnemyBG;

	[Token(Token = "0x4016816")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Distance;

	[Token(Token = "0x4016817")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Enemy;

	[Token(Token = "0x6016A49")]
	[Address(RVA = "0x1592F08", Offset = "0x1592F08", VA = "0x1592F08")]
	public UIHudTutorialTargetGuideView()
	{
	}

	[Token(Token = "0x6016A4A")]
	[Address(RVA = "0x1592F10", Offset = "0x1592F10", VA = "0x1592F10", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A4B")]
	[Address(RVA = "0x1593430", Offset = "0x1593430", VA = "0x1593430")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
