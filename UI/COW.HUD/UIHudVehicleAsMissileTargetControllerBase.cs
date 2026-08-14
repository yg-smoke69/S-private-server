using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.HUD;

[Token(Token = "0x20028B1")]
internal class UIHudVehicleAsMissileTargetControllerBase : UIHudVehiclePosControllerBase
{
	[Token(Token = "0x400FA5C")]
	[FieldOffset(Offset = "0x84")]
	protected List<LevelMissileBase> LFONMLHKNIJ;

	[Token(Token = "0x400FA5D")]
	[FieldOffset(Offset = "0x88")]
	protected bool KCIODPJMEFM;

	[Token(Token = "0x600FFD6")]
	[Address(RVA = "0x18F57A8", Offset = "0x18F57A8", VA = "0x18F57A8")]
	public UIHudVehicleAsMissileTargetControllerBase()
	{
	}

	[Token(Token = "0x600FFD7")]
	[Address(RVA = "0x18F583C", Offset = "0x18F583C", VA = "0x18F583C", Slot = "39")]
	protected override void CGJPGICLLMN([Optional] Object KAEHJEGFKBL)
	{
	}

	[Token(Token = "0x600FFD8")]
	[Address(RVA = "0x18F5958", Offset = "0x18F5958", VA = "0x18F5958")]
	internal void OLBHJIKPPPP(LevelMissileBase OGFMNCIGEMB)
	{
	}

	[Token(Token = "0x600FFD9")]
	[Address(RVA = "0x18F5A10", Offset = "0x18F5A10", VA = "0x18F5A10")]
	internal void BBFHJJICGIF(LevelMissileBase OGFMNCIGEMB)
	{
	}

	[Token(Token = "0x600FFDA")]
	[Address(RVA = "0x18F5B1C", Offset = "0x18F5B1C", VA = "0x18F5B1C", Slot = "40")]
	public virtual void SetAsAimTarget(bool KENDCFNPDCE, object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x600FFDB")]
	[Address(RVA = "0x18F5BD8", Offset = "0x18F5BD8", VA = "0x18F5BD8", Slot = "36")]
	public override void RecycleUI()
	{
	}
}
