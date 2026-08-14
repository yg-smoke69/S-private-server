using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x200064C")]
internal class LevelMagneticField : LevelObjectSpawned
{
	[Token(Token = "0x40046EC")]
	[FieldOffset(Offset = "0x9C")]
	private LPNKIPJKKHL BOPLAOANKBI;

	[Token(Token = "0x40046ED")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject LINKCFPMIHH;

	[Token(Token = "0x600274B")]
	[Address(RVA = "0x24B86C8", Offset = "0x24B86C8", VA = "0x24B86C8")]
	public LevelMagneticField()
	{
	}

	[Token(Token = "0x600274C")]
	[Address(RVA = "0x24B8784", Offset = "0x24B8784", VA = "0x24B8784", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x600274D")]
	[Address(RVA = "0x24B8828", Offset = "0x24B8828", VA = "0x24B8828", Slot = "41")]
	protected override void DPLMGOJKKCM(CSVBaseData IHCGHDENPKF)
	{
	}

	[Token(Token = "0x600274E")]
	[Address(RVA = "0x24B8A7C", Offset = "0x24B8A7C", VA = "0x24B8A7C")]
	public bool IsInside(Vector3 PFAPJJODMCM)
	{
		return default(bool);
	}

	[Token(Token = "0x600274F")]
	[Address(RVA = "0x24B8C20", Offset = "0x24B8C20", VA = "0x24B8C20", Slot = "42")]
	public override void OnDead(MEBEMEIFFBA OMNGGLFFMGM)
	{
	}

	[Token(Token = "0x6002750")]
	[Address(RVA = "0x24B8D6C", Offset = "0x24B8D6C", VA = "0x24B8D6C")]
	public void _003C_003EiFixBaseProxy_DPLMGOJKKCM(CSVBaseData P0)
	{
	}

	[Token(Token = "0x6002751")]
	[Address(RVA = "0x24B8DCC", Offset = "0x24B8DCC", VA = "0x24B8DCC")]
	public void _003C_003EiFixBaseProxy_OnDead(MEBEMEIFFBA P0)
	{
	}
}
