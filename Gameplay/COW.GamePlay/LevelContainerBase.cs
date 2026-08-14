using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x20005FC")]
public class LevelContainerBase : BaseLevelObject
{
	[Token(Token = "0x400451D")]
	[FieldOffset(Offset = "0x74")]
	public float concentricRadiusMin;

	[Token(Token = "0x400451E")]
	[FieldOffset(Offset = "0x78")]
	public float concentricRadiusMax;

	[Token(Token = "0x400451F")]
	[FieldOffset(Offset = "0x7C")]
	protected List<MNGBAPBBJDC> BPGHBBKBGEH;

	[Token(Token = "0x4004520")]
	[FieldOffset(Offset = "0x80")]
	protected List<MNGBAPBBJDC> PCEEGJLOKAL;

	[Token(Token = "0x4004521")]
	[FieldOffset(Offset = "0x84")]
	protected BoxCollider MNNAPHEELIM;

	[Token(Token = "0x4004522")]
	[FieldOffset(Offset = "0x88")]
	public byte m_ContainerType;

	[Token(Token = "0x4004523")]
	[FieldOffset(Offset = "0x89")]
	private bool FPBBIFJAMGD;

	[Token(Token = "0x4004524")]
	[FieldOffset(Offset = "0x8A")]
	public bool NeedAttachModel;

	[Token(Token = "0x4004525")]
	[FieldOffset(Offset = "0x8B")]
	protected bool BLGMBCANEOP;

	[Token(Token = "0x4004526")]
	[FieldOffset(Offset = "0x8C")]
	protected bool BMJJCBDCFBG;

	[Token(Token = "0x4004527")]
	[FieldOffset(Offset = "0x0")]
	public static Vector3 DEFAULT_SIZE;

