using System.Collections.Generic;
using Il2CppDummyDll;
using UMA;

[Token(Token = "0x2003C95")]
public class RaceLibrary : RaceLibraryBase
{
	[Token(Token = "0x4019C1C")]
	[FieldOffset(Offset = "0xC")]
	protected RaceData[] raceElementList;

	[Token(Token = "0x4019C1D")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, RaceData> raceDictionary;

	[Token(Token = "0x60183D2")]
	[Address(RVA = "0x315531C", Offset = "0x315531C", VA = "0x315531C")]
	public RaceLibrary()
	{
	}

	[Token(Token = "0x60183D3")]
	[Address(RVA = "0x3155390", Offset = "0x3155390", VA = "0x3155390")]
	private void Awake()
	{
	}

	[Token(Token = "0x60183D4")]
	[Address(RVA = "0x31553A0", Offset = "0x31553A0", VA = "0x31553A0", Slot = "9")]
	public override void ValidateDictionary()
	{
	}

	[Token(Token = "0x60183D5")]
	[Address(RVA = "0x3155440", Offset = "0x3155440", VA = "0x3155440", Slot = "8")]
	public override void UpdateDictionary()
	{
	}

	[Token(Token = "0x60183D6")]
	[Address(RVA = "0x31556BC", Offset = "0x31556BC", VA = "0x31556BC", Slot = "4")]
	public override void AddRace(RaceData race)
	{
	}

	[Token(Token = "0x60183D7")]
	[Address(RVA = "0x31559CC", Offset = "0x31559CC", VA = "0x31559CC", Slot = "5")]
	public override RaceData GetRace(string raceName)
	{
		return null;
	}

	[Token(Token = "0x60183D8")]
	[Address(RVA = "0x3155AA4", Offset = "0x3155AA4", VA = "0x3155AA4", Slot = "6")]
	public override RaceData GetRace(int raceHash)
	{
		return null;
	}

	[Token(Token = "0x60183D9")]
	[Address(RVA = "0x3155C90", Offset = "0x3155C90", VA = "0x3155C90", Slot = "7")]
	public override RaceData[] GetAllRaces()
	{
		return null;
	}
}
