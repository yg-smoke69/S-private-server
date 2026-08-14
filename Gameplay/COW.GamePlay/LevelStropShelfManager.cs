using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006A6")]
public class LevelStropShelfManager : MonoBehaviour
{
	[Token(Token = "0x40048F2")]
	[FieldOffset(Offset = "0x0")]
	private static LevelStropShelfManager HDMPBIPMLGP;

	[Token(Token = "0x40048F3")]
	[FieldOffset(Offset = "0xC")]
	public Dictionary<int, LevelStropShelf> StropShelfs;

	[Token(Token = "0x40048F4")]
	[FieldOffset(Offset = "0x10")]
	public List<LevelStrop> Strops;

	[Token(Token = "0x17000345")]
	public static LevelStropShelfManager GAHBKGJAHPJ
	{
		[Token(Token = "0x6002AB5")]
		[Address(RVA = "0x20D48E8", Offset = "0x20D48E8", VA = "0x20D48E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002AB4")]
	[Address(RVA = "0x20D4828", Offset = "0x20D4828", VA = "0x20D4828")]
	public LevelStropShelfManager()
	{
	}

	[Token(Token = "0x6002AB6")]
	[Address(RVA = "0x20D49B8", Offset = "0x20D49B8", VA = "0x20D49B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002AB7")]
	[Address(RVA = "0x20D4C80", Offset = "0x20D4C80", VA = "0x20D4C80")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002AB8")]
	[Address(RVA = "0x20D4D5C", Offset = "0x20D4D5C", VA = "0x20D4D5C")]
	public static void AssignStropShelfID(LevelStropShelfManager GCMJDPIGBOL)
	{
	}
}
