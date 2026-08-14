using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.HUD;

[Token(Token = "0x200277B")]
internal class UIHudInfectionHPController : UIHudNameBaseController, _Attribute
{
	[Token(Token = "0x400F3C3")]
	[FieldOffset(Offset = "0x50")]
	private UIHudInfectionHPView NOJLDPLOCIH;

	[Token(Token = "0x400F3C4")]
	[FieldOffset(Offset = "0x58")]
	private IHAAMHPPLMG MJCIOGBICHJ;

	[Token(Token = "0x400F3C5")]
	[FieldOffset(Offset = "0x70")]
	private float IIAFHNGIIMH;

	[Token(Token = "0x600F1F3")]
	[Address(RVA = "0x12191E4", Offset = "0x12191E4", VA = "0x12191E4")]
	public UIHudInfectionHPController()
	{
	}

	[Token(Token = "0x600F1F4")]
	[Address(RVA = "0x12192E0", Offset = "0x12192E0", VA = "0x12192E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F1F5")]
	[Address(RVA = "0x1219348", Offset = "0x1219348", VA = "0x1219348", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F1F6")]
	[Address(RVA = "0x12194B8", Offset = "0x12194B8", VA = "0x12194B8", Slot = "32")]
	protected override bool NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600F1F7")]
	[Address(RVA = "0x12194C0", Offset = "0x12194C0", VA = "0x12194C0", Slot = "34")]
	protected override bool NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600F1F8")]
	[Address(RVA = "0x12194C8", Offset = "0x12194C8", VA = "0x12194C8", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F1F9")]
	[Address(RVA = "0x121970C", Offset = "0x121970C", VA = "0x121970C", Slot = "33")]
	protected override bool NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600F1FA")]
	[Address(RVA = "0x12196D0", Offset = "0x12196D0", VA = "0x12196D0")]
	private Vector3 EGGJHFKIALM(Player PJOIFFLCDPM)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F1FB")]
	[Address(RVA = "0x1219714", Offset = "0x1219714", VA = "0x1219714", Slot = "46")]
	public void BindPlayer(IHAAMHPPLMG FKPFJHMFGCJ)
	{
	}

	[Token(Token = "0x600F1FC")]
	[Address(RVA = "0x1219A54", Offset = "0x1219A54", VA = "0x1219A54", Slot = "47")]
	public void UnbindPlayer()
	{
	}

	[Token(Token = "0x600F1FD")]
	[Address(RVA = "0x1219B9C", Offset = "0x1219B9C", VA = "0x1219B9C")]
	public void OnHpChanged(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600F1FE")]
	[Address(RVA = "0x121A3F4", Offset = "0x121A3F4", VA = "0x121A3F4")]
	private void Update()
	{
	}
}
