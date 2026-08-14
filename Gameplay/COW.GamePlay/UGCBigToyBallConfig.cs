using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200072E")]
public class UGCBigToyBallConfig : MonoBehaviour
{
	[Token(Token = "0x4004C7D")]
	[FieldOffset(Offset = "0xC")]
	public float MoveRangeRadius;

	[Token(Token = "0x4004C7E")]
	[FieldOffset(Offset = "0x10")]
	public float PlayerTriggerRadius;

	[Token(Token = "0x6002D89")]
	[Address(RVA = "0x1385000", Offset = "0x1385000", VA = "0x1385000")]
	public UGCBigToyBallConfig()
	{
	}
}
