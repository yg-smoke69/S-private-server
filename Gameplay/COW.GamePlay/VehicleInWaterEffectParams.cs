using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000D24")]
public class VehicleInWaterEffectParams : MonoBehaviour
{
	[Token(Token = "0x4006A6F")]
	[FieldOffset(Offset = "0xC")]
	public UpdateEffectParams[] WaterEffects;

	[Token(Token = "0x600647A")]
	[Address(RVA = "0x26EF9F4", Offset = "0x26EF9F4", VA = "0x26EF9F4")]
	public VehicleInWaterEffectParams()
	{
	}
}