	[Token(Token = "0x170002E7")]
	protected BoxCollider FELEIMBDDHC
	{
		[Token(Token = "0x600249B")]
		[Address(RVA = "0x2387354", Offset = "0x2387354", VA = "0x2387354")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E8")]
	public byte LFNKFFLPPFF
	{
		[Token(Token = "0x600249C")]
		[Address(RVA = "0x2389280", Offset = "0x2389280", VA = "0x2389280")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x600249D")]
		[Address(RVA = "0x238A99C", Offset = "0x238A99C", VA = "0x238A99C")]
		set
		{
		}
	}

	[Token(Token = "0x170002E9")]
	public bool MJHGNJLONGO
	{
		[Token(Token = "0x600249E")]
		[Address(RVA = "0x238A308", Offset = "0x238A308", VA = "0x238A308")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600249F")]
		[Address(RVA = "0x238E2AC", Offset = "0x238E2AC", VA = "0x238E2AC")]
		set
		{
		}
	}

	[Token(Token = "0x600249A")]
	[Address(RVA = "0x2384538", Offset = "0x2384538", VA = "0x2384538")]
	public LevelContainerBase()
	{
	}

	[Token(Token = "0x60024A0")]
	[Address(RVA = "0x238E30C", Offset = "0x238E30C", VA = "0x238E30C", Slot = "40")]
	protected virtual ResourceID GCKKLGACPCL()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60024A1")]
	[Address(RVA = "0x238E3BC", Offset = "0x238E3BC", VA = "0x238E3BC")]
	public int GetCount()
	{
		return default(int);
	}

	[Token(Token = "0x60024A2")]
	[Address(RVA = "0x238E47C", Offset = "0x238E47C", VA = "0x238E47C")]
	public string GetFirstPickUpName()
	{
		return null;
	}

	[Token(Token = "0x60024A3")]
	[Address(RVA = "0x238E5B0", Offset = "0x238E5B0", VA = "0x238E5B0")]
	public List<MNGBAPBBJDC> GetPickUpList()
	{
		return null;
	}

	[Token(Token = "0x60024A4")]
	[Address(RVA = "0x238E0B0", Offset = "0x238E0B0", VA = "0x238E0B0", Slot = "30")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x60024A5")]
	[Address(RVA = "0x238E110", Offset = "0x238E110", VA = "0x238E110", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x60024A6")]
	[Address(RVA = "0x238708C", Offset = "0x238708C", VA = "0x238708C")]
	protected void AIDMPFOIEHD()
	{
	}

	[Token(Token = "0x60024A7")]
	[Address(RVA = "0x238621C", Offset = "0x238621C", VA = "0x238621C")]
	protected void GONOLEHJOBD()
	{
	}

	[Token(Token = "0x60024A8")]
	[Address(RVA = "0x2388E84", Offset = "0x2388E84", VA = "0x2388E84", Slot = "41")]
	protected virtual void HIDBEMAHGMB()
	{
	}

	[Token(Token = "0x60024A9")]
	[Address(RVA = "0x238E608", Offset = "0x238E608", VA = "0x238E608")]
	protected void OPOKNOGKKKG()
	{
	}

	[Token(Token = "0x60024AA")]
	[Address(RVA = "0x238E8B4", Offset = "0x238E8B4", VA = "0x238E8B4", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60024AB")]
	[Address(RVA = "0x238E920", Offset = "0x238E920", VA = "0x238E920")]
	public void Init(OFJHNKMJNGA PMGBACFJIHO, uint IDNEFEOPGIF)
	{
	}

	[Token(Token = "0x60024AC")]
	[Address(RVA = "0x238EADC", Offset = "0x238EADC", VA = "0x238EADC", Slot = "32")]
	protected override void CFHFEKAHCAI()
	{
	}

	[Token(Token = "0x60024AD")]
	[Address(RVA = "0x238E9E4", Offset = "0x238E9E4", VA = "0x238E9E4")]
	protected void KDGGJAENLOL()
	{
	}

	[Token(Token = "0x60024AE")]
	[Address(RVA = "0x238E7C8", Offset = "0x238E7C8", VA = "0x238E7C8")]
	protected void DNFPBBJEPIK()
	{
	}

	[Token(Token = "0x60024AF")]
	[Address(RVA = "0x2389E74", Offset = "0x2389E74", VA = "0x2389E74")]
	protected Vector3 KIJHGKPIOEB(Vector3 COCOBLKAIMJ)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60024B0")]
	[Address(RVA = "0x238E198", Offset = "0x238E198", VA = "0x238E198", Slot = "42")]
	protected virtual void HAAACAIBDNN(MNGBAPBBJDC OIKHKCIIDAD, uint BIFFAIEPIND = uint.MaxValue, bool BBIDGILJCMB = false, bool PGJOFAKGBJG = false)
	{
	}

	[Token(Token = "0x60024B1")]
	[Address(RVA = "0x238E214", Offset = "0x238E214", VA = "0x238E214", Slot = "43")]
	protected virtual void NDFEDODBDHC(MNGBAPBBJDC OIKHKCIIDAD)
	{
	}

	[Token(Token = "0x60024B2")]
	[Address(RVA = "0x238A360", Offset = "0x238A360", VA = "0x238A360")]
	protected void FFGFGEEFFCG(GameObject ECINOMEHBKA)
	{
	}

	[Token(Token = "0x60024B3")]
	[Address(RVA = "0x238EB50", Offset = "0x238EB50", VA = "0x238EB50")]
	public static void DelAnimInWater(GameObject ECINOMEHBKA)
	{
	}

	[Token(Token = "0x60024B4")]
	[Address(RVA = "0x238BE40", Offset = "0x238BE40", VA = "0x238BE40")]
	public void InitAttachModel(ref MNGBAPBBJDC OIKHKCIIDAD)
	{
	}

	[Token(Token = "0x60024B5")]
	[Address(RVA = "0x238ECD4", Offset = "0x238ECD4", VA = "0x238ECD4", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60024B6")]
	[Address(RVA = "0x238ED78", Offset = "0x238ED78", VA = "0x238ED78", Slot = "23")]
	protected override void OnUpdateVisibleStateByStreamer(Vector3 MKGCDPNKMOB, Vector3 OANAHFHPBNB)
	{
	}

	[Token(Token = "0x60024B7")]
	[Address(RVA = "0x238F368", Offset = "0x238F368", VA = "0x238F368")]
	public void SetSize(Vector3 JLFLJKCNCKD, float GJGEBKHCAFL, float NGBHFBLJLGH)
	{
	}

	[Token(Token = "0x60024B8")]
	[Address(RVA = "0x238F4C8", Offset = "0x238F4C8", VA = "0x238F4C8")]
	public static string GetNameTag(byte FMEOKLHEKNH)
	{
		return null;
	}

	[Token(Token = "0x60024B9")]
	[Address(RVA = "0x238F650", Offset = "0x238F650", VA = "0x238F650")]
	public static string GetContainerName(byte FMEOKLHEKNH, ushort POGKEGOGKEF)
	{
		return null;
	}

	[Token(Token = "0x60024BA")]
	[Address(RVA = "0x238F780", Offset = "0x238F780", VA = "0x238F780")]
	public static OFJHNKMJNGA GetLevelObjectType(byte FMEOKLHEKNH)
	{
		return default(OFJHNKMJNGA);
	}

	[Token(Token = "0x60024BB")]
	[Address(RVA = "0x2386108", Offset = "0x2386108", VA = "0x2386108")]
	public static MNGBAPBBJDC MapMsgid2PickUp(uint BDNNEBHECPP, uint KIJFFPEOKML, uint BLEAICPKPGL, byte PMGBACFJIHO, uint BHCKHHPMAEK = 0u, ushort FFCMCEABIAL = 0, uint MKFJPKBDLMM = 0u)
	{
		return null;
	}

	[Token(Token = "0x60024BC")]
	[Address(RVA = "0x2387A64", Offset = "0x2387A64", VA = "0x2387A64")]
	internal static bool DMBFNAPAOGE(List<OGNOJHPADCL> IHFEPCLHFKJ, uint LLONJJJJLFL, IHAAMHPPLMG PLPPDLOJPJN)
	{
		return default(bool);
	}

	[Token(Token = "0x60024BD")]
	[Address(RVA = "0x238F944", Offset = "0x238F944", VA = "0x238F944")]
	internal static bool DMBFNAPAOGE(IHAAMHPPLMG MMBCJCPNCPN, uint LLONJJJJLFL, IHAAMHPPLMG PLPPDLOJPJN)
	{
		return default(bool);
	}

	[Token(Token = "0x60024BF")]
	[Address(RVA = "0x238FC8C", Offset = "0x238FC8C", VA = "0x238FC8C")]
	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	[Token(Token = "0x60024C0")]
	[Address(RVA = "0x238FC94", Offset = "0x238FC94", VA = "0x238FC94")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	[Token(Token = "0x60024C1")]
	[Address(RVA = "0x238FC9C", Offset = "0x238FC9C", VA = "0x238FC9C")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x60024C2")]
	[Address(RVA = "0x238FCA4", Offset = "0x238FCA4", VA = "0x238FCA4")]
	public void _003C_003EiFixBaseProxy_CFHFEKAHCAI()
	{
	}

	[Token(Token = "0x60024C3")]
	[Address(RVA = "0x238FCAC", Offset = "0x238FCAC", VA = "0x238FCAC")]
	public void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}
}
