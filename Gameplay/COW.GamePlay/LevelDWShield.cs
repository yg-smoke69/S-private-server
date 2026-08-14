using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000614")]
public class LevelDWShield : BaseLevelObject
{
	[Token(Token = "0x40045BE")]
	[FieldOffset(Offset = "0x74")]
	public GameObject m_Effect;

	[Token(Token = "0x40045BF")]
	[FieldOffset(Offset = "0x78")]
	private ResourceID JKILFKNGIFJ;

	[Token(Token = "0x40045C0")]
	[FieldOffset(Offset = "0x7C")]
	private float DCBBAMINCNB;

	[Token(Token = "0x40045C1")]
	[FieldOffset(Offset = "0x80")]
	private IHAAMHPPLMG ACBDIDHNNOF;

	[Token(Token = "0x40045C2")]
	[FieldOffset(Offset = "0x98")]
	public BoxCollider m_CacheCollider;

	[Token(Token = "0x40045C3")]
	[FieldOffset(Offset = "0x9C")]
	private float PNHJEFBMLJJ;

	[Token(Token = "0x40045C4")]
	[FieldOffset(Offset = "0xA0")]
	private float JCGJNKNKOJK;

	[Token(Token = "0x40045C5")]
	[FieldOffset(Offset = "0xA4")]
	private float KLDCPGIBEJP;

	[Token(Token = "0x40045C6")]
	[FieldOffset(Offset = "0xA8")]
	private float DEACEFEEJEM;

	[Token(Token = "0x40045C7")]
	[FieldOffset(Offset = "0xAC")]
	private bool NKLPHGGGMFI;

	[Token(Token = "0x40045C8")]
	[FieldOffset(Offset = "0xAD")]
	private bool PPDMEDDGCIM;

	[Token(Token = "0x40045C9")]
	[FieldOffset(Offset = "0xB0")]
	private float GDDOIAHNNDF;

	[Token(Token = "0x600258A")]
	[Address(RVA = "0x270DA70", Offset = "0x270DA70", VA = "0x270DA70")]
	public LevelDWShield()
	{
	}

	[Token(Token = "0x600258B")]
	[Address(RVA = "0x270DAF0", Offset = "0x270DAF0", VA = "0x270DAF0", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x600258C")]
	[Address(RVA = "0x270DB94", Offset = "0x270DB94", VA = "0x270DB94", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600258D")]
	[Address(RVA = "0x270E518", Offset = "0x270E518", VA = "0x270E518")]
	public IHAAMHPPLMG GetShieldOwnerID()
	{
		return default(IHAAMHPPLMG);
	}

	[Token(Token = "0x600258E")]
	[Address(RVA = "0x270E58C", Offset = "0x270E58C", VA = "0x270E58C")]
	public float GetReduceDamageRate()
	{
		return default(float);
	}

	[Token(Token = "0x600258F")]
	[Address(RVA = "0x270E5E4", Offset = "0x270E5E4", VA = "0x270E5E4", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002590")]
	[Address(RVA = "0x270ED78", Offset = "0x270ED78", VA = "0x270ED78")]
	public void FixPos()
	{
	}

	[Token(Token = "0x6002591")]
	[Address(RVA = "0x270F0D8", Offset = "0x270F0D8", VA = "0x270F0D8")]
	public bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x6002592")]
	[Address(RVA = "0x270DEAC", Offset = "0x270DEAC", VA = "0x270DEAC")]
	private void DJLMOAIEEAK()
	{
	}

	[Token(Token = "0x6002593")]
	[Address(RVA = "0x270EC0C", Offset = "0x270EC0C", VA = "0x270EC0C")]
	private void GLOOHGPDBPM()
	{
	}

	[Token(Token = "0x6002594")]
	[Address(RVA = "0x270E2EC", Offset = "0x270E2EC", VA = "0x270E2EC")]
	private void LLJKMFAFBLC()
	{
	}

	[Token(Token = "0x6002595")]
	[Address(RVA = "0x270F130", Offset = "0x270F130", VA = "0x270F130")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	[Token(Token = "0x6002596")]
	[Address(RVA = "0x270F138", Offset = "0x270F138", VA = "0x270F138")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
