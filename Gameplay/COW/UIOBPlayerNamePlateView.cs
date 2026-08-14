using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038DA")]
public class UIOBPlayerNamePlateView : UIBaseView
{
	[Token(Token = "0x4017942")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Widget;

	[Token(Token = "0x4017943")]
	[FieldOffset(Offset = "0x18")]
	public Transform ArrowContainer;

	[Token(Token = "0x4017944")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite playerArrowPeek;

	[Token(Token = "0x4017945")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SelectedDirection;

	[Token(Token = "0x4017946")]
	[FieldOffset(Offset = "0x24")]
	public UISprite PlayerArrow;

	[Token(Token = "0x4017947")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget FireIcon;

	[Token(Token = "0x4017948")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite OutLight;

	[Token(Token = "0x4017949")]
	[FieldOffset(Offset = "0x30")]
	public GameObject IndexLabelRot;

	[Token(Token = "0x401794A")]
	[FieldOffset(Offset = "0x34")]
	public UISprite KnockDownIcon;

	[Token(Token = "0x401794B")]
	[FieldOffset(Offset = "0x38")]
	public UISprite DeadIcon;

	[Token(Token = "0x401794C")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget HurtWave;

	[Token(Token = "0x401794D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel IndexLabel;

	[Token(Token = "0x401794E")]
	[FieldOffset(Offset = "0x44")]
	public UIWidget HurtIcon;

	[Token(Token = "0x401794F")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget KokGo;

	[Token(Token = "0x4017950")]
	[FieldOffset(Offset = "0x4C")]
	public UIWidget TeamIconGo;

	[Token(Token = "0x4017951")]
	[FieldOffset(Offset = "0x50")]
	public UIEffectSprite TeamIcon;

	[Token(Token = "0x4017952")]
	[FieldOffset(Offset = "0x54")]
	public UISprite TeamFakeIcon;

	[Token(Token = "0x4017953")]
	[FieldOffset(Offset = "0x58")]
	public GameObject NamePlateRot;

	[Token(Token = "0x4017954")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite NamePlateBG;

	[Token(Token = "0x4017955")]
	[FieldOffset(Offset = "0x60")]
	public UILabel NameLabel;

	[Token(Token = "0x4017956")]
	[FieldOffset(Offset = "0x64")]
	public UISprite FiringRay;

	[Token(Token = "0x4017957")]
	[FieldOffset(Offset = "0x68")]
	public UIButton GotoBtn;

	[Token(Token = "0x6016E37")]
	[Address(RVA = "0x159C5C0", Offset = "0x159C5C0", VA = "0x159C5C0")]
	public UIOBPlayerNamePlateView()
	{
	}

	[Token(Token = "0x6016E38")]
	[Address(RVA = "0x159C5C8", Offset = "0x159C5C8", VA = "0x159C5C8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E39")]
	[Address(RVA = "0x159CD70", Offset = "0x159CD70", VA = "0x159CD70")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
