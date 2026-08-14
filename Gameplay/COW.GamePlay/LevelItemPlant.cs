using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200063F")]
public class LevelItemPlant : BaseLevelObject
{
	[Token(Token = "0x2000640")]
	public enum NMMIPIMDDHL
	{
		[Token(Token = "0x40046A5")]
		Add,
		[Token(Token = "0x40046A6")]
		Destroy
	}

	[Token(Token = "0x400469B")]
	[FieldOffset(Offset = "0x74")]
	public uint m_ItemID;

	[Token(Token = "0x400469C")]
	[FieldOffset(Offset = "0x78")]
	public uint m_ItemCount;

	[Token(Token = "0x400469D")]
	[FieldOffset(Offset = "0x7C")]
	public float m_GrownInterval;

	[Token(Token = "0x400469E")]
	[FieldOffset(Offset = "0x80")]
	private float CKLEHEEDHHE;

	[Token(Token = "0x400469F")]
	[FieldOffset(Offset = "0x84")]
	public Transform m_PlantModel;

	[Token(Token = "0x40046A0")]
	[FieldOffset(Offset = "0x88")]
	private GameObject CDOJAEGHFFP;

	[Token(Token = "0x40046A1")]
	[FieldOffset(Offset = "0x8C")]
	private bool MKJNOCHICHA;

	[Token(Token = "0x40046A2")]
	[FieldOffset(Offset = "0x90")]
	private float FDEMBINLOGI;

	[Token(Token = "0x40046A3")]
	[FieldOffset(Offset = "0x94")]
	protected BoxCollider MNNAPHEELIM;

	[Token(Token = "0x17000301")]
	protected BoxCollider FELEIMBDDHC
	{
		[Token(Token = "0x60026D4")]
		[Address(RVA = "0x24B0F50", Offset = "0x24B0F50", VA = "0x24B0F50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000302")]
	public float CJLOGBOIEOJ
	{
		[Token(Token = "0x60026D8")]
		[Address(RVA = "0x24B13C8", Offset = "0x24B13C8", VA = "0x24B13C8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000303")]
	public float IDBBDMJBHEH
	{
		[Token(Token = "0x60026D9")]
		[Address(RVA = "0x24B1420", Offset = "0x24B1420", VA = "0x24B1420")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60026D3")]
	[Address(RVA = "0x24B0F3C", Offset = "0x24B0F3C", VA = "0x24B0F3C")]
	public LevelItemPlant()
	{
	}

	[Token(Token = "0x60026D5")]
	[Address(RVA = "0x24B104C", Offset = "0x24B104C", VA = "0x24B104C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60026D6")]
	[Address(RVA = "0x24B10F0", Offset = "0x24B10F0", VA = "0x24B10F0", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60026D7")]
	[Address(RVA = "0x24B115C", Offset = "0x24B115C", VA = "0x24B115C", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60026DA")]
	[Address(RVA = "0x24B1560", Offset = "0x24B1560", VA = "0x24B1560")]
	protected void PCDFHKLNOCN(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60026DB")]
	[Address(RVA = "0x24B1974", Offset = "0x24B1974", VA = "0x24B1974")]
	protected void ECDFJKJICNI(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60026DC")]
	[Address(RVA = "0x24B1C08", Offset = "0x24B1C08", VA = "0x24B1C08", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x60026DD")]
	[Address(RVA = "0x24B205C", Offset = "0x24B205C", VA = "0x24B205C", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60026DE")]
	[Address(RVA = "0x24B20B4", Offset = "0x24B20B4", VA = "0x24B20B4", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60026DF")]
	[Address(RVA = "0x24B23A8", Offset = "0x24B23A8", VA = "0x24B23A8")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x60026E0")]
	[Address(RVA = "0x24B23B0", Offset = "0x24B23B0", VA = "0x24B23B0")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60026E1")]
	[Address(RVA = "0x24B23B8", Offset = "0x24B23B8", VA = "0x24B23B8")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	[Token(Token = "0x60026E2")]
	[Address(RVA = "0x24B23C0", Offset = "0x24B23C0", VA = "0x24B23C0")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60026E3")]
	[Address(RVA = "0x24B23C8", Offset = "0x24B23C8", VA = "0x24B23C8")]
	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}
}
