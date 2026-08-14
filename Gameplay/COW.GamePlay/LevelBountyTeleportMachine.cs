using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005E6")]
internal class LevelBountyTeleportMachine : BaseLevelObject
{
	[Token(Token = "0x4004478")]
	[FieldOffset(Offset = "0x74")]
	public GameObject BrokenRoot;

	[Token(Token = "0x4004479")]
	[FieldOffset(Offset = "0x78")]
	public GameObject RepairingRoot;

	[Token(Token = "0x400447A")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject EnableRoot;

	[Token(Token = "0x400447B")]
	[FieldOffset(Offset = "0x80")]
	public BoxCollider Trigger;

	[Token(Token = "0x60023C0")]
	[Address(RVA = "0x2374F9C", Offset = "0x2374F9C", VA = "0x2374F9C")]
	public LevelBountyTeleportMachine()
	{
	}

	[Token(Token = "0x60023C1")]
	[Address(RVA = "0x2374FA4", Offset = "0x2374FA4", VA = "0x2374FA4", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60023C2")]
	[Address(RVA = "0x2375048", Offset = "0x2375048", VA = "0x2375048", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60023C3")]
	[Address(RVA = "0x237513C", Offset = "0x237513C", VA = "0x237513C", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60023C4")]
	[Address(RVA = "0x2375364", Offset = "0x2375364", VA = "0x2375364", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60023C5")]
	[Address(RVA = "0x23753BC", Offset = "0x23753BC", VA = "0x23753BC")]
	private void HPGILFDILLD(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60023C6")]
	[Address(RVA = "0x23756C0", Offset = "0x23756C0", VA = "0x23756C0")]
	public uint GetCurState()
	{
		return default(uint);
	}

	[Token(Token = "0x60023C7")]
	[Address(RVA = "0x23757E4", Offset = "0x23757E4", VA = "0x23757E4")]
	public bool CanUse()
	{
		return default(bool);
	}

	[Token(Token = "0x60023C8")]
	[Address(RVA = "0x2375908", Offset = "0x2375908", VA = "0x2375908", Slot = "30")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x60023C9")]
	[Address(RVA = "0x2375EBC", Offset = "0x2375EBC", VA = "0x2375EBC")]
	private void MNBKHMHKCEA()
	{
	}

	[Token(Token = "0x60023CA")]
	[Address(RVA = "0x2375FC4", Offset = "0x2375FC4", VA = "0x2375FC4", Slot = "38")]
	public override void TakeHealing(int EDEOPLNOGPP, IHAAMHPPLMG ONPMGNIIMJD, int BOEIBGAABDL, [Optional] Vector3 NJMFBKNHMBP, [Optional] Vector3 DOBOBMFMKBJ, [Optional] List<float> NBKBEBFNDBE)
	{
	}

	[Token(Token = "0x60023CB")]
	[Address(RVA = "0x23767D4", Offset = "0x23767D4", VA = "0x23767D4")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x60023CC")]
	[Address(RVA = "0x23767DC", Offset = "0x23767DC", VA = "0x23767DC")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60023CD")]
	[Address(RVA = "0x23767E4", Offset = "0x23767E4", VA = "0x23767E4")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60023CE")]
	[Address(RVA = "0x23767EC", Offset = "0x23767EC", VA = "0x23767EC")]
	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	[Token(Token = "0x60023CF")]
	[Address(RVA = "0x23767F4", Offset = "0x23767F4", VA = "0x23767F4")]
	public void _003C_003EiFixBaseProxy_TakeHealing(int P0, IHAAMHPPLMG P1, int P2, Vector3 P3, Vector3 P4, List<float> P5)
	{
	}
}
