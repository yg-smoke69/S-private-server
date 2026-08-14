using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000D10")]
internal class VehicleCollideComponent : MonoBehaviour
{
	[Token(Token = "0x4006A0A")]
	[FieldOffset(Offset = "0xC")]
	public Vehicle owner;

	[Token(Token = "0x6006444")]
	[Address(RVA = "0x26E5EE8", Offset = "0x26E5EE8", VA = "0x26E5EE8")]
	public VehicleCollideComponent()
	{
	}
}
