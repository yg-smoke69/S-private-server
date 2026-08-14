using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.HUD;

[Token(Token = "0x20027A6")]
public class UIHudLockedWarningController : UIBaseController
{
	[Token(Token = "0x400F4C5")]
	[FieldOffset(Offset = "0x28")]
	private UIHudLockedWarningView NOJLDPLOCIH;

	[Token(Token = "0x400F4C6")]
	[FieldOffset(Offset = "0x2C")]
	private List<LevelMissileBase> LFONMLHKNIJ;

	[Token(Token = "0x400F4C7")]
	private const float DCFJJKMFOJE = 30f;

	[Token(Token = "0x400F4C8")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<LevelMissileBase, GameObject> AMKFKPCANPH;

	[Token(Token = "0x400F4C9")]
	[FieldOffset(Offset = "0x34")]
	private AEPAPLNNAHF BLLCHBHMCFE;

	[Token(Token = "0x600F487")]
	[Address(RVA = "0x121C0C8", Offset = "0x121C0C8", VA = "0x121C0C8")]
	public UIHudLockedWarningController()
	{
	}

	[Token(Token = "0x600F488")]
	[Address(RVA = "0x121C180", Offset = "0x121C180", VA = "0x121C180")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F489")]
	[Address(RVA = "0x121C1E4", Offset = "0x121C1E4", VA = "0x121C1E4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F48A")]
	[Address(RVA = "0x121C258", Offset = "0x121C258", VA = "0x121C258", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F48B")]
	[Address(RVA = "0x121C284", Offset = "0x121C284", VA = "0x121C284", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600F48C")]
	[Address(RVA = "0x121C4E4", Offset = "0x121C4E4", VA = "0x121C4E4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F48D")]
	[Address(RVA = "0x121C504", Offset = "0x121C504", VA = "0x121C504")]
	internal void OLBHJIKPPPP(LevelMissileBase OGFMNCIGEMB)
	{
	}

	[Token(Token = "0x600F48E")]
	[Address(RVA = "0x121C6A0", Offset = "0x121C6A0", VA = "0x121C6A0")]
	internal void BBFHJJICGIF(LevelMissileBase OGFMNCIGEMB)
	{
	}

	[Token(Token = "0x600F48F")]
	[Address(RVA = "0x121C908", Offset = "0x121C908", VA = "0x121C908")]
	private void LAJLCKOEKFO()
	{
	}

	[Token(Token = "0x600F490")]
	[Address(RVA = "0x121C9A4", Offset = "0x121C9A4", VA = "0x121C9A4")]
	private void Update()
	{
	}

	[Token(Token = "0x600F491")]
	[Address(RVA = "0x121CE20", Offset = "0x121CE20", VA = "0x121CE20")]
	private void HCAGAACNOEN(Entity FFDHFKIMFDG, LevelMissileBase OGFMNCIGEMB)
	{
	}

	[Token(Token = "0x600F492")]
	[Address(RVA = "0x121C7A0", Offset = "0x121C7A0", VA = "0x121C7A0")]
	private void EBLBAGFOEBH(LevelMissileBase OGFMNCIGEMB)
	{
	}

	[Token(Token = "0x600F493")]
	[Address(RVA = "0x121C2A4", Offset = "0x121C2A4", VA = "0x121C2A4")]
	private void GJLGNLPJCKH()
	{
	}
}
