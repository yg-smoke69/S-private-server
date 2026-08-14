using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000717")]
public class RoundDynamicCollider : MonoBehaviour
{
	[Token(Token = "0x4004C17")]
	[FieldOffset(Offset = "0xC")]
	public List<int> ActiveRoundID;

	[Token(Token = "0x6002CF0")]
	[Address(RVA = "0x316D488", Offset = "0x316D488", VA = "0x316D488")]
	public RoundDynamicCollider()
	{
	}

	[Token(Token = "0x6002CF1")]
	[Address(RVA = "0x316D308", Offset = "0x316D308", VA = "0x316D308")]
	public void OnRoundStart(int roundID)
	{
	}
}
