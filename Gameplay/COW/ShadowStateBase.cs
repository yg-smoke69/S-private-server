using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20007FE")]
internal class ShadowStateBase
{
	[Token(Token = "0x400508D")]
	[FieldOffset(Offset = "0x8")]
	public uint TargetTickCount;

	[Token(Token = "0x400508E")]
	[FieldOffset(Offset = "0xC")]
	public uint SimTick;

	[Token(Token = "0x6003320")]
	[Address(RVA = "0x20E4C9C", Offset = "0x20E4C9C", VA = "0x20E4C9C")]
	public ShadowStateBase()
	{
	}

	[Token(Token = "0x6003321")]
	[Address(RVA = "0x20E4CA4", Offset = "0x20E4CA4", VA = "0x20E4CA4")]
	public bool IncreaseSimTick()
	{
		return default(bool);
	}

	[Token(Token = "0x6003322")]
	[Address(RVA = "0x20E4DB8", Offset = "0x20E4DB8", VA = "0x20E4DB8")]
	public float GetDeltaTimeInLerp()
	{
		return default(float);
	}

	[Token(Token = "0x6003323")]
	[Address(RVA = "0x20E4F14", Offset = "0x20E4F14", VA = "0x20E4F14")]
	public float GetLerpRatio()
	{
		return default(float);
	}
}
