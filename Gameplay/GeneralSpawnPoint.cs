using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005C5")]
public class GeneralSpawnPoint : MonoBehaviour
{
	[Token(Token = "0x40043CB")]
	[FieldOffset(Offset = "0xC")]
	public int ID;

	[Token(Token = "0x40043CC")]
	[FieldOffset(Offset = "0x10")]
	public EGeneralSpawnPointType Type;

	[Token(Token = "0x170002DC")]
	public bool ExportDirection
	{
		[Token(Token = "0x60022F0")]
		[Address(RVA = "0x3502184", Offset = "0x3502184", VA = "0x3502184")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60022EF")]
	[Address(RVA = "0x350217C", Offset = "0x350217C", VA = "0x350217C")]
	public GeneralSpawnPoint()
	{
	}
}
