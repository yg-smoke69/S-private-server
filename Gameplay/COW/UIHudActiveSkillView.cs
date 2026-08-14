using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035C5")]
public class UIHudActiveSkillView : UIBaseView
{
	[Token(Token = "0x4015868")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnActiveSkill;

	[Token(Token = "0x4015869")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BtnSprite;

	[Token(Token = "0x401586A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel CancelLabel;

	[Token(Token = "0x401586B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CDMask;

	[Token(Token = "0x401586C")]
	[FieldOffset(Offset = "0x24")]
	public UISprite CDProgress;

	[Token(Token = "0x401586D")]
	[FieldOffset(Offset = "0x28")]
	public UISprite TakeEffectProgress;

	[Token(Token = "0x401586E")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject PhaseObj;

	[Token(Token = "0x401586F")]
	[FieldOffset(Offset = "0x30")]
	public UISprite PhaseFillProgress;

	[Token(Token = "0x4015870")]
	[FieldOffset(Offset = "0x34")]
	public UILabel PhaseValue;

	[Token(Token = "0x4015871")]
	[FieldOffset(Offset = "0x38")]
	public Transform SkillTakeEffectGo;

	[Token(Token = "0x4015872")]
	[FieldOffset(Offset = "0x3C")]
	public ParticleSystem SkillReadyAgainEffect;

	[Token(Token = "0x4015873")]
	[FieldOffset(Offset = "0x40")]
	public UISprite DisableProgress;

	[Token(Token = "0x4015874")]
	[FieldOffset(Offset = "0x44")]
	public UISprite highLightSprite;

	[Token(Token = "0x4015875")]
	[FieldOffset(Offset = "0x48")]
	public GameObject petSkill;

	[Token(Token = "0x4015876")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject petLv1;

	[Token(Token = "0x4015877")]
	[FieldOffset(Offset = "0x50")]
	public GameObject petLv2;

	[Token(Token = "0x4015878")]
	[FieldOffset(Offset = "0x54")]
	public GameObject petLv3;

	[Token(Token = "0x4015879")]
	[FieldOffset(Offset = "0x58")]
	public GameObject Enhanced;

	[Token(Token = "0x60164FD")]
	[Address(RVA = "0x1702958", Offset = "0x1702958", VA = "0x1702958")]
	public UIHudActiveSkillView()
	{
	}

	[Token(Token = "0x60164FE")]
	[Address(RVA = "0x1702960", Offset = "0x1702960", VA = "0x1702960", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164FF")]
	[Address(RVA = "0x17030EC", Offset = "0x17030EC", VA = "0x17030EC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
