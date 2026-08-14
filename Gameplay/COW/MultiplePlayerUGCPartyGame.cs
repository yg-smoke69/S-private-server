using System;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000859")]
internal class MultiplePlayerUGCPartyGame : HBNIDAFBOBL, _Attribute
{
	[Token(Token = "0x4005240")]
	[FieldOffset(Offset = "0xD9")]
	private bool hasShowEndHint;

	[Token(Token = "0x4005241")]
	[FieldOffset(Offset = "0xDC")]
	private SpawnAreaFences mSpawnAreaFences;

	[Token(Token = "0x6003A5F")]
	[Address(RVA = "0x2290380", Offset = "0x2290380", VA = "0x2290380")]
	public MultiplePlayerUGCPartyGame()
	{
	}

	[Token(Token = "0x6003A60")]
	[Address(RVA = "0x2290388", Offset = "0x2290388", VA = "0x2290388", Slot = "19")]
	public override Type GetUISceneType()
	{
		return null;
	}

	[Token(Token = "0x6003A61")]
	[Address(RVA = "0x2290464", Offset = "0x2290464", VA = "0x2290464", Slot = "46")]
	protected override void InitGRIData()
	{
	}

	[Token(Token = "0x6003A62")]
	[Address(RVA = "0x22905F0", Offset = "0x22905F0", VA = "0x22905F0", Slot = "9")]
	protected override void OnSceneLoaded()
	{
	}

	[Token(Token = "0x6003A63")]
	[Address(RVA = "0x22906FC", Offset = "0x22906FC", VA = "0x22906FC", Slot = "68")]
	public void ShowSpawnAreaFences(bool show, uint TeamIndex = 2u)
	{
	}

	[Token(Token = "0x6003A64")]
	[Address(RVA = "0x22909DC", Offset = "0x22909DC", VA = "0x22909DC")]
	private void OnPhaseChange(uint oldValue, uint newValue)
	{
	}

	[Token(Token = "0x6003A65")]
	[Address(RVA = "0x2290F64", Offset = "0x2290F64", VA = "0x2290F64", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6003A66")]
	[Address(RVA = "0x22911A4", Offset = "0x22911A4", VA = "0x22911A4")]
	public Type _003C_003EiFixBaseProxy_GetUISceneType()
	{
		return null;
	}

	[Token(Token = "0x6003A67")]
	[Address(RVA = "0x22911AC", Offset = "0x22911AC", VA = "0x22911AC")]
	public void _003C_003EiFixBaseProxy_InitGRIData()
	{
	}

	[Token(Token = "0x6003A68")]
	[Address(RVA = "0x22911B4", Offset = "0x22911B4", VA = "0x22911B4")]
	public new void _003C_003EiFixBaseProxy_OnSceneLoaded()
	{
	}

	[Token(Token = "0x6003A69")]
	[Address(RVA = "0x22911BC", Offset = "0x22911BC", VA = "0x22911BC")]
	public new void _003C_003EiFixBaseProxy_OnUpdate()
	{
	}
}
