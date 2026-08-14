using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005DE")]
public class LevelBaseDrum : BaseLevelObject
{
	[Token(Token = "0x20005DF")]
	public enum JPAKCIIEOML
	{
		[Token(Token = "0x400444B")]
		None,
		[Token(Token = "0x400444C")]
		OilDrum,
		[Token(Token = "0x400444D")]
		SmokeDrum,
		[Token(Token = "0x400444E")]
		EasterEggDrum,
		[Token(Token = "0x400444F")]
		ShootingTargetDrum
	}

	[Token(Token = "0x4004446")]
	[FieldOffset(Offset = "0x74")]
	private OilDrums DHBJAHPALGI;

	[Token(Token = "0x4004447")]
	[FieldOffset(Offset = "0x78")]
	protected BitArrayBoolean FAGCPHGJGPI;

	[Token(Token = "0x4004448")]
	protected const uint AOIJEJNBIOE = 1u;

	[Token(Token = "0x4004449")]
	protected const uint EGCCKHNBENN = 2u;

	[Token(Token = "0x600237A")]
	[Address(RVA = "0x236DF7C", Offset = "0x236DF7C", VA = "0x236DF7C")]
	public LevelBaseDrum()
	{
	}

	[Token(Token = "0x600237B")]
	[Address(RVA = "0x236E000", Offset = "0x236E000", VA = "0x236E000", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x600237C")]
	[Address(RVA = "0x236E0AC", Offset = "0x236E0AC", VA = "0x236E0AC", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x600237D")]
	[Address(RVA = "0x236E228", Offset = "0x236E228", VA = "0x236E228", Slot = "40")]
	public virtual int GetMaxDurability()
	{
		return default(int);
	}

	[Token(Token = "0x600237E")]
	[Address(RVA = "0x236E300", Offset = "0x236E300", VA = "0x236E300", Slot = "41")]
	public virtual ResourceID GetModelResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600237F")]
	[Address(RVA = "0x236E3D8", Offset = "0x236E3D8", VA = "0x236E3D8", Slot = "42")]
	public virtual ResourceID GetDamagedEffect()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002380")]
	[Address(RVA = "0x236E4B0", Offset = "0x236E4B0", VA = "0x236E4B0", Slot = "43")]
	public virtual ResourceID GetExplodeEffect()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002381")]
	[Address(RVA = "0x236E588", Offset = "0x236E588", VA = "0x236E588", Slot = "44")]
	public virtual ResourceID GetExplodeSound()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002382")]
	[Address(RVA = "0x236E660", Offset = "0x236E660", VA = "0x236E660", Slot = "45")]
	public virtual JPAKCIIEOML OilDrumType()
	{
		return default(JPAKCIIEOML);
	}

	[Token(Token = "0x6002383")]
	[Address(RVA = "0x236E6B8", Offset = "0x236E6B8", VA = "0x236E6B8", Slot = "46")]
	public virtual float GetEffectTime()
	{
		return default(float);
	}

	[Token(Token = "0x6002384")]
	[Address(RVA = "0x236E718", Offset = "0x236E718", VA = "0x236E718", Slot = "47")]
	public virtual void OnDrumBroken()
	{
	}

	[Token(Token = "0x6002385")]
	[Address(RVA = "0x236E814", Offset = "0x236E814", VA = "0x236E814", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002386")]
	[Address(RVA = "0x236E86C", Offset = "0x236E86C", VA = "0x236E86C", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002387")]
	[Address(RVA = "0x236EC68", Offset = "0x236EC68", VA = "0x236EC68")]
	public void SetHP(int LBMGGMBKAEH)
	{
	}

	[Token(Token = "0x6002388")]
	[Address(RVA = "0x236EEC4", Offset = "0x236EEC4", VA = "0x236EEC4", Slot = "48")]
	protected virtual void HPGILFDILLD(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002389")]
	[Address(RVA = "0x236EFF0", Offset = "0x236EFF0", VA = "0x236EFF0", Slot = "23")]
	protected override void OnUpdateVisibleStateByStreamer(Vector3 MKGCDPNKMOB, Vector3 OANAHFHPBNB)
	{
	}

	[Token(Token = "0x600238A")]
	[Address(RVA = "0x236EAE4", Offset = "0x236EAE4", VA = "0x236EAE4")]
	private void FCPGNADNEEI()
	{
	}

	[Token(Token = "0x600238B")]
	[Address(RVA = "0x236F1D0", Offset = "0x236F1D0", VA = "0x236F1D0")]
	protected void LLKBODKEENI()
	{
	}

	[Token(Token = "0x600238C")]
	[Address(RVA = "0x236F5CC", Offset = "0x236F5CC", VA = "0x236F5CC")]
	private void LNGLKOANLLK()
	{
	}

	[Token(Token = "0x600238D")]
	[Address(RVA = "0x236F784", Offset = "0x236F784", VA = "0x236F784")]
	public bool CanBeUsed()
	{
		return default(bool);
	}

	[Token(Token = "0x600238E")]
	[Address(RVA = "0x236F8B4", Offset = "0x236F8B4", VA = "0x236F8B4", Slot = "30")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600238F")]
	[Address(RVA = "0x236FBAC", Offset = "0x236FBAC", VA = "0x236FBAC", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002390")]
	[Address(RVA = "0x236FC84", Offset = "0x236FC84", VA = "0x236FC84")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x6002391")]
	[Address(RVA = "0x236FC8C", Offset = "0x236FC8C", VA = "0x236FC8C")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002392")]
	[Address(RVA = "0x236FC94", Offset = "0x236FC94", VA = "0x236FC94")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002393")]
	[Address(RVA = "0x236FC9C", Offset = "0x236FC9C", VA = "0x236FC9C")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002394")]
	[Address(RVA = "0x236FCA4", Offset = "0x236FCA4", VA = "0x236FCA4")]
	public void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	[Token(Token = "0x6002395")]
	[Address(RVA = "0x236FCD8", Offset = "0x236FCD8", VA = "0x236FCD8")]
	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}
}
