using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036C0")]
public class UIHudNameView : UIBaseView
{
	[Token(Token = "0x4016103")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x4016104")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ContainerWidget;

	[Token(Token = "0x4016105")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Name;

	[Token(Token = "0x4016106")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GoName;

	[Token(Token = "0x4016107")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Effect_Glow;

	[Token(Token = "0x4016108")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ArrowUp;

	[Token(Token = "0x4016109")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ArrowUpLight;

	[Token(Token = "0x401610A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ArrowLeft;

	[Token(Token = "0x401610B")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ArrowLeftLight;

	[Token(Token = "0x401610C")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ArrowRight;

	[Token(Token = "0x401610D")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite ArrowRightSprite;

	[Token(Token = "0x401610E")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ArrowRightLight;

	[Token(Token = "0x401610F")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ArrowDown;

	[Token(Token = "0x4016110")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ArrowDownLight;

	[Token(Token = "0x4016111")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject AdditiveInfo;

	[Token(Token = "0x4016112")]
	[FieldOffset(Offset = "0x50")]
	public UISprite AdditiveIcon;

	[Token(Token = "0x4016113")]
	[FieldOffset(Offset = "0x54")]
	public UILabel AdditiveLabel;

	[Token(Token = "0x4016114")]
	[FieldOffset(Offset = "0x58")]
	public UILabel TeammateDistance;

	[Token(Token = "0x4016115")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite DistanceBG;

	[Token(Token = "0x4016116")]
	[FieldOffset(Offset = "0x60")]
	public Transform EventTriggerMarkPos;

	[Token(Token = "0x4016117")]
	[FieldOffset(Offset = "0x64")]
	public UIWidget WidgetEventTriggerMark;

	[Token(Token = "0x4016118")]
	[FieldOffset(Offset = "0x68")]
	public GameObject PlayerIndex;

	[Token(Token = "0x4016119")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite PlayerIndexIcon;

	[Token(Token = "0x401611A")]
	[FieldOffset(Offset = "0x70")]
	public UILabel PlayerIndexLabel;

	[Token(Token = "0x401611B")]
	[FieldOffset(Offset = "0x74")]
	public UIGrid leftArrowGrid;

	[Token(Token = "0x401611C")]
	[FieldOffset(Offset = "0x78")]
	public UIWidget leftArrowWidget;

	[Token(Token = "0x401611D")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject HealGunIcon;

	[Token(Token = "0x401611E")]
	[FieldOffset(Offset = "0x80")]
	public UIWidget Pivot;

	[Token(Token = "0x401611F")]
	[FieldOffset(Offset = "0x84")]
	public GameObject identityContainer;

	[Token(Token = "0x4016120")]
	[FieldOffset(Offset = "0x88")]
	public UILabel NameLbl;

	[Token(Token = "0x4016121")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject ReplayName;

	[Token(Token = "0x4016122")]
	[FieldOffset(Offset = "0x90")]
	public UILabel TeamId;

	[Token(Token = "0x4016123")]
	[FieldOffset(Offset = "0x94")]
	public UISprite Hpbarfg;

	[Token(Token = "0x4016124")]
	[FieldOffset(Offset = "0x98")]
	public UIProgressBar HPProgressBar;

	[Token(Token = "0x4016125")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite Hpbarbg;

	[Token(Token = "0x4016126")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject NormalName;

	[Token(Token = "0x4016127")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject SelfSprite;

	[Token(Token = "0x60167ED")]
	[Address(RVA = "0x1F52774", Offset = "0x1F52774", VA = "0x1F52774")]
	public UIHudNameView()
	{
	}

	[Token(Token = "0x60167EE")]
	[Address(RVA = "0x1F5277C", Offset = "0x1F5277C", VA = "0x1F5277C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167EF")]
	[Address(RVA = "0x1F535A4", Offset = "0x1F535A4", VA = "0x1F535A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
