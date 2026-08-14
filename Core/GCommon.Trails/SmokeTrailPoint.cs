using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails;

[Token(Token = "0x2003EB5")]
public class SmokeTrailPoint : PCTrailPoint
{
	[Token(Token = "0x401A7AB")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 RandomVec;

	[Token(Token = "0x6019812")]
	[Address(RVA = "0x3240D50", Offset = "0x3240D50", VA = "0x3240D50")]
	public SmokeTrailPoint()
	{
	}

	[Token(Token = "0x6019813")]
	[Address(RVA = "0x3240D58", Offset = "0x3240D58", VA = "0x3240D58", Slot = "4")]
	public override void Update(float deltaTime)
	{
	}
}
