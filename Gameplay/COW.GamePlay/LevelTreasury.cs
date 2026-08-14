using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006C3")]
public class LevelTreasury : BaseLevelObject
{
	[Token(Token = "0x20006C4")]
	public enum JNCMCDACLGC
	{
		[Token(Token = "0x4004ABD")]
		Add,
		[Token(Token = "0x4004ABE")]
		Destroy
	}

	[Token(Token = "0x4004AB7")]
	[FieldOffset(Offset = "0x74")]
	public Transform m_GateRoot;

	[Token(Token = "0x4004AB8")]
	[FieldOffset(Offset = "0x78")]
	public BoxCollider m_TriggerCollider;

	[Token(Token = "0x4004AB9")]
	[FieldOffset(Offset = "0x7C")]
	public Animation m_GateAnimation;

	[Token(Token = "0x4004ABA")]
	[FieldOffset(Offset = "0x80")]
	private GameObject HNNGKOJHOEM;

	[Token(Token = "0x4004ABB")]
	[FieldOffset(Offset = "0x84")]
	public GameObject m_Effect;

	[Token(Token = "0x1700034B")]
	public bool APLGPNDGBOI
	{
		[Token(Token = "0x6002B6A")]
		[Address(RVA = "0x2428DFC", Offset = "0x2428DFC", VA = "0x2428DFC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002B66")]
	[Address(RVA = "0x2428B64", Offset = "0x2428B64", VA = "0x2428B64")]
	public LevelTreasury()
	{
	}

	[Token(Token = "0x6002B67")]
	[Address(RVA = "0x2428B6C", Offset = "0x2428B6C", VA = "0x2428B6C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002B68")]
	[Address(RVA = "0x2428C10", Offset = "0x2428C10", VA = "0x2428C10", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002B69")]
	[Address(RVA = "0x2428DA4", Offset = "0x2428DA4", VA = "0x2428DA4", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002B6B")]
	[Address(RVA = "0x2428F20", Offset = "0x2428F20", VA = "0x2428F20", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002B6C")]
	[Address(RVA = "0x24293AC", Offset = "0x24293AC", VA = "0x24293AC", Slot = "40")]
	protected virtual void OHNFIEMCCFF(bool JGLJDJFHPBO, bool DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002B6D")]
	[Address(RVA = "0x24290F4", Offset = "0x24290F4", VA = "0x24290F4")]
	public void ShowInMap()
	{
	}

	[Token(Token = "0x6002B6E")]
	[Address(RVA = "0x24297D0", Offset = "0x24297D0", VA = "0x24297D0")]
	private void JLGNNBINDOL()
	{
	}

	[Token(Token = "0x6002B6F")]
	[Address(RVA = "0x2429858", Offset = "0x2429858", VA = "0x2429858")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002B70")]
	[Address(RVA = "0x2429860", Offset = "0x2429860", VA = "0x2429860")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002B71")]
	[Address(RVA = "0x2429868", Offset = "0x2429868", VA = "0x2429868")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
