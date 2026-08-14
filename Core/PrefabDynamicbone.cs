using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007EF")]
public class PrefabDynamicbone : MonoBehaviour
{
	[Token(Token = "0x4005014")]
	[FieldOffset(Offset = "0xC")]
	public List<DynamicBonePair> dynamicbonepairs;

	[Token(Token = "0x4005015")]
	[FieldOffset(Offset = "0x10")]
	public List<FluxPair> fluxpairs;

	[Token(Token = "0x6003217")]
	[Address(RVA = "0x1E2883C", Offset = "0x1E2883C", VA = "0x1E2883C")]
	public PrefabDynamicbone()
	{
	}

	[Token(Token = "0x6003218")]
	[Address(RVA = "0x1E28844", Offset = "0x1E28844", VA = "0x1E28844")]
	private void Start()
	{
	}
}
