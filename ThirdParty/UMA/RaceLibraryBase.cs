using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CB4")]
public abstract class RaceLibraryBase : MonoBehaviour
{
	[Token(Token = "0x6018489")]
	[Address(RVA = "0x2D5402C", Offset = "0x2D5402C", VA = "0x2D5402C")]
	protected RaceLibraryBase()
	{
	}

	[Token(Token = "0x601848A")]
	public abstract void AddRace(RaceData race);

	[Token(Token = "0x601848B")]
	public abstract RaceData GetRace(string raceName);

	[Token(Token = "0x601848C")]
	public abstract RaceData GetRace(int raceHash);

	[Token(Token = "0x601848D")]
	public abstract RaceData[] GetAllRaces();

	[Token(Token = "0x601848E")]
	public abstract void UpdateDictionary();

	[Token(Token = "0x601848F")]
	public abstract void ValidateDictionary();
}
