using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200069C")]
public class LevelSmokeDrum : LevelBaseDrum
{
	[Token(Token = "0x40048C9")]
	[FieldOffset(Offset = "0x7C")]
	public BoxCollider m_Trigger;

	[Token(Token = "0x6002A66")]
	[Address(RVA = "0x20CFD20", Offset = "0x20CFD20", VA = "0x20CFD20")]
	public LevelSmokeDrum()
	{
	}

	[Token(Token = "0x6002A67")]
	[Address(RVA = "0x20CFD28", Offset = "0x20CFD28", VA = "0x20CFD28", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002A68")]
	[Address(RVA = "0x20CFDCC", Offset = "0x20CFDCC", VA = "0x20CFDCC", Slot = "41")]
	public override ResourceID GetModelResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002A69")]
	[Address(RVA = "0x20CFE7C", Offset = "0x20CFE7C", VA = "0x20CFE7C", Slot = "43")]
	public override ResourceID GetExplodeEffect()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002A6A")]
	[Address(RVA = "0x20CFF2C", Offset = "0x20CFF2C", VA = "0x20CFF2C", Slot = "44")]
	public override ResourceID GetExplodeSound()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002A6B")]
	[Address(RVA = "0x20CFFDC", Offset = "0x20CFFDC", VA = "0x20CFFDC", Slot = "46")]
	public override float GetEffectTime()
	{
		return default(float);
	}

	[Token(Token = "0x6002A6C")]
	[Address(RVA = "0x20D003C", Offset = "0x20D003C", VA = "0x20D003C", Slot = "45")]
	public override JPAKCIIEOML OilDrumType()
	{
		return default(JPAKCIIEOML);
	}

	[Token(Token = "0x6002A6D")]
	[Address(RVA = "0x20D0094", Offset = "0x20D0094", VA = "0x20D0094", Slot = "48")]
	protected override void HPGILFDILLD(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002A6E")]
	[Address(RVA = "0x20D032C", Offset = "0x20D032C", VA = "0x20D032C")]
	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002A6F")]
	[Address(RVA = "0x20D0334", Offset = "0x20D0334", VA = "0x20D0334")]
	public ResourceID _003C_003EiFixBaseProxy_GetModelResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002A70")]
	[Address(RVA = "0x20D033C", Offset = "0x20D033C", VA = "0x20D033C")]
	public ResourceID _003C_003EiFixBaseProxy_GetExplodeEffect()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002A71")]
	[Address(RVA = "0x20D0344", Offset = "0x20D0344", VA = "0x20D0344")]
	public ResourceID _003C_003EiFixBaseProxy_GetExplodeSound()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002A72")]
	[Address(RVA = "0x20D034C", Offset = "0x20D034C", VA = "0x20D034C")]
	public float _003C_003EiFixBaseProxy_GetEffectTime()
	{
		return default(float);
	}

	[Token(Token = "0x6002A73")]
	[Address(RVA = "0x20D0354", Offset = "0x20D0354", VA = "0x20D0354")]
	public JPAKCIIEOML _003C_003EiFixBaseProxy_OilDrumType()
	{
		return default(JPAKCIIEOML);
	}

	[Token(Token = "0x6002A74")]
	[Address(RVA = "0x20D035C", Offset = "0x20D035C", VA = "0x20D035C")]
	public void _003C_003EiFixBaseProxy_HPGILFDILLD(byte P0, byte P1)
	{
	}
}
