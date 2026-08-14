using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.HUD;

[Token(Token = "0x200273C")]
public class UIHudEnermyPointController : UIHudNameBaseController
{
	[Token(Token = "0x400F224")]
	[FieldOffset(Offset = "0x50")]
	private UIHudEnermyPointView NOJLDPLOCIH;

	[Token(Token = "0x400F225")]
	[FieldOffset(Offset = "0x58")]
	private IHAAMHPPLMG MJCIOGBICHJ;

	[Token(Token = "0x400F226")]
	[FieldOffset(Offset = "0x70")]
	private int FPDFPAGFOEI;

	[Token(Token = "0x400F227")]
	[FieldOffset(Offset = "0x74")]
	private HCIKONFBCDP APMAPMOFJMH;

	[Token(Token = "0x400F228")]
	[FieldOffset(Offset = "0x78")]
	public bool IsUsing;

	[Token(Token = "0x600EF33")]
	[Address(RVA = "0x121577C", Offset = "0x121577C", VA = "0x121577C")]
	public UIHudEnermyPointController()
	{
	}

	[Token(Token = "0x600EF34")]
	[Address(RVA = "0x1215828", Offset = "0x1215828", VA = "0x1215828")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EF35")]
	[Address(RVA = "0x1215890", Offset = "0x1215890", VA = "0x1215890", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EF36")]
	[Address(RVA = "0x1215904", Offset = "0x1215904", VA = "0x1215904")]
	public void BindEnermy(IHAAMHPPLMG FKPFJHMFGCJ, int OGKCBAGNBGP, HCIKONFBCDP MNPBIOJNHME)
	{
	}

	[Token(Token = "0x600EF37")]
	[Address(RVA = "0x1215960", Offset = "0x1215960", VA = "0x1215960")]
	public void UnBindEnermy()
	{
	}

	[Token(Token = "0x600EF38")]
	[Address(RVA = "0x1215A20", Offset = "0x1215A20", VA = "0x1215A20", Slot = "32")]
	protected override bool NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF39")]
	[Address(RVA = "0x1215A28", Offset = "0x1215A28", VA = "0x1215A28", Slot = "34")]
	protected override bool NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF3A")]
	[Address(RVA = "0x12161B4", Offset = "0x12161B4", VA = "0x12161B4", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EF3B")]
	[Address(RVA = "0x12163A0", Offset = "0x12163A0", VA = "0x12163A0")]
	private Vector3 EGGJHFKIALM(Player PJOIFFLCDPM)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EF3C")]
	[Address(RVA = "0x1216584", Offset = "0x1216584", VA = "0x1216584", Slot = "44")]
	protected override bool IsVisibleWithZoneType(int PCKAGGCEKCM)
	{
		return default(bool);
	}
}
