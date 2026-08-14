using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200366F")]
public class UIHudHumanlikeTargetDamageResultView : UIBaseView
{
	[Token(Token = "0x4015D8A")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnSwitch;

	[Token(Token = "0x4015D8B")]
	[FieldOffset(Offset = "0x18")]
	public UIButton FoldBtn;

	[Token(Token = "0x4015D8C")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Setting;

	[Token(Token = "0x4015D8D")]
	[FieldOffset(Offset = "0x20")]
	public UIButton CleanDataBtn;

	[Token(Token = "0x4015D8E")]
	[FieldOffset(Offset = "0x24")]
	public UILabel DPSVal;

	[Token(Token = "0x4015D8F")]
	[FieldOffset(Offset = "0x28")]
	public UILabel RealDamageVal;

	[Token(Token = "0x4015D90")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel ShieldVal;

	[Token(Token = "0x4015D91")]
	[FieldOffset(Offset = "0x30")]
	public UILabel HeadShotVal;

	[Token(Token = "0x4015D92")]
	[FieldOffset(Offset = "0x34")]
	public UILabel BodyShotVal;

	[Token(Token = "0x4015D93")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LimbShotVal;

	[Token(Token = "0x4015D94")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Config;

	[Token(Token = "0x60166FA")]
	[Address(RVA = "0x1340BC4", Offset = "0x1340BC4", VA = "0x1340BC4")]
	public UIHudHumanlikeTargetDamageResultView()
	{
	}

	[Token(Token = "0x60166FB")]
	[Address(RVA = "0x1340BCC", Offset = "0x1340BCC", VA = "0x1340BCC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166FC")]
	[Address(RVA = "0x134111C", Offset = "0x134111C", VA = "0x134111C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
