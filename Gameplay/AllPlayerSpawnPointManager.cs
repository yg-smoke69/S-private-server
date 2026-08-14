using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200073B")]
public class AllPlayerSpawnPointManager : MonoBehaviour
{
	[Token(Token = "0x4004CB8")]
	[FieldOffset(Offset = "0xC")]
	public List<Transform> pointList;

	[Token(Token = "0x6002DB6")]
	[Address(RVA = "0x2EC3934", Offset = "0x2EC3934", VA = "0x2EC3934")]
	public AllPlayerSpawnPointManager()
	{
	}

	[Token(Token = "0x6002DB7")]
	[Address(RVA = "0x2EC39C0", Offset = "0x2EC39C0", VA = "0x2EC39C0")]
	public void RefreshPoint()
	{
	}
}
