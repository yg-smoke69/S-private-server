using GCommon;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Token(Token = "0x2000695")]
public class LevelShootingTarget : LevelBaseDrum
{
	[Token(Token = "0x2000696")]
	public enum NPCGACNPMBJ
	{
		[Token(Token = "0x40048B5")]
		typeA,
		[Token(Token = "0x40048B6")]
		typeB,
		[Token(Token = "0x40048B7")]
		typeC
	}

	[Token(Token = "0x40048B3")]
	[FieldOffset(Offset = "0x7C")]
	public NPCGACNPMBJ ModelType;

	[Token(Token = "0x6002A3A")]
	[Address(RVA = "0x20CE138", Offset = "0x20CE138", VA = "0x20CE138")]
	public LevelShootingTarget()
	{
	}

	[Token(Token = "0x6002A3B")]
	[Address(RVA = "0x20CE140", Offset = "0x20CE140", VA = "0x20CE140", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6002A3C")]
	[Address(RVA = "0x20CE1A4", Offset = "0x20CE1A4", VA = "0x20CE1A4", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002A3D")]
	[Address(RVA = "0x20CE208", Offset = "0x20CE208", VA = "0x20CE208", Slot = "45")]
	public override JPAKCIIEOML OilDrumType()
	{
		return default(JPAKCIIEOML);
	}

	[Token(Token = "0x6002A3E")]
	[Address(RVA = "0x20CE260", Offset = "0x20CE260", VA = "0x20CE260", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002A3F")]
	[Address(RVA = "0x20CE304", Offset = "0x20CE304", VA = "0x20CE304", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002A40")]
	[Address(RVA = "0x20CE368", Offset = "0x20CE368", VA = "0x20CE368", Slot = "41")]
	public override ResourceID GetModelResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002A41")]
	[Address(RVA = "0x20CE44C", Offset = "0x20CE44C", VA = "0x20CE44C", Slot = "40")]
	public override int GetMaxDurability()
	{
		return default(int);
	}

	[Token(Token = "0x6002A42")]
	[Address(RVA = "0x20CE524", Offset = "0x20CE524", VA = "0x20CE524", Slot = "44")]
	public override ResourceID GetExplodeSound()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002A43")]
	[Address(RVA = "0x20CE5D4", Offset = "0x20CE5D4", VA = "0x20CE5D4", Slot = "48")]
	protected override void HPGILFDILLD(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002A44")]
	[Address(RVA = "0x20CE684", Offset = "0x20CE684", VA = "0x20CE684")]
	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x6002A45")]
	[Address(RVA = "0x20CE68C", Offset = "0x20CE68C", VA = "0x20CE68C")]
	public new void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002A46")]
	[Address(RVA = "0x20CE694", Offset = "0x20CE694", VA = "0x20CE694")]
	public JPAKCIIEOML _003C_003EiFixBaseProxy_OilDrumType()
	{
		return default(JPAKCIIEOML);
	}

	[Token(Token = "0x6002A47")]
	[Address(RVA = "0x20CE69C", Offset = "0x20CE69C", VA = "0x20CE69C")]
	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002A48")]
	[Address(RVA = "0x20CE6A4", Offset = "0x20CE6A4", VA = "0x20CE6A4")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x6002A49")]
	[Address(RVA = "0x20CE6AC", Offset = "0x20CE6AC", VA = "0x20CE6AC")]
	public ResourceID _003C_003EiFixBaseProxy_GetModelResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002A4A")]
	[Address(RVA = "0x20CE6B4", Offset = "0x20CE6B4", VA = "0x20CE6B4")]
	public int _003C_003EiFixBaseProxy_GetMaxDurability()
	{
		return default(int);
	}

	[Token(Token = "0x6002A4B")]
	[Address(RVA = "0x20CE6BC", Offset = "0x20CE6BC", VA = "0x20CE6BC")]
	public ResourceID _003C_003EiFixBaseProxy_GetExplodeSound()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002A4C")]
	[Address(RVA = "0x20CE6C4", Offset = "0x20CE6C4", VA = "0x20CE6C4")]
	public void _003C_003EiFixBaseProxy_HPGILFDILLD(byte P0, byte P1)
	{
	}
}
