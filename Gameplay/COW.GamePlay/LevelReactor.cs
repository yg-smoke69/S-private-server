using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000686")]
public class LevelReactor : BaseLevelObject
{
	[Token(Token = "0x400486E")]
	[FieldOffset(Offset = "0x74")]
	private TimeDependentModelObject FLNFBHPJOBK;

	[Token(Token = "0x400486F")]
	[FieldOffset(Offset = "0x78")]
	private Reactor LMKNNHBIPNH;

	[Token(Token = "0x60029CE")]
	[Address(RVA = "0x20C6B9C", Offset = "0x20C6B9C", VA = "0x20C6B9C")]
	public LevelReactor()
	{
	}

	[Token(Token = "0x60029CF")]
	[Address(RVA = "0x20C6BA4", Offset = "0x20C6BA4", VA = "0x20C6BA4", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60029D0")]
	[Address(RVA = "0x20C6C48", Offset = "0x20C6C48", VA = "0x20C6C48")]
	public ResourceID GetExplodeEffect()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60029D1")]
	[Address(RVA = "0x20C6CF8", Offset = "0x20C6CF8", VA = "0x20C6CF8")]
	public ResourceID GetExplodeSound()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60029D2")]
	[Address(RVA = "0x20C6DA8", Offset = "0x20C6DA8", VA = "0x20C6DA8", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60029D3")]
	[Address(RVA = "0x20C6F14", Offset = "0x20C6F14", VA = "0x20C6F14")]
	public void OnBroken()
	{
	}

	[Token(Token = "0x60029D4")]
	[Address(RVA = "0x20C7010", Offset = "0x20C7010", VA = "0x20C7010", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60029D5")]
	[Address(RVA = "0x20C7068", Offset = "0x20C7068", VA = "0x20C7068", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60029D6")]
	[Address(RVA = "0x20C72AC", Offset = "0x20C72AC", VA = "0x20C72AC")]
	private void ANAKGBPHPMJ(int IMGNBGJDAHG)
	{
	}

	[Token(Token = "0x60029D7")]
	[Address(RVA = "0x20C7420", Offset = "0x20C7420", VA = "0x20C7420")]
	private void HPGILFDILLD(int JGLJDJFHPBO, int DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60029D8")]
	[Address(RVA = "0x20C74B0", Offset = "0x20C74B0", VA = "0x20C74B0")]
	private void MEMBMAJPKPN(GameObject OMDFNKNJDII)
	{
	}

	[Token(Token = "0x60029D9")]
	[Address(RVA = "0x20C75E0", Offset = "0x20C75E0", VA = "0x20C75E0")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x60029DA")]
	[Address(RVA = "0x20C75E8", Offset = "0x20C75E8", VA = "0x20C75E8")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60029DB")]
	[Address(RVA = "0x20C75F0", Offset = "0x20C75F0", VA = "0x20C75F0")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}
}
