using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000601")]
public class LevelConveyer : BaseLevelObject
{
	[Token(Token = "0x400453B")]
	[FieldOffset(Offset = "0x74")]
	public List<Transform> PatrolPoints;

	[Token(Token = "0x400453C")]
	[FieldOffset(Offset = "0x78")]
	public LevelMotionPlatform[] PlatformArray;

	[Token(Token = "0x400453D")]
	[FieldOffset(Offset = "0x7C")]
	public float UpdateInterval;

	[Token(Token = "0x400453E")]
	[FieldOffset(Offset = "0x80")]
	protected float AEMKFNJOMLB;

	[Token(Token = "0x400453F")]
	[FieldOffset(Offset = "0x84")]
	protected int NPIBKLDJNPA;

	[Token(Token = "0x4004540")]
	[FieldOffset(Offset = "0x88")]
	private bool OHIPGHDPDEG;

	[Token(Token = "0x60024E5")]
	[Address(RVA = "0x2392250", Offset = "0x2392250", VA = "0x2392250")]
	public LevelConveyer()
	{
	}

	[Token(Token = "0x60024E6")]
	[Address(RVA = "0x2392260", Offset = "0x2392260", VA = "0x2392260", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60024E7")]
	[Address(RVA = "0x2392304", Offset = "0x2392304", VA = "0x2392304", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60024E8")]
	[Address(RVA = "0x23924F0", Offset = "0x23924F0", VA = "0x23924F0")]
	private void OnApplicationPause(bool IEHLJGPHGLM)
	{
	}

	[Token(Token = "0x60024E9")]
	[Address(RVA = "0x2392554", Offset = "0x2392554", VA = "0x2392554")]
	public bool CheckServerTickInitState(float EAHHJDBOCLH)
	{
		return default(bool);
	}

	[Token(Token = "0x60024EA")]
	[Address(RVA = "0x2392A30", Offset = "0x2392A30", VA = "0x2392A30")]
	private void FDLHBNKAFLP()
	{
	}

	[Token(Token = "0x60024EB")]
	[Address(RVA = "0x2392C04", Offset = "0x2392C04", VA = "0x2392C04", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60024EC")]
	[Address(RVA = "0x2392CAC", Offset = "0x2392CAC", VA = "0x2392CAC")]
	public void UpdateMovement()
	{
	}

	[Token(Token = "0x60024ED")]
	[Address(RVA = "0x23929B0", Offset = "0x23929B0", VA = "0x23929B0")]
	public int GetRightPosIndex(int KEBCBEKEPEE, int EOLLFBFELFB)
	{
		return default(int);
	}

	[Token(Token = "0x60024EE")]
	[Address(RVA = "0x2393060", Offset = "0x2393060", VA = "0x2393060")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x60024EF")]
	[Address(RVA = "0x2393068", Offset = "0x2393068", VA = "0x2393068")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
