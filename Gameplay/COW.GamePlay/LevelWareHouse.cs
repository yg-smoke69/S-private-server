using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006E2")]
public class LevelWareHouse : BaseLevelObject
{
	[Token(Token = "0x20006E3")]
	public enum BBFBKNJHKMK
	{
		[Token(Token = "0x4004B3A")]
		Warehouse_None,
		[Token(Token = "0x4004B3B")]
		Warehouse_Normal,
		[Token(Token = "0x4004B3C")]
		Warehouse_Damaged,
		[Token(Token = "0x4004B3D")]
		Warehouse_Broken
	}

	[Token(Token = "0x20006E4")]
	public enum DFKPFBOGGHB
	{
		[Token(Token = "0x4004B3F")]
		Add,
		[Token(Token = "0x4004B40")]
		Destroy
	}

	[Token(Token = "0x4004B30")]
	[FieldOffset(Offset = "0x74")]
	private Warehouse KHONDHALDDD;

	[Token(Token = "0x4004B31")]
	[FieldOffset(Offset = "0x78")]
	public uint m_TeamIndex;

	[Token(Token = "0x4004B32")]
	[FieldOffset(Offset = "0x7C")]
	private float OHHEBDCFAPE;

	[Token(Token = "0x4004B33")]
	private const float IGMJLFKFIFB = 5f;

	[Token(Token = "0x4004B34")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_NormalEffect;

	[Token(Token = "0x4004B35")]
	[FieldOffset(Offset = "0x84")]
	public GameObject m_DamagedEffect;

	[Token(Token = "0x4004B36")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_BrokenEffect;

	[Token(Token = "0x4004B37")]
	[FieldOffset(Offset = "0x8C")]
	private GameObject EPKEHAOJGCK;

	[Token(Token = "0x4004B38")]
	[FieldOffset(Offset = "0x90")]
	private BBFBKNJHKMK EGOBBHJJAFL;

	[Token(Token = "0x17000355")]
	public int JMFDKFEGFLK
	{
		[Token(Token = "0x6002C03")]
		[Address(RVA = "0x2436868", Offset = "0x2436868", VA = "0x2436868")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000356")]
	public int LJBCNMIFEFJ
	{
		[Token(Token = "0x6002C04")]
		[Address(RVA = "0x2436990", Offset = "0x2436990", VA = "0x2436990")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002C00")]
	[Address(RVA = "0x2436764", Offset = "0x2436764", VA = "0x2436764")]
	public LevelWareHouse()
	{
	}

	[Token(Token = "0x6002C01")]
	[Address(RVA = "0x243676C", Offset = "0x243676C", VA = "0x243676C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002C02")]
	[Address(RVA = "0x2436810", Offset = "0x2436810", VA = "0x2436810", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002C05")]
	[Address(RVA = "0x2436AB8", Offset = "0x2436AB8", VA = "0x2436AB8")]
	public bool IsMyTeam(int OOLNKDGDDCE)
	{
		return default(bool);
	}

	[Token(Token = "0x6002C06")]
	[Address(RVA = "0x2436B38", Offset = "0x2436B38", VA = "0x2436B38", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002C07")]
	[Address(RVA = "0x2436DA4", Offset = "0x2436DA4", VA = "0x2436DA4")]
	protected void MNKMALKKPEA(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002C08")]
	[Address(RVA = "0x2437398", Offset = "0x2437398", VA = "0x2437398")]
	private void AADOEOODGAO()
	{
	}

	[Token(Token = "0x6002C09")]
	[Address(RVA = "0x2438198", Offset = "0x2438198", VA = "0x2438198")]
	protected void MINFFBODCOL(ushort JGLJDJFHPBO, ushort DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002C0A")]
	[Address(RVA = "0x24384B4", Offset = "0x24384B4", VA = "0x24384B4", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002C0B")]
	[Address(RVA = "0x24386C4", Offset = "0x24386C4", VA = "0x24386C4")]
	public void ShowInMap(bool OPCMPECJPHG)
	{
	}

	[Token(Token = "0x6002C0C")]
	[Address(RVA = "0x2438964", Offset = "0x2438964", VA = "0x2438964")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002C0D")]
	[Address(RVA = "0x243896C", Offset = "0x243896C", VA = "0x243896C")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002C0E")]
	[Address(RVA = "0x2438974", Offset = "0x2438974", VA = "0x2438974")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
