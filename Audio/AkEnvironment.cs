using System.Runtime.InteropServices;
using AK.Wwise;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E16")]
public class AkEnvironment : MonoBehaviour
{
	[Token(Token = "0x2003E17")]
	public class AkEnvironment_CompareByPriority : _Attribute
	{
		[Token(Token = "0x60193F8")]
		[Address(RVA = "0x35D56D8", Offset = "0x35D56D8", VA = "0x35D56D8")]
		public AkEnvironment_CompareByPriority()
		{
		}

		[Token(Token = "0x60193F9")]
		[Address(RVA = "0x35D56E8", Offset = "0x35D56E8", VA = "0x35D56E8", Slot = "5")]
		public virtual int Compare(AkEnvironment a, AkEnvironment b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2003E18")]
	public class AkEnvironment_CompareBySelectionAlgorithm : AkEnvironment_CompareByPriority
	{
		[Token(Token = "0x60193FA")]
		[Address(RVA = "0x35D56E0", Offset = "0x35D56E0", VA = "0x35D56E0")]
		public AkEnvironment_CompareBySelectionAlgorithm()
		{
		}

		[Token(Token = "0x60193FB")]
		[Address(RVA = "0x35D57CC", Offset = "0x35D57CC", VA = "0x35D57CC", Slot = "5")]
		public override int Compare(AkEnvironment a, AkEnvironment b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x401A4C1")]
	public const int MAX_NB_ENVIRONMENTS = 4;

	[Token(Token = "0x401A4C2")]
	[FieldOffset(Offset = "0x0")]
	public static AkEnvironment_CompareByPriority s_compareByPriority;

	[Token(Token = "0x401A4C3")]
	[FieldOffset(Offset = "0x4")]
	public static AkEnvironment_CompareBySelectionAlgorithm s_compareBySelectionAlgorithm;

	[Token(Token = "0x401A4C4")]
	[FieldOffset(Offset = "0xC")]
	public bool excludeOthers;

	[Token(Token = "0x401A4C5")]
	[FieldOffset(Offset = "0xD")]
	public bool isDefault;

	[Token(Token = "0x401A4C6")]
	[FieldOffset(Offset = "0x10")]
	public AuxBus data;

	[Token(Token = "0x401A4C7")]
	[FieldOffset(Offset = "0x14")]
	private Collider _003CCollider_003Ek__BackingField;

	[Token(Token = "0x401A4C8")]
	[FieldOffset(Offset = "0x18")]
	public int priority;

	[Token(Token = "0x401A4C9")]
	[FieldOffset(Offset = "0x1C")]
	private int auxBusIdInternal;

	[Token(Token = "0x401A4CA")]
	[FieldOffset(Offset = "0x20")]
	private byte[] valueGuidInternal;

	[Token(Token = "0x17001B7D")]
	public Collider Collider
	{
		[Token(Token = "0x60193F0")]
		[Address(RVA = "0x35D54D4", Offset = "0x35D54D4", VA = "0x35D54D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60193F1")]
		[Address(RVA = "0x35D54DC", Offset = "0x35D54DC", VA = "0x35D54DC")]
		private set
		{
		}
	}

	[Token(Token = "0x17001B7E")]
	public int m_auxBusID
	{
		[Token(Token = "0x60193F3")]
		[Address(RVA = "0x35D554C", Offset = "0x35D554C", VA = "0x35D554C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001B7F")]
	public byte[] valueGuid
	{
		[Token(Token = "0x60193F4")]
		[Address(RVA = "0x35D5560", Offset = "0x35D5560", VA = "0x35D5560")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60193EF")]
	[Address(RVA = "0x35D5458", Offset = "0x35D5458", VA = "0x35D5458")]
	public AkEnvironment()
	{
	}

	[Token(Token = "0x60193F2")]
	[Address(RVA = "0x35D54E4", Offset = "0x35D54E4", VA = "0x35D54E4")]
	public void Awake()
	{
	}

	[Token(Token = "0x60193F5")]
	[Address(RVA = "0x35D55FC", Offset = "0x35D55FC", VA = "0x35D55FC")]
	public uint GetAuxBusID()
	{
		return default(uint);
	}

	[Token(Token = "0x60193F6")]
	[Address(RVA = "0x35D5624", Offset = "0x35D5624", VA = "0x35D5624")]
	public Collider GetCollider()
	{
		return null;
	}
}
