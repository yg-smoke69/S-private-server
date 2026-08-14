using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005BE")]
public class EnergyStoneBoxSpawnPoints : MonoBehaviour
{
	[Token(Token = "0x40043B5")]
	[FieldOffset(Offset = "0xC")]
	public int TeamIndex;

	[Token(Token = "0x40043B6")]
	[FieldOffset(Offset = "0x10")]
	public Transform[] EnergyStoneBoxList;

	[Token(Token = "0x60022DA")]
	[Address(RVA = "0x32081BC", Offset = "0x32081BC", VA = "0x32081BC")]
	public EnergyStoneBoxSpawnPoints()
	{
	}
}
