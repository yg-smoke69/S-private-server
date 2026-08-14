using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.HUD;

[Token(Token = "0x200277A")]
public class UIHudIdentityController : UIHudNameBaseController, _Attribute
{
	[Token(Token = "0x400F3BE")]
	[FieldOffset(Offset = "0x50")]
	private UIHudIdentityView NOJLDPLOCIH;

	[Token(Token = "0x400F3BF")]
	[FieldOffset(Offset = "0x58")]
	private IHAAMHPPLMG MJCIOGBICHJ;

	[Token(Token = "0x400F3C0")]
	[FieldOffset(Offset = "0x70")]
	private int FPDFPAGFOEI;

	[Token(Token = "0x400F3C1")]
	[FieldOffset(Offset = "0x74")]
	private int IGLLLGOKPPF;

	[Token(Token = "0x400F3C2")]
	[FieldOffset(Offset = "0x78")]
	public bool IsUsing;

	[Token(Token = "0x600F1E7")]
	[Address(RVA = "0x1218464", Offset = "0x1218464", VA = "0x1218464")]
	public UIHudIdentityController()
	{
	}

	[Token(Token = "0x600F1E8")]
	[Address(RVA = "0x1218510", Offset = "0x1218510", VA = "0x1218510")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F1E9")]
	[Address(RVA = "0x1218578", Offset = "0x1218578", VA = "0x1218578", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F1EA")]
	[Address(RVA = "0x1218668", Offset = "0x1218668", VA = "0x1218668", Slot = "32")]
	protected override bool NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600F1EB")]
	[Address(RVA = "0x1218670", Offset = "0x1218670", VA = "0x1218670", Slot = "34")]
	protected override bool NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600F1EC")]
	[Address(RVA = "0x1218678", Offset = "0x1218678", VA = "0x1218678", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F1ED")]
	[Address(RVA = "0x12188BC", Offset = "0x12188BC", VA = "0x12188BC", Slot = "33")]
	protected override bool NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600F1EE")]
	[Address(RVA = "0x1218880", Offset = "0x1218880", VA = "0x1218880")]
	private Vector3 EGGJHFKIALM(Player PJOIFFLCDPM)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F1EF")]
	[Address(RVA = "0x12188C4", Offset = "0x12188C4", VA = "0x12188C4", Slot = "46")]
	public void BindPlayer(IHAAMHPPLMG FKPFJHMFGCJ)
	{
	}

	[Token(Token = "0x600F1F0")]
	[Address(RVA = "0x1218DA0", Offset = "0x1218DA0", VA = "0x1218DA0", Slot = "47")]
	public void UnbindPlayer()
	{
	}

	[Token(Token = "0x600F1F1")]
	[Address(RVA = "0x1218EF0", Offset = "0x1218EF0", VA = "0x1218EF0", Slot = "39")]
	protected override void OnHudOutScreen(OUTSCREEN_DIRCTION_TYPE FOPBFFPMPAL)
	{
	}

	[Token(Token = "0x600F1F2")]
	[Address(RVA = "0x1218AFC", Offset = "0x1218AFC", VA = "0x1218AFC")]
	private void PFMBEAIIACE(int HDNAIPBHNOL)
	{
	}
}
