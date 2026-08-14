using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000712")]
public class PVEHyakkiMatchConfig : MonoBehaviour
{
	[Token(Token = "0x4004C0D")]
	[FieldOffset(Offset = "0xC")]
	public int GeneralSpawnMaxAliveCount;

	[Token(Token = "0x4004C0E")]
	[FieldOffset(Offset = "0x10")]
	public List<PVEHyakkiMatchDifficultyRelatedConfig> DifficultyRelatedConfigs;

	[Token(Token = "0x6002CD8")]
	[Address(RVA = "0x1C7913C", Offset = "0x1C7913C", VA = "0x1C7913C")]
	public PVEHyakkiMatchConfig()
	{
	}

	[Token(Token = "0x6002CD9")]
	[Address(RVA = "0x1C792BC", Offset = "0x1C792BC", VA = "0x1C792BC")]
	private void Awake()
	{
	}
}
